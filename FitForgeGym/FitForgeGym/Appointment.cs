using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FitForgeGym
{
    public partial class frmappoi : Form
    {
        public frmappoi()
        {
            InitializeComponent();
            LoadComboBoxData();
            LoadComboBoxData1();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            Functions fnc = new Functions();
            string query = "select * from Appointments";
            DataSet ds = fnc.Show(query);

            dgvappoi.DataSource = ds.Tables[0];

        }


        int key;
        private void bttnadd_Click(object sender, EventArgs e)
        {
            if (txtappoi.Text == "")
            {
                key = 0;
            }
            else
            {
                key = 1;
            }
            if (key == 0)
            {
                MessageBox.Show("Values can't be empty");
            }
            else
            {



                DialogResult result = MessageBox.Show("Are you sure you want to confirm this appointment?", "Appointment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the result
                if (result == DialogResult.Yes)
                {
                    string query = "Insert into Appointments values('" + txtappoi.Text + "','" + cmbmem.SelectedItem.ToString() + "', '" + cmbtrainer.SelectedItem.ToString() + "','" + dtpappo.Value + "','" + cmbtime.SelectedItem.ToString() + "')";
                    Functions Mem = new Functions();
                    try
                    {
                        //Display a message once a Member registered
                        Mem.Add(query);
                        MessageBox.Show("Appointment Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                else
                {
                    // Code if the appointment is canceled
                    MessageBox.Show("Appointment canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            //Clear all the items after the message

            txtappoi.Clear();
            cmbmem.Items.Clear();
            cmbtime.Items.Clear();
            cmbtrainer.Items.Clear();
            dtpappo.Refresh();



        }

        private void dgvappoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvappoi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvappoi.CurrentRow.Selected = true;
                txtappoi.Text = dgvappoi.Rows[e.RowIndex].Cells["Appointment_ID"].FormattedValue.ToString();
                cmbmem.SelectedItem = dgvappoi.Rows[e.RowIndex].Cells["Member_Name"].FormattedValue.ToString();
                cmbtime.SelectedItem = dgvappoi.Rows[e.RowIndex].Cells["Time_Schedule"].FormattedValue.ToString();
                cmbtrainer.SelectedItem = dgvappoi.Rows[e.RowIndex].Cells["Trainer"].FormattedValue.ToString();

            }
        }

        private void bttnupdate_Click(object sender, EventArgs e)
        {
            Functions Mem = new Functions();
            if (key == 0)
            {
                MessageBox.Show("Select the Appointment Id");
            }
            else
            {
                try
                {
                    // Correct the ToString method call by adding parentheses
                    string query = "Update Appointments set Member_Name='" + cmbmem.SelectedItem.ToString() + "' Trainer='" + cmbtrainer.SelectedItem.ToString() + "',Appointment_Date='" + dtpappo.Value + "', Time_schedule='" + cmbtime.SelectedItem.ToString() + "', where Appointment_ID = '" + txtappoi.Text + "' ";

                    Mem.Update(query);

                    MessageBox.Show("Appointment successfully Updated");

                    RefreshData();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }
            }
        }





        private void LoadComboBoxData()
        {
            Connectionstring Myconnection = new Connectionstring();


            //SQL query to select data from table
            string query = "SELECT Name from Members";

            //Create a SQL connection
            using (SqlConnection Con = Myconnection.GetCon())
            {
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmbmem.Items.Clear();
                    while (reader.Read())
                    {
                        cmbmem.Items.Add(reader["Name"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message);
                }
            }

        }

        private void LoadComboBoxData1()
        {
            Connectionstring Myconnection = new Connectionstring();


            //SQL query to select data from table
            string query = "SELECT Name from Trainer";

            //Create a SQL connection
            using (SqlConnection Con = Myconnection.GetCon())
            {
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmbtrainer.Items.Clear();
                    while (reader.Read())
                    {
                        cmbtrainer.Items.Add(reader["Name"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message);
                }
            }

        }
        private void bttnref_Click(object sender, EventArgs e)
        {
            RefreshData();

            txtappoi.Clear();
            cmbmem.Items.Clear();
            cmbtime.Items.Clear();
            cmbtrainer.Items.Clear();
            dtpappo.Refresh();
        }

        private void cmbtrainer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnmember_Click(object sender, EventArgs e)
        {
            frmmem frmmem = new frmmem();
            this.Hide();
            frmmem.Show();
        }


        private void bttntrainer_Click_1(object sender, EventArgs e)
        {
            frmtrainer frmtrainer = new frmtrainer();
            this.Hide();
            frmtrainer.Show();
        }

        private void bttnactive_Click(object sender, EventArgs e)
        {
            frmappoi frmappoi = new frmappoi();
            this.Hide();
            frmappoi.Show();
        }

        private void bttnequip_Click(object sender, EventArgs e)
        {
            frmequip frm = new frmequip();
            this.Hide();
            frm.Show();
        }

        private void bttnpayments_Click(object sender, EventArgs e)
        {
            frmpay frm = new frmpay();
            this.Hide();
            frm.Show();
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
                this.Hide(); // Hide the current form 

                frmlogin loginForm = new frmlogin();
                loginForm.Show(); // Show the Login Form
            }

        }

        private void bttnaddmem_Click(object sender, EventArgs e)
        {
            frmmem frmmem = new frmmem();
            this.Hide();
            frmmem.Show();
        }

        private void bttncan_Click(object sender, EventArgs e)
        {

            {
                const string message = "Are you sure that you want to Cancel?";
                const string caption = "Delete";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Functions Mem = new Functions();
                    if (key == 1)
                    {
                        MessageBox.Show("Select the Appointment Id");
                    }
                    else
                    {
                        try
                        {
                            string query = "DELETE from Appointments where Appointment_ID = '" + txtappoi.Text + "'";
                            Mem.Delete(query);

                            MessageBox.Show("Appointment successfully canceled");

                            RefreshData();
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.Message);
                        }
                    }
                }
                else
                {
                    frmappoi n = new frmappoi();
                    this.Hide();
                    n.Show();
                }
            }
        }

        private void cmbmem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnupdate_Click_1(object sender, EventArgs e)
        {

        }

        private void bttnback_Click(object sender, EventArgs e)
        {
            frmdashboard frmdashboard = new frmdashboard();
            this.Hide();
            frmdashboard.Show();
        }

        private void bttnexit_Click(object sender, EventArgs e)
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
