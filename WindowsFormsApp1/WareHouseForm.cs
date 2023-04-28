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
    public partial class WareHouseForm : Form
    {
        SqlDataReader sqlDataReader;
        SqlDataReader sqlData;
        public string name; 
        public int idOfProduct;
        SqlCommand sqlCommand;
        SqlCommand commannd;
        public int idOfManufacturer;
       
        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);
        public WareHouseForm()
        {
            InitializeComponent();
        }
        

        

        private void btn_main_page_Click(object sender, EventArgs e)
        {
            var manufacturerForm = new ManufacturerForm();
            manufacturerForm.Show();
            this.Close();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "select id from products where name='"+ txt_p_name.Text +"'";
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                idOfProduct = sqlDataReader.GetInt32(0);

            }
            sqlDataReader.Close();



            commannd = new SqlCommand();
            commannd.Connection = sqlConnection;
            commannd.CommandText = "select id from manufacturerFactory where manufacturerName='"+ txt_man_name.Text+"'";
            Console.WriteLine(ManufacturerInfoForm.name);
             sqlData = commannd.ExecuteReader();
            while (sqlData.Read())
            {
                idOfManufacturer = sqlData.GetInt32(0);

            }
            sqlData.Close();

            try
            {

                String save = "insert into warehouses(manufacturerId,numberOfWarehouses,location,productId)VALUES(@manId,@number,@loc,@prodId)";
                sqlCommand = new SqlCommand(save, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@manId", idOfManufacturer);
                sqlCommand.Parameters.AddWithValue("@number", int.Parse(txt_number_warehouse.Text));
                sqlCommand.Parameters.AddWithValue("@loc", txtboloc.Text);
                sqlCommand.Parameters.AddWithValue("@prodId", idOfProduct);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Warehouse is inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred when you insert" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }
    }
}
