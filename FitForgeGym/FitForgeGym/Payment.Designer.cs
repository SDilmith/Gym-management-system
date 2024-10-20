namespace FitForgeGym
{
    partial class frmpay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpay));
            panel3 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel4 = new Panel();
            bttnback = new Button();
            label1 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            cmbmemid = new ComboBox();
            txtamount = new TextBox();
            dtpdate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvpay = new DataGridView();
            bttnref = new Button();
            txtsearch = new TextBox();
            bttnsearch = new Button();
            bttndel = new Button();
            bttnupdate = new Button();
            bttnadd = new Button();
            label5 = new Label();
            txtpayID = new TextBox();
            bttnexit = new Button();
            label6 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvpay).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Location = new Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 689);
            panel3.TabIndex = 48;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.Location = new Point(-2, 239);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(50, 50);
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.Location = new Point(0, 294);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 50);
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(0, 350);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.LightCoral;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Location = new Point(2, 583);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(-2, 183);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-2, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 581);
            button1.Name = "button1";
            button1.Size = new Size(213, 55);
            button1.TabIndex = 2;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Palatino Linotype", 9F);
            button2.Location = new Point(1, 348);
            button2.Name = "button2";
            button2.Size = new Size(213, 55);
            button2.TabIndex = 5;
            button2.Text = "Payments";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Palatino Linotype", 9F);
            button3.Location = new Point(1, 292);
            button3.Name = "button3";
            button3.Size = new Size(213, 55);
            button3.TabIndex = 4;
            button3.Text = "Equipments";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Palatino Linotype", 9F);
            button4.Location = new Point(0, 236);
            button4.Name = "button4";
            button4.Size = new Size(213, 55);
            button4.TabIndex = 3;
            button4.Text = "Appointments";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Palatino Linotype", 9F);
            button5.Location = new Point(0, 180);
            button5.Name = "button5";
            button5.Size = new Size(213, 55);
            button5.TabIndex = 2;
            button5.Text = "Trainer";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Palatino Linotype", 9F);
            button6.Location = new Point(0, 124);
            button6.Name = "button6";
            button6.Size = new Size(213, 55);
            button6.TabIndex = 1;
            button6.Text = "Members";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(bttnback);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1201, 76);
            panel4.TabIndex = 49;
            // 
            // bttnback
            // 
            bttnback.BackColor = SystemColors.ActiveCaption;
            bttnback.BackgroundImage = (Image)resources.GetObject("bttnback.BackgroundImage");
            bttnback.BackgroundImageLayout = ImageLayout.Center;
            bttnback.Location = new Point(-1, 10);
            bttnback.Name = "bttnback";
            bttnback.Size = new Size(50, 49);
            bttnback.TabIndex = 56;
            bttnback.UseVisualStyleBackColor = false;
            bttnback.Click += bttnback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(460, 21);
            label1.Name = "label1";
            label1.Size = new Size(318, 36);
            label1.TabIndex = 2;
            label1.Text = "Fit_Forge Fitness";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(129, 21);
            label9.Name = "label9";
            label9.Size = new Size(99, 40);
            label9.TabIndex = 1;
            label9.Text = "User Admin\r\n*****";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(58, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 59);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cmbmemid
            // 
            cmbmemid.Font = new Font("Georgia", 10.8F);
            cmbmemid.FormattingEnabled = true;
            cmbmemid.Location = new Point(384, 294);
            cmbmemid.Name = "cmbmemid";
            cmbmemid.Size = new Size(248, 29);
            cmbmemid.TabIndex = 50;
            // 
            // txtamount
            // 
            txtamount.Font = new Font("Georgia", 10.8F);
            txtamount.Location = new Point(384, 350);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(248, 28);
            txtamount.TabIndex = 51;
            // 
            // dtpdate
            // 
            dtpdate.Font = new Font("Georgia", 10.8F);
            dtpdate.Location = new Point(384, 408);
            dtpdate.Name = "dtpdate";
            dtpdate.Size = new Size(248, 28);
            dtpdate.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F);
            label2.Location = new Point(247, 294);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 53;
            label2.Text = "Member _ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F);
            label3.Location = new Point(247, 350);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 54;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.8F);
            label4.Location = new Point(247, 415);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 55;
            label4.Text = "Date";
            label4.Click += label4_Click;
            // 
            // dgvpay
            // 
            dgvpay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpay.Location = new Point(675, 196);
            dgvpay.Name = "dgvpay";
            dgvpay.RowHeadersWidth = 51;
            dgvpay.Size = new Size(513, 394);
            dgvpay.TabIndex = 56;
            dgvpay.CellContentClick += dgvpay_CellContentClick;
            // 
            // bttnref
            // 
            bttnref.BackColor = Color.Lavender;
            bttnref.BackgroundImage = (Image)resources.GetObject("bttnref.BackgroundImage");
            bttnref.BackgroundImageLayout = ImageLayout.Stretch;
            bttnref.Location = new Point(1102, 132);
            bttnref.Name = "bttnref";
            bttnref.Size = new Size(40, 40);
            bttnref.TabIndex = 62;
            bttnref.UseVisualStyleBackColor = false;
            bttnref.Click += bttnref_Click;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.Location = new Point(748, 140);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(269, 28);
            txtsearch.TabIndex = 61;
            // 
            // bttnsearch
            // 
            bttnsearch.BackColor = SystemColors.ActiveCaption;
            bttnsearch.BackgroundImage = (Image)resources.GetObject("bttnsearch.BackgroundImage");
            bttnsearch.BackgroundImageLayout = ImageLayout.Stretch;
            bttnsearch.Font = new Font("Palatino Linotype", 10.2F);
            bttnsearch.Location = new Point(1040, 132);
            bttnsearch.Name = "bttnsearch";
            bttnsearch.Size = new Size(40, 40);
            bttnsearch.TabIndex = 60;
            bttnsearch.UseVisualStyleBackColor = false;
            bttnsearch.Click += bttnsearch_Click;
            // 
            // bttndel
            // 
            bttndel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttndel.BackColor = Color.Firebrick;
            bttndel.BackgroundImage = (Image)resources.GetObject("bttndel.BackgroundImage");
            bttndel.BackgroundImageLayout = ImageLayout.Stretch;
            bttndel.Font = new Font("Palatino Linotype", 10.2F);
            bttndel.Location = new Point(543, 541);
            bttndel.Name = "bttndel";
            bttndel.Size = new Size(90, 49);
            bttndel.TabIndex = 59;
            bttndel.UseVisualStyleBackColor = false;
            bttndel.Click += bttndel_Click;
            // 
            // bttnupdate
            // 
            bttnupdate.BackgroundImage = (Image)resources.GetObject("bttnupdate.BackgroundImage");
            bttnupdate.BackgroundImageLayout = ImageLayout.Stretch;
            bttnupdate.Font = new Font("Palatino Linotype", 10.2F);
            bttnupdate.Location = new Point(410, 541);
            bttnupdate.Name = "bttnupdate";
            bttnupdate.Size = new Size(95, 49);
            bttnupdate.TabIndex = 58;
            bttnupdate.UseVisualStyleBackColor = true;
            bttnupdate.Click += bttnupdate_Click;
            // 
            // bttnadd
            // 
            bttnadd.BackgroundImage = (Image)resources.GetObject("bttnadd.BackgroundImage");
            bttnadd.BackgroundImageLayout = ImageLayout.Stretch;
            bttnadd.Font = new Font("Palatino Linotype", 10.2F);
            bttnadd.Location = new Point(283, 541);
            bttnadd.Name = "bttnadd";
            bttnadd.Size = new Size(95, 49);
            bttnadd.TabIndex = 57;
            bttnadd.UseVisualStyleBackColor = true;
            bttnadd.Click += bttnadd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.8F);
            label5.Location = new Point(247, 238);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 63;
            label5.Text = "Payment ID";
            // 
            // txtpayID
            // 
            txtpayID.Font = new Font("Georgia", 10.8F);
            txtpayID.Location = new Point(384, 238);
            txtpayID.Name = "txtpayID";
            txtpayID.Size = new Size(248, 28);
            txtpayID.TabIndex = 64;
            // 
            // bttnexit
            // 
            bttnexit.BackColor = SystemColors.ActiveCaption;
            bttnexit.BackgroundImage = (Image)resources.GetObject("bttnexit.BackgroundImage");
            bttnexit.BackgroundImageLayout = ImageLayout.Stretch;
            bttnexit.Location = new Point(1163, 2);
            bttnexit.Name = "bttnexit";
            bttnexit.Size = new Size(39, 38);
            bttnexit.TabIndex = 65;
            bttnexit.UseVisualStyleBackColor = false;
            bttnexit.Click += bttnexit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(384, 140);
            label6.Name = "label6";
            label6.Size = new Size(155, 32);
            label6.TabIndex = 66;
            label6.Text = "Payments";
            // 
            // frmpay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1200, 690);
            Controls.Add(label6);
            Controls.Add(bttnexit);
            Controls.Add(txtpayID);
            Controls.Add(label5);
            Controls.Add(bttnref);
            Controls.Add(txtsearch);
            Controls.Add(bttnsearch);
            Controls.Add(bttndel);
            Controls.Add(bttnupdate);
            Controls.Add(bttnadd);
            Controls.Add(dgvpay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpdate);
            Controls.Add(txtamount);
            Controls.Add(cmbmemid);
            Controls.Add(panel4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmpay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmpay_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvpay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel4;
        private Label label1;
        private Label label9;
        private PictureBox pictureBox1;
        private ComboBox cmbmemid;
        private TextBox txtamount;
        private DateTimePicker dtpdate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bttnback;
        private DataGridView dgvpay;
        private Button bttnref;
        private TextBox txtsearch;
        private Button bttnsearch;
        private Button bttndel;
        private Button bttnupdate;
        private Button bttnadd;
        private Label label5;
        private TextBox txtpayID;
        private Button bttnexit;
        private Label label6;
    }
}