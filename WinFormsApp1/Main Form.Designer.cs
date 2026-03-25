namespace WinFormsApp1
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            lblid = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtBookID = new TextBox();
            label3 = new Label();
            btnVerifyBorrow = new Button();
            btnReturn = new Button();
            dgvBooks = new DataGridView();
            rdoHistory = new RadioButton();
            rdoMostBorrowed = new RadioButton();
            lblTitle = new Label();
            btnReports = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            rdoAvailable = new RadioButton();
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(209, 256);
            txtStudentID.Multiline = true;
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(300, 30);
            txtStudentID.TabIndex = 0;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(247, 307);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(262, 31);
            txtStudentName.TabIndex = 1;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.BackColor = Color.SeaShell;
            lblid.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblid.Location = new Point(68, 255);
            lblid.Name = "lblid";
            lblid.Size = new Size(135, 30);
            lblid.TabIndex = 2;
            lblid.Text = "Student ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(68, 306);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 3;
            label1.Text = "Student Name :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1361, 69);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 9);
            label2.Name = "label2";
            label2.Size = new Size(627, 50);
            label2.TabIndex = 5;
            label2.Text = "Library Borrowing System";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(170, 349);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(339, 31);
            txtBookID.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(68, 348);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 6;
            label3.Text = "Book ID :";
            // 
            // btnVerifyBorrow
            // 
            btnVerifyBorrow.BackgroundImage = (Image)resources.GetObject("btnVerifyBorrow.BackgroundImage");
            btnVerifyBorrow.BackgroundImageLayout = ImageLayout.Stretch;
            btnVerifyBorrow.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerifyBorrow.Location = new Point(158, 398);
            btnVerifyBorrow.Name = "btnVerifyBorrow";
            btnVerifyBorrow.Size = new Size(185, 54);
            btnVerifyBorrow.TabIndex = 7;
            btnVerifyBorrow.UseVisualStyleBackColor = true;
            btnVerifyBorrow.Click += btnVerifyBorrow_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.BackgroundImage = (Image)resources.GetObject("btnReturn.BackgroundImage");
            btnReturn.BackgroundImageLayout = ImageLayout.Stretch;
            btnReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReturn.Location = new Point(365, 398);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(157, 56);
            btnReturn.TabIndex = 8;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBooks.BackgroundColor = Color.Silver;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(677, 178);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.Size = new Size(636, 290);
            dgvBooks.TabIndex = 10;
            // 
            // rdoHistory
            // 
            rdoHistory.AutoSize = true;
            rdoHistory.BackColor = Color.SeaShell;
            rdoHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoHistory.Location = new Point(734, 521);
            rdoHistory.Name = "rdoHistory";
            rdoHistory.Size = new Size(188, 32);
            rdoHistory.TabIndex = 12;
            rdoHistory.TabStop = true;
            rdoHistory.Text = " Borrow History";
            rdoHistory.UseVisualStyleBackColor = false;
            // 
            // rdoMostBorrowed
            // 
            rdoMostBorrowed.AutoSize = true;
            rdoMostBorrowed.BackColor = Color.SeaShell;
            rdoMostBorrowed.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdoMostBorrowed.Location = new Point(734, 559);
            rdoMostBorrowed.Name = "rdoMostBorrowed";
            rdoMostBorrowed.Size = new Size(180, 32);
            rdoMostBorrowed.TabIndex = 13;
            rdoMostBorrowed.TabStop = true;
            rdoMostBorrowed.Text = "Most Borrowed";
            rdoMostBorrowed.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(883, 122);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 30);
            lblTitle.TabIndex = 18;
            // 
            // btnReports
            // 
            btnReports.BackgroundImage = (Image)resources.GetObject("btnReports.BackgroundImage");
            btnReports.BackgroundImageLayout = ImageLayout.Stretch;
            btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReports.Location = new Point(986, 496);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 64);
            btnReports.TabIndex = 19;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(552, 384);
            dataGridView1.TabIndex = 20;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.SeaShell;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(656, 122);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(675, 480);
            dataGridView2.TabIndex = 21;
            // 
            // rdoAvailable
            // 
            rdoAvailable.AutoSize = true;
            rdoAvailable.BackColor = Color.SeaShell;
            rdoAvailable.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdoAvailable.Location = new Point(734, 483);
            rdoAvailable.Name = "rdoAvailable";
            rdoAvailable.Size = new Size(189, 32);
            rdoAvailable.TabIndex = 22;
            rdoAvailable.TabStop = true;
            rdoAvailable.Text = "Available Books";
            rdoAvailable.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.SteelBlue;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(39, 155);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(570, 409);
            dataGridView3.TabIndex = 23;
            // 
            // dataGridView4
            // 
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BackgroundColor = Color.SteelBlue;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(644, 110);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.Size = new Size(699, 506);
            dataGridView4.TabIndex = 24;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1361, 670);
            Controls.Add(rdoAvailable);
            Controls.Add(btnReports);
            Controls.Add(lblTitle);
            Controls.Add(rdoMostBorrowed);
            Controls.Add(rdoHistory);
            Controls.Add(dgvBooks);
            Controls.Add(btnReturn);
            Controls.Add(btnVerifyBorrow);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lblid);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Borrowing System";
            Load += Main_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private Label lblid;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txtBookID;
        private Label label3;
        private Button btnVerifyBorrow;
        private Button btnReturn;
        private DataGridView dgvBooks;
        private RadioButton rdoHistory;
        private RadioButton rdoMostBorrowed;
        private Label lblTitle;
        private Button btnReports;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private RadioButton rdoAvailable;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
    }
}