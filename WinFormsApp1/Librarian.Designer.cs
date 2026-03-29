namespace WinFormsApp1
{
    partial class Librarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Librarian));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtStudentID = new TextBox();
            btnReturn = new Custom_Buttons();
            btnVerifyBorrow = new Custom_Buttons();
            label3 = new Label();
            txtBookID = new TextBox();
            label1 = new Label();
            lblid = new Label();
            txtStudentName = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvBooks = new DataGridView();
            panel4 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1347, 69);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(300, 9);
            label2.Name = "label2";
            label2.Size = new Size(627, 50);
            label2.TabIndex = 5;
            label2.Text = "Library Borrowing System";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(199, 68);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(300, 31);
            txtStudentID.TabIndex = 37;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.MediumSlateBlue;
            btnReturn.BackgroundImage = (Image)resources.GetObject("btnReturn.BackgroundImage");
            btnReturn.BackgroundImageLayout = ImageLayout.Stretch;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(328, 223);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(159, 46);
            btnReturn.TabIndex = 36;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnVerifyBorrow
            // 
            btnVerifyBorrow.BackColor = Color.MediumSlateBlue;
            btnVerifyBorrow.BackgroundImage = (Image)resources.GetObject("btnVerifyBorrow.BackgroundImage");
            btnVerifyBorrow.BackgroundImageLayout = ImageLayout.Stretch;
            btnVerifyBorrow.FlatAppearance.BorderSize = 0;
            btnVerifyBorrow.FlatStyle = FlatStyle.Flat;
            btnVerifyBorrow.ForeColor = Color.White;
            btnVerifyBorrow.Location = new Point(145, 223);
            btnVerifyBorrow.Name = "btnVerifyBorrow";
            btnVerifyBorrow.Size = new Size(163, 46);
            btnVerifyBorrow.TabIndex = 35;
            btnVerifyBorrow.UseVisualStyleBackColor = false;
            btnVerifyBorrow.Click += btnVerifyBorrow_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(58, 150);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 32;
            label3.Text = "Book ID :";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(160, 151);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(339, 31);
            txtBookID.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(58, 108);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 30;
            label1.Text = "Student Name :";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.BackColor = Color.SeaShell;
            lblid.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblid.Location = new Point(58, 67);
            lblid.Name = "lblid";
            lblid.Size = new Size(135, 30);
            lblid.TabIndex = 29;
            lblid.Text = "Student ID :";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(237, 109);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(262, 31);
            txtStudentName.TabIndex = 28;
            txtStudentName.TextChanged += txtStudentName_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 345);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtStudentID);
            panel3.Controls.Add(txtBookID);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtStudentName);
            panel3.Controls.Add(btnReturn);
            panel3.Controls.Add(btnVerifyBorrow);
            panel3.Controls.Add(lblid);
            panel3.Location = new Point(18, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(549, 319);
            panel3.TabIndex = 7;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBooks.BackgroundColor = Color.Silver;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(20, 80);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.Size = new Size(636, 257);
            dgvBooks.TabIndex = 38;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(634, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(695, 437);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SeaShell;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dgvBooks);
            panel5.Location = new Point(13, 17);
            panel5.Name = "panel5";
            panel5.Size = new Size(670, 410);
            panel5.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SeaShell;
            label4.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(244, 38);
            label4.Name = "label4";
            label4.Size = new Size(196, 32);
            label4.TabIndex = 6;
            label4.Text = "Available Books";
            // 
            // Librarian
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 565);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Librarian";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librarian";
            Load += Librarian_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtStudentID;
        private Custom_Buttons btnReturn;
        private Custom_Buttons btnVerifyBorrow;
        private Label label3;
        private TextBox txtBookID;
        private Label label1;
        private Label lblid;
        private TextBox txtStudentName;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvBooks;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private PictureBox pictureBox1;
    }
}