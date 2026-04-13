namespace WinFormsApp1
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            dgvBooks = new DataGridView();
            rdoHistory = new RadioButton();
            rdoMostBorrowed = new RadioButton();
            lblTitle = new Label();
            rdoAvailable = new RadioButton();
            btnReport = new Custom_Buttons();
            panel4 = new Panel();
            panel5 = new Panel();
            btnExport = new Custom_Buttons();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 69);
            panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1012, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(928, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(235, 9);
            label2.Name = "label2";
            label2.Size = new Size(627, 50);
            label2.TabIndex = 5;
            label2.Text = "Library Borrowing System";
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBooks.BackgroundColor = Color.Silver;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(17, 67);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.Size = new Size(703, 225);
            dgvBooks.TabIndex = 10;
            // 
            // rdoHistory
            // 
            rdoHistory.AutoSize = true;
            rdoHistory.BackColor = Color.SeaShell;
            rdoHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoHistory.Location = new Point(101, 374);
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
            rdoMostBorrowed.Location = new Point(101, 412);
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
            lblTitle.BackColor = Color.SeaShell;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Green;
            lblTitle.Location = new Point(274, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 30);
            lblTitle.TabIndex = 18;
            // 
            // rdoAvailable
            // 
            rdoAvailable.AutoSize = true;
            rdoAvailable.BackColor = Color.SeaShell;
            rdoAvailable.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdoAvailable.Location = new Point(101, 336);
            rdoAvailable.Name = "rdoAvailable";
            rdoAvailable.Size = new Size(189, 32);
            rdoAvailable.TabIndex = 22;
            rdoAvailable.TabStop = true;
            rdoAvailable.Text = "Available Books";
            rdoAvailable.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.MediumSlateBlue;
            btnReport.BackgroundImage = (Image)resources.GetObject("btnReport.BackgroundImage");
            btnReport.BackgroundImageLayout = ImageLayout.Stretch;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(312, 353);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(202, 43);
            btnReport.TabIndex = 28;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(172, 137);
            panel4.Name = "panel4";
            panel4.Size = new Size(762, 511);
            panel4.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SeaShell;
            panel5.Controls.Add(btnExport);
            panel5.Controls.Add(lblTitle);
            panel5.Controls.Add(btnReport);
            panel5.Controls.Add(dgvBooks);
            panel5.Controls.Add(rdoAvailable);
            panel5.Controls.Add(rdoHistory);
            panel5.Controls.Add(rdoMostBorrowed);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(736, 488);
            panel5.TabIndex = 27;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.MediumSlateBlue;
            btnExport.BackgroundImage = (Image)resources.GetObject("btnExport.BackgroundImage");
            btnExport.BackgroundImageLayout = ImageLayout.Stretch;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(532, 435);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(201, 50);
            btnExport.TabIndex = 29;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // Admin_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1074, 729);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Borrowing System";
            Load += Admin_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
       
        private DataGridView dgvBooks;
        private RadioButton rdoHistory;
        private RadioButton rdoMostBorrowed;
        private Label lblTitle;
        private RadioButton rdoAvailable;
        private PictureBox pictureBox1;
        private Custom_Buttons btnReport;
        private Panel panel4;
        private Panel panel5;
        private Custom_Buttons btnExport;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}