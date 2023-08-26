namespace StationeryManagementSystem
{
    partial class ManageOrder2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.CustomersGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OrderIdTb = new System.Windows.Forms.TextBox();
            this.ProdPriceTb = new System.Windows.Forms.TextBox();
            this.StockTb = new System.Windows.Forms.TextBox();
            this.ProductNameTb = new System.Windows.Forms.TextBox();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.CustIdTb = new System.Windows.Forms.TextBox();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.ProductIdTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderGv = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalAmountTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OrderDate = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(693, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product List";
            // 
            // ProductsGV
            // 
            this.ProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGV.Location = new System.Drawing.Point(361, 108);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.Size = new System.Drawing.Size(465, 199);
            this.ProductsGV.TabIndex = 3;
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustomersGV
            // 
            this.CustomersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGV.Location = new System.Drawing.Point(35, 108);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.Size = new System.Drawing.Size(302, 199);
            this.CustomersGV.TabIndex = 4;
            this.CustomersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "OrderId";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cust Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cust Id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(557, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Product Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(557, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Available Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(310, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Product Name";
            // 
            // OrderIdTb
            // 
            this.OrderIdTb.Location = new System.Drawing.Point(123, 326);
            this.OrderIdTb.Name = "OrderIdTb";
            this.OrderIdTb.Size = new System.Drawing.Size(144, 20);
            this.OrderIdTb.TabIndex = 12;
            this.OrderIdTb.TextChanged += new System.EventHandler(this.OrderIdTb_TextChanged);
            // 
            // ProdPriceTb
            // 
            this.ProdPriceTb.Enabled = false;
            this.ProdPriceTb.Location = new System.Drawing.Point(416, 344);
            this.ProdPriceTb.Name = "ProdPriceTb";
            this.ProdPriceTb.Size = new System.Drawing.Size(92, 20);
            this.ProdPriceTb.TabIndex = 13;
            this.ProdPriceTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // StockTb
            // 
            this.StockTb.Enabled = false;
            this.StockTb.Location = new System.Drawing.Point(679, 313);
            this.StockTb.Name = "StockTb";
            this.StockTb.Size = new System.Drawing.Size(73, 20);
            this.StockTb.TabIndex = 14;
            // 
            // ProductNameTb
            // 
            this.ProductNameTb.Enabled = false;
            this.ProductNameTb.Location = new System.Drawing.Point(416, 313);
            this.ProductNameTb.Name = "ProductNameTb";
            this.ProductNameTb.Size = new System.Drawing.Size(92, 20);
            this.ProductNameTb.TabIndex = 15;
            // 
            // CustNameTb
            // 
            this.CustNameTb.Enabled = false;
            this.CustNameTb.Location = new System.Drawing.Point(123, 376);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(144, 20);
            this.CustNameTb.TabIndex = 16;
            this.CustNameTb.TextChanged += new System.EventHandler(this.CustomerNameTb_TextChanged);
            // 
            // CustIdTb
            // 
            this.CustIdTb.Enabled = false;
            this.CustIdTb.Location = new System.Drawing.Point(123, 351);
            this.CustIdTb.Name = "CustIdTb";
            this.CustIdTb.Size = new System.Drawing.Size(144, 20);
            this.CustIdTb.TabIndex = 17;
            this.CustIdTb.TextChanged += new System.EventHandler(this.CustomerIdTb_TextChanged);
            // 
            // QtyTb
            // 
            this.QtyTb.Location = new System.Drawing.Point(626, 343);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(92, 20);
            this.QtyTb.TabIndex = 18;
            this.QtyTb.TextChanged += new System.EventHandler(this.QtyTb_TextChanged);
            // 
            // ProductIdTb
            // 
            this.ProductIdTb.Enabled = false;
            this.ProductIdTb.Location = new System.Drawing.Point(758, 313);
            this.ProductIdTb.Name = "ProductIdTb";
            this.ProductIdTb.Size = new System.Drawing.Size(68, 20);
            this.ProductIdTb.TabIndex = 19;
            this.ProductIdTb.Text = "Pro Id";
            this.ProductIdTb.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(724, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add to Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderGv
            // 
            this.OrderGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGv.Location = new System.Drawing.Point(313, 385);
            this.OrderGv.Name = "OrderGv";
            this.OrderGv.Size = new System.Drawing.Size(458, 181);
            this.OrderGv.TabIndex = 21;
            this.OrderGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGv_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(310, 587);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total Amount  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(408, 585);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Rs";
            // 
            // TotalAmountTb
            // 
            this.TotalAmountTb.Enabled = false;
            this.TotalAmountTb.Location = new System.Drawing.Point(443, 583);
            this.TotalAmountTb.Name = "TotalAmountTb";
            this.TotalAmountTb.Size = new System.Drawing.Size(92, 20);
            this.TotalAmountTb.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Order Date";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(161, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 26);
            this.button2.TabIndex = 26;
            this.button2.Text = "View Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(35, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 26);
            this.button3.TabIndex = 27;
            this.button3.Text = "Insert Order";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OrderDate
            // 
            this.OrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OrderDate.Location = new System.Drawing.Point(123, 403);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(84, 20);
            this.OrderDate.TabIndex = 28;
            this.OrderDate.ValueChanged += new System.EventHandler(this.OrderDate_ValueChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(99, 510);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 26);
            this.button4.TabIndex = 29;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 74);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Navy;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(307, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 24);
            this.label14.TabIndex = 1;
            this.label14.Text = "Manage Order";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Navy;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(177, -2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(457, 33);
            this.label13.TabIndex = 0;
            this.label13.Text = "Stationery Management System";
            // 
            // CatCombo
            // 
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(515, 84);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(121, 21);
            this.CatCombo.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(391, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Select Category";
            // 
            // ManageOrder2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StationeryManagementSystem.Properties.Resources.Screenshot__130_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 612);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TotalAmountTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OrderGv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductIdTb);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.CustIdTb);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.ProductNameTb);
            this.Controls.Add(this.StockTb);
            this.Controls.Add(this.ProdPriceTb);
            this.Controls.Add(this.OrderIdTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomersGV);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageOrder2";
            this.Text = "ManageOrder2";
            this.Load += new System.EventHandler(this.ManageOrder2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductsGV;
        private System.Windows.Forms.DataGridView CustomersGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OrderIdTb;
        private System.Windows.Forms.TextBox ProdPriceTb;
        private System.Windows.Forms.TextBox StockTb;
        private System.Windows.Forms.TextBox ProductNameTb;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.TextBox CustIdTb;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.TextBox ProductIdTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OrderGv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TotalAmountTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker OrderDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.Label label15;
    }
}