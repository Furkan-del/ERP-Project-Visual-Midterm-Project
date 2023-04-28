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
    
    public partial class AddProductForm : Form
    {
        SqlCommand sqlCommand;
        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);


        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                    sqlConnection.Open();
                    String save = "insert into products(quantityOfProduct,price,name,orderTime)VALUES(@qty,@price,@name,@ordrTime)";
                    sqlCommand = new SqlCommand(save, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@qty",int.Parse(txt_qty.Text));
                    sqlCommand.Parameters.AddWithValue("@price", int.Parse(txtPrice.Text));
                    sqlCommand.Parameters.AddWithValue("@name", txt_prodName.Text);
                    sqlCommand.Parameters.AddWithValue("@ordrTime",DateTime.UtcNow);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Product inserted to database correctly" , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlConnection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred when you insert"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();

            }
        }

        private void btn_Main_Page_Click(object sender, EventArgs e)
        {
            var dashboardManufacturerForm = new ManufacturerForm();
            dashboardManufacturerForm.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            var goManufacturerForm = new ManufacturerInfoForm();
            goManufacturerForm.Show();
            this.Close();
        }
    }
}
