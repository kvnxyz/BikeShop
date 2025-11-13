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
            MySqlConnection sqlcon = new MySqlConnection("");
            sqlcon.Open();

            string query = "SELECT * FROM accounts WHERE Email=@Email AND Password=@Password";
            MySqlCommand cmd = new MySqlCommand(query, sqlcon);

            cmd.Parameters.AddWithValue("@Email", TBuser.Text);
            cmd.Parameters.AddWithValue("@Password", TBpass.Text);

            int count = (int)cmd.ExecuteScalar();
            sqlcon.Close();

            if (count > 0)
            {
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Invalid email or password!");
            }
        }
    }
}
