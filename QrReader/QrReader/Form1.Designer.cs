namespace QrReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cameraList = new System.Windows.Forms.ComboBox();
            this.qrtext = new System.Windows.Forms.TextBox();
            this.box = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.open = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraList
            // 
            this.cameraList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cameraList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cameraList.FormattingEnabled = true;
            this.cameraList.Location = new System.Drawing.Point(421, 12);
            this.cameraList.Name = "cameraList";
            this.cameraList.Size = new System.Drawing.Size(238, 21);
            this.cameraList.TabIndex = 0;
            // 
            // qrtext
            // 
            this.qrtext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qrtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrtext.Location = new System.Drawing.Point(615, 243);
            this.qrtext.Multiline = true;
            this.qrtext.Name = "qrtext";
            this.qrtext.Size = new System.Drawing.Size(317, 296);
            this.qrtext.TabIndex = 1;
            // 
            // box
            // 
            this.box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box.Location = new System.Drawing.Point(41, 79);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(511, 471);
            this.box.TabIndex = 2;
            this.box.TabStop = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(615, 77);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(157, 76);
            this.start.TabIndex = 3;
            this.start.Text = "Start Scan";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timertick);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.Location = new System.Drawing.Point(615, 161);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(157, 76);
            this.open.TabIndex = 5;
            this.open.Text = "Open Webseite";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(778, 77);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(154, 76);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.Location = new System.Drawing.Point(778, 161);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(154, 76);
            this.copy.TabIndex = 7;
            this.copy.Text = "Copy to Clipboard";
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(998, 577);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.open);
            this.Controls.Add(this.start);
            this.Controls.Add(this.box);
            this.Controls.Add(this.qrtext);
            this.Controls.Add(this.cameraList);
            this.Name = "Form1";
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Camera;
        private System.Windows.Forms.ComboBox cameraList;
        private System.Windows.Forms.TextBox qrtext;
        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button copy;
    }
}

