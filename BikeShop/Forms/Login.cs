using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace BikeShop
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlcon = new MySqlConnection("Server=localhost;Database=bikeinventorysystem;Uid=username;Password=password123;");
            sqlcon.Open();

            string query = "SELECT COUNT(*) FROM accounts WHERE Email=@Email AND Password=@Password";
            MySqlCommand cmd = new MySqlCommand(query, sqlcon);

            cmd.Parameters.AddWithValue("@Email", TBuser.Text);
            cmd.Parameters.AddWithValue("@Password", TBpass.Text);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            sqlcon.Close();

            if (count > 0)
            {
                MessageBox.Show("Login Successful!");
                Items form = new Items();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password!");
            }
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
