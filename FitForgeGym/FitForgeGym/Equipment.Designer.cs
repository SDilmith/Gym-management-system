namespace FitForgeGym
{
    partial class frmequip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmequip));
            panel2 = new Panel();
            panel1 = new Panel();
            bttnlogout = new Button();
            bttnpayments = new Button();
            bttnequip = new Button();
            bttnactive = new Button();
            bttntrainer = new Button();
            bttnmember = new Button();
            bttnadd = new Button();
            Equipment_ID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtequipid = new TextBox();
            txtsupplier = new TextBox();
            txtprice = new TextBox();
            cmbequip = new ComboBox();
            cmbcon = new ComboBox();
            dtpdate = new DateTimePicker();
            dgvequipment = new DataGridView();
            bttnupdate = new Button();
            bttndel = new Button();
            bttnref = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            txtequipname = new TextBox();
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
            label1 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            nupquant = new NumericUpDown();
            bttnback = new Button();
            bttnexit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvequipment).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupquant).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1095, 54);
            panel2.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(bttnlogout);
            panel1.Controls.Add(bttnpayments);
            panel1.Controls.Add(bttnequip);
            panel1.Controls.Add(bttnactive);
            panel1.Controls.Add(bttntrainer);
            panel1.Controls.Add(bttnmember);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 580);
            panel1.TabIndex = 20;
            // 
            // bttnlogout
            // 
            bttnlogout.Location = new Point(0, 509);
            bttnlogout.Name = "bttnlogout";
            bttnlogout.Size = new Size(213, 55);
            bttnlogout.TabIndex = 2;
            bttnlogout.Text = "Logout";
            bttnlogout.UseVisualStyleBackColor = true;
            // 
            // bttnpayments
            // 
            bttnpayments.Font = new Font("Palatino Linotype", 9F);
            bttnpayments.Location = new Point(1, 346);
            bttnpayments.Name = "bttnpayments";
            bttnpayments.Size = new Size(213, 55);
            bttnpayments.TabIndex = 5;
            bttnpayments.Text = "Payments";
            bttnpayments.UseVisualStyleBackColor = true;
            // 
            // bttnequip
            // 
            bttnequip.Font = new Font("Palatino Linotype", 9F);
            bttnequip.Location = new Point(1, 291);
            bttnequip.Name = "bttnequip";
            bttnequip.Size = new Size(213, 55);
            bttnequip.TabIndex = 4;
            bttnequip.Text = "Equipments";
            bttnequip.UseVisualStyleBackColor = true;
            // 
            // bttnactive
            // 
            bttnactive.Font = new Font("Palatino Linotype", 9F);
            bttnactive.Location = new Point(0, 236);
            bttnactive.Name = "bttnactive";
            bttnactive.Size = new Size(213, 55);
            bttnactive.TabIndex = 3;
            bttnactive.Text = "Appointment";
            bttnactive.UseVisualStyleBackColor = true;
            // 
            // bttntrainer
            // 
            bttntrainer.Font = new Font("Palatino Linotype", 9F);
            bttntrainer.Location = new Point(0, 181);
            bttntrainer.Name = "bttntrainer";
            bttntrainer.Size = new Size(213, 55);
            bttntrainer.TabIndex = 2;
            bttntrainer.Text = "Trainer";
            bttntrainer.UseVisualStyleBackColor = true;
            // 
            // bttnmember
            // 
            bttnmember.Font = new Font("Palatino Linotype", 9F);
            bttnmember.Location = new Point(0, 126);
            bttnmember.Name = "bttnmember";
            bttnmember.Size = new Size(213, 55);
            bttnmember.TabIndex = 1;
            bttnmember.Text = "Members";
            bttnmember.UseVisualStyleBackColor = true;
            // 
            // bttnadd
            // 
            bttnadd.BackgroundImage = (Image)resources.GetObject("bttnadd.BackgroundImage");
            bttnadd.BackgroundImageLayout = ImageLayout.Stretch;
            bttnadd.Location = new Point(839, 375);
            bttnadd.Name = "bttnadd";
            bttnadd.Size = new Size(95, 49);
            bttnadd.TabIndex = 19;
            bttnadd.UseVisualStyleBackColor = true;
            bttnadd.Click += bttnadd_Click;
            // 
            // Equipment_ID
            // 
            Equipment_ID.AutoSize = true;
            Equipment_ID.Font = new Font("Georgia", 10.8F);
            Equipment_ID.Location = new Point(333, 135);
            Equipment_ID.Name = "Equipment_ID";
            Equipment_ID.Size = new Size(132, 21);
            Equipment_ID.TabIndex = 22;
            Equipment_ID.Text = "Equipment_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F);
            label2.Location = new Point(333, 172);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 23;
            label2.Text = "Equipment Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F);
            label3.Location = new Point(333, 208);
            label3.Name = "label3";
            label3.Size = new Size(152, 21);
            label3.TabIndex = 24;
            label3.Text = "Equipment Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.8F);
            label4.Location = new Point(333, 245);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 25;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.8F);
            label5.Location = new Point(734, 169);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 26;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.8F);
            label6.Location = new Point(734, 135);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 27;
            label6.Text = "Condition";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.8F);
            label7.Location = new Point(734, 204);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 28;
            label7.Text = "Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 10.8F);
            label8.Location = new Point(734, 241);
            label8.Name = "label8";
            label8.Size = new Size(129, 21);
            label8.TabIndex = 29;
            label8.Text = "Supplier Name";
            // 
            // txtequipid
            // 
            txtequipid.Font = new Font("Georgia", 10.8F);
            txtequipid.Location = new Point(484, 132);
            txtequipid.Name = "txtequipid";
            txtequipid.Size = new Size(170, 28);
            txtequipid.TabIndex = 30;
            // 
            // txtsupplier
            // 
            txtsupplier.Font = new Font("Georgia", 10.8F);
            txtsupplier.Location = new Point(872, 238);
            txtsupplier.Name = "txtsupplier";
            txtsupplier.Size = new Size(226, 28);
            txtsupplier.TabIndex = 32;
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Georgia", 10.8F);
            txtprice.Location = new Point(872, 166);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(226, 28);
            txtprice.TabIndex = 33;
            // 
            // cmbequip
            // 
            cmbequip.Font = new Font("Georgia", 10.8F);
            cmbequip.FormattingEnabled = true;
            cmbequip.Items.AddRange(new object[] { "Cardio Equipment", "Strength Training Equipment", "Flexibility / Straching Equipment", "Functional Training Equipment", "Weightlifting Equipment", "Accessories" });
            cmbequip.Location = new Point(484, 169);
            cmbequip.Name = "cmbequip";
            cmbequip.Size = new Size(170, 29);
            cmbequip.TabIndex = 34;
            cmbequip.SelectedIndexChanged += cmbequip_SelectedIndexChanged;
            // 
            // cmbcon
            // 
            cmbcon.Font = new Font("Georgia", 10.8F);
            cmbcon.FormattingEnabled = true;
            cmbcon.Items.AddRange(new object[] { "New", "Used", "Need Maintaince" });
            cmbcon.Location = new Point(872, 127);
            cmbcon.Name = "cmbcon";
            cmbcon.Size = new Size(226, 29);
            cmbcon.TabIndex = 35;
            // 
            // dtpdate
            // 
            dtpdate.Font = new Font("Georgia", 10.8F);
            dtpdate.Location = new Point(872, 202);
            dtpdate.Name = "dtpdate";
            dtpdate.Size = new Size(226, 28);
            dtpdate.TabIndex = 36;
            // 
            // dgvequipment
            // 
            dgvequipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvequipment.Location = new Point(336, 430);
            dgvequipment.Name = "dgvequipment";
            dgvequipment.RowHeadersWidth = 51;
            dgvequipment.Size = new Size(800, 194);
            dgvequipment.TabIndex = 37;
            dgvequipment.CellClick += dgvequipment_CellClick;
            // 
            // bttnupdate
            // 
            bttnupdate.BackgroundImage = (Image)resources.GetObject("bttnupdate.BackgroundImage");
            bttnupdate.BackgroundImageLayout = ImageLayout.Stretch;
            bttnupdate.Location = new Point(940, 375);
            bttnupdate.Name = "bttnupdate";
            bttnupdate.Size = new Size(95, 49);
            bttnupdate.TabIndex = 38;
            bttnupdate.UseVisualStyleBackColor = true;
            bttnupdate.Click += bttnupdate_Click;
            // 
            // bttndel
            // 
            bttndel.BackgroundImage = (Image)resources.GetObject("bttndel.BackgroundImage");
            bttndel.BackgroundImageLayout = ImageLayout.Stretch;
            bttndel.Location = new Point(1041, 375);
            bttndel.Name = "bttndel";
            bttndel.Size = new Size(95, 49);
            bttndel.TabIndex = 39;
            bttndel.UseVisualStyleBackColor = true;
            bttndel.Click += bttndel_Click;
            // 
            // bttnref
            // 
            bttnref.BackgroundImage = (Image)resources.GetObject("bttnref.BackgroundImage");
            bttnref.BackgroundImageLayout = ImageLayout.Stretch;
            bttnref.Location = new Point(793, 379);
            bttnref.Name = "bttnref";
            bttnref.Size = new Size(40, 40);
            bttnref.TabIndex = 40;
            bttnref.UseVisualStyleBackColor = true;
            bttnref.Click += bttnref_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Georgia", 10.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Treadmil", "Elliptical Trainer", "Stationary Bike", "Rowing Machine", "Stair Climber" });
            comboBox1.Location = new Point(484, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 29);
            comboBox1.TabIndex = 41;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Georgia", 10.8F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Dumbbells", "Barbells", "Kettlebells", "Smith Machine", "Leg Press Machine", "Bench Press", "Cable Machine" });
            comboBox2.Location = new Point(484, 210);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 29);
            comboBox2.TabIndex = 42;
            comboBox2.Visible = false;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Georgia", 10.8F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Yoga Mat", "Resistance Bands", "Stretching Machine", "Foam Roller" });
            comboBox3.Location = new Point(484, 210);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(170, 29);
            comboBox3.TabIndex = 43;
            comboBox3.Visible = false;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Georgia", 10.8F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Medicine Ball", "Battle Ropes", "Plyometric Box", "Suspension Trainer (TRX)" });
            comboBox4.Location = new Point(484, 210);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(170, 29);
            comboBox4.TabIndex = 44;
            comboBox4.Visible = false;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Georgia", 10.8F);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Weight Plates", "Squat Rack", "Olympic Barbell", "Power Rack" });
            comboBox5.Location = new Point(484, 210);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(170, 29);
            comboBox5.TabIndex = 45;
            comboBox5.Visible = false;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Georgia", 10.8F);
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Exercise Ball", "Step Platform", "Jump Rope", "Weight Lifting Belt", "Lifting Straps" });
            comboBox6.Location = new Point(484, 205);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(170, 29);
            comboBox6.TabIndex = 46;
            comboBox6.Visible = false;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // txtequipname
            // 
            txtequipname.Location = new Point(459, 584);
            txtequipname.Name = "txtequipname";
            txtequipname.Size = new Size(170, 27);
            txtequipname.TabIndex = 31;
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
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 689);
            panel3.TabIndex = 47;
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
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(1, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1201, 76);
            panel4.TabIndex = 48;
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
            // nupquant
            // 
            nupquant.Font = new Font("Georgia", 10.8F);
            nupquant.Location = new Point(484, 249);
            nupquant.Name = "nupquant";
            nupquant.Size = new Size(170, 28);
            nupquant.TabIndex = 49;
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
            // frmequip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1200, 690);
            Controls.Add(bttnexit);
            Controls.Add(bttnback);
            Controls.Add(nupquant);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(bttnref);
            Controls.Add(bttndel);
            Controls.Add(bttnupdate);
            Controls.Add(dgvequipment);
            Controls.Add(dtpdate);
            Controls.Add(cmbcon);
            Controls.Add(cmbequip);
            Controls.Add(txtprice);
            Controls.Add(txtsupplier);
            Controls.Add(txtequipname);
            Controls.Add(txtequipid);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Equipment_ID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(bttnadd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmequip";
            Text = "Equipment";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvequipment).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)nupquant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button bttnlogout;
        private Button bttnpayments;
        private Button bttnequip;
        private Button bttnactive;
        private Button bttntrainer;
        private Button bttnmember;
        private Button bttnadd;
        private Label Equipment_ID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtequipid;
        private TextBox txtsupplier;
        private TextBox txtprice;
        private ComboBox cmbequip;
        private ComboBox cmbcon;
        private DateTimePicker dtpdate;
        private DataGridView dgvequipment;
        private Button bttnupdate;
        private Button bttndel;
        private Button bttnref;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private TextBox txtequipname;
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
        private NumericUpDown nupquant;
        private Button bttnback;
        private Button bttnexit;
    }
}