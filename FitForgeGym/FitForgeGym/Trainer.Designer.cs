namespace FitForgeGym
{
    partial class frmtrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtrainer));
            bttndelete = new Button();
            bttnupdate = new Button();
            bttnadd = new Button();
            bttnsearch = new Button();
            txtsearch = new TextBox();
            txtcon = new TextBox();
            txtage = new TextBox();
            txtname = new TextBox();
            txttrainerid = new TextBox();
            cmbspe = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvtrain = new DataGridView();
            bttnref = new Button();
            radmale = new RadioButton();
            radfemale = new RadioButton();
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
            ((System.ComponentModel.ISupportInitialize)dgvtrain).BeginInit();
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
            // bttndelete
            // 
            bttndelete.BackgroundImage = (Image)resources.GetObject("bttndelete.BackgroundImage");
            bttndelete.BackgroundImageLayout = ImageLayout.Stretch;
            bttndelete.Font = new Font("Palatino Linotype", 10.8F);
            bttndelete.Location = new Point(958, 274);
            bttndelete.Name = "bttndelete";
            bttndelete.Size = new Size(95, 49);
            bttndelete.TabIndex = 36;
            bttndelete.UseVisualStyleBackColor = true;
            bttndelete.Click += bttndelete_Click;
            // 
            // bttnupdate
            // 
            bttnupdate.BackgroundImage = (Image)resources.GetObject("bttnupdate.BackgroundImage");
            bttnupdate.BackgroundImageLayout = ImageLayout.Stretch;
            bttnupdate.Font = new Font("Palatino Linotype", 10.8F);
            bttnupdate.Location = new Point(857, 274);
            bttnupdate.Name = "bttnupdate";
            bttnupdate.Size = new Size(95, 49);
            bttnupdate.TabIndex = 35;
            bttnupdate.UseVisualStyleBackColor = true;
            bttnupdate.Click += bttnupdate_Click;
            // 
            // bttnadd
            // 
            bttnadd.BackgroundImage = (Image)resources.GetObject("bttnadd.BackgroundImage");
            bttnadd.BackgroundImageLayout = ImageLayout.Stretch;
            bttnadd.Font = new Font("Palatino Linotype", 10.8F);
            bttnadd.Location = new Point(756, 274);
            bttnadd.Name = "bttnadd";
            bttnadd.Size = new Size(95, 49);
            bttnadd.TabIndex = 34;
            bttnadd.UseVisualStyleBackColor = true;
            bttnadd.Click += bttnadd_Click;
            // 
            // bttnsearch
            // 
            bttnsearch.BackColor = SystemColors.ActiveCaption;
            bttnsearch.BackgroundImage = (Image)resources.GetObject("bttnsearch.BackgroundImage");
            bttnsearch.BackgroundImageLayout = ImageLayout.Stretch;
            bttnsearch.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnsearch.Location = new Point(600, 288);
            bttnsearch.Name = "bttnsearch";
            bttnsearch.Size = new Size(40, 40);
            bttnsearch.TabIndex = 33;
            bttnsearch.UseVisualStyleBackColor = false;
            bttnsearch.Click += bttnsearch_Click;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.Location = new Point(326, 295);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(245, 28);
            txtsearch.TabIndex = 32;
            // 
            // txtcon
            // 
            txtcon.Font = new Font("Georgia", 10.8F);
            txtcon.Location = new Point(863, 192);
            txtcon.Name = "txtcon";
            txtcon.Size = new Size(180, 28);
            txtcon.TabIndex = 31;
            // 
            // txtage
            // 
            txtage.Font = new Font("Georgia", 10.8F);
            txtage.Location = new Point(464, 193);
            txtage.Name = "txtage";
            txtage.Size = new Size(180, 28);
            txtage.TabIndex = 30;
            // 
            // txtname
            // 
            txtname.Font = new Font("Georgia", 10.8F);
            txtname.Location = new Point(464, 153);
            txtname.Name = "txtname";
            txtname.Size = new Size(180, 28);
            txtname.TabIndex = 29;
            // 
            // txttrainerid
            // 
            txttrainerid.Font = new Font("Georgia", 10.8F);
            txttrainerid.Location = new Point(464, 113);
            txttrainerid.Name = "txttrainerid";
            txttrainerid.Size = new Size(180, 28);
            txttrainerid.TabIndex = 28;
            // 
            // cmbspe
            // 
            cmbspe.Font = new Font("Georgia", 10.8F);
            cmbspe.FormattingEnabled = true;
            cmbspe.Items.AddRange(new object[] { "Yoga", "Weightlifting", "Cardio", "Athlete" });
            cmbspe.Location = new Point(863, 155);
            cmbspe.Name = "cmbspe";
            cmbspe.Size = new Size(180, 29);
            cmbspe.TabIndex = 27;
            cmbspe.SelectedIndexChanged += cmbspe_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.8F);
            label6.Location = new Point(725, 195);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 25;
            label6.Text = "Contact No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.8F);
            label5.Location = new Point(725, 155);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 24;
            label5.Text = "Specialization";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.8F);
            label4.Location = new Point(725, 120);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 23;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F);
            label3.Location = new Point(326, 193);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 22;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F);
            label2.Location = new Point(326, 155);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 21;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.8F);
            label1.Location = new Point(326, 116);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 20;
            label1.Text = "Trainer ID";
            // 
            // dgvtrain
            // 
            dgvtrain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtrain.Location = new Point(326, 329);
            dgvtrain.Name = "dgvtrain";
            dgvtrain.RowHeadersWidth = 51;
            dgvtrain.Size = new Size(791, 273);
            dgvtrain.TabIndex = 37;
            dgvtrain.CellContentClick += dgvtrain_CellContentClick;
            // 
            // bttnref
            // 
            bttnref.BackColor = Color.Lavender;
            bttnref.BackgroundImage = (Image)resources.GetObject("bttnref.BackgroundImage");
            bttnref.BackgroundImageLayout = ImageLayout.Stretch;
            bttnref.Font = new Font("Palatino Linotype", 10.8F);
            bttnref.Location = new Point(646, 287);
            bttnref.Name = "bttnref";
            bttnref.Size = new Size(40, 40);
            bttnref.TabIndex = 38;
            bttnref.UseVisualStyleBackColor = false;
            bttnref.Click += bttnref_Click;
            // 
            // radmale
            // 
            radmale.AutoSize = true;
            radmale.Font = new Font("Georgia", 10.8F);
            radmale.Location = new Point(863, 118);
            radmale.Name = "radmale";
            radmale.Size = new Size(71, 25);
            radmale.TabIndex = 39;
            radmale.TabStop = true;
            radmale.Text = "Male";
            radmale.UseVisualStyleBackColor = true;
            // 
            // radfemale
            // 
            radfemale.AutoSize = true;
            radfemale.Font = new Font("Georgia", 10.8F);
            radfemale.Location = new Point(964, 118);
            radfemale.Name = "radfemale";
            radfemale.Size = new Size(90, 25);
            radfemale.TabIndex = 40;
            radfemale.TabStop = true;
            radfemale.Text = "Female";
            radfemale.UseVisualStyleBackColor = true;
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
            panel1.TabIndex = 41;
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
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1201, 76);
            panel2.TabIndex = 42;
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
            // frmtrainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1200, 690);
            Controls.Add(bttnexit);
            Controls.Add(bttnback);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(radfemale);
            Controls.Add(radmale);
            Controls.Add(bttnref);
            Controls.Add(dgvtrain);
            Controls.Add(bttndelete);
            Controls.Add(bttnupdate);
            Controls.Add(bttnadd);
            Controls.Add(bttnsearch);
            Controls.Add(txtsearch);
            Controls.Add(txtcon);
            Controls.Add(txtage);
            Controls.Add(txtname);
            Controls.Add(txttrainerid);
            Controls.Add(cmbspe);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmtrainer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trainer";
            Load += frmtrainer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvtrain).EndInit();
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
        private Button bttndelete;
        private Button bttnupdate;
        private Button bttnadd;
        private Button bttnsearch;
        private TextBox txtsearch;
        private TextBox txtcon;
        private TextBox txtage;
        private TextBox txtname;
        private TextBox txttrainerid;
        private ComboBox cmbspe;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvtrain;
        private Button bttnref;
        private RadioButton radmale;
        private RadioButton radfemale;
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