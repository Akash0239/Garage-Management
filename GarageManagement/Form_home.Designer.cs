namespace GarageManagement
{
    partial class Form_home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_analytics = new System.Windows.Forms.Button();
            this.btn_stocks = new System.Windows.Forms.Button();
            this.btn_cars = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.uc_analytics2 = new GarageManagement.uc_analytics();
            this.uc_stock1 = new GarageManagement.uc_stock();
            this.uc_employee1 = new GarageManagement.uc_employee();
            this.uc_car1 = new GarageManagement.uc_car();
            this.uc_analytics1 = new GarageManagement.uc_analytics();
            this.uc_billing1 = new GarageManagement.uc_billing();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_analytics);
            this.panel1.Controls.Add(this.btn_stocks);
            this.panel1.Controls.Add(this.btn_cars);
            this.panel1.Controls.Add(this.btn_billing);
            this.panel1.Controls.Add(this.btn_employees);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 828);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(141, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Garage\r\nManagement";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(0, 221);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(30, 55);
            this.SidePanel.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DimGray;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(85, 645);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(199, 55);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_analytics
            // 
            this.btn_analytics.BackColor = System.Drawing.Color.DimGray;
            this.btn_analytics.FlatAppearance.BorderSize = 0;
            this.btn_analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analytics.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_analytics.Location = new System.Drawing.Point(85, 562);
            this.btn_analytics.Name = "btn_analytics";
            this.btn_analytics.Size = new System.Drawing.Size(199, 55);
            this.btn_analytics.TabIndex = 4;
            this.btn_analytics.Text = "Analytics";
            this.btn_analytics.UseVisualStyleBackColor = false;
            this.btn_analytics.Click += new System.EventHandler(this.btn_analytics_Click);
            // 
            // btn_stocks
            // 
            this.btn_stocks.BackColor = System.Drawing.Color.DimGray;
            this.btn_stocks.FlatAppearance.BorderSize = 0;
            this.btn_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stocks.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stocks.Location = new System.Drawing.Point(85, 309);
            this.btn_stocks.Name = "btn_stocks";
            this.btn_stocks.Size = new System.Drawing.Size(199, 55);
            this.btn_stocks.TabIndex = 1;
            this.btn_stocks.Text = "Stock";
            this.btn_stocks.UseVisualStyleBackColor = false;
            this.btn_stocks.Click += new System.EventHandler(this.btn_stocks_Click);
            // 
            // btn_cars
            // 
            this.btn_cars.BackColor = System.Drawing.Color.Gray;
            this.btn_cars.FlatAppearance.BorderSize = 0;
            this.btn_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cars.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cars.ForeColor = System.Drawing.Color.Black;
            this.btn_cars.Location = new System.Drawing.Point(85, 221);
            this.btn_cars.Name = "btn_cars";
            this.btn_cars.Size = new System.Drawing.Size(199, 55);
            this.btn_cars.TabIndex = 0;
            this.btn_cars.Text = "Cars";
            this.btn_cars.UseVisualStyleBackColor = false;
            this.btn_cars.Click += new System.EventHandler(this.btn_cars_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.BackColor = System.Drawing.Color.DimGray;
            this.btn_billing.FlatAppearance.BorderSize = 0;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_billing.Location = new System.Drawing.Point(85, 480);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(199, 55);
            this.btn_billing.TabIndex = 3;
            this.btn_billing.Text = "Billing";
            this.btn_billing.UseVisualStyleBackColor = false;
            this.btn_billing.Click += new System.EventHandler(this.btn_billing_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.BackColor = System.Drawing.Color.DimGray;
            this.btn_employees.FlatAppearance.BorderSize = 0;
            this.btn_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employees.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_employees.Location = new System.Drawing.Point(85, 392);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(199, 55);
            this.btn_employees.TabIndex = 2;
            this.btn_employees.Text = "Employees";
            this.btn_employees.UseVisualStyleBackColor = false;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(299, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 35);
            this.panel3.TabIndex = 1;
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.Cornsilk;
            this.Main_Panel.Controls.Add(this.uc_analytics2);
            this.Main_Panel.Controls.Add(this.uc_stock1);
            this.Main_Panel.Controls.Add(this.uc_employee1);
            this.Main_Panel.Controls.Add(this.uc_car1);
            this.Main_Panel.Controls.Add(this.uc_analytics1);
            this.Main_Panel.Controls.Add(this.uc_billing1);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(299, 35);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1132, 793);
            this.Main_Panel.TabIndex = 2;
            // 
            // uc_analytics2
            // 
            this.uc_analytics2.BackColor = System.Drawing.Color.Cornsilk;
            this.uc_analytics2.Location = new System.Drawing.Point(0, 0);
            this.uc_analytics2.Name = "uc_analytics2";
            this.uc_analytics2.Size = new System.Drawing.Size(1249, 796);
            this.uc_analytics2.TabIndex = 5;
            // 
            // uc_stock1
            // 
            this.uc_stock1.BackColor = System.Drawing.Color.Cornsilk;
            this.uc_stock1.Location = new System.Drawing.Point(6, 11);
            this.uc_stock1.Name = "uc_stock1";
            this.uc_stock1.Size = new System.Drawing.Size(1340, 852);
            this.uc_stock1.TabIndex = 4;
            // 
            // uc_employee1
            // 
            this.uc_employee1.BackColor = System.Drawing.Color.Cornsilk;
            this.uc_employee1.Location = new System.Drawing.Point(8, 1);
            this.uc_employee1.Name = "uc_employee1";
            this.uc_employee1.Size = new System.Drawing.Size(1410, 935);
            this.uc_employee1.TabIndex = 3;
            // 
            // uc_car1
            // 
            this.uc_car1.BackColor = System.Drawing.Color.Cornsilk;
            this.uc_car1.Location = new System.Drawing.Point(47, 11);
            this.uc_car1.Name = "uc_car1";
            this.uc_car1.Size = new System.Drawing.Size(1505, 941);
            this.uc_car1.TabIndex = 2;
            // 
            // uc_analytics1
            // 
            this.uc_analytics1.BackColor = System.Drawing.Color.Cornsilk;
            this.uc_analytics1.Location = new System.Drawing.Point(87, 9);
            this.uc_analytics1.Name = "uc_analytics1";
            this.uc_analytics1.Size = new System.Drawing.Size(1249, 796);
            this.uc_analytics1.TabIndex = 1;
            // 
            // uc_billing1
            // 
            this.uc_billing1.BackColor = System.Drawing.Color.Cornsilk;
            this.uc_billing1.Location = new System.Drawing.Point(36, 35);
            this.uc_billing1.Name = "uc_billing1";
            this.uc_billing1.Size = new System.Drawing.Size(1505, 941);
            this.uc_billing1.TabIndex = 0;
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 828);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form_home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Main_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel SidePanel;
        private Button btn_exit;
        private Button btn_analytics;
        private Button btn_stocks;
        private Button btn_cars;
        private Button btn_billing;
        private Button btn_employees;
        private Panel panel3;
        private Panel Main_Panel;
        private uc_billing uc_billing1;
        private uc_analytics uc_analytics2;
        private uc_stock uc_stock1;
        private uc_employee uc_employee1;
        private uc_car uc_car1;
        private uc_analytics uc_analytics1;
    }
}