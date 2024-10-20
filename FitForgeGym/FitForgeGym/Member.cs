using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitForgeGym
{
    public partial class frmmem : Form
    {
        public frmmem()
        {
            InitializeComponent();
        }

        int key;
        string gender;
        private void bttnadd_Click(object sender, EventArgs e)
        {

            if (txtmemid.Text == "")
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
                if (radmale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string query = "Insert into Members values('" + txtmemid.Text + "','" + txtname.Text + "','" + txtage.Text + "','" + gender + "','" + cmbsched.SelectedItem.ToString() + "','" + txtcon.Text + "')";
                Functions Mem = new Functions();
                try
                {
                    //Display a message once a Member registered
                    Mem.Add(query);
                    MessageBox.Show("Member Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

            //Clear all the items after the message

            txtmemid.Clear();
            txtname.Clear();
            txtage.Clear();
            txtcon.Clear();


            //How to clear a combo-box
            cmbsched.SelectedItem = null;

            //How to clear Radio Button
            radfemale.Checked = false;
            radmale.Checked = false;

        }

        private void dgvmem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvmem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvmem.CurrentRow.Selected = true;

                // Set text box and combo box values
                txtmemid.Text = dgvmem.Rows[e.RowIndex].Cells["Member_ID"].FormattedValue.ToString();
                txtname.Text = dgvmem.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtage.Text = dgvmem.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                cmbsched.SelectedItem = dgvmem.Rows[e.RowIndex].Cells["Schedule_Time"].FormattedValue.ToString();
                txtcon.Text = dgvmem.Rows[e.RowIndex].Cells["Contact_No"].FormattedValue.ToString();

                // Set radio button based on the Gender column
                string gender = dgvmem.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                if (gender == "Male")
                {
                    radmale.Checked = true;
                }
                else if (gender == "Female")
                {
                    radfemale.Checked = true;
                }
            }
        }


        private void cmbsched_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string gen = "";


        private void frmmem_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            Functions fnc = new Functions();
            string query = "select * from Members";
            DataSet ds = fnc.Show(query);

            dgvmem.DataSource = ds.Tables[0];

        }

        private void bttndel_Click(object sender, EventArgs e)
        {
            {
                const string message = "Are you sure that you want to delete?";
                const string caption = "Delete";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Functions Mem = new Functions();
                    if (key == 1)
                    {
                        MessageBox.Show("Select the Member Id");
                    }
                    else
                    {
                        try
                        {
                            string query = "DELETE from Members where Member_ID= '" + txtmemid.Text + "'";
                            Mem.Delete(query);

                            MessageBox.Show("Member successfully deleted");

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
                    frmmem n = new frmmem();
                    this.Hide();
                    n.Show();
                }
            }
        }

        private void bttnsearch_Click(object sender, EventArgs e)
        {
            Functions fun = new Functions();
            string query = "Select * from Members where Member_ID = '" + txtsearch.Text + "'";
            DataSet ds = fun.Show(query);

            dgvmem.DataSource = ds.Tables[0];
        }

        private void bttnupdate_Click(object sender, EventArgs e)
        {
            Functions Mem = new Functions();
            if (key == 1)
            {
                MessageBox.Show("Select the Member ID");
                
            }
            else
            {
                try
                {
                    // Correct the ToString method call by adding parentheses
                    string query = "Update Members set Name='" + txtname.Text + "', Age='" + txtage.Text + "', Gender='" + gen + "', Schedule_Time='" + cmbsched.SelectedItem.ToString() + "', Contact_No='" + txtcon.Text + "' where Member_ID = '" + txtmemid.Text + "' ";

                    Mem.Update(query);

                    MessageBox.Show("Member successfully Updated")
                   

                    RefreshData();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }
            }
        }

        private void bttnref_Click(object sender, EventArgs e)
        {
            RefreshData();

            //Clear all the items after the message

            txtmemid.Clear();
            txtname.Clear();
            txtage.Clear();
            txtcon.Clear();


            //How to clear a combo-box
            cmbsched.SelectedItem = null;

            //How to clear Radio Button
            radfemale.Checked = false;
            radmale.Checked = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the value of the clicked cell
                DataGridViewRow row = dgvmem.Rows[e.RowIndex];
                string gender = row.Cells["Gender"].FormattedValue.ToString();

                // Set the corresponding radio button based on the cell value
                if (gender == "Male")
                {
                    radmale.Checked = true;
                }
                else if (gender == "Female")
                {
                    radfemale.Checked = true;
                }
            }
        }

        private void bttntrainer_Click(object sender, EventArgs e)
        {
            frmtrainer frmtrainer = new frmtrainer();
            this.Hide();
            frmtrainer.Show();
        }

        private void bttnactive_Click(object sender, EventArgs e)
        {
            frmappoi appoint = new frmappoi();
            this.Hide();
            appoint.Show();
        }

        private void bttnequip_Click(object sender, EventArgs e)
        {
            frmequip frmequip = new frmequip();
            this.Hide();
            frmequip.Show();
        }

        private void bttnpayments_Click(object sender, EventArgs e)
        {
            Form frmpay = new Form();
            this.Hide();
            frmpay.Show();
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

        private void bttnback_Click(object sender, EventArgs e)
        {
            frmdashboard frmdashboard = new frmdashboard();
            this.Hide();
            frmdashboard.Show();
        }
    }


}
