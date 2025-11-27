using BikeShop.Forms;
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

            cmd.Parameters.AddWithValue("@Quantity", (int)TBitemQuantityNumeric.Value);
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Item Added");
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

            this.DataGridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btndeleteitem_Click(object sender, EventArgs e)
        {
            if (DataGridItems.SelectedRows.Count > 0)
            {
                {
                    int id = Convert.ToInt32(DataGridItems.SelectedRows[0].Cells["PartID"].Value);
                    using MySqlConnection sqlcon = new MySqlConnection("Server=localhost;Database=bikeinventorysystem;Uid=username;Password=password123;");
                    sqlcon.Open();
                    string query = "DELETE FROM parts WHERE PartID = @id";
                    using MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                }
                foreach (DataGridViewRow row in DataGridItems.SelectedRows)
                {
                    DataGridItems.Rows.Remove(row);
                }

            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Accessories form = new Accessories();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products form = new Products();
            form.Show();
            this.Hide();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to EXIT the program?";
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
        }
    }
}
