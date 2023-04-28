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
    public partial class ManufacturerInfoForm : Form
    {
        SqlCommand sqlCommand;
        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);
        public static string name;
        public ManufacturerInfoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                    sqlConnection.Open();
                    String save = "insert into manufacturerFactory(manufacturerName,addressOfFactory,totalNumberOfEmployee,userId)VALUES(@manName,@address,@totalEmp,@userId)";
                    sqlCommand = new SqlCommand(save, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@address", txt_address.Text);
                    sqlCommand.Parameters.AddWithValue("@manName", txt_man_name.Text);
                    sqlCommand.Parameters.AddWithValue("@totalEmp", int.Parse(txt_num_emp.Text));
                    sqlCommand.Parameters.AddWithValue("@userId", LogInForm.idOfManufacturer);
                    name = txt_man_name.Text;
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer is inserted,successfully","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_man_page_Click(object sender, EventArgs e)
        {
            var manufacturerForm = new ManufacturerForm();
            manufacturerForm.Show();
            this.Close();
        }

        private void btn_warehouse_Click(object sender, EventArgs e)
        {

            var wareHouseForm = new WareHouseForm();
            wareHouseForm.Show();
            this.Close();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            var productAddForm = new AddProductForm();
            productAddForm.Show();
            this.Hide();
         }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
