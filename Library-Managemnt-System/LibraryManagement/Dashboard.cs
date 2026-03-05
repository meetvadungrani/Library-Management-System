using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void vIEWBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewbook vb = new viewbook();
            vb.Show();
        }

        private void aDDNEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbook ab = new addbook();
            ab.Show();
        }

        private void iSSUEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issuebooks ib = new issuebooks();
            ib.Show();
        }

        private void rETURNBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnbook rb = new returnbook();
            rb.Show();
        }

        private void aDDBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addstudent ads = new addstudent();
            ads.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void xITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void cOMPLETEBOOKDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            completebookdetails cb = new completebookdetails();
            cb.Show();
        }
    }
}
