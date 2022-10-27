namespace AdminLogin
{
    partial class NewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPassword));
            this.BtnCloseNewPassword = new System.Windows.Forms.Button();
            this.PnlNewPassword = new System.Windows.Forms.Panel();
            this.BtnSaveNewPassword = new System.Windows.Forms.Button();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.LblConfirmationCode = new System.Windows.Forms.Label();
            this.TxtConfirmationCode = new System.Windows.Forms.TextBox();
            this.LblNewPassword = new System.Windows.Forms.Label();
            this.PnlNewPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCloseNewPassword
            // 
            this.BtnCloseNewPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCloseNewPassword.BackgroundImage")));
            this.BtnCloseNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCloseNewPassword.Location = new System.Drawing.Point(1052, 12);
            this.BtnCloseNewPassword.Name = "BtnCloseNewPassword";
            this.BtnCloseNewPassword.Size = new System.Drawing.Size(75, 44);
            this.BtnCloseNewPassword.TabIndex = 5;
            this.BtnCloseNewPassword.UseVisualStyleBackColor = true;
            this.BtnCloseNewPassword.Click += new System.EventHandler(this.BtnCloseNewPassword_Click);
            // 
            // PnlNewPassword
            // 
            this.PnlNewPassword.Controls.Add(this.LblNewPassword);
            this.PnlNewPassword.Controls.Add(this.TxtConfirmationCode);
            this.PnlNewPassword.Controls.Add(this.LblConfirmationCode);
            this.PnlNewPassword.Controls.Add(this.BtnSaveNewPassword);
            this.PnlNewPassword.Controls.Add(this.TxtNewPassword);
            this.PnlNewPassword.Location = new System.Drawing.Point(138, 132);
            this.PnlNewPassword.Name = "PnlNewPassword";
            this.PnlNewPassword.Size = new System.Drawing.Size(782, 403);
            this.PnlNewPassword.TabIndex = 6;
            // 
            // BtnSaveNewPassword
            // 
            this.BtnSaveNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnSaveNewPassword.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSaveNewPassword.ForeColor = System.Drawing.Color.White;
            this.BtnSaveNewPassword.Location = new System.Drawing.Point(474, 326);
            this.BtnSaveNewPassword.Name = "BtnSaveNewPassword";
            this.BtnSaveNewPassword.Size = new System.Drawing.Size(176, 54);
            this.BtnSaveNewPassword.TabIndex = 5;
            this.BtnSaveNewPassword.Text = "Kaydet";
            this.BtnSaveNewPassword.UseVisualStyleBackColor = false;
            this.BtnSaveNewPassword.Click += new System.EventHandler(this.BtnSaveNewPassword_Click);
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TxtNewPassword.ForeColor = System.Drawing.Color.White;
            this.TxtNewPassword.Location = new System.Drawing.Point(135, 241);
            this.TxtNewPassword.Multiline = true;
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.Size = new System.Drawing.Size(515, 37);
            this.TxtNewPassword.TabIndex = 3;
            this.TxtNewPassword.TextChanged += new System.EventHandler(this.TxtNewPassword_TextChanged);
            // 
            // LblConfirmationCode
            // 
            this.LblConfirmationCode.AutoSize = true;
            this.LblConfirmationCode.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblConfirmationCode.ForeColor = System.Drawing.Color.White;
            this.LblConfirmationCode.Location = new System.Drawing.Point(138, 30);
            this.LblConfirmationCode.Name = "LblConfirmationCode";
            this.LblConfirmationCode.Size = new System.Drawing.Size(378, 46);
            this.LblConfirmationCode.TabIndex = 6;
            this.LblConfirmationCode.Text = "Onay Kodunu Giriniz";
            // 
            // TxtConfirmationCode
            // 
            this.TxtConfirmationCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TxtConfirmationCode.ForeColor = System.Drawing.Color.White;
            this.TxtConfirmationCode.Location = new System.Drawing.Point(135, 92);
            this.TxtConfirmationCode.Multiline = true;
            this.TxtConfirmationCode.Name = "TxtConfirmationCode";
            this.TxtConfirmationCode.Size = new System.Drawing.Size(515, 37);
            this.TxtConfirmationCode.TabIndex = 7;
            // 
            // LblNewPassword
            // 
            this.LblNewPassword.AutoSize = true;
            this.LblNewPassword.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNewPassword.ForeColor = System.Drawing.Color.White;
            this.LblNewPassword.Location = new System.Drawing.Point(138, 192);
            this.LblNewPassword.Name = "LblNewPassword";
            this.LblNewPassword.Size = new System.Drawing.Size(182, 46);
            this.LblNewPassword.TabIndex = 8;
            this.LblNewPassword.Text = "Yeni Şifre\r\n";
            this.LblNewPassword.Click += new System.EventHandler(this.LblNewPassword_Click_1);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1129, 613);
            this.Controls.Add(this.PnlNewPassword);
            this.Controls.Add(this.BtnCloseNewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPassword";
            this.PnlNewPassword.ResumeLayout(false);
            this.PnlNewPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCloseNewPassword;
        private System.Windows.Forms.Panel PnlNewPassword;
        private System.Windows.Forms.Button BtnSaveNewPassword;
        private System.Windows.Forms.TextBox TxtNewPassword;
        private System.Windows.Forms.Label LblConfirmationCode;
        private System.Windows.Forms.TextBox TxtConfirmationCode;
        private System.Windows.Forms.Label LblNewPassword;
    }
}