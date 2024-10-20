namespace FitForgeGym
{
    partial class frmappoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmappoi));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtappoi = new TextBox();
            cmbmem = new ComboBox();
            cmbtrainer = new ComboBox();
            dtpappo = new DateTimePicker();
            cmbtime = new ComboBox();
            dgvappoi = new DataGridView();
            bttnadd = new Button();
            bttnupdate = new Button();
            bttncan = new Button();
            bttnaddmem = new Button();
            txtsearch = new TextBox();
            bttnsearch = new Button();
            bttnref = new Button();
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            bttnlogout = new Button();
            bttnpayments = new Button();
            bttnequip = new Button();
            bttnactive = new Button();
            bttntrainer = new Button();
            bttnmember = new Button();
            panel2 = new Panel();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            bttnback = new Button();
            bttnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvappoi).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.8F);
            label1.Location = new Point(346, 141);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 8;
            label1.Text = "Member Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F);
            label2.Location = new Point(351, 180);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 9;
            label2.Text = "Trainer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F);
            label3.Location = new Point(350, 222);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 10;
            label3.Text = "Appointment ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.8F);
            label5.Location = new Point(752, 145);
            label5.Name = "label5";
            label5.Size = new Size(128, 21);
            label5.TabIndex = 12;
            label5.Text = "Time Schedule";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.8F);
            label6.Location = new Point(351, 271);
            label6.Name = "label6";
            label6.Size = new Size(47, 21);
            label6.TabIndex = 13;
            label6.Text = "Date";
            // 
            // txtappoi
            // 
            txtappoi.Font = new Font("Georgia", 10.8F);
            txtappoi.Location = new Point(518, 217);
            txtappoi.Name = "txtappoi";
            txtappoi.Size = new Size(197, 28);
            txtappoi.TabIndex = 15;
            // 
            // cmbmem
            // 
            cmbmem.Font = new Font("Georgia", 10.8F);
            cmbmem.FormattingEnabled = true;
            cmbmem.Location = new Point(518, 133);
            cmbmem.Name = "cmbmem";
            cmbmem.Size = new Size(184, 29);
            cmbmem.TabIndex = 16;
            cmbmem.SelectedIndexChanged += cmbmem_SelectedIndexChanged;
            // 
            // cmbtrainer
            // 
            cmbtrainer.Font = new Font("Georgia", 10.8F);
            cmbtrainer.FormattingEnabled = true;
            cmbtrainer.Location = new Point(518, 177);
            cmbtrainer.Name = "cmbtrainer";
            cmbtrainer.Size = new Size(184, 29);
            cmbtrainer.TabIndex = 17;
            cmbtrainer.SelectedIndexChanged += cmbtrainer_SelectedIndexChanged;
            // 
            // dtpappo
            // 
            dtpappo.Font = new Font("Georgia", 10.8F);
            dtpappo.Location = new Point(484, 266);
            dtpappo.Name = "dtpappo";
            dtpappo.Size = new Size(311, 28);
            dtpappo.TabIndex = 18;
            // 
            // cmbtime
            // 
            cmbtime.Font = new Font("Georgia", 10.8F);
            cmbtime.FormattingEnabled = true;
            cmbtime.Items.AddRange(new object[] { "5:00 AM – 7:00 AM\t", "7:00 AM – 9:00 AM", "9:00 AM – 11:00 AM", "11:00 AM – 1:00 PM", "1:00 PM – 3:00 PM", "3:00 PM – 5:00 PM", "5:00 PM – 7:00 PM\t", "7:00 PM – 9:00 PM\t", "9:00 PM – 11:00 PM" });
            cmbtime.Location = new Point(896, 140);
            cmbtime.Name = "cmbtime";
            cmbtime.Size = new Size(217, 29);
            cmbtime.TabIndex = 19;
            // 
            // dgvappoi
            // 
            dgvappoi.BackgroundColor = Color.Silver;
            dgvappoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvappoi.Location = new Point(341, 401);
            dgvappoi.Name = "dgvappoi";
            dgvappoi.RowHeadersWidth = 51;
            dgvappoi.Size = new Size(702, 210);
            dgvappoi.TabIndex = 20;
            dgvappoi.CellContentClick += dgvappoi_CellContentClick;
            // 
            // bttnadd
            // 
            bttnadd.BackgroundImage = (Image)resources.GetObject("bttnadd.BackgroundImage");
            bttnadd.BackgroundImageLayout = ImageLayout.Stretch;
            bttnadd.Location = new Point(737, 345);
            bttnadd.Name = "bttnadd";
            bttnadd.Size = new Size(95, 49);
            bttnadd.TabIndex = 21;
            bttnadd.UseVisualStyleBackColor = true;
            bttnadd.Click += bttnadd_Click;
            // 
            // bttnupdate
            // 
            bttnupdate.BackgroundImage = Properties.Resources.ADD__4_;
            bttnupdate.BackgroundImageLayout = ImageLayout.Stretch;
            bttnupdate.Location = new Point(854, 345);
            bttnupdate.Name = "bttnupdate";
            bttnupdate.Size = new Size(95, 49);
            bttnupdate.TabIndex = 22;
            bttnupdate.UseVisualStyleBackColor = true;
            bttnupdate.Click += bttnupdate_Click_1;
            // 
            // bttncan
            // 
            bttncan.BackgroundImage = Properties.Resources.ADD__6_;
            bttncan.BackgroundImageLayout = ImageLayout.Stretch;
            bttncan.Location = new Point(955, 345);
            bttncan.Name = "bttncan";
            bttncan.Size = new Size(95, 49);
            bttncan.TabIndex = 23;
            bttncan.UseVisualStyleBackColor = true;
            bttncan.Click += bttncan_Click;
            // 
            // bttnaddmem
            // 
            bttnaddmem.BackColor = Color.Lavender;
            bttnaddmem.BackgroundImage = Properties.Resources.icons8_add_member_24;
            bttnaddmem.BackgroundImageLayout = ImageLayout.Stretch;
            bttnaddmem.Location = new Point(1041, 11);
            bttnaddmem.Name = "bttnaddmem";
            bttnaddmem.Size = new Size(50, 50);
            bttnaddmem.TabIndex = 24;
            bttnaddmem.UseVisualStyleBackColor = false;
            bttnaddmem.Click += bttnaddmem_Click;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Georgia", 10.8F);
            txtsearch.Location = new Point(342, 359);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(207, 28);
            txtsearch.TabIndex = 25;
            // 
            // bttnsearch
            // 
            bttnsearch.BackColor = SystemColors.ActiveCaption;
            bttnsearch.BackgroundImage = Properties.Resources.icons8_search_128;
            bttnsearch.BackgroundImageLayout = ImageLayout.Stretch;
            bttnsearch.Location = new Point(555, 355);
            bttnsearch.Name = "bttnsearch";
            bttnsearch.Size = new Size(40, 40);
            bttnsearch.TabIndex = 26;
            bttnsearch.UseVisualStyleBackColor = false;
            // 
            // bttnref
            // 
            bttnref.BackColor = Color.Lavender;
            bttnref.BackgroundImage = Properties.Resources.icons8_refresh_50;
            bttnref.BackgroundImageLayout = ImageLayout.Stretch;
            bttnref.ForeColor = Color.FromArgb(192, 255, 255);
            bttnref.Location = new Point(609, 353);
            bttnref.Name = "bttnref";
            bttnref.Size = new Size(40, 40);
            bttnref.TabIndex = 27;
            bttnref.UseVisualStyleBackColor = false;
            bttnref.Click += bttnref_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(bttnlogout);
            panel1.Controls.Add(bttnpayments);
            panel1.Controls.Add(bttnequip);
            panel1.Controls.Add(bttnactive);
            panel1.Controls.Add(bttntrainer);
            panel1.Controls.Add(bttnmember);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 689);
            panel1.TabIndex = 28;
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
            // bttnlogout
            // 
            bttnlogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnlogout.BackColor = Color.FromArgb(255, 128, 128);
            bttnlogout.FlatStyle = FlatStyle.Popup;
            bttnlogout.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnlogout.Location = new Point(0, 581);
            bttnlogout.Name = "bttnlogout";
            bttnlogout.Size = new Size(213, 55);
            bttnlogout.TabIndex = 2;
            bttnlogout.Text = "Logout";
            bttnlogout.UseVisualStyleBackColor = false;
            bttnlogout.Click += bttnlogout_Click;
            // 
            // bttnpayments
            // 
            bttnpayments.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnpayments.FlatStyle = FlatStyle.Popup;
            bttnpayments.Font = new Font("Palatino Linotype", 9F);
            bttnpayments.Location = new Point(1, 348);
            bttnpayments.Name = "bttnpayments";
            bttnpayments.Size = new Size(213, 55);
            bttnpayments.TabIndex = 5;
            bttnpayments.Text = "Payments";
            bttnpayments.UseVisualStyleBackColor = true;
            bttnpayments.Click += bttnpayments_Click;
            // 
            // bttnequip
            // 
            bttnequip.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnequip.FlatStyle = FlatStyle.Popup;
            bttnequip.Font = new Font("Palatino Linotype", 9F);
            bttnequip.Location = new Point(1, 292);
            bttnequip.Name = "bttnequip";
            bttnequip.Size = new Size(213, 55);
            bttnequip.TabIndex = 4;
            bttnequip.Text = "Equipments";
            bttnequip.UseVisualStyleBackColor = true;
            bttnequip.Click += bttnequip_Click;
            // 
            // bttnactive
            // 
            bttnactive.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnactive.FlatStyle = FlatStyle.Popup;
            bttnactive.Font = new Font("Palatino Linotype", 9F);
            bttnactive.Location = new Point(0, 236);
            bttnactive.Name = "bttnactive";
            bttnactive.Size = new Size(213, 55);
            bttnactive.TabIndex = 3;
            bttnactive.Text = "Appointments";
            bttnactive.UseVisualStyleBackColor = true;
            bttnactive.Click += bttnactive_Click;
            // 
            // bttntrainer
            // 
            bttntrainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttntrainer.FlatStyle = FlatStyle.Popup;
            bttntrainer.Font = new Font("Palatino Linotype", 9F);
            bttntrainer.Location = new Point(0, 180);
            bttntrainer.Name = "bttntrainer";
            bttntrainer.Size = new Size(213, 55);
            bttntrainer.TabIndex = 2;
            bttntrainer.Text = "Trainer";
            bttntrainer.UseVisualStyleBackColor = true;
            bttntrainer.Click += bttntrainer_Click_1;
            // 
            // bttnmember
            // 
            bttnmember.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnmember.FlatStyle = FlatStyle.Popup;
            bttnmember.Font = new Font("Palatino Linotype", 9F);
            bttnmember.Location = new Point(0, 124);
            bttnmember.Name = "bttnmember";
            bttnmember.Size = new Size(213, 55);
            bttnmember.TabIndex = 1;
            bttnmember.Text = "Members";
            bttnmember.UseVisualStyleBackColor = true;
            bttnmember.Click += bttnmember_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(bttnaddmem);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1201, 76);
            panel2.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(460, 21);
            label7.Name = "label7";
            label7.Size = new Size(318, 36);
            label7.TabIndex = 2;
            label7.Text = "Fit_Forge Fitness";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(129, 21);
            label8.Name = "label8";
            label8.Size = new Size(99, 40);
            label8.TabIndex = 1;
            label8.Text = "User Admin\r\n*****";
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
            // bttnback
            // 
            bttnback.BackColor = SystemColors.ActiveCaption;
            bttnback.BackgroundImage = (Image)resources.GetObject("bttnback.BackgroundImage");
            bttnback.BackgroundImageLayout = ImageLayout.Center;
            bttnback.Location = new Point(-1, 10);
            bttnback.Name = "bttnback";
            bttnback.Size = new Size(50, 49);
            bttnback.TabIndex = 57;
            bttnback.UseVisualStyleBackColor = false;
            bttnback.Click += bttnback_Click;
            // 
            // bttnexit
            // 
            bttnexit.BackColor = SystemColors.ActiveCaption;
            bttnexit.BackgroundImage = (Image)resources.GetObject("bttnexit.BackgroundImage");
            bttnexit.BackgroundImageLayout = ImageLayout.Stretch;
            bttnexit.Location = new Point(1163, 2);
            bttnexit.Name = "bttnexit";
            bttnexit.Size = new Size(39, 38);
            bttnexit.TabIndex = 58;
            bttnexit.UseVisualStyleBackColor = false;
            bttnexit.Click += bttnexit_Click;
            // 
            // frmappoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1200, 690);
            Controls.Add(bttnexit);
            Controls.Add(bttnback);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(bttnref);
            Controls.Add(bttnsearch);
            Controls.Add(txtsearch);
            Controls.Add(bttncan);
            Controls.Add(bttnupdate);
            Controls.Add(bttnadd);
            Controls.Add(dgvappoi);
            Controls.Add(cmbtime);
            Controls.Add(dtpappo);
            Controls.Add(cmbtrainer);
            Controls.Add(cmbmem);
            Controls.Add(txtappoi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmappoi";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvappoi).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtappoi;
        private ComboBox cmbmem;
        private ComboBox cmbtrainer;
        private DateTimePicker dtpappo;
        private ComboBox cmbtime;
        private DataGridView dgvappoi;
        private Button bttnadd;
        private Button bttnupdate;
        private Button bttncan;
        private Button bttnaddmem;
        private TextBox txtsearch;
        private Button bttnsearch;
        private Button bttnref;
        private Panel panel1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button bttnlogout;
        private Button bttnpayments;
        private Button bttnequip;
        private Button bttnactive;
        private Button bttntrainer;
        private Button bttnmember;
        private Panel panel2;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Button bttnback;
        private Button bttnexit;
    }
}