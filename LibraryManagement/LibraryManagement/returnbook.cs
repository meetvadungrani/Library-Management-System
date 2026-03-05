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
    public partial class returnbook : Form
    {
        public returnbook()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollmentNo.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-J31R6KLM\\SQLEXPRESS; database = library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            // *** Use parameterized query ***
            cmd.CommandText = "Select * from IRBooks where std_enroll = @enrollmentNo and book_return_date IS NULL"; // Replace std_enroll with the actual column name
            cmd.Parameters.AddWithValue("@enrollmentNo", txtEnrollmentNo.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds); // No need for the _

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollmentNo.Text != "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void EnterEnrollmentNo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void returnbook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.IRBooks' table. You can move, or remove it, as needed.
            this.iRBooksTableAdapter.Fill(this.libraryDataSet.IRBooks);
            panel2.Visible = false;
            txtEnrollmentNo.Clear();
        }
        String bname;
        String bdate;
        Int64 rowid;
        private void btnReturn_Click(object sender, EventArgs e)
        {
            {
                string connectionString = "data source = LAPTOP-J31R6KLM\\SQLEXPRESS;database = library; integrated security=True"; // Store connection string

                using (SqlConnection con = new SqlConnection(connectionString)) // Only declare 'con' ONCE, inside the using
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "update IRBooks set book_return_date = @returnDate where [std_enroll] = @enroll and id = @rowId";

                    con.Open();

                    cmd.Parameters.Add("@returnDate", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                    cmd.Parameters.Add("@enroll", SqlDbType.VarChar).Value = txtEnrollmentNo.Text; // Match the parameter name with the SQL query
                    cmd.Parameters.Add("@rowId", SqlDbType.Int).Value = rowid;

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Return Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        returnbook_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("Error: Could not return book. Please check the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }// The 'using' statement ensures the connection is closed
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBookName.Text = bname;
            txtIssueDate.Text = bdate;
        }
    }
}

