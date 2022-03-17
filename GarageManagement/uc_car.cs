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
    public partial class uc_car : UserControl
    {
        Connection conn = new Connection();
        public uc_car()
        {
            InitializeComponent();
            display_data();
        }
        string carno, carbrand, carmodel, date, carcolor, ownername,si_no;

        void display_data()
        {
            try
            {
                string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand("SELECT * FROM `db_cars`", MyConn2);
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


        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_carno.Text == "")
                {
                    MessageBox.Show("Please, Enter Car No.","Try again",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txt_carno.Focus();
                }
                else if (txt_carbrand.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Brand", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carbrand.Focus();
                }
                else if (txt_carmodel.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Model", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carmodel.Focus();
                }
                else if (txt_carcolor.Text == "")
                {
                    MessageBox.Show("Please, Enter Car color", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carcolor.Focus();
                }
                else if (txt_ownername.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Owner Name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ownername.Focus();
                }
                else
                {
                    try
                    {
                        string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                        string query = "Insert into db_cars (carno, carbrand, carmodel, date, carcolor, ownername) Values ('" + txt_carno.Text + "','" + txt_carbrand.Text + "','" + txt_carmodel.Text + "','" + dtp_date.Text + "','" + txt_carcolor.Text + "','" + txt_ownername.Text + "') ";
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

        public void clear()
        {
            txt_ownername.Clear();
            txt_carno.Clear();
            txt_carmodel.Clear();
            txt_carcolor.Clear();
            txt_carbrand.Clear();
            dtp_date.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_carno.Text == "")
                {
                    MessageBox.Show("Please, Enter Car No.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carno.Focus();
                }
                else if (txt_carbrand.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Brand", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carbrand.Focus();
                }
                else if (txt_carmodel.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Model", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carmodel.Focus();
                }
                else if (txt_carcolor.Text == "")
                {
                    MessageBox.Show("Please, Enter Car color", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carcolor.Focus();
                }
                else if (txt_ownername.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Owner Name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ownername.Focus();
                }
                else
                {
                    try
                    {
                        string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                        string Query = " UPDATE `db_cars` SET `carno`='"+this.txt_carno.Text+"', `carbrand`= '" + this.txt_carbrand.Text+"',`carmodel`= '"+this.txt_carmodel.Text+"',`date`= '"+this.dtp_date.Text+ "',`carcolor`= '" + this.txt_carcolor.Text + "',`ownername`= '" + this.txt_ownername.Text + "' WHERE `si_no`= '" + si_no+"';";
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_carno.Text == "")
                {
                    MessageBox.Show("Please, Enter Car No.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carno.Focus();
                }
                else if (txt_carbrand.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Brand", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carbrand.Focus();
                }
                else if (txt_carmodel.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Model", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carmodel.Focus();
                }
                else if (txt_carcolor.Text == "")
                {
                    MessageBox.Show("Please, Enter Car color", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carcolor.Focus();
                }
                else if (txt_ownername.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Owner Name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ownername.Focus();
                }
                else
                {
                    try
                    {
                        string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                        string Query = "DELETE FROM `db_cars` WHERE `si_no`= '" + si_no + "';";
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

                    carno = dataGridView1.SelectedRows[0].Cells["carno"].Value.ToString();
                    carmodel = dataGridView1.SelectedRows[0].Cells["carmodel"].Value.ToString();
                    carbrand = dataGridView1.SelectedRows[0].Cells["carbrand"].Value.ToString();
                    carcolor = dataGridView1.SelectedRows[0].Cells["carcolor"].Value.ToString();
                    ownername = dataGridView1.SelectedRows[0].Cells["ownername"].Value.ToString();
                    date = dataGridView1.SelectedRows[0].Cells["date"].Value.ToString();
                    si_no = dataGridView1.SelectedRows[0].Cells["si_no"].Value.ToString();

                    txt_carno.Text = carno;
                    txt_carmodel.Text = carmodel;
                    txt_carbrand.Text = carbrand;
                    txt_carcolor.Text = carcolor;
                    txt_ownername.Text = ownername;
                    dtp_date.Text = date;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
