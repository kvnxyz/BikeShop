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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items form = new Items();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Accessories form = new Accessories();
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

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void btnRefreshproducts_Click(object sender, EventArgs e)
        {
            using MySqlConnection sqlcon = new MySqlConnection("Server=localhost;Database=bikeinventorysystem;Uid=username;Password=password123;");
            sqlcon.Open();
            string query = "SELECT * FROM products";
            using MySqlCommand cmd = new MySqlCommand(query, sqlcon);
            MySqlDataAdapter itemsda = new MySqlDataAdapter(cmd);
            DataTable itemdt = new DataTable();
            itemsda.Fill(itemdt);
            DataGridProducts.DataSource = itemdt;

            this.DataGridProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void DataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
