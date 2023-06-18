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
namespace WindowsFormsApp1
{
    public partial class CustomerAddForm : Form
    {
        SqlCommand sqlCommand;
        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);
        public CustomerAddForm()
        {
            InitializeComponent();
        }

     

        private void btn_cstmr_Click(object sender, EventArgs e)
        {
            var customerMainPage = new DashboardCustomerForm();
            customerMainPage.Show();
            this.Close();
        }





        private void btn_enter_Click_1(object sender, EventArgs e)
        {
            try
            {
                   sqlConnection.Open();
                    String save = "insert into customerfactory(customerName,addressOfFactory,totalNumberOfEmployee,userId)VALUES(@cusName,@address,@totalEmp,@userId)";
                    sqlCommand = new SqlCommand(save, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@address", txt_address.Text);
                    sqlCommand.Parameters.AddWithValue("@cusName", txt_cus_name.Text);
                    sqlCommand.Parameters.AddWithValue("@totalEmp", int.Parse(txt_emp.Text));
                    sqlCommand.Parameters.AddWithValue("@userId", LogInForm.idOfCustomer);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                MessageBox.Show("Customer is inserted,successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
