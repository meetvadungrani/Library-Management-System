namespace LibraryManagement
{
    partial class returnbook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnbook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtEnrollmentNo = new System.Windows.Forms.TextBox();
            this.EnterEnrollmentNo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdenrollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdcontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookissuedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookreturndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new LibraryManagement.libraryDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.BookReturnDate = new System.Windows.Forms.Label();
            this.BookIssueDate = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.iRBooksTableAdapter = new LibraryManagement.libraryDataSetTableAdapters.IRBooksTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSearchStudent);
            this.panel1.Controls.Add(this.txtEnrollmentNo);
            this.panel1.Controls.Add(this.EnterEnrollmentNo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(26, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 556);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(211, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(37, 435);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 45);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.Location = new System.Drawing.Point(98, 308);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(180, 56);
            this.btnSearchStudent.TabIndex = 3;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtEnrollmentNo
            // 
            this.txtEnrollmentNo.AcceptsReturn = true;
            this.txtEnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollmentNo.Location = new System.Drawing.Point(57, 244);
            this.txtEnrollmentNo.Name = "txtEnrollmentNo";
            this.txtEnrollmentNo.Size = new System.Drawing.Size(255, 34);
            this.txtEnrollmentNo.TabIndex = 2;
            this.txtEnrollmentNo.TextChanged += new System.EventHandler(this.txtEnrollmentNo_TextChanged);
            // 
            // EnterEnrollmentNo
            // 
            this.EnterEnrollmentNo.AutoSize = true;
            this.EnterEnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterEnrollmentNo.Location = new System.Drawing.Point(93, 192);
            this.EnterEnrollmentNo.Name = "EnterEnrollmentNo";
            this.EnterEnrollmentNo.Size = new System.Drawing.Size(185, 25);
            this.EnterEnrollmentNo.TabIndex = 1;
            this.EnterEnrollmentNo.Text = "Enter Enrollment No";
            this.EnterEnrollmentNo.Click += new System.EventHandler(this.EnterEnrollmentNo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stdenrollDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.depDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.stdcontactDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.bookissuedateDataGridViewTextBoxColumn,
            this.bookreturndateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iRBooksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(417, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 556);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdenrollDataGridViewTextBoxColumn
            // 
            this.stdenrollDataGridViewTextBoxColumn.DataPropertyName = "std_enroll";
            this.stdenrollDataGridViewTextBoxColumn.HeaderText = "std_enroll";
            this.stdenrollDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdenrollDataGridViewTextBoxColumn.Name = "stdenrollDataGridViewTextBoxColumn";
            this.stdenrollDataGridViewTextBoxColumn.Width = 125;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "sname";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.Width = 125;
            // 
            // depDataGridViewTextBoxColumn
            // 
            this.depDataGridViewTextBoxColumn.DataPropertyName = "dep";
            this.depDataGridViewTextBoxColumn.HeaderText = "dep";
            this.depDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depDataGridViewTextBoxColumn.Name = "depDataGridViewTextBoxColumn";
            this.depDataGridViewTextBoxColumn.Width = 125;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdcontactDataGridViewTextBoxColumn
            // 
            this.stdcontactDataGridViewTextBoxColumn.DataPropertyName = "std_contact";
            this.stdcontactDataGridViewTextBoxColumn.HeaderText = "std_contact";
            this.stdcontactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdcontactDataGridViewTextBoxColumn.Name = "stdcontactDataGridViewTextBoxColumn";
            this.stdcontactDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "book_name";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "book_name";
            this.booknameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            this.booknameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookissuedateDataGridViewTextBoxColumn
            // 
            this.bookissuedateDataGridViewTextBoxColumn.DataPropertyName = "book_issue_date";
            this.bookissuedateDataGridViewTextBoxColumn.HeaderText = "book_issue_date";
            this.bookissuedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookissuedateDataGridViewTextBoxColumn.Name = "bookissuedateDataGridViewTextBoxColumn";
            this.bookissuedateDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookreturndateDataGridViewTextBoxColumn
            // 
            this.bookreturndateDataGridViewTextBoxColumn.DataPropertyName = "book_return_date";
            this.bookreturndateDataGridViewTextBoxColumn.HeaderText = "book_return_date";
            this.bookreturndateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookreturndateDataGridViewTextBoxColumn.Name = "bookreturndateDataGridViewTextBoxColumn";
            this.bookreturndateDataGridViewTextBoxColumn.Width = 125;
            // 
            // iRBooksBindingSource
            // 
            this.iRBooksBindingSource.DataMember = "IRBooks";
            this.iRBooksBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txtIssueDate);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.BookReturnDate);
            this.panel2.Controls.Add(this.BookIssueDate);
            this.panel2.Controls.Add(this.BookName);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(669, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 243);
            this.panel2.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(549, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Location = new System.Drawing.Point(549, 111);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(119, 32);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 30);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIssueDate.Location = new System.Drawing.Point(245, 110);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(261, 30);
            this.txtIssueDate.TabIndex = 4;
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.Location = new System.Drawing.Point(245, 51);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(261, 30);
            this.txtBookName.TabIndex = 3;
            // 
            // BookReturnDate
            // 
            this.BookReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookReturnDate.AutoSize = true;
            this.BookReturnDate.Location = new System.Drawing.Point(33, 179);
            this.BookReturnDate.Name = "BookReturnDate";
            this.BookReturnDate.Size = new System.Drawing.Size(155, 25);
            this.BookReturnDate.TabIndex = 2;
            this.BookReturnDate.Text = "Book return date";
            // 
            // BookIssueDate
            // 
            this.BookIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookIssueDate.AutoSize = true;
            this.BookIssueDate.Location = new System.Drawing.Point(33, 115);
            this.BookIssueDate.Name = "BookIssueDate";
            this.BookIssueDate.Size = new System.Drawing.Size(155, 25);
            this.BookIssueDate.TabIndex = 1;
            this.BookIssueDate.Text = "Book Issue Date";
            // 
            // BookName
            // 
            this.BookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(33, 51);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(114, 25);
            this.BookName.TabIndex = 0;
            this.BookName.Text = "Book Name";
            // 
            // iRBooksTableAdapter
            // 
            this.iRBooksTableAdapter.ClearBeforeFill = true;
            // 
            // returnbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1465, 810);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "returnbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "returnbook";
            this.Load += new System.EventHandler(this.returnbook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtEnrollmentNo;
        private System.Windows.Forms.Label EnterEnrollmentNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label BookReturnDate;
        private System.Windows.Forms.Label BookIssueDate;
        private System.Windows.Forms.Label BookName;
        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource iRBooksBindingSource;
        private libraryDataSetTableAdapters.IRBooksTableAdapter iRBooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdenrollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdcontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookissuedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookreturndateDataGridViewTextBoxColumn;
    }
}