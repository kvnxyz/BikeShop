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
                Login form = new Login();
                form.Show();
                this.Close();
            }
            else
            {

            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using MySqlConnection sqlcon = new MySqlConnection("Server=localhost;Database=bikeinventorysystem;Uid=username;Password=password123;");
            sqlcon.Open();

            string query = "INSERT INTO parts (ItemName, ItemType, BikeCategory) VALUES (@ItemName, @ItemType, @BikeCategory)";
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using MySqlConnection sqlcon = new MySqlConnection("Server=localhost;Database=bikeinventorysystem;Uid=username;Password=password123;");
            sqlcon.Open();
            string query = "SELECT * FROM parts";
            using MySqlCommand cmd = new MySqlCommand(query, sqlcon);
            MySqlDataAdapter itemsda = new MySqlDataAdapter(cmd);
            DataTable itemdt = new DataTable();
            itemsda.Fill(itemdt);
            DataGridItems.DataSource = itemdt;
        }
    }
}
