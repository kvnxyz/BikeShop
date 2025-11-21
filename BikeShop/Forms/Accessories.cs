using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeShop.Forms
{
    public partial class Accessories : Form
    {
        public Accessories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items form = new Items();
            form.Show();
            this.Hide();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            string message = "Do you want to logout?";
            string title = "Close window";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {
                Login form = new Login();
                form.Show();
                this.Close();
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products form = new Products();
            form.Show();
            this.Hide();
        }
    }
}
