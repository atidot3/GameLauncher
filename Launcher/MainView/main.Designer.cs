namespace Launcher
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.EstimatedTime = new System.Windows.Forms.Label();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.LauncherVersion = new System.Windows.Forms.Label();
            this.totalDownload = new System.Windows.Forms.Label();
            this.downloading = new System.Windows.Forms.Label();
            this.downloadingInfo = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this._Options = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this._Close = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.play = new System.Windows.Forms.Button();
            this.font = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Options)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.font)).BeginInit();
            this.SuspendLayout();
            // 
            // EstimatedTime
            // 
            this.EstimatedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EstimatedTime.AutoSize = true;
            this.EstimatedTime.BackColor = System.Drawing.Color.Lime;
            this.EstimatedTime.Location = new System.Drawing.Point(701, 544);
            this.EstimatedTime.Name = "EstimatedTime";
            this.EstimatedTime.Size = new System.Drawing.Size(76, 13);
            this.EstimatedTime.TabIndex = 5;
            this.EstimatedTime.Text = "EstimatedTime";
            this.EstimatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(24, 559);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(753, 15);
            this.progressBar.Style = MetroFramework.MetroColorStyle.Lime;
            this.progressBar.TabIndex = 6;
            this.progressBar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.progressBar.UseCustomBackColor = true;
            this.progressBar.Value = 50;
            // 
            // LauncherVersion
            // 
            this.LauncherVersion.AutoSize = true;
            this.LauncherVersion.BackColor = System.Drawing.Color.Lime;
            this.LauncherVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LauncherVersion.Location = new System.Drawing.Point(3, 5);
            this.LauncherVersion.Name = "LauncherVersion";
            this.LauncherVersion.Size = new System.Drawing.Size(70, 16);
            this.LauncherVersion.TabIndex = 8;
            this.LauncherVersion.Text = "ver. 0.0.0.1";
            // 
            // totalDownload
            // 
            this.totalDownload.BackColor = System.Drawing.Color.Lime;
            this.totalDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDownload.ForeColor = System.Drawing.Color.White;
            this.totalDownload.Location = new System.Drawing.Point(24, 576);
            this.totalDownload.Name = "totalDownload";
            this.totalDownload.Size = new System.Drawing.Size(753, 22);
            this.totalDownload.TabIndex = 9;
            this.totalDownload.Text = "0 / 0Gb";
            this.totalDownload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.totalDownload.UseCompatibleTextRendering = true;
            this.totalDownload.UseMnemonic = false;
            // 
            // downloading
            // 
            this.downloading.AutoSize = true;
            this.downloading.BackColor = System.Drawing.Color.Lime;
            this.downloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloading.Location = new System.Drawing.Point(23, 540);
            this.downloading.Name = "downloading";
            this.downloading.Size = new System.Drawing.Size(96, 16);
            this.downloading.TabIndex = 11;
            this.downloading.Text = "Downloading...";
            // 
            // downloadingInfo
            // 
            this.downloadingInfo.AutoSize = true;
            this.downloadingInfo.BackColor = System.Drawing.Color.Lime;
            this.downloadingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadingInfo.Location = new System.Drawing.Point(125, 540);
            this.downloadingInfo.Name = "downloadingInfo";
            this.downloadingInfo.Size = new System.Drawing.Size(135, 16);
            this.downloadingInfo.TabIndex = 12;
            this.downloadingInfo.Text = "getting informations....";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Lime;
            this.TopPanel.Controls.Add(this._Options);
            this.TopPanel.Controls.Add(this.LauncherVersion);
            this.TopPanel.Controls.Add(this.Minimize);
            this.TopPanel.Controls.Add(this._Close);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1000, 25);
            this.TopPanel.TabIndex = 18;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // _Options
            // 
            this._Options.BackColor = System.Drawing.Color.Lime;
            this._Options.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_Options.BackgroundImage")));
            this._Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._Options.Location = new System.Drawing.Point(931, 3);
            this._Options.Name = "_Options";
            this._Options.Size = new System.Drawing.Size(20, 20);
            this._Options.TabIndex = 15;
            this._Options.TabStop = false;
            this._Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Lime;
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Location = new System.Drawing.Point(957, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(20, 20);
            this.Minimize.TabIndex = 14;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // _Close
            // 
            this._Close.BackColor = System.Drawing.Color.Lime;
            this._Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_Close.BackgroundImage")));
            this._Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._Close.Location = new System.Drawing.Point(980, 3);
            this._Close.Name = "_Close";
            this._Close.Size = new System.Drawing.Size(20, 20);
            this._Close.TabIndex = 10;
            this._Close.TabStop = false;
            this._Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1000, 508);
            this.webBrowser1.TabIndex = 19;
            this.webBrowser1.Url = new System.Uri("http://google.de", System.UriKind.Absolute);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Lime;
            this.play.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(783, 540);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(206, 54);
            this.play.TabIndex = 20;
            this.play.Text = "PLAY";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // font
            // 
            this.font.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.font.BackColor = System.Drawing.Color.Black;
            this.font.BackgroundImage = global::Launcher.Properties.Resources.font;
            this.font.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.font.Image = global::Launcher.Properties.Resources.bg;
            this.font.InitialImage = global::Launcher.Properties.Resources.bg;
            this.font.Location = new System.Drawing.Point(0, 0);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(1000, 600);
            this.font.TabIndex = 16;
            this.font.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.play);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.totalDownload);
            this.Controls.Add(this.EstimatedTime);
            this.Controls.Add(this.downloading);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.downloadingInfo);
            this.Controls.Add(this.font);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAMENAME Launcher";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Options)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.font)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox font;
        private System.Windows.Forms.Label EstimatedTime;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private System.Windows.Forms.Label LauncherVersion;
        public System.Windows.Forms.Label totalDownload;
        private System.Windows.Forms.PictureBox _Close;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Label downloading;
        private System.Windows.Forms.Label downloadingInfo;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.PictureBox _Options;
    }
}

