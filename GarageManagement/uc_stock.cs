using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GarageManagement
{
    public partial class uc_stock : UserControl
    {
        Connection conn = new Connection();
        public uc_stock()
        {
            InitializeComponent();
            display_data();
        }

        string partname, partquantity, partprice,sl_no;

        void display_data()
        {
            try
            {
                string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand("SELECT * FROM `db_stock`", MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                MyConn2.Open();
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn2.Close();
                dataGridViewStock.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            txt_partname.Clear();
            txt_partquantity.Clear();
            txt_partprice.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();
                }
                else if (txt_partquantity.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Quantity", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partquantity.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else
                {
                    try
                    {
                        string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                        string Query = " UPDATE db_stock SET partname='" + this.txt_partname.Text + "', partquantity= '" + this.txt_partquantity.Text + "',partprice= '" + this.txt_partprice.Text + "' WHERE sl_no = '" +sl_no+ "';";
                        //This is  MySqlConnection here i have created the object and pass my connection string.  
                        MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MyConn2.Close();
                        MessageBox.Show("Updated!");
                        display_data();
                        clear();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();
                }
                else if (txt_partquantity.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Quantity", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partquantity.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }   
                else
                {
                    try
                    {
                        string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                        string query = "Insert into db_stock (partname, partquantity, partprice) Values ('" + txt_partname.Text + "','" + txt_partquantity.Text + "','" + txt_partprice.Text + "') ";
                        MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                        MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                        MySqlDataReader mySqlDataReader;
                        mySqlConnection.Open();
                        mySqlDataReader = mySqlCommand.ExecuteReader();
                        MessageBox.Show("Sucessfully Registered!!");
                        mySqlConnection.Close();
                        display_data();
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();
                }
                else if (txt_partquantity.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Quantity", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partquantity.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else
                {
                    try
                    {
                        string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                        string Query = "DELETE FROM `db_stock` WHERE `sl_no`= '" + sl_no + "';";
                        MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Deleted");
                        MyConn2.Close();
                        display_data();
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewStock.Rows[e.RowIndex];
                try
                {

                    partname = dataGridViewStock.SelectedRows[0].Cells["partname"].Value.ToString();
                    partquantity = dataGridViewStock.SelectedRows[0].Cells["partquantity"].Value.ToString();
                    partprice = dataGridViewStock.SelectedRows[0].Cells["partprice"].Value.ToString();
                    sl_no = dataGridViewStock.SelectedRows[0].Cells["sl_no"].Value.ToString();

                    txt_partname.Text = partname;
                    txt_partquantity.Text = partquantity;
                    txt_partprice.Text = partprice;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
