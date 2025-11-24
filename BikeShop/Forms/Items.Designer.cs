namespace BikeShop
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btlogout = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            TBitemType = new TextBox();
            label3 = new Label();
            btnAddItem = new Button();
            DataGridItems = new DataGridView();
            label5 = new Label();
            TBitemName = new TextBox();
            label6 = new Label();
            TBitemQuantityNumeric = new NumericUpDown();
            radioButtonMountain = new RadioButton();
            radioButtonRoad = new RadioButton();
            btnRefresh = new Button();
            btndeleteitem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TBitemQuantityNumeric).BeginInit();
            SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 599);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 237);
            button3.Name = "button3";
            button3.Size = new Size(169, 49);
            button3.TabIndex = 6;
            button3.Text = "Accessories";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 292);
            button2.Name = "button2";
            button2.Size = new Size(169, 49);
            button2.TabIndex = 5;
            button2.Text = "Products";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btlogout
            // 
            btlogout.FlatAppearance.BorderSize = 0;
            btlogout.FlatStyle = FlatStyle.Flat;
            btlogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btlogout.ForeColor = Color.White;
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
            button1.BackColor = Color.FromArgb(42, 113, 57);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 182);
            button1.Name = "button1";
            button1.Size = new Size(169, 49);
            button1.TabIndex = 3;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 113, 57);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(169, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 61);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(443, 32);
            label1.TabIndex = 0;
            label1.Text = "Alon's Hub Bike Shop Inventory System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 74);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 2;
            label2.Text = "Bike Category:";
            // 
            // TBitemType
            // 
            TBitemType.BorderStyle = BorderStyle.FixedSingle;
            TBitemType.Location = new Point(355, 100);
            TBitemType.Name = "TBitemType";
            TBitemType.Size = new Size(188, 23);
            TBitemType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(355, 74);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 5;
            label3.Text = "Item Type:";
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(11, 42, 69);
            btnAddItem.FlatAppearance.BorderColor = Color.Black;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(355, 143);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(188, 26);
            btnAddItem.TabIndex = 8;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // DataGridItems
            // 
            DataGridItems.AllowUserToAddRows = false;
            DataGridItems.BackgroundColor = Color.White;
            DataGridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DataGridItems.DefaultCellStyle = dataGridViewCellStyle4;
            DataGridItems.Location = new Point(178, 182);
            DataGridItems.Name = "DataGridItems";
            DataGridItems.RowHeadersWidth = 62;
            DataGridItems.Size = new Size(895, 409);
            DataGridItems.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(570, 73);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 11;
            label5.Text = "Item Name:";
            // 
            // TBitemName
            // 
            TBitemName.BorderStyle = BorderStyle.FixedSingle;
            TBitemName.Location = new Point(570, 100);
            TBitemName.Name = "TBitemName";
            TBitemName.Size = new Size(188, 23);
            TBitemName.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(779, 73);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 16;
            label6.Text = "Item Quantity:";
            // 
            // TBitemQuantityNumeric
            // 
            TBitemQuantityNumeric.Location = new Point(779, 100);
            TBitemQuantityNumeric.Margin = new Padding(2);
            TBitemQuantityNumeric.Name = "TBitemQuantityNumeric";
            TBitemQuantityNumeric.Size = new Size(188, 23);
            TBitemQuantityNumeric.TabIndex = 17;
            // 
            // radioButtonMountain
            // 
            radioButtonMountain.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonMountain.Location = new Point(188, 115);
            radioButtonMountain.Name = "radioButtonMountain";
            radioButtonMountain.Size = new Size(100, 22);
            radioButtonMountain.TabIndex = 18;
            radioButtonMountain.TabStop = true;
            radioButtonMountain.Text = "Mountain";
            radioButtonMountain.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoad
            // 
            radioButtonRoad.AutoSize = true;
            radioButtonRoad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonRoad.Location = new Point(188, 143);
            radioButtonRoad.Name = "radioButtonRoad";
            radioButtonRoad.Size = new Size(66, 25);
            radioButtonRoad.TabIndex = 19;
            radioButtonRoad.TabStop = true;
            radioButtonRoad.Text = "Road";
            radioButtonRoad.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(45, 116, 60);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(570, 143);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(188, 26);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btndeleteitem
            // 
            btndeleteitem.BackColor = Color.FromArgb(45, 116, 60);
            btndeleteitem.FlatStyle = FlatStyle.Flat;
            btndeleteitem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndeleteitem.ForeColor = Color.White;
            btndeleteitem.Location = new Point(779, 143);
            btndeleteitem.Margin = new Padding(2);
            btndeleteitem.Name = "btndeleteitem";
            btndeleteitem.Size = new Size(188, 26);
            btndeleteitem.TabIndex = 21;
            btndeleteitem.Text = "Delete Item";
            btndeleteitem.UseVisualStyleBackColor = false;
            btndeleteitem.Click += btndeleteitem_Click;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 248);
            ClientSize = new Size(1082, 599);
            Controls.Add(btndeleteitem);
            Controls.Add(btnRefresh);
            Controls.Add(radioButtonRoad);
            Controls.Add(radioButtonMountain);
            Controls.Add(TBitemQuantityNumeric);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TBitemName);
            Controls.Add(DataGridItems);
            Controls.Add(btnAddItem);
            Controls.Add(label3);
            Controls.Add(TBitemType);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Items";
            Text = "Inventory";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)TBitemQuantityNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button1;
        private Button btlogout;
        private Label label1;
        private Label label2;
        private TextBox TBitemType;
        private Label label3;
        private Button btnAddItem;
        private DataGridView DataGridItems;
        private Label label5;
        private TextBox TBitemName;
        private Label label6;
        private NumericUpDown TBitemQuantityNumeric;
        private Button button3;
        private Button button2;
        private RadioButton radioButtonMountain;
        private RadioButton radioButtonRoad;
        private Button btnRefresh;
        private Button btndeleteitem;
    }
}