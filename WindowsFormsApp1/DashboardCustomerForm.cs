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
    public partial class DashboardCustomerForm : Form
    {

        SqlCommand sqlCommand;
        public DashboardCustomerForm()
        {
            InitializeComponent();
        }
        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);


       
        private void btn_list_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.erpTIRSANDataSet.products);

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                    sqlConnection.Open();
                    string save = "insert into logger(messagefromcustomer,senderOfMessage,userId)VALUES(@msg,@sender,@userId) ";
                    sqlCommand = new SqlCommand(save, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@msg", txt_message.Text);
                    sqlCommand.Parameters.AddWithValue("@sender", txt_sender.Text);
                   sqlCommand.Parameters.AddWithValue("@userId", LogInForm.idOfCustomer);
                    sqlCommand.ExecuteNonQuery();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        MessageBox.Show("Succes");
                    }
                    sqlConnection.Close();
                

            }catch(Exception ex)
            {

                MessageBox.Show("Log didnt send correctly"+ ex.Message);
            }
          
            }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_list_Click_1(object sender, EventArgs e)
        {
            String query = "select w.numberOfWarehouses,w.location,p.name,p.orderTime,p.price,p.quantityOfProduct from warehouses w ,products as p WHERE p.id = w.id";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlConnection);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            dataGridViewCustomer.DataSource = table;

        }

     
    }
}
