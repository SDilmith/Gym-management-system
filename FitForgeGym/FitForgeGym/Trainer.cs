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

    public partial class frmtrainer : Form
    {
        public frmtrainer()
        {
            InitializeComponent();
        }

        int key;
        private void bttnadd_Click(object sender, EventArgs e)
        {
            if (txttrainerid.Text == "")
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
                    gen = "Male";
                }
                else
                {
                    gen = "Female";
                }
                string query = "Insert into Trainer values('" + txttrainerid.Text + "','" + txtname.Text + "','" + txtage.Text + "','" + gen + "', '" + cmbspe.SelectedItem.ToString() + "','" + txtcon.Text + "')";
                Functions Mem = new Functions();
                try
                {
                    //Display a message once a student registered
                    Mem.Add(query);
                    MessageBox.Show("Trainer Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

            //Clear all the items after the message

            txttrainerid.Clear();
            txtname.Clear();
            txtage.Clear();
            txtcon.Clear();


            //How to clear a combo-box
            cmbspe.SelectedItem = null;

            //How to clear Radio Button
            radmale.Checked = false;
            radfemale.Checked = false;
        }



        private void frmtrainer_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            Functions fnc = new Functions();
            string query = "select * from Trainer";
            DataSet ds = fnc.Show(query);

            dgvtrain.DataSource = ds.Tables[0];

        }

        private void dgvtrain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvtrain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvtrain.CurrentRow.Selected = true;
                txttrainerid.Text = dgvtrain.Rows[e.RowIndex].Cells["Trainer_ID"].FormattedValue.ToString();
                txtname.Text = dgvtrain.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtage.Text = dgvtrain.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                cmbspe.SelectedItem = dgvtrain.Rows[e.RowIndex].Cells["Specialization"].FormattedValue.ToString();
                txtcon.Text = dgvtrain.Rows[e.RowIndex].Cells["Contact_No"].FormattedValue.ToString();
                string gender = dgvtrain.Rows[e.RowIndex].Cells["Gender"].ToString();
            }
        }

        string gen = "";
        private void radmale_CheckedChanged(object sender, EventArgs e)
        {
            if (radmale.Checked)
            {
                gen = "Male";
            }
            else
            {
                gen = "Female";
            }
        }

        private void bttnupdate_Click(object sender, EventArgs e)
        {
            Functions Mem = new Functions();
            if (key == 1)
            {
                MessageBox.Show("Select the Trainer Id");
            }
            else
            {
                try
                {
                    // Correct the ToString method call by adding parentheses
                    string query = "Update Trainer set Name='" + txtname.Text + "', Age='" + txtage.Text + "', Gender='" + gen + "', Specialization='" + cmbspe.SelectedItem.ToString() + "', Contact_No='" + txtcon.Text + "' where Trainer_ID = '" + txttrainerid.Text + "' ";

                    Mem.Update(query);

                    MessageBox.Show("Trainer successfully Updated");

                    RefreshData();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }
            }
        }

        private void bttndelete_Click(object sender, EventArgs e)
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
                    if (key == 0)
                    {
                        MessageBox.Show("Select the Trainer Id");
                    }
                    else
                    {
                        try
                        {
                            string query = "Delete from Trainer where Trainer_ID= '" + txttrainerid + "'";
                            Mem.Delete(query);

                            MessageBox.Show("Trainer successfully deleted");

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
                    frmtrainer n = new frmtrainer();
                    this.Hide();
                    n.Show();
                }
            }
        }

        private void bttnsearch_Click(object sender, EventArgs e)
        {
            Functions fun = new Functions();
            string query = "Select * from Trainer where Trainer_ID = '" + txtsearch.Text + "'";
            DataSet ds = fun.Show(query);

            dgvtrain.DataSource = ds.Tables[0];
        }

        private void bttnref_Click(object sender, EventArgs e)
        {
            RefreshData();

            txtage.Clear();
            txtcon.Clear();
            txtname.Clear();
            txttrainerid.Clear();
            cmbspe.SelectedItem = null;
            gen = null;
        }

        private void bttnmember_Click(object sender, EventArgs e)
        {
            frmmem frmmem = new frmmem();
            this.Hide();
            frmmem.Show();
        }

        private void bttnactive_Click(object sender, EventArgs e)
        {
            frmappoi frmappoi = new frmappoi();
            this.Hide();
            frmappoi.Show();
        }

        private void bttnequip_Click(object sender, EventArgs e)
        {
            frmequip frmf = new frmequip();
            this.Hide();
            frmf.Show();
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

        private void cmbspe_SelectedIndexChanged(object sender, EventArgs e)
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

