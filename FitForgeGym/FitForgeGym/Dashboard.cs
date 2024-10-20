using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FitForgeGym
{
    public partial class frmdashboard : Form
    {


        public frmdashboard()
        {
            InitializeComponent();

        }





        private void bttnmember_Click(object sender, EventArgs e)
        {
            frmmem frmmem = new frmmem();
            this.Hide();
            frmmem.Show();

        }
        private void bttntrainer_Click(object sender, EventArgs e)
        {
            frmtrainer frmtrainer = new frmtrainer();
            this.Hide();
            frmtrainer.Show();
        }

        private void bttnactive_Click(object sender, EventArgs e)
        {
            frmappoi appointments = new frmappoi();
            this.Hide();
            appointments.Show();
        }

        private void bttnequip_Click(object sender, EventArgs e)
        {
            frmequip equipment = new frmequip();
            this.Hide();
            equipment.Show();
        }

        private void bttnpayments_Click(object sender, EventArgs e)
        {
            frmpay payments = new frmpay();
            this.Hide();
            payments.Show();
        }

        private void bttnlogout_Click(object sender, EventArgs e)
        {
            // Display a Yes/No confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // If user clicks 'Yes', go to the Login Form
            if (result == DialogResult.Yes)
            {
                this.Hide(); // Hide the current form (Dashboard)

                frmlogin loginForm = new frmlogin();
                loginForm.Show(); // Show the Login Form
            }
            // If 'No' is selected, do nothing and return to the Dashboard
        }

        private void bttnexit_Click(object sender, EventArgs e)
        {
            // Display a Yes/No confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to Close the form?",
                "Confirm close",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // If user clicks 'Yes', close the form
            if (result == DialogResult.Yes)
            {
                this.Close();


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmmem frmmem = new frmmem();
            this.Hide();
            frmmem.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmtrainer frmtrainer = new frmtrainer();
            this.Hide();
            frmtrainer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmappoi frmfrmappoi = new frmappoi();
            this.Hide();
            frmfrmappoi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmequip frm = new frmequip();
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmpay frm = new frmpay();
            this.Hide();
            frm.Show();
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;

            lblhours.Text = now.Hour.ToString("D2");    // 2-digit hour
            lblmins.Text = now.Minute.ToString("D2"); // 2-digit minute
            lblsec.Text = now.Second.ToString("D2"); // 2-digit second
        }

        private void lbltottrainer_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display a Yes/No confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // If user clicks 'Yes', go to the Login Form
            if (result == DialogResult.Yes)
            {
                this.Hide(); // Hide the current form 

                frmlogin loginForm = new frmlogin();
                loginForm.Show(); // Show the Login Form
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to Close the form?",
                "Confirm close",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // If user clicks 'Yes', close the form
            if (result == DialogResult.Yes)
            {
                this.Close();


            }
        }
    }









}
