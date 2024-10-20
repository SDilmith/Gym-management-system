namespace FitForgeGym
{
    partial class frmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            pictureBox1 = new PictureBox();
            bttnlogin = new Button();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            label1 = new Label();
            bttnexit = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(850, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 156);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // bttnlogin
            // 
            bttnlogin.BackColor = Color.PaleGreen;
            bttnlogin.FlatStyle = FlatStyle.Flat;
            bttnlogin.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnlogin.ForeColor = Color.FromArgb(0, 0, 64);
            bttnlogin.Location = new Point(833, 578);
            bttnlogin.Name = "bttnlogin";
            bttnlogin.Size = new Size(254, 41);
            bttnlogin.TabIndex = 7;
            bttnlogin.Text = "Login";
            bttnlogin.UseVisualStyleBackColor = false;
            bttnlogin.Click += bttnlogin_Click;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Calisto MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(833, 458);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(240, 28);
            txtpassword.TabIndex = 5;
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.KeyDown += txtpassword_KeyDown;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Calisto MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(833, 365);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Username";
            txtusername.Size = new Size(240, 28);
            txtusername.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(793, 217);
            label1.Name = "label1";
            label1.Size = new Size(340, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Fit_Forge!";
            // 
            // bttnexit
            // 
            bttnexit.BackgroundImage = (Image)resources.GetObject("bttnexit.BackgroundImage");
            bttnexit.BackgroundImageLayout = ImageLayout.Stretch;
            bttnexit.Location = new Point(1163, 2);
            bttnexit.Name = "bttnexit";
            bttnexit.Size = new Size(39, 38);
            bttnexit.TabIndex = 9;
            bttnexit.UseVisualStyleBackColor = true;
            bttnexit.Click += bttnexit_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 703);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(779, 327);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 11;
            label2.Text = "Username\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(779, 420);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 690);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(bttnexit);
            Controls.Add(bttnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmlogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Button bttnlogin;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Button bttnexit;
        private Panel panel1;
        private Label label2;
        private Label label3;
    }
}
