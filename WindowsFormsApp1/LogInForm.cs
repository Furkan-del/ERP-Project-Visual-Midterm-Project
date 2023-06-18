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
        public static string cusName;
        static string role;
        public static int idOfManufacturer;

        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);



        public LogInForm()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            String username = txt_user.Text;
            String password = txt_password.Text; 
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText= "select id ,role from users where username=@userName AND password=@password";
            sqlCommand.Parameters.AddWithValue("@userName", username);
            sqlCommand.Parameters.AddWithValue("@password", password);
            sqlDataReader = sqlCommand.ExecuteReader();
            idOfCustomer = 0;
            role = "x";
            if (sqlDataReader.Read())
            {
                MessageBox.Show("Congratulations User Authenticated", "Successful!");
                idOfCustomer = sqlDataReader.GetInt32(0); // veya sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("id"));
                role = sqlDataReader.GetString(1); // veya sqlDataReader.GetString(sqlDataReader.GetOrdinal("role"));

                sqlDataReader.Close();

                if (role == "CUSTOMER")
                {
                    SqlDataReader sqlData;
                    var customerAddForm = new CustomerAddForm();
                    customerAddForm.Show();
                    this.Close();
                    string queryy = "select customerName  from customerFactory where userId=@userId";
                    SqlCommand sql = new SqlCommand(queryy, sqlConnection);
                    sql.Parameters.AddWithValue("@userId", idOfCustomer);
                    sqlData = sql.ExecuteReader();
                    while (sqlData.Read())
                    {
                        cusName = sqlData["customerName"].ToString();
                    }
                    sqlData.Close();
                }
                else if (role == "MANUFACTURER")
                {
                    idOfManufacturer = idOfCustomer;
                    var manufacturerInfoForm = new ManufacturerInfoForm();
                    manufacturerInfoForm.Show();
                    this.Close();
                }
            }
            else
                {
                    MessageBox.Show("Username or Password is incorrect! ","Login Incorrect", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
