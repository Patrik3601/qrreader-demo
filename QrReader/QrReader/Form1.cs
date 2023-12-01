using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Diagnostics;

namespace QrReader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        FilterInfoCollection collection;
        VideoCaptureDevice device;

        private void Form1_Load(object sender, EventArgs e)
        {

            collection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in collection)
            {
                cameraList.Items.Add(item.Name);
            }
            if (cameraList.Items.Count != 0)
            {
                cameraList.SelectedIndex = 0;
            }
        }

        private void NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            box.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
            {
                device.Stop();
                Application.Exit();
            }
        }

        private void Timertick(object sender, EventArgs e)
        {
            if (box.Image != null)
            {
                BarcodeReader barcodereader = new BarcodeReader();
                Result result = barcodereader.Decode((Bitmap)box.Image);
                if (result != null)
                {
                    qrtext.Text = result.ToString();

                    timer1.Stop();
                    if (device.IsRunning)
                    {
                        device.Stop();
                    }
                }
            }
        }

        #region Buttons
        private void start_Click(object sender, EventArgs e)
        {
            if (cameraList.Items.Count == 0)
            {
                string message = "No Camera Selected";
                MessageBox.Show(message);
                return;
            }
            if (device == null)
            {
                device = new VideoCaptureDevice(collection[cameraList.SelectedIndex].MonikerString);
            }

            if (!device.IsRunning)
            {

                device.NewFrame += NewFrame;
                device.Start();
                timer1.Start();
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (!IsTextFieldEmpty())
            {
                // Nur Links
                Process.Start(qrtext.Text);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            qrtext.Text = String.Empty;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            if (!IsTextFieldEmpty())
            {
                Clipboard.SetText(qrtext.Text);
            }
        }
        #endregion
        bool IsTextFieldEmpty()
        {
            if (qrtext.Text == String.Empty)
            {
                return true;
            }
            return false;
        }
    }
}