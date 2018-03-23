namespace ManifestTool
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Logging = new System.Windows.Forms.RichTextBox();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 409);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(347, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.Location = new System.Drawing.Point(12, 23);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(216, 20);
            this.DirectoryPath.TabIndex = 1;
            this.DirectoryPath.Text = "Target directory";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(234, 23);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(65, 23);
            this.Open.TabIndex = 2;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logging
            // 
            this.Logging.Location = new System.Drawing.Point(12, 52);
            this.Logging.Name = "Logging";
            this.Logging.ReadOnly = true;
            this.Logging.Size = new System.Drawing.Size(347, 351);
            this.Logging.TabIndex = 3;
            this.Logging.Text = "";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(302, 23);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(65, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Logging);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.DirectoryPath);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Manifest Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox DirectoryPath;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox Logging;
        private System.Windows.Forms.Button Start;
    }
}

