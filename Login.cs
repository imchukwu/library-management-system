using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace lms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Perform your authentication logic here
            if (IsValidLogin(username, password))
            {
                // If login is successful, switch to home screen
                Home homeForm = new Home();
                homeForm.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool IsValidLogin(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True;Encrypt=False"))
            {
                string query = "SELECT COUNT(*) FROM login WHERE username=@username AND password=@password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        int count = (int)cmd.ExecuteScalar();

                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during login: " + ex.Message);
                        return false;
                    }
                } 
            } 
        }


    }

}
