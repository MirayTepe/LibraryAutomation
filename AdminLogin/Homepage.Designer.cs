namespace AdminLogin
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.BtnCloseHomepage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCloseHomepage
            // 
            this.BtnCloseHomepage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCloseHomepage.BackgroundImage")));
            this.BtnCloseHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCloseHomepage.Location = new System.Drawing.Point(1063, 12);
            this.BtnCloseHomepage.Name = "BtnCloseHomepage";
            this.BtnCloseHomepage.Size = new System.Drawing.Size(75, 44);
            this.BtnCloseHomepage.TabIndex = 6;
            this.BtnCloseHomepage.UseVisualStyleBackColor = true;
            this.BtnCloseHomepage.Click += new System.EventHandler(this.BtnCloseHomepage_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1319, 706);
            this.Controls.Add(this.BtnCloseHomepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCloseHomepage;
    }
}