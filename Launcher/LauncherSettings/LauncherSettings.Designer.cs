namespace Launcher
{
    partial class LauncherSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherSettings));
            this._Close = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.Uninstall = new System.Windows.Forms.Button();
            this.Repair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Close)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Close
            // 
            this._Close.BackColor = System.Drawing.Color.Lime;
            this._Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_Close.BackgroundImage")));
            this._Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._Close.Location = new System.Drawing.Point(342, 3);
            this._Close.Name = "_Close";
            this._Close.Size = new System.Drawing.Size(20, 20);
            this._Close.TabIndex = 11;
            this._Close.TabStop = false;
            this._Close.Click += new System.EventHandler(this._Close_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Lime;
            this.TopPanel.Controls.Add(this.Label);
            this.TopPanel.Controls.Add(this._Close);
            this.TopPanel.Location = new System.Drawing.Point(0, 1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(367, 26);
            this.TopPanel.TabIndex = 12;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.Lime;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.White;
            this.Label.Location = new System.Drawing.Point(3, 3);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(89, 20);
            this.Label.TabIndex = 15;
            this.Label.Text = "SETTINGS";
            // 
            // Uninstall
            // 
            this.Uninstall.BackColor = System.Drawing.Color.Lime;
            this.Uninstall.BackgroundImage = global::Launcher.Properties.Resources.buttonUpdate;
            this.Uninstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Uninstall.FlatAppearance.BorderSize = 0;
            this.Uninstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Uninstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Uninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uninstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uninstall.ForeColor = System.Drawing.Color.White;
            this.Uninstall.Location = new System.Drawing.Point(100, 238);
            this.Uninstall.Name = "Uninstall";
            this.Uninstall.Size = new System.Drawing.Size(176, 63);
            this.Uninstall.TabIndex = 13;
            this.Uninstall.Text = "Uninstall";
            this.Uninstall.UseVisualStyleBackColor = false;
            this.Uninstall.Click += new System.EventHandler(this.Uninstall_Click);
            // 
            // Repair
            // 
            this.Repair.BackColor = System.Drawing.Color.Lime;
            this.Repair.BackgroundImage = global::Launcher.Properties.Resources.button;
            this.Repair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Repair.FlatAppearance.BorderSize = 0;
            this.Repair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Repair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Repair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repair.ForeColor = System.Drawing.Color.White;
            this.Repair.Location = new System.Drawing.Point(100, 169);
            this.Repair.Name = "Repair";
            this.Repair.Size = new System.Drawing.Size(176, 63);
            this.Repair.TabIndex = 15;
            this.Repair.Text = "Repair";
            this.Repair.UseVisualStyleBackColor = false;
            this.Repair.Click += new System.EventHandler(this.Repair_Click);
            // 
            // LauncherSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.settingsFont;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 320);
            this.Controls.Add(this.Repair);
            this.Controls.Add(this.Uninstall);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LauncherSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LauncherSettings";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.LauncherSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Close)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _Close;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button Uninstall;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button Repair;
    }
}