using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class ReportingScreenForm : Form
    {
        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        public ReportingScreenForm()
        {
            InitializeComponent();
            sqlConnection.Open();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
         try
            {
                string query = "select productName,warehousename,confirmationDeliver,quantityOfProduct,actualDepartureDate,cargoParcelAmount,estimatedArrivalDate,warehousename,quantityOfProduct from expedition_infos where warehousename = @warehouseName ";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@warehouseName", filter_txt_box.Text);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                report_data_view.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }           
        }

        private void dateFilter_Click(object sender, EventArgs e)
        {
            try
            {
            SqlCommand sql;
            string queryy = "select warehousename,dateOfOrder,confirmationDeliver,productName,cargoParcelAmount,warehousename,quantityOfProduct from expedition_infos where actualArrivalDate BETWEEN  @baslangic AND @bitis ";
            sql = new SqlCommand(queryy, sqlConnection);
            sql.Parameters.AddWithValue("@baslangic", date_time_begin.Value.ToString("yyyy-MM-dd"));
            sql.Parameters.AddWithValue("@bitis", DateTime.Now.ToString("yyyy-MM-dd"));
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            report_data_view.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
         
        private void date_and_warehouse_filt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql;
                string queryy = "select warehousename,dateOfOrder,confirmationDeliver,productName,cargoParcelAmount,warehousename,quantityOfProduct from expedition_infos where actualArrivalDate BETWEEN @baslangic AND @bitis AND warehousename=@warehouseName  ";
                sql = new SqlCommand(queryy, sqlConnection);

                sql.Parameters.AddWithValue("@baslangic", date_time_begin.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                sql.Parameters.AddWithValue("@bitis", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                sql.Parameters.AddWithValue("@warehouseName", filter_txt_box.Text);
                SqlDataAdapter sqlData = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);
                report_data_view.DataSource = dt;

            }catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        
        private void back_btn_Click_1(object sender, EventArgs e)
        {
            var manForm = new ManufacturerForm();
            manForm.Show();
            this.Close();

        }
    }
}
