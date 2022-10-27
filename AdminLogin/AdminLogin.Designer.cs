namespace AdminLogin
{
    partial class AdminLoginPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox AdminLoginImage;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginPage));
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.BtnForgetPassword = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCloseLibraryAutomation = new System.Windows.Forms.Button();
            AdminLoginImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(AdminLoginImage)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminLoginImage
            // 
            AdminLoginImage.BackColor = System.Drawing.Color.White;
            AdminLoginImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminLoginImage.BackgroundImage")));
            AdminLoginImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            AdminLoginImage.Location = new System.Drawing.Point(97, 118);
            AdminLoginImage.Name = "AdminLoginImage";
            AdminLoginImage.Size = new System.Drawing.Size(273, 291);
            AdminLoginImage.TabIndex = 1;
            AdminLoginImage.TabStop = false;
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TxtUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUserName.ForeColor = System.Drawing.Color.White;
            this.TxtUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtUserName.Location = new System.Drawing.Point(428, 140);
            this.TxtUserName.Multiline = true;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(473, 46);
            this.TxtUserName.TabIndex = 3;
            this.TxtUserName.TabStop = false;
            this.TxtUserName.Text = "Kullanıcı adınızı girin :";
            this.TxtUserName.UseWaitCursor = true;
            this.TxtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LoginPanel.Controls.Add(this.BtnForgetPassword);
            this.LoginPanel.Controls.Add(this.TxtPassword);
            this.LoginPanel.Controls.Add(this.TxtUserName);
            this.LoginPanel.Controls.Add(this.BtnLogin);
            this.LoginPanel.Controls.Add(AdminLoginImage);
            this.LoginPanel.Location = new System.Drawing.Point(79, 128);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1011, 523);
            this.LoginPanel.TabIndex = 0;
            // 
            // BtnForgetPassword
            // 
            this.BtnForgetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnForgetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnForgetPassword.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnForgetPassword.ForeColor = System.Drawing.Color.White;
            this.BtnForgetPassword.Location = new System.Drawing.Point(428, 318);
            this.BtnForgetPassword.Name = "BtnForgetPassword";
            this.BtnForgetPassword.Size = new System.Drawing.Size(201, 55);
            this.BtnForgetPassword.TabIndex = 6;
            this.BtnForgetPassword.Text = "Şifremi Unuttum";
            this.BtnForgetPassword.UseVisualStyleBackColor = false;
            this.BtnForgetPassword.Click += new System.EventHandler(this.BtnForgetPassword_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TxtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.ForeColor = System.Drawing.Color.White;
            this.TxtPassword.Location = new System.Drawing.Point(428, 224);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(473, 46);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.Text = "Şifrenizi Girin :";
            this.TxtPassword.UseWaitCursor = true;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(696, 318);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(205, 55);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCloseLibraryAutomation
            // 
            this.BtnCloseLibraryAutomation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCloseLibraryAutomation.BackgroundImage")));
            this.BtnCloseLibraryAutomation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCloseLibraryAutomation.Location = new System.Drawing.Point(1187, -1);
            this.BtnCloseLibraryAutomation.Name = "BtnCloseLibraryAutomation";
            this.BtnCloseLibraryAutomation.Size = new System.Drawing.Size(75, 44);
            this.BtnCloseLibraryAutomation.TabIndex = 6;
            this.BtnCloseLibraryAutomation.UseVisualStyleBackColor = true;
            this.BtnCloseLibraryAutomation.Click += new System.EventHandler(this.BtnCloseLibraryAutomation_Click);
            // 
            // AdminLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1261, 780);
            this.Controls.Add(this.BtnCloseLibraryAutomation);
            this.Controls.Add(this.LoginPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLoginPage";
            this.Text = "Libray";
            ((System.ComponentModel.ISupportInitialize)(AdminLoginImage)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        public System.Windows.Forms.Button BtnLogin;
        public System.Windows.Forms.TextBox TxtPassword;
        public System.Windows.Forms.TextBox TxtUserName;
        public System.Windows.Forms.Button BtnForgetPassword;
        private System.Windows.Forms.Button BtnCloseLibraryAutomation;
    }
}

