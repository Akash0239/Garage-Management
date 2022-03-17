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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_username.Text=="admin"&& textBox2.Text == "admin")
            {
                Form_home fh = new Form_home();
                fh.ShowDialog();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show(checkBox1.Checked.ToString());

            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = (char)0;
                
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
