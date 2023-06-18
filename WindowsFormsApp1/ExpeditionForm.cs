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
    public partial class ExpeditionForm : Form
    {
        SqlCommand sqlCommand;
        static String connString = "Data Source= DESKTOP-6NDRJ67\\MSSQLSERVER01;Initial Catalog=erpTIRSAN;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);
        SqlDataReader sqlDataReader;
        static int idCustomer;
       
        
        

        public ExpeditionForm()
        {
            InitializeComponent();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();



                string sqlQuery = "select id from customerfactory where customerName=@customerName";
                SqlCommand sql = new SqlCommand(sqlQuery, sqlConnection);
                sql.Parameters.AddWithValue("@customerName", comboBox_cus_name.Text);
                sqlDataReader= sql.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    idCustomer = int.Parse(sqlDataReader["id"].ToString());
                }
                sqlDataReader.Close();
                
                //logger idsini yollamayı unutma önemli 
                string query = "insert into expedition_infos(frrom,too,cargoName,cargoParcelAmount,totalCargoWeight,totalCargoVolume,estimatedDepartureDate,estimatedArrivalDate,actualDepartureDate,actualArrivalDate,confirmationDeliver,dateOfOrder,customer_id,warehousename,quantityOfProduct,productName,logger_id) " +
                    "VALUES(@from,@to,@cargoName,@cargoParcelAmount,@totalCargoWeight,@totalCargoVolume,@estimatedDepartureDate,@estimatedArrivalDate,@actualDepartureDate,@actualArrivalDate,@confDeliver,@dateOfOrder,@customerId,@warehouseName,@quantity,@pname,@order_id)";

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@from", txt_box_from.Text);
                sqlCommand.Parameters.AddWithValue("@to", txt_box_to.Text);
                sqlCommand.Parameters.AddWithValue("@cargoName", txt_cargo_name.Text);
                sqlCommand.Parameters.AddWithValue("@cargoParcelAmount", int.Parse(txt_parcel_amount.Text));
                sqlCommand.Parameters.AddWithValue("@totalCargoWeight",int.Parse(txt_total_cargo_weight.Text));
                sqlCommand.Parameters.AddWithValue("@totalCargoVolume", int.Parse(txt_total_cargo_volume.Text));
                sqlCommand.Parameters.AddWithValue("@estimatedDepartureDate", est_dep_date.Value);
                sqlCommand.Parameters.AddWithValue("@actualDepartureDate", act_departure_date.Value);
                sqlCommand.Parameters.AddWithValue("@actualArrivalDate", act_arr_date_picker.Value);
                sqlCommand.Parameters.AddWithValue("@estimatedArrivalDate", est_arr_date_picker.Value);
                sqlCommand.Parameters.AddWithValue("@confDeliver", txt_status.Text);
                sqlCommand.Parameters.AddWithValue("@dateOfOrder", DateTime.Now);
                sqlCommand.Parameters.AddWithValue("@customerId", idCustomer);
                sqlCommand.Parameters.AddWithValue("@warehousename", txt_ware_name.Text);
                sqlCommand.Parameters.AddWithValue("@quantity", int.Parse(txt_quantity.Text));
                sqlCommand.Parameters.AddWithValue("@pname", txt_product.Text);
                sqlCommand.Parameters.AddWithValue("@order_id", ManufacturerForm.order_id);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Expedition Infos are correctly added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

            }
            catch (Exception exception )
            {
                
                MessageBox.Show(exception.Message,"Error" ,  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 

        }
    }
}
