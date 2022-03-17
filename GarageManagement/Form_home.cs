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
    public partial class Form_home : Form
    {
        public Form_home()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cars_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_cars.Height;
            SidePanel.Top = btn_cars.Top;
            uc_car1.BringToFront();
        }

        private void btn_stocks_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_stocks.Height;
            SidePanel.Top = btn_stocks.Top;
            uc_stock1.BringToFront();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_employees.Height;
            SidePanel.Top = btn_employees.Top;
            uc_employee1.BringToFront();
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_billing.Height;
            SidePanel.Top = btn_billing.Top;
            uc_billing1.BringToFront();
        }

        private void btn_analytics_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_analytics.Height;
            SidePanel.Top = btn_analytics.Top;
            uc_analytics1.BringToFront();
        }

        private void Form_home_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btn_analytics.Height;
            SidePanel.Top = btn_analytics.Top;
            uc_analytics1.BringToFront();
        }
    }
}
