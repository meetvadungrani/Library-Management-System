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
    public partial class addbook : Form
    {
        public addbook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbookname.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                using (SqlConnection con = new SqlConnection(@"Server=LAPTOP-J31R6KLM\SQLEXPRESS;Database=library;Integrated Security=True;"))
                {
                    string bName = txtbookname.Text;
                    string bAuthor = txtAuthor.Text;
                    string bPul = txtPublication.Text;
                    string bDate = dateTimePicker1.Text;
                    Int64 price = Int64.Parse(txtPrice.Text);
                    Int64 quantity = Int64.Parse(txtQuantity.Text);

                    string query = "INSERT INTO NewBook (bName, bAuthor, bPul, bDate, bPrice, bQuan) VALUES (@bName, @bAuthor, @bPul, @bDate, @bPrice, @bQuan)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bName", bName);
                        cmd.Parameters.AddWithValue("@bAuthor", bAuthor);
                        cmd.Parameters.AddWithValue("@bPul", bPul);
                        cmd.Parameters.AddWithValue("@bDate", bDate);
                        cmd.Parameters.AddWithValue("@bPrice", price);
                        cmd.Parameters.AddWithValue("@bQuan", quantity);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear all text boxes and reset controls
                    txtbookname.Text = "";
                    txtAuthor.Text = "";
                    txtPublication.Text = "";
                    txtPrice.Text = "";
                    txtQuantity.Text = "";
                    dateTimePicker1.Value = DateTime.Now; // Reset the date picker to the current date
                }
            }
            else
            {
                MessageBox.Show("Empty Fields NOT ALLOWED", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your UNSAVED DATA", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addbook_Load(object sender, EventArgs e)
        {

        }
    }
}
