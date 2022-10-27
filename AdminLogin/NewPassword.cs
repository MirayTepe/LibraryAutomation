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

namespace AdminLogin
{
    public partial class NewPassword : Form
    {
      
        public NewPassword() 
        {
            InitializeComponent();
           
        }

       


        private void BtnCloseNewPassword_Click_1(object sender, EventArgs e)
        {
           this.Close();
        }

        private void TxtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCloseNewPassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblNewPassword_Click(object sender, EventArgs e)
        {

        }

        private void LblNewPassword_Click_1(object sender, EventArgs e)
        {

        }

        public void BtnSaveNewPassword_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();


            if (this.TxtNewPassword.Text.Trim().Equals(resetPassword.onayKodu)) {
                try
                {
                    SqlConnection connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=LibraryManagement;Trusted_Connection=true");
                    connection.Open();
                    string sql = "UPDATE adminInformations SET Password=@sifresi";

                    SqlParameter prmPassword = new SqlParameter("sifresi", TxtNewPassword.Text.Trim());
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add(prmPassword);
                    command.ExecuteNonQuery();
                        
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    MessageBox.Show("İşlem başarılı.Yeni şifreniz ="+TxtNewPassword.Text);

                    if (dataTable.Rows.Count > 0)
                    {
                        Homepage homepage = new Homepage();
                        homepage.Show();

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
}
