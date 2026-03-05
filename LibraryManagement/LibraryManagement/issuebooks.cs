using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LibraryManagement
{
    public partial class issuebooks : Form
    {
        private int count;

        public issuebooks()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void issuebooks_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "data source = LAPTOP-J31R6KLM\\SQLEXPRESS; database=library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            Con.Open();

            cmd = new SqlCommand("select bname from NewBook", Con);

            SqlDataReader Sdr = cmd.ExecuteReader();
            while (Sdr.Read())
           {

                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            Con.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollment.Text == "")
            {
                txtName.Clear();
                txtDepartment.Clear();
                txtSemester.Clear();
                txtContact.Clear();
                txtEmail.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollment.Text != "")
            {
                String eid = txtEnrollment.Text;
                SqlConnection Con = new SqlConnection();
                Con.ConnectionString = "data source = LAPTOP-J31R6KLM\\SQLEXPRESS;database=library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;

                cmd.CommandText = "select * from NewStudent where enroll='" + eid + "' ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


                //------------------------------------
                //--code to count
                cmd.CommandText = "select count (std_enroll)  from IRBooks where std_enroll='" +eid+ "' and book_return_date is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

                //------------------------------------

                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDepartment.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSemester.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtDepartment.Clear();
                    txtSemester.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Invalid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (comboBoxBooks.SelectedIndex != -1 && count <= 2)
                {
                    String enroll = txtEnrollment.Text;
                    String sname = txtName.Text;
                    String dep = txtDepartment.Text;
                    String semester = txtSemester.Text;
                    String contact = txtContact.Text;
                    String email = txtEmail.Text;
                    String bookname = comboBoxBooks.Text;
                    String bookIssueDate = dateTimePicker.Text;

                    SqlConnection Con = new SqlConnection();
                    Con.ConnectionString = "data source = LAPTOP-J31R6KLM\\SQLEXPRESS; database=library; integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Con;

                    try
                    {
                        Con.Open();
                        cmd.CommandText = "insert into IRBooks (std_enroll, sname, dep, semester, std_contact, email, book_name, book_issue_date) values (@enroll, @sname, @dep, @semester, @contact, @email, @bookname, @bookIssueDate)";
                        cmd.Parameters.AddWithValue("@enroll", enroll);
                        cmd.Parameters.AddWithValue("@sname", sname);
                        cmd.Parameters.AddWithValue("@dep", dep);
                        cmd.Parameters.AddWithValue("@semester", semester);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@bookname", bookname);
                        cmd.Parameters.AddWithValue("@bookIssueDate", bookIssueDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Book not issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select Book. OR Maximum number of Book Has been ISSUED", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollment.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
