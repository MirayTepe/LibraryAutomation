namespace AdminLogin
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.PnlResetPassword = new System.Windows.Forms.Panel();
            this.BtnCloseResetPassword = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblForgetPassword = new System.Windows.Forms.Label();
            this.BtnSend = new System.Windows.Forms.Button();
            this.PnlResetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlResetPassword
            // 
            this.PnlResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlResetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PnlResetPassword.Controls.Add(this.TxtEmail);
            this.PnlResetPassword.Controls.Add(this.TxtUserName);
            this.PnlResetPassword.Controls.Add(this.LblForgetPassword);
            this.PnlResetPassword.Controls.Add(this.BtnSend);
            this.PnlResetPassword.Location = new System.Drawing.Point(156, 71);
            this.PnlResetPassword.Name = "PnlResetPassword";
            this.PnlResetPassword.Size = new System.Drawing.Size(868, 464);
            this.PnlResetPassword.TabIndex = 5;
            // 
            // BtnCloseResetPassword
            // 
            this.BtnCloseResetPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCloseResetPassword.BackgroundImage")));
            this.BtnCloseResetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCloseResetPassword.Location = new System.Drawing.Point(1022, 7);
            this.BtnCloseResetPassword.Name = "BtnCloseResetPassword";
            this.BtnCloseResetPassword.Size = new System.Drawing.Size(75, 44);
            this.BtnCloseResetPassword.TabIndex = 9;
            this.BtnCloseResetPassword.UseVisualStyleBackColor = true;
            this.BtnCloseResetPassword.Click += new System.EventHandler(this.BtnCloseResetPassword_Click_1);
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TxtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEmail.ForeColor = System.Drawing.Color.White;
            this.TxtEmail.Location = new System.Drawing.Point(177, 260);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(537, 44);
            this.TxtEmail.TabIndex = 8;
            this.TxtEmail.Text = "Email Girin:";
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged_1);
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TxtUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUserName.ForeColor = System.Drawing.Color.White;
            this.TxtUserName.Location = new System.Drawing.Point(177, 163);
            this.TxtUserName.Multiline = true;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(537, 44);
            this.TxtUserName.TabIndex = 7;
            this.TxtUserName.Text = "Kullanıcı Adınızı Girin:";
            this.TxtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged_1);
            // 
            // LblForgetPassword
            // 
            this.LblForgetPassword.AutoSize = true;
            this.LblForgetPassword.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblForgetPassword.ForeColor = System.Drawing.Color.White;
            this.LblForgetPassword.Location = new System.Drawing.Point(265, 58);
            this.LblForgetPassword.Name = "LblForgetPassword";
            this.LblForgetPassword.Size = new System.Drawing.Size(304, 46);
            this.LblForgetPassword.TabIndex = 6;
            this.LblForgetPassword.Text = "Şifremi Unuttum";
            // 
            // BtnSend
            // 
            this.BtnSend.AutoSize = true;
            this.BtnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnSend.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSend.ForeColor = System.Drawing.Color.White;
            this.BtnSend.Location = new System.Drawing.Point(497, 354);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(217, 55);
            this.BtnSend.TabIndex = 5;
            this.BtnSend.Text = "Gönder";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click_1);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1140, 599);
            this.Controls.Add(this.BtnCloseResetPassword);
            this.Controls.Add(this.PnlResetPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Şifremi Unuttum";
            this.PnlResetPassword.ResumeLayout(false);
            this.PnlResetPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlResetPassword;
        private System.Windows.Forms.Button BtnCloseResetPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblForgetPassword;
        private System.Windows.Forms.Button BtnSend;
    }
}