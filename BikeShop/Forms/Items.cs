using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeShop
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            string message = "Do you want to logout?";
            string title = "Close window";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
            //Login form = new Login();
            //form.Show();
            //this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using MySqlConnection sqlcon = new MySqlConnection("Server=localhost;Database=loginuser;Uid=user;Password=password123;");

            sqlcon.Open();

            string query = "INSERT INTO parts (ItemName, ItemType, BikeCategory, Quantity) VALUES (@ItemName, @ItemType, @BikeCategory, @Quantity)";
            using MySqlCommand cmd = new MySqlCommand(query, sqlcon);

            cmd.Parameters.AddWithValue("@ItemName", TBitemName.Text);
            cmd.Parameters.AddWithValue("@ItemType", TBitemType.Text);

            string radiobtn = "";
            if (radioButtonMountain.Checked)
            {
                radiobtn = "Mountain";
            }
            else if (radioButtonRoad.Checked)
            {
                radiobtn = "Road";
            }

            cmd.Parameters.AddWithValue("@BikeCategory", radiobtn);

            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
