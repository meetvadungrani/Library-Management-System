using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class viewstudent : Form
    {
        public viewstudent()
        {
            InitializeComponent();
        }

        private void viewstudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-J31R6KLM\\SQLEXPRESS; database=library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from New Student";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
        


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EnterenrollmentNo_TextChanged(object sender, EventArgs e)
        {

            if (txtEnterenrollmentNo.Text != "")
            {
                view.Visible = false;
                Image image = Image.FromFile("C:\\Users\\MEETVA\\OneDrive\\Pictures\\Liberay Management System Icon and Images\\Liberay Management System\\search1.gif");
                pictureBox1.Image = image;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = LAPTOP-J31R6KLM\\SQLEXPRESS; database=library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from New Student where enroll LIKE '" + txtEnterenrollmentNo.Text + "'%";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            else
            {
                view.Visible = true;
                Image image = Image.FromFile("C:\\Users\\MEETVA\\OneDrive\\Pictures\\Liberay Management System Icon and Images\\Liberay Management System\\search.gif");
                pictureBox1.Image = image;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sname = txtname.Text;
            string enroll = txtEnterenrollmentNo.Text;
            string dep = txtDepartment.Text;
            string sem = txtSemester.Text;
            string contact = txtContact.Text;
            string semail = txtEmail.Text;

            if (MessageBox.Show("Data will be updated. Confirm?", "Sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAPTOP-J31R6KLM\\SQLEXPRESS; database=library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set sname ='" + sname + "',enroll ='" + enroll + "',dep="+dep+"', sem='"+sem+"', contact='"+contact+"',email='"+semail+"' where stuid = "+rowid+"";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                viewstudent_Load(this, null);
            }

        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-J31R6KLM\\SQLEXPRESS; database=library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from New Student where id = " + bid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtname.Text = DS.Tables[0].Rows[0][1].ToString();
            txtEnterenrollmentNo.Text = DS.Tables[0].Rows[0][2].ToString();
            txtDepartment.Text = DS.Tables[0].Rows[0][3].ToString();
            txtSemester.Text = DS.Tables[0].Rows[0][4].ToString();
            txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
        }

        private void sdept_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

