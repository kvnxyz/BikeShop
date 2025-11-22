namespace BikeShop.Forms
{
    partial class Accessories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accessories));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btlogout = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            DataGridAccessories = new DataGridView();
            btnRefreshAccessories = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridAccessories).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btlogout);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 599);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 217);
            button3.Name = "button3";
            button3.Size = new Size(169, 49);
            button3.TabIndex = 6;
            button3.Text = "Accessories";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 162);
            button2.Name = "button2";
            button2.Size = new Size(169, 49);
            button2.TabIndex = 5;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btlogout
            // 
            btlogout.FlatAppearance.BorderSize = 0;
            btlogout.FlatStyle = FlatStyle.Flat;
            btlogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btlogout.Image = (Image)resources.GetObject("btlogout.Image");
            btlogout.ImageAlign = ContentAlignment.MiddleLeft;
            btlogout.Location = new Point(0, 548);
            btlogout.Name = "btlogout";
            btlogout.Size = new Size(169, 49);
            btlogout.TabIndex = 4;
            btlogout.Text = "Logout";
            btlogout.UseVisualStyleBackColor = true;
            btlogout.Click += btlogout_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 107);
            button1.Name = "button1";
            button1.Size = new Size(169, 49);
            button1.TabIndex = 3;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(169, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 61);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(443, 32);
            label1.TabIndex = 0;
            label1.Text = "Alon's Hub Bike Shop Inventory System";
            // 
            // DataGridAccessories
            // 
            DataGridAccessories.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridAccessories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridAccessories.Location = new Point(179, 165);
            DataGridAccessories.Margin = new Padding(2, 2, 2, 2);
            DataGridAccessories.Name = "DataGridAccessories";
            DataGridAccessories.RowHeadersWidth = 62;
            DataGridAccessories.Size = new Size(895, 425);
            DataGridAccessories.TabIndex = 4;
            // 
            // btnRefreshAccessories
            // 
            btnRefreshAccessories.Location = new Point(904, 78);
            btnRefreshAccessories.Margin = new Padding(2, 2, 2, 2);
            btnRefreshAccessories.Name = "btnRefreshAccessories";
            btnRefreshAccessories.Size = new Size(130, 53);
            btnRefreshAccessories.TabIndex = 5;
            btnRefreshAccessories.Text = "Refresh";
            btnRefreshAccessories.UseVisualStyleBackColor = true;
            btnRefreshAccessories.Click += btnRefreshAccessories_Click;
            // 
            // Accessories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 599);
            Controls.Add(btnRefreshAccessories);
            Controls.Add(DataGridAccessories);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Accessories";
            Text = "Products";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridAccessories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button btlogout;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private DataGridView DataGridAccessories;
        private Button btnRefreshAccessories;
    }
}