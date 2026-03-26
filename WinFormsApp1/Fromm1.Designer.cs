namespace WinFormsApp1
{
    partial class Fromm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fromm1));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 74);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(267, 19);
            label3.Name = "label3";
            label3.Size = new Size(216, 43);
            label3.TabIndex = 5;
            label3.Text = "SELECT ROLE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(454, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(218, 173);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(82, 185);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 3;
            label1.Text = "ADMIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(56, 191);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 4;
            label2.Text = "LIBRARIAN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(52, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 222);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Location = new Point(42, 137);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 239);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PeachPuff;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(443, 137);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 228);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Location = new Point(435, 128);
            panel5.Name = "panel5";
            panel5.Size = new Size(257, 248);
            panel5.TabIndex = 7;
            // 
            // Fromm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 393);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fromm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fromm1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}