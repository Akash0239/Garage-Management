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
    public partial class uc_employee : UserControl
    {
        Connection conn = new Connection();
        public uc_employee()
        {
            InitializeComponent();
            display_data();
        }

        string si_no, name, education, address, gender;

        void display_data()
        {
            try
            {
                string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand("SELECT * FROM `db_employee`", MyConn2);
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
            txt_employeename.Clear();
            txt_education.Clear();
            txt_address.Clear();
            combo_gender.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                try
                {

                    name = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
                    education = dataGridView1.SelectedRows[0].Cells["education"].Value.ToString();
                    address = dataGridView1.SelectedRows[0].Cells["address"].Value.ToString();
                    gender = dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString();
                    si_no = dataGridView1.SelectedRows[0].Cells["si_no"].Value.ToString();

                    txt_employeename.Text = name;
                    txt_education.Text = education;
                    txt_address.Text = address;
                    combo_gender.Text = gender;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_employeename.Text == "")
                {
                    MessageBox.Show("Please, Enter employee name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_employeename.Focus();
                }
                else if (txt_education.Text == "")
                {
                    MessageBox.Show("Please, Enter employee education", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_education.Focus();
                }
                else if (txt_address.Text == "")
                {
                    MessageBox.Show("Please, Enter employee address", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_address.Focus();
                }
                else if (combo_gender.Text == "")
                {
                    MessageBox.Show("Please, Enter employee gender", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    combo_gender.Focus();
                }
                else
                {
                    try
                    {
                        string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                        string query = "Insert into db_employee (name, education, address, gender) Values ('" + txt_employeename.Text + "','" + txt_education.Text + "','" + txt_address.Text + "','" + combo_gender.Text + "') ";
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_employeename.Text == "")
                {
                    MessageBox.Show("Please, Enter employee name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_employeename.Focus();
                }
                else if (txt_education.Text == "")
                {
                    MessageBox.Show("Please, Enter employee education", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_education.Focus();
                }
                else if (txt_address.Text == "")
                {
                    MessageBox.Show("Please, Enter employee address", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_address.Focus();
                }
                else if (combo_gender.Text == "")
                {
                    MessageBox.Show("Please, Enter employee gender", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    combo_gender.Focus();
                }
                else
                {
                    try
                    {
                        string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                        string Query = " UPDATE `db_employee` SET `name`='" + this.txt_employeename.Text + "', `education`= '" + this.txt_education.Text + "',`address`= '" + this.txt_address.Text + "',`gender`= '" + this.combo_gender.Text + "' WHERE `si_no`= '" + si_no + "';";
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
                if (txt_employeename.Text == "")
                {
                    MessageBox.Show("Please, Enter employee name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_employeename.Focus();
                }
                else if (txt_education.Text == "")
                {
                    MessageBox.Show("Please, Enter employee education", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_education.Focus();
                }
                else if (txt_address.Text == "")
                {
                    MessageBox.Show("Please, Enter employee address", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_address.Focus();
                }
                else if (combo_gender.Text == "")
                {
                    MessageBox.Show("Please, Enter employee gender", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    combo_gender.Focus();
                }
                else
                {
                    try
                    {
                        string connectionString = "datasource = localhost; username = root; password=; database = garage_service";
                        string Query = "DELETE FROM `db_employee` WHERE `si_no`= '" + si_no + "';";
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


    }
}
