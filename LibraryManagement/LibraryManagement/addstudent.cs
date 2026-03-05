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
    public partial class addstudent : Form
    {
        public addstudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtstudent.Clear();
            txtEnrollment.Clear();
            txtDept.Clear();
            txtsem.Clear();
            txtcontact.Clear();
            txtemail.Clear();

            txtemail.Text = " ";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtstudent.Text != "" && txtEnrollment.Text != "" && txtDept.Text != "" && txtsem.Text != "" && txtcontact.Text != "" && txtemail.Text != "")
            {
                // Gather user input
                String sname = txtstudent.Text;
                String enroll = txtEnrollment.Text;
                String dept = txtDept.Text;
                String sem = txtsem.Text;
                String contact = txtcontact.Text; // Store as string first for validation
                String email = txtemail.Text;

                // Validate mobile number (must be exactly 10 digits)
                if (contact.Length != 10 || !contact.All(char.IsDigit))
                {
                    MessageBox.Show("Mobile number must be exactly 10 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Int64 mobile = Int64.Parse(contact); // Parse to Int64 after validation

                // Initialize connection and command
                using (SqlConnection con = new SqlConnection("data source = LAPTOP-J31R6KLM\\SQLEXPRESS; database=library; integrated security=True"))
                {
                    con.Open();

                    // Check if the enrollment number already exists
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM NewStudent WHERE enroll = @enroll", con))
                    {
                        checkCmd.Parameters.AddWithValue("@enroll", enroll);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Enrollment number already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // If not, proceed with the insert
                    using (SqlCommand insertCmd = new SqlCommand("INSERT INTO NewStudent (sname, enroll, dep, sem, contact, email) VALUES (@sname, @enroll, @dep, @sem, @contact, @email)", con))
                    {
                        insertCmd.Parameters.AddWithValue("@sname", sname);
                        insertCmd.Parameters.AddWithValue("@enroll", enroll);
                        insertCmd.Parameters.AddWithValue("@dep", dept);
                        insertCmd.Parameters.AddWithValue("@sem", sem);
                        insertCmd.Parameters.AddWithValue("@contact", mobile);
                        insertCmd.Parameters.AddWithValue("@email", email);
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addstudent_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
