using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private async void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Validate password length
                if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if username already exists
                if (await UsernameExists(username))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Username doesn't exist and password is valid, proceed with registration
                using (SqlConnection con = new SqlConnection(@"Server=LAPTOP-J31R6KLM\SQLEXPRESS;Database=librarymanagement;Integrated Security=True;"))
                {
                    string query = "INSERT INTO logintable (username, password) VALUES (@username, @password)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close signup form after successful registration
                    Form1 loginPage = new Form1();
                    loginPage.Show();
                }
            }
            else
            {
                MessageBox.Show("Empty Fields NOT ALLOWED", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task<bool> UsernameExists(string username)
        {
            using (SqlConnection con = new SqlConnection(@"Server=LAPTOP-J31R6KLM\SQLEXPRESS;Database=librarymanagement;Integrated Security=True;"))
            {
                string query = "SELECT COUNT(*) FROM logintable WHERE username = @username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    con.Open();
                    int count = (int)await cmd.ExecuteScalarAsync();
                    con.Close();
                    return count > 0;
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loginPage = new Form1();
            loginPage.Show();
        }
    }
}
