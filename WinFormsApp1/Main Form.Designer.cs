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
            dgvReports = new DataGridView();
            rdoHistory = new RadioButton();
            rdoMostBorrowed = new RadioButton();
            lblStatus = new Label();
            btnReports = new Button();
            btnClear = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(221, 287);
            txtStudentID.Multiline = true;
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(244, 30);
            txtStudentID.TabIndex = 0;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(221, 340);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(244, 31);
            txtStudentName.TabIndex = 1;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblid.Location = new Point(55, 281);
            lblid.Name = "lblid";
            lblid.Size = new Size(135, 30);
            lblid.TabIndex = 2;
            lblid.Text = "Student ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(26, 339);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 3;
            label1.Text = "Student Name :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 92);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(488, 23);
            label2.Name = "label2";
            label2.Size = new Size(246, 50);
            label2.TabIndex = 5;
            label2.Text = "Main Form";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(221, 392);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(244, 31);
            txtBookID.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(84, 391);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 6;
            label3.Text = "Book ID :";
            // 
            // btnVerifyBorrow
            // 
            btnVerifyBorrow.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerifyBorrow.Location = new Point(205, 455);
            btnVerifyBorrow.Name = "btnVerifyBorrow";
            btnVerifyBorrow.Size = new Size(165, 40);
            btnVerifyBorrow.TabIndex = 7;
            btnVerifyBorrow.Text = "Verify Borrow";
            btnVerifyBorrow.UseVisualStyleBackColor = true;
            btnVerifyBorrow.Click += btnVerifyBorrow_Click;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReturn.Location = new Point(376, 455);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(89, 40);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.Silver;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(672, 234);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.Size = new Size(628, 277);
            dgvBooks.TabIndex = 10;
            // 
            // dgvReports
            // 
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReports.BackgroundColor = Color.Silver;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.GridColor = SystemColors.ScrollBar;
            dgvReports.Location = new Point(672, 517);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 62;
            dgvReports.Size = new Size(628, 297);
            dgvReports.TabIndex = 11;
            dgvReports.CellContentClick += dgvReports_CellContentClick;
            // 
            // rdoHistory
            // 
            rdoHistory.AutoSize = true;
            rdoHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoHistory.Location = new Point(465, 655);
            rdoHistory.Name = "rdoHistory";
            rdoHistory.Size = new Size(188, 32);
            rdoHistory.TabIndex = 12;
            rdoHistory.TabStop = true;
            rdoHistory.Text = " Borrow History";
            rdoHistory.UseVisualStyleBackColor = true;
            rdoHistory.CheckedChanged += rdoHistory_CheckedChanged;
            // 
            // rdoMostBorrowed
            // 
            rdoMostBorrowed.AutoSize = true;
            rdoMostBorrowed.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdoMostBorrowed.Location = new Point(473, 606);
            rdoMostBorrowed.Name = "rdoMostBorrowed";
            rdoMostBorrowed.Size = new Size(180, 32);
            rdoMostBorrowed.TabIndex = 13;
            rdoMostBorrowed.TabStop = true;
            rdoMostBorrowed.Text = "Most Borrowed";
            rdoMostBorrowed.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(189, 151);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 36);
            lblStatus.TabIndex = 15;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(513, 715);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(122, 38);
            btnReports.TabIndex = 16;
            btnReports.Text = "SHOW";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(498, 282);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(68, 40);
            btnClear.TabIndex = 17;
            btnClear.Text = "⌫ ";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(919, 193);
            label4.Name = "label4";
            label4.Size = new Size(163, 28);
            label4.TabIndex = 18;
            label4.Text = "Available Books";
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1312, 849);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(btnReports);
            Controls.Add(lblStatus);
            Controls.Add(rdoMostBorrowed);
            Controls.Add(rdoHistory);
            Controls.Add(dgvReports);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Form";
            Load += Main_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
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
        private DataGridView dgvReports;
        private RadioButton rdoHistory;
        private RadioButton rdoMostBorrowed;
        private Label lblStatus;
        private Button btnReports;
        private Button btnClear;
        private Label label4;
    }
}