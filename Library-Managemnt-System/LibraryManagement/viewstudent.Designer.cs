namespace LibraryManagement
{
    partial class viewstudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewstudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.view = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.txtEnrollmentNo = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.StuEmail = new System.Windows.Forms.Label();
            this.StudentCon = new System.Windows.Forms.Label();
            this.StudentSem = new System.Windows.Forms.Label();
            this.Dept = new System.Windows.Forms.Label();
            this.EnrollNo = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.txtEnterenrollmentNo = new System.Windows.Forms.TextBox();
            this.EnrollmentNo = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.view);
            this.panel1.Controls.Add(this.Student);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(7, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 168);
            this.panel1.TabIndex = 0;
            // 
            // view
            // 
            this.view.AutoSize = true;
            this.view.BackColor = System.Drawing.Color.Transparent;
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.view.Location = new System.Drawing.Point(596, 46);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(80, 32);
            this.view.TabIndex = 1;
            this.view.Text = "View";
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.Student.Location = new System.Drawing.Point(641, 78);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(120, 32);
            this.Student.TabIndex = 2;
            this.Student.Text = "Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 332);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btncancel);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtContact);
            this.panel2.Controls.Add(this.txtSemester);
            this.panel2.Controls.Add(this.txtEnrollmentNo);
            this.panel2.Controls.Add(this.txtDepartment);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.StuEmail);
            this.panel2.Controls.Add(this.StudentCon);
            this.panel2.Controls.Add(this.StudentSem);
            this.panel2.Controls.Add(this.Dept);
            this.panel2.Controls.Add(this.EnrollNo);
            this.panel2.Controls.Add(this.StudentName);
            this.panel2.Location = new System.Drawing.Point(8, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 304);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(945, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 38);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(702, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 38);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btncancel
            // 
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(824, 242);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(110, 38);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(819, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(819, 110);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(236, 22);
            this.txtContact.TabIndex = 12;
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(819, 53);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(236, 22);
            this.txtSemester.TabIndex = 11;
            // 
            // txtEnrollmentNo
            // 
            this.txtEnrollmentNo.Location = new System.Drawing.Point(309, 110);
            this.txtEnrollmentNo.Name = "txtEnrollmentNo";
            this.txtEnrollmentNo.Size = new System.Drawing.Size(260, 22);
            this.txtEnrollmentNo.TabIndex = 10;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(309, 170);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(260, 22);
            this.txtDepartment.TabIndex = 9;
            this.txtDepartment.TextChanged += new System.EventHandler(this.sdept_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(309, 53);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(260, 22);
            this.txtname.TabIndex = 8;
            // 
            // StuEmail
            // 
            this.StuEmail.AutoSize = true;
            this.StuEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuEmail.Location = new System.Drawing.Point(642, 170);
            this.StuEmail.Name = "StuEmail";
            this.StuEmail.Size = new System.Drawing.Size(138, 20);
            this.StuEmail.TabIndex = 7;
            this.StuEmail.Text = "Student Email :";
            // 
            // StudentCon
            // 
            this.StudentCon.AutoSize = true;
            this.StudentCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentCon.Location = new System.Drawing.Point(642, 112);
            this.StudentCon.Name = "StudentCon";
            this.StudentCon.Size = new System.Drawing.Size(156, 20);
            this.StudentCon.TabIndex = 6;
            this.StudentCon.Text = "Student Contact :";
            // 
            // StudentSem
            // 
            this.StudentSem.AutoSize = true;
            this.StudentSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSem.Location = new System.Drawing.Point(642, 56);
            this.StudentSem.Name = "StudentSem";
            this.StudentSem.Size = new System.Drawing.Size(171, 20);
            this.StudentSem.TabIndex = 5;
            this.StudentSem.Text = "Student Semester :";
            // 
            // Dept
            // 
            this.Dept.AutoSize = true;
            this.Dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dept.Location = new System.Drawing.Point(142, 170);
            this.Dept.Name = "Dept";
            this.Dept.Size = new System.Drawing.Size(119, 20);
            this.Dept.TabIndex = 4;
            this.Dept.Text = "Department :";
            // 
            // EnrollNo
            // 
            this.EnrollNo.AutoSize = true;
            this.EnrollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollNo.Location = new System.Drawing.Point(142, 116);
            this.EnrollNo.Name = "EnrollNo";
            this.EnrollNo.Size = new System.Drawing.Size(139, 20);
            this.EnrollNo.TabIndex = 3;
            this.EnrollNo.Text = "Enrollment No.:";
            this.EnrollNo.Click += new System.EventHandler(this.label3_Click);
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.Location = new System.Drawing.Point(142, 56);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(133, 20);
            this.StudentName.TabIndex = 2;
            this.StudentName.Text = "Student Name:";
            // 
            // txtEnterenrollmentNo
            // 
            this.txtEnterenrollmentNo.Location = new System.Drawing.Point(458, 202);
            this.txtEnterenrollmentNo.Name = "txtEnterenrollmentNo";
            this.txtEnterenrollmentNo.Size = new System.Drawing.Size(234, 22);
            this.txtEnterenrollmentNo.TabIndex = 3;
            this.txtEnterenrollmentNo.TextChanged += new System.EventHandler(this.EnterenrollmentNo_TextChanged);
            // 
            // EnrollmentNo
            // 
            this.EnrollmentNo.AutoSize = true;
            this.EnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentNo.ForeColor = System.Drawing.Color.Lavender;
            this.EnrollmentNo.Location = new System.Drawing.Point(296, 199);
            this.EnrollmentNo.Name = "EnrollmentNo";
            this.EnrollmentNo.Size = new System.Drawing.Size(147, 25);
            this.EnrollmentNo.TabIndex = 4;
            this.EnrollmentNo.Text = "Enrollment No";
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Lavender;
            this.btnrefresh.Location = new System.Drawing.Point(713, 193);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(130, 40);
            this.btnrefresh.TabIndex = 5;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.UseVisualStyleBackColor = true;
            // 
            // viewstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1249, 922);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.EnrollmentNo);
            this.Controls.Add(this.txtEnterenrollmentNo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "viewstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewstudent";
            this.Load += new System.EventHandler(this.viewstudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label view;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StuEmail;
        private System.Windows.Forms.Label StudentCon;
        private System.Windows.Forms.Label StudentSem;
        private System.Windows.Forms.Label Dept;
        private System.Windows.Forms.Label EnrollNo;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.TextBox txtEnrollmentNo;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEnterenrollmentNo;
        private System.Windows.Forms.Label EnrollmentNo;
        private System.Windows.Forms.Button btnrefresh;
    }
}