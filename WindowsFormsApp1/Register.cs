using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
   
        public Register()
        {
            InitializeComponent();
        }
        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);

        private void reg_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    String save = " insert into users(username,email,password,role) VALUES(@kullanici_ad,@mail,@passw,@role)";
                    SqlCommand command = new SqlCommand(save, sqlConnection);
                    command.Parameters.AddWithValue("@kullanici_ad", txt_userName.Text);
                    command.Parameters.AddWithValue("@mail", txt_email.Text);
                    command.Parameters.AddWithValue("@passw", txt_password.Text);
                    command.Parameters.AddWithValue("@role", txt_role.Text.ToUpper());
                    command.ExecuteNonQuery();
                    
                    MessageBox.Show("Kayıt Eklendi",MessageBoxIcon.Information.ToString());
            
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Meydana Geldi " + ex.Message, MessageBoxIcon.Error.ToString());
            }



            }

        private void link_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var logInForm= new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

