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
    public partial class Form1 : Form
    {
        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);
        SqlCommand sqlCommand1;
       
        public Form1()
        {
            InitializeComponent();
            sqlConnection.Open();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            try
            {
                
                String query = "select * from expedition_infos where customer_id = @customerId";
                sqlCommand1 = new SqlCommand(query, sqlConnection);
                sqlCommand1.Parameters.AddWithValue("@customerId", DashboardCustomerForm.idCustomer);

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand1);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                dataGridViewCargo.DataSource = table;

            }catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK);
            }


        }

        private void btn_accept_arr_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand;
                SqlDataAdapter sqlDataAdapter;
                int order_id = int.Parse(dataGridViewCargo.Rows[dataGridViewCargo.CurrentRow.Index].Cells["logger_id"].Value.ToString());
                string query = "UPDATE expedition_infos SET confirmationDeliver='Approval' WHERE logger_id=@idofOrder";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@idofOrder", order_id);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridViewCargo.DataSource = dataTable;

             }catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dashCustomerForm = new DashboardCustomerForm();
            dashCustomerForm.Show();
            this.Close();
        }
    }
}
