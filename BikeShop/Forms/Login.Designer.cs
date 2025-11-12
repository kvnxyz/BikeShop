namespace BikeShop
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TBuser = new TextBox();
            TBpass = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(228, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 201);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 1;
            label1.Text = "User";
            label1.Click += label1_Click;
            // 
            // TBuser
            // 
            TBuser.Location = new Point(196, 229);
            TBuser.Name = "TBuser";
            TBuser.Size = new Size(197, 23);
            TBuser.TabIndex = 2;
            // 
            // TBpass
            // 
            TBpass.Location = new Point(196, 288);
            TBpass.Name = "TBpass";
            TBpass.Size = new Size(197, 23);
            TBpass.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(196, 260);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 403);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(238, 332);
            button1.Name = "button1";
            button1.Size = new Size(91, 35);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 403);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(TBpass);
            Controls.Add(label2);
            Controls.Add(TBuser);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox TBuser;
        private TextBox TBpass;
        private Label label2;
        private Panel panel1;
        private Button button1;
    }
}
