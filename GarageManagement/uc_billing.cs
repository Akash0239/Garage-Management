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
    public partial class uc_billing : UserControl
    {
        Connection conn = new Connection();
        public uc_billing()
        {
            InitializeComponent();
            display_data();
        }

        string si_no, billno, partname, partprice, partquantity, totalprice;

        void display_data()
        {
            try
            {
                string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand("SELECT * FROM `db_bill`", MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                MyConn2.Open();
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn2.Close();
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            txt_billno.Clear();
            txt_partname.Clear();
            txt_partprice.Clear();
            txt_partquantity.Clear();
            txt_totalprice.Clear();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_billno.Text == "")
                {
                    MessageBox.Show("Please, Enter Bill no", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_billno.Focus();
                }
                else if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please, Enter part name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please, Enter part price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else if (txt_partquantity.Text == "")
                {
                    MessageBox.Show("Please, Enter part quantity", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partquantity.Focus();
                }
                else if (txt_totalprice.Text == "")
                {
                    MessageBox.Show("Please, Enter total price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_totalprice.Focus();
                }
                else
                {
                    try
                    {
                        string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                        string query = "Insert into db_bill (billno, partname, partprice, partquantity, totalprice) Values ('" + txt_billno.Text + "','" + txt_partname.Text + "','" + txt_partprice.Text + "','" + txt_partquantity.Text + "','" + txt_totalprice.Text + "') ";
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
                if (txt_billno.Text == "")
                {
                    MessageBox.Show("Please, Enter Bill no", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_billno.Focus();
                }
                else if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please, Enter part name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please, Enter part price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else if (txt_partquantity.Text == "")
                {
                    MessageBox.Show("Please, Enter part quantity", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partquantity.Focus();
                }
                else if (txt_totalprice.Text == "")
                {
                    MessageBox.Show("Please, Enter total price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_totalprice.Focus();
                }
                else
                {
                    try
                    {
                        string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                        string Query = "DELETE FROM `db_bill` WHERE `si_no`= '" + si_no + "';";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                try
                {

                    billno = dataGridView1.SelectedRows[0].Cells["billno"].Value.ToString();
                    partname = dataGridView1.SelectedRows[0].Cells["partname"].Value.ToString();
                    partprice = dataGridView1.SelectedRows[0].Cells["partprice"].Value.ToString();
                    partquantity = dataGridView1.SelectedRows[0].Cells["partquantity"].Value.ToString();
                    totalprice = dataGridView1.SelectedRows[0].Cells["totalprice"].Value.ToString();
                    si_no = dataGridView1.SelectedRows[0].Cells["si_no"].Value.ToString();

                    txt_billno.Text = billno;
                    txt_partname.Text = partname;
                    txt_partprice.Text = partprice;
                    txt_partquantity.Text = partquantity;
                    txt_totalprice.Text = totalprice;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
