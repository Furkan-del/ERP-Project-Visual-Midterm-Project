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
    public partial class ManufacturerForm : Form
    {
        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader1;
        int currentQuantity;
        int requestedQuantity;
        public static int order_id;

        public ManufacturerForm()
        {
            InitializeComponent();
            sqlConnection.Open();
        }

        

        

        private void btn_sendProduct_Click(object sender, EventArgs e)
        {
            try
            {
                
                string sqlQuery = "select * from products where name=@name";
                SqlCommand sql = new SqlCommand(sqlQuery, sqlConnection);
                sql.Parameters.AddWithValue("@name", txt_name.Text);
                sqlDataReader1 = sql.ExecuteReader();

                while (sqlDataReader1.Read())
                {
                    currentQuantity = int.Parse(sqlDataReader1["quantityOfProduct"].ToString());

                    requestedQuantity = int.Parse(txt_qty.Text);
                }
                sqlDataReader1.Close();

                if (requestedQuantity < currentQuantity)
                {
                    string query = "UPDATE products SET quantityOfProduct = quantityOfProduct - @quantity WHERE name = @name";
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@quantity", requestedQuantity);
                    sqlCommand.Parameters.AddWithValue("@name", txt_name.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("The Product is sending", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (requestedQuantity > currentQuantity)
                {
                    MessageBox.Show(" Your product quantity is less than the requested one so You cant send it ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (requestedQuantity == currentQuantity && currentQuantity!=0)
                {
                    string query = "UPDATE products SET quantityOfProduct = quantityOfProduct - @quantity WHERE name = @name";
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@quantity", requestedQuantity);
                    sqlCommand.Parameters.AddWithValue("@name", txt_name.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("We dont have anymore this product ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("You cannot send this product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Product is not sended"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void btn_warehouses_Click(object sender, EventArgs e)
        {
            try
            {    
                    string query= "select w.numberOfWarehouses,w.location,p.name,p.orderTime,p.price,p.quantityOfProduct from warehouses w ,products as p WHERE p.id = w.productId AND w.manufacturerID=(select id from manufacturerFactory where userId=@userId)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@userId", LogInForm.idOfManufacturer);
                    SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlData.Fill(dataTable);
                    dataGridViewStock.DataSource = dataTable;

            
            }catch(Exception ex)
            {
                MessageBox.Show("Error ocurred during show warehouses"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            var goBackManInfForm = new ManufacturerInfoForm();
            goBackManInfForm.Show();
            this.Close();
        }

        private void man_name_Click(object sender, EventArgs e)
        {
        
            string query = "select * from manufacturerFactory where userId=@userId";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@userId", LogInForm.idOfManufacturer);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                manName_menu.Text = sqlDataReader["manufacturerName"].ToString();
                location_men_itm.Text = sqlDataReader["addressOfFactory"].ToString();
            }
            sqlDataReader.Close();
            
        }

        private void reportScreen_btn_Click(object sender, EventArgs e)
        {
            var reporting = new ReportingScreenForm();
            reporting.Show();
            this.Close();
        }

        private void dataGridViewMsg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Request is approved ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void filterRequest_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from logger where customername=@cusName ";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@cusName", cmb_box_cus.Text);
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                dataGridViewMsg.DataSource = dataTable;

            }catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand sqlCommand;
                SqlDataAdapter sqlDataAdapter;
                string query = "delete from  logger where id=@logger_id; ";

                int idValue = int.Parse(dataGridViewMsg.Rows[dataGridViewMsg.CurrentRow.Index].Cells["id"].Value.ToString());
                order_id = idValue;
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@logger_id", idValue);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataGridViewMsg.DataSource = dt;

            }catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            var expeditionForm = new ExpeditionForm();
            expeditionForm.Show();
            this.Close();
        }

        private void btn_deny_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand;

                int idValue = int.Parse(dataGridViewMsg.Rows[dataGridViewMsg.CurrentRow.Index].Cells["id"].Value.ToString());
                string query = "delete from  logger where id=@logger_id";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@logger_id", idValue);
                MessageBox.Show("Request are not accepted and deleted ", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);
                SqlDataAdapter sqlDataAdapter;
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataGridViewMsg.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

       
    }
}
