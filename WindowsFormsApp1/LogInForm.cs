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
using System.Data.Sql;


namespace WindowsFormsApp1
{
    public partial class LogInForm : Form
    {

        
        SqlDataReader sqlDataReader;
        SqlCommand sqlCommand;
        public static int idOfCustomer;
        public static int idOfManufacturer;
       
        

        public LogInForm()
        {
            InitializeComponent();
        }
        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);
        private void btn_login_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            String username = txt_user.Text;
            String password = txt_password.Text; 
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText= "select * from users where username='"+username+"'And password='"+password+"'";   
            sqlDataReader = sqlCommand.ExecuteReader();
          
                if (sqlDataReader.Read())
                {
                MessageBox.Show("Congratulations User Authenticated","Successfull!");
                string role = (string)sqlDataReader.GetValue(sqlDataReader.GetOrdinal("role"));
                sqlDataReader.Close();
              
                if (role=="CUSTOMER")
                {
                 
                    
                    string query = "select id from users where username='" + txt_user.Text +"' ";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    SqlDataReader sqlDataReaderr= command.ExecuteReader();
                    while (sqlDataReaderr.Read())
                    {
                        idOfCustomer = sqlDataReaderr.GetInt32(0);
                    }
                    
                    sqlDataReader.Close();
                    var customerAddForm = new CustomerAddForm();
                    customerAddForm.Show();
                    this.Close();
                   
                }else if (role=="MANUFACTURER")
                {

                    string query = "select id from users where username='" + txt_user.Text + "' ";
                    SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
                    SqlDataReader sqlData = sqlCommand.ExecuteReader();
                    
                    while (sqlData.Read())
                    {
                        idOfManufacturer = sqlData.GetInt32(0);
                      
                    }


                    var manufacturerInfoForm = new ManufacturerInfoForm();
                    manufacturerInfoForm.Show();
                    this.Close();
                }

            }
                else
                {
                    MessageBox.Show("Username or Password is incorrect! ","Login Incorrect", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            sqlConnection.Close();


            
            
        }

       
    }
}
