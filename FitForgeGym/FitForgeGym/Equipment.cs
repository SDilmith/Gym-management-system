using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FitForgeGym
{
    public partial class frmequip : Form
    {
        public frmequip()
        {
            InitializeComponent();
        }


        int key;
        private void bttnadd_Click(object sender, EventArgs e)
        {
            if (txtequipid.Text == "")
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

                string query = "Insert into Equipment values('" + txtequipid.Text + "','" + cmbequip.SelectedItem.ToString() + "','" + txtequipname.Text + "','" + cmbcon.SelectedItem.ToString() + "', '" + nupquant.Value + "','" + txtprice.Text + "','" + txtsupplier.Text + "','" + dtpdate.Value + "')";
                string selectedSubCategory = "";

                // Determine which sub-category combo box is visible and selected
                if (comboBox1.Visible)
                {
                    selectedSubCategory = comboBox1.SelectedItem.ToString();
                }
                else if (comboBox2.Visible)
                {
                    selectedSubCategory = comboBox2.SelectedItem.ToString();
                }
                else if (comboBox3.Visible)
                {
                    selectedSubCategory = comboBox3.SelectedItem.ToString();
                }
                else if (comboBox4.Visible)
                {
                    selectedSubCategory = comboBox4.SelectedItem.ToString();
                }
                else if (comboBox5.Visible)
                {
                    selectedSubCategory = comboBox5.SelectedItem.ToString();
                }
                else if (comboBox6.Visible)
                {
                    selectedSubCategory = comboBox6.SelectedItem.ToString();
                }


                Functions Mem = new Functions();
                try
                {
                    //Display a message once a student registered
                    Mem.Add(query);
                    MessageBox.Show("Equipment Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

            //Clear all the items after the message

            txtsupplier.Clear();
            txtprice.Clear();
            txtequipname.Clear();
            txtequipid.Clear();


            //How to clear a combo-box
            cmbcon.SelectedItem = null;
            cmbequip.SelectedItem = null;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvequipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvequipment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvequipment.CurrentRow.Selected = true;

                // Set text box and combo box values
                txtequipid.Text = dgvequipment.Rows[e.RowIndex].Cells["Equipment_ID"].FormattedValue.ToString();
                cmbequip.SelectedItem = dgvequipment.Rows[e.RowIndex].Cells["Equipment_Type"].FormattedValue.ToString();
                txtequipname.Text = dgvequipment.Rows[e.RowIndex].Cells["Equipment_Name"].FormattedValue.ToString();
                cmbcon.SelectedItem = dgvequipment.Rows[e.RowIndex].Cells["Condition"].FormattedValue.ToString();
                nupquant.Value = Convert.ToDecimal(dgvequipment.Rows[e.RowIndex].Cells["Quantity"].Value); txtprice.Text = dgvequipment.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                txtsupplier.Text = dgvequipment.Rows[e.RowIndex].Cells["Supplier_Name"].FormattedValue.ToString();
                dtpdate.Value = Convert.ToDateTime(dgvequipment.Rows[e.RowIndex].Cells["Date"].Value);


            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (comboBox1.Visible)
            {
                selectedSubCategory = comboBox1.SelectedItem.ToString();
            }
            else if (comboBox2.Visible)
            {
                selectedSubCategory = comboBox2.SelectedItem.ToString();
            }
            else if (comboBox3.Visible)
            {
                selectedSubCategory = comboBox3.SelectedItem.ToString();
            }
            else if (comboBox4.Visible)
            {
                selectedSubCategory = comboBox4.SelectedItem.ToString();
            }
            else if (comboBox5.Visible)
            {
                selectedSubCategory = comboBox5.SelectedItem.ToString();
            }
            else if (comboBox6.Visible)
            {
                selectedSubCategory = comboBox6.SelectedItem.ToString();
            }

            txtequipname.Text = selectedSubCategory;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (comboBox1.Visible)
            {
                selectedSubCategory = comboBox1.SelectedItem.ToString();
            }
            else if (comboBox2.Visible)
            {
                selectedSubCategory = comboBox2.SelectedItem.ToString();
            }
            else if (comboBox3.Visible)
            {
                selectedSubCategory = comboBox3.SelectedItem.ToString();
            }
            else if (comboBox4.Visible)
            {
                selectedSubCategory = comboBox4.SelectedItem.ToString();
            }
            else if (comboBox5.Visible)
            {
                selectedSubCategory = comboBox5.SelectedItem.ToString();
            }
            else if (comboBox6.Visible)
            {
                selectedSubCategory = comboBox6.SelectedItem.ToString();
            }

            txtequipname.Text = selectedSubCategory;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (comboBox1.Visible)
            {
                selectedSubCategory = comboBox1.SelectedItem.ToString();
            }
            else if (comboBox2.Visible)
            {
                selectedSubCategory = comboBox2.SelectedItem.ToString();
            }
            else if (comboBox3.Visible)
            {
                selectedSubCategory = comboBox3.SelectedItem.ToString();
            }
            else if (comboBox4.Visible)
            {
                selectedSubCategory = comboBox4.SelectedItem.ToString();
            }
            else if (comboBox5.Visible)
            {
                selectedSubCategory = comboBox5.SelectedItem.ToString();
            }
            else if (comboBox6.Visible)
            {
                selectedSubCategory = comboBox6.SelectedItem.ToString();
            }

            txtequipname.Text = selectedSubCategory;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (comboBox1.Visible)
            {
                selectedSubCategory = comboBox1.SelectedItem.ToString();
            }
            else if (comboBox2.Visible)
            {
                selectedSubCategory = comboBox2.SelectedItem.ToString();
            }
            else if (comboBox3.Visible)
            {
                selectedSubCategory = comboBox3.SelectedItem.ToString();
            }
            else if (comboBox4.Visible)
            {
                selectedSubCategory = comboBox4.SelectedItem.ToString();
            }
            else if (comboBox5.Visible)
            {
                selectedSubCategory = comboBox5.SelectedItem.ToString();
            }
            else if (comboBox6.Visible)
            {
                selectedSubCategory = comboBox6.SelectedItem.ToString();
            }

            txtequipname.Text = selectedSubCategory;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (comboBox1.Visible)
            {
                selectedSubCategory = comboBox1.SelectedItem.ToString();
            }
            else if (comboBox2.Visible)
            {
                selectedSubCategory = comboBox2.SelectedItem.ToString();
            }
            else if (comboBox3.Visible)
            {
                selectedSubCategory = comboBox3.SelectedItem.ToString();
            }
            else if (comboBox4.Visible)
            {
                selectedSubCategory = comboBox4.SelectedItem.ToString();
            }
            else if (comboBox5.Visible)
            {
                selectedSubCategory = comboBox5.SelectedItem.ToString();
            }
            else if (comboBox6.Visible)
            {
                selectedSubCategory = comboBox6.SelectedItem.ToString();
            }

            txtequipname.Text = selectedSubCategory;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (comboBox1.Visible)
            {
                selectedSubCategory = comboBox1.SelectedItem.ToString();
            }
            else if (comboBox2.Visible)
            {
                selectedSubCategory = comboBox2.SelectedItem.ToString();
            }
            else if (comboBox3.Visible)
            {
                selectedSubCategory = comboBox3.SelectedItem.ToString();
            }
            else if (comboBox4.Visible)
            {
                selectedSubCategory = comboBox4.SelectedItem.ToString();
            }
            else if (comboBox5.Visible)
            {
                selectedSubCategory = comboBox5.SelectedItem.ToString();
            }
            else if (comboBox6.Visible)
            {
                selectedSubCategory = comboBox6.SelectedItem.ToString();
            }

            txtequipname.Text = selectedSubCategory;
        }



        string selectedSubCategory = "";
        private void cmbequip_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (comboBox1.Visible)
            {
                selectedSubCategory = comboBox1.SelectedItem.ToString();
            }
            else if (comboBox2.Visible)
            {
                selectedSubCategory = comboBox2.SelectedItem.ToString();
            }
            else if (comboBox3.Visible)
            {
                selectedSubCategory = comboBox3.SelectedItem.ToString();
            }
            else if (comboBox4.Visible)
            {
                selectedSubCategory = comboBox4.SelectedItem.ToString();
            }
            else if (comboBox5.Visible)
            {
                selectedSubCategory = comboBox5.SelectedItem.ToString();
            }
            else if (comboBox6.Visible)
            {
                selectedSubCategory = comboBox6.SelectedItem.ToString();
            }

            txtequipname.Text = selectedSubCategory;

            if

            (cmbequip.SelectedItem == "Cardio Equipment")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
            }

            if
                (cmbequip.SelectedItem == "Strength Training Equipment")
            {
                comboBox2.Visible = true;
                comboBox1.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
            }

            if
                (cmbequip.SelectedItem == "Flexibility/Stretching Equipment")
            {
                comboBox3.Visible = true;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox5.Visible = false;
                comboBox4.Visible = false;
                comboBox6.Visible = false;
            }

            if
               (cmbequip.SelectedItem == "Functional Training Equipment")
            {
                comboBox4.Visible = true;
                comboBox3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
            }

            if
                (cmbequip.SelectedItem == "Weightlifting Equipment")
            {
                comboBox5.Visible = true;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox6.Visible = false;
            }

            if
                (cmbequip.SelectedItem == "Accessories")
            {
                comboBox6.Visible = true;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
            }

        }





        private void Frmequip_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            Functions fnc = new Functions();
            string query = "Select * from Equipment";
            DataSet ds = fnc.Show(query);

            dgvequipment.DataSource = ds.Tables[0];
            dgvequipment.AutoGenerateColumns = true;


        }

        private void bttnupdate_Click(object sender, EventArgs e)

        {
            Functions Mem = new Functions();
            if (key == 1)
            {
                MessageBox.Show("Select the Equipment Id");
            }
            else
            {
                try
                {
                    // Correct the ToString method call by adding parentheses
                    string query = "Update Equipment set Equipment_Name='" + txtequipname.Text + "', Condition='" + cmbcon.SelectedItem.ToString() + "',Quantity='" + nupquant.Value + "', Price='" + txtprice.Text + "', Supplier_Name='" + txtsupplier.Text + "', Date='" + dtpdate.Value + "' where Equipment_ID = '" + txtequipid.Text + "' ";

                    Mem.Update(query);

                    MessageBox.Show("Equipment successfully Updated");

                    RefreshData();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }
            }
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
                        MessageBox.Show("Select the Equipment Id");
                    }
                    else
                    {
                        try
                        {
                            string query = "DELETE from Equipment where Equipment_ID= '" + txtequipid.Text + "'";
                            Mem.Delete(query);

                            MessageBox.Show("Equipment successfully deleted");

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
                    frmequip n = new frmequip();
                    this.Hide();
                    n.Show();
                }
            }
        }

        private void bttnref_Click(object sender, EventArgs e)
        {
            RefreshData();

            //Clear all the items after the message

            txtequipid.Clear();
            txtequipname.Clear();
            txtprice.Clear();
            txtsupplier.Clear();


            //How to clear a combo-box
            cmbcon.SelectedItem = null;
            cmbequip.SelectedIndex = 0;
            selectedSubCategory = null;



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
            frmappoi frmappoi = new frmappoi();
            this.Hide();
            frmappoi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmpay frmpay = new frmpay();
            this.Hide();
            frmpay.Show();
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
