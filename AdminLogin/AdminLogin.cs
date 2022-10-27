using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AdminLogin
{
    public partial class AdminLoginPage: Form
    {
        public AdminLoginPage()
        {
            InitializeComponent();
        }
       

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=LibraryManagement;Trusted_Connection=true");
                connection.Open();
                string sql = "Select * From adminInformations where UserName=@adi AND Password=@sifresi";
                SqlParameter prmUserName = new SqlParameter("adi",TxtUserName.Text.Trim());
                SqlParameter prmPassword = new SqlParameter("sifresi",TxtPassword.Text.Trim());
                SqlCommand  command=new SqlCommand(sql, connection);
                command.Parameters.Add(prmUserName);
                command.Parameters.Add(prmPassword);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count >0)
                {
                    Homepage loginHomepage=new Homepage();
                    loginHomepage.Show();

                }
                connection.Close();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            if(TxtUserName.Text.StartsWith("Kullanıcı adınızı girin :"))
            {
                TxtUserName.Text ="";

            }

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (TxtPassword.Text.StartsWith("Şifrenizi Girin :"))
            {
                TxtPassword.Text = "";

            }
        }

        private void BtnForgetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.Show();
        }

        private void BtnCloseLibraryAutomation_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
