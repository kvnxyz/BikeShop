namespace BikeShop
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btlogout = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            DataGridProducts = new DataGridView();
            btnRefreshproducts = new Button();
            exitbtn = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridProducts).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 113, 57);
            panel2.Controls.Add(exitbtn);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(241, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1305, 102);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(664, 48);
            label1.TabIndex = 0;
            label1.Text = "Alon's Hub Bike Shop Inventory System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 42, 69);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btlogout);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 998);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(11, 42, 69);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 395);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(241, 82);
            button3.TabIndex = 6;
            button3.Text = "Accessories";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(42, 113, 57);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 487);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(241, 82);
            button2.TabIndex = 5;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = false;
            // 
            // btlogout
            // 
            btlogout.FlatAppearance.BorderSize = 0;
            btlogout.FlatStyle = FlatStyle.Flat;
            btlogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btlogout.ForeColor = Color.White;
            btlogout.Image = (Image)resources.GetObject("btlogout.Image");
            btlogout.ImageAlign = ContentAlignment.MiddleLeft;
            btlogout.Location = new Point(0, 913);
            btlogout.Margin = new Padding(4, 5, 4, 5);
            btlogout.Name = "btlogout";
            btlogout.Size = new Size(241, 82);
            btlogout.TabIndex = 4;
            btlogout.Text = "Logout";
            btlogout.UseVisualStyleBackColor = true;
            btlogout.Click += btlogout_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 303);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(241, 82);
            button1.TabIndex = 3;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // DataGridProducts
            // 
            DataGridProducts.BackgroundColor = Color.White;
            DataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridProducts.Location = new Point(254, 303);
            DataGridProducts.Margin = new Padding(4, 5, 4, 5);
            DataGridProducts.Name = "DataGridProducts";
            DataGridProducts.RowHeadersWidth = 62;
            DataGridProducts.Size = new Size(1279, 682);
            DataGridProducts.TabIndex = 6;
            DataGridProducts.CellContentClick += DataGridProducts_CellContentClick;
            // 
            // btnRefreshproducts
            // 
            btnRefreshproducts.BackColor = Color.FromArgb(11, 42, 69);
            btnRefreshproducts.FlatStyle = FlatStyle.Flat;
            btnRefreshproducts.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshproducts.ForeColor = Color.White;
            btnRefreshproducts.Location = new Point(1313, 155);
            btnRefreshproducts.Margin = new Padding(4, 5, 4, 5);
            btnRefreshproducts.Name = "btnRefreshproducts";
            btnRefreshproducts.Size = new Size(220, 100);
            btnRefreshproducts.TabIndex = 7;
            btnRefreshproducts.Text = "Refresh";
            btnRefreshproducts.UseVisualStyleBackColor = false;
            btnRefreshproducts.Click += btnRefreshproducts_Click;
            // 
            // exitbtn
            // 
            exitbtn.FlatAppearance.BorderSize = 0;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Image = (Image)resources.GetObject("exitbtn.Image");
            exitbtn.Location = new Point(1269, 0);
            exitbtn.Margin = new Padding(4, 5, 4, 5);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(36, 42);
            exitbtn.TabIndex = 8;
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 998);
            Controls.Add(btnRefreshproducts);
            Controls.Add(DataGridProducts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button btlogout;
        private Button button1;
        private PictureBox pictureBox1;
        private DataGridView DataGridProducts;
        private Button btnRefreshproducts;
        private Button exitbtn;
    }
}