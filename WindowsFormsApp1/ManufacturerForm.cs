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
        public ManufacturerForm()
        {
            InitializeComponent();
        }

        

        

        private void btn_sendProduct_Click(object sender, EventArgs e)
        {
            try
            {
                    sqlConnection.Open();
                
                    int value = int.Parse(txt_qty.Text);
                 
                    string query = "UPDATE products SET quantityOfProduct = quantityOfProduct - @quantity WHERE name = @name";
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@quantity", value);
                    sqlCommand.Parameters.AddWithValue("@name", txt_name.Text);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("The Product is sending","Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }catch(Exception ex)
            {
                MessageBox.Show("Product is not sended", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void btn_warehouses_Click(object sender, EventArgs e)
        {
            try
            {
                
                    sqlConnection.Open();
                    
                    string query= "select w.numberOfWarehouses,w.location,p.name,p.orderTime,p.price,p.quantityOfProduct from warehouses w ,products as p WHERE p.id = w.id";
                    SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlData.Fill(dataTable);
                    dataGridViewStock.DataSource = dataTable;

                    SqlCommand sql = new SqlCommand("select  senderOfMessage,messagefromcustomer from logger where manufacturerId=(SELECT id from manufacturerFactory  where userId=@userId)", sqlConnection);
                    sql.Parameters.AddWithValue("@userId", LogInForm.idOfManufacturer);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    dataGridViewMsg.DataSource = dt;
                    


                

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
            sqlConnection.Open();
            string query = "select * from manufacturerFactory where id=@manId ";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@manId", LogInForm.idOfManufacturer);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                manName_menu.Text = sqlDataReader["manufacturerName"].ToString();
                location_men_itm.Text = sqlDataReader["addressOfFactory"].ToString();

            }
            sqlDataReader.Close();
            
        }
    }
}
