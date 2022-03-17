using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManagement
{
    public partial class uc_analytics : UserControl
    {
        public uc_analytics()
        {
            InitializeComponent();
            refresh();
        }

        void refresh()
        {
            display_data_count("db_cars", lbl_cars);
            display_data_count("db_stock", lbl_spare);
            display_data_count("db_employee", lbl_employee);
            display_data_count("db_bill", lbl_finance);
        }

        void display_data_count(String tableName, Label labelTxt)
        {
            String data = "";
            try
            {
                string connection = "datasource=localhost;username=root;password=; database=garage_service";
                MySqlConnection con = new MySqlConnection(connection);
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM `"+tableName+"` WHERE 1";
                con.Open();
                var dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                   data = dr.GetString(0);
                    labelTxt.Text = data;
                }
                else
                {
                    MessageBox.Show("wrong Username/password inside \n ");
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
           
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
