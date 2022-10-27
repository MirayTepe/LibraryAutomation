using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AdminLogin
{
    public partial class ResetPassword : Form,IResetPasswordService
    {
        public ResetPassword()
        {
            InitializeComponent();
        }
        private void TxtUserName_TextChanged_1(object sender, EventArgs e)
        {
            if (TxtUserName.Text.StartsWith("Kullanıcı Adınızı Girin:"))
            {
                TxtUserName.Text = "";

            }
        }
        private void TxtEmail_TextChanged_1(object sender, EventArgs e)
        {
            if (TxtEmail.Text.StartsWith("Email Girin:"))
            {
                TxtEmail.Text = "";

            }
        }



     

       

        private void BtnCloseResetPassword_Click_1(object sender, EventArgs e)
        {        
            this.Close();

        }
        Random random = new Random();

        public string onayKodu;    
       

        private void BtnSend_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=LibraryManagement;Trusted_Connection=true");
                connection.Open();
                string sql = "Select * From adminInformations where UserName=@adi AND Email=@emaili";
                SqlParameter prmUserName = new SqlParameter("adi", TxtUserName.Text.Trim());
                SqlParameter prmEmail = new SqlParameter("emaili", TxtEmail.Text.Trim());
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(prmUserName);
                command.Parameters.Add(prmEmail);

                onayKodu = random.Next(100, 999).ToString();
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("AAAA04@outlook.com.tr");
                mailMessage.To.Add(TxtEmail.Text.ToString());
                mailMessage.Subject = "Şifremi Unuttum";
                mailMessage.Body = onayKodu;

                SmtpClient smtpClient = new SmtpClient();

                smtpClient.Credentials = new NetworkCredential("AAAA04@outlook.com.tr", "siGbZz+Rj,2@.44");
                smtpClient.Host = ("smtp-mail.outlook.com");
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.Send(mailMessage);
                MessageBox.Show("İşlem Başarılı");



                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count > 0)
                {
                    NewPassword newPassword = new NewPassword();
                    newPassword.Show();

                }

                connection.Close();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }
    }
 }

