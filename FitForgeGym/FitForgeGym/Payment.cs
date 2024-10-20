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
using System.Drawing.Printing;
using System.Drawing;


namespace FitForgeGym
{
    public partial class frmpay : Form
    {
        public frmpay()
        {
            InitializeComponent();
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
            // Connection string to your SQL databse
            string connectionstring = @"Data Source=DESKTOP-EOPDPD2\SQLEXPRESS;Initial Catalog=Fit_Forge;Integrated Security=True;Encrypt=False";

            //SQL query to select data from table
            string query = "SELECT Member_ID from Members";

            //Create a SQL connection
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmbmemid.Items.Clear();
                    while (reader.Read())
                    {
                        cmbmemid.Items.Add(reader["Member_ID"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message);
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmpay_Load(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void RefreshData()
        {
            Functions fnc = new Functions();
            string query = "select * from Payment";
            DataSet ds = fnc.Show(query);

            dgvpay.DataSource = ds.Tables[0];
        }


        int key;
        private void bttnadd_Click(object sender, EventArgs e)
        {
            if (cmbmemid.SelectedItem == "")
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



                DialogResult result = MessageBox.Show("Are you sure you want to confirm this Payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the result
                if (result == DialogResult.Yes)
                {
                    string query = "Insert into Payment values('" + txtpayID.Text + "','" + cmbmemid.SelectedItem.ToString() + "','" + txtamount.Text + "', '" + dtpdate.Value + "')";
                    Functions Mem = new Functions();
                    try
                    {
                        //Display a message once a Member registered
                        Mem.Add(query);
                        MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                else
                {
                    // Code if the appointment is canceled
                    MessageBox.Show("Payment canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            //Clear all the items after the message

            txtamount.Clear();
            cmbmemid.Items.Clear();
            dtpdate.Refresh();

        }

        private void dgvpay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvpay.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvpay.CurrentRow.Selected = true;

                // Set text box and combo box values
                txtamount.Text = dgvpay.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
                cmbmemid.SelectedItem = dgvpay.Rows[e.RowIndex].Cells["Member_ID"].FormattedValue.ToString();
                txtpayID.Text = dgvpay.Rows[e.RowIndex].Cells["payment_ID"].FormattedValue.ToString();


                if (DateTime.TryParse(dgvpay.Rows[e.RowIndex].Cells["Date"].FormattedValue.ToString(), out DateTime parsedDate))
                {
                    dtpdate.Value = parsedDate;  // Set the DateTimePicker value
                }
                else
                {
                    MessageBox.Show("Invalid date format in the selected cell.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void bttnupdate_Click(object sender, EventArgs e)
        {
            Functions Mem = new Functions();
            if (key == 1)
            {
                MessageBox.Show("Select the Payment Id");
            }
            else
            {
                try
                {
                    // Correct the ToString method call by adding parentheses
                    string query = "Update Payment set Member_ID = '" + cmbmemid.SelectedItem.ToString() + "', Amount='" + txtamount.Text + "', Date='" + dtpdate.Value + "' where Payment_ID = '" + txtpayID.Text + "' ";

                    Mem.Update(query);

                    MessageBox.Show("Payment successfully Updated");

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
            RefreshData();  // Refresh the DataGridView or related data

            cmbmemid.SelectedIndex = -1;  // Reset ComboBox selection
            txtpayID.Clear();  // Clear Payment ID TextBox
            txtamount.Clear();  // Clear Amount TextBox
        }

        private void bttndel_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Select the Payment Id");
                }
                else
                {
                    try
                    {
                        string query = "DELETE from Payment where Payment_ID= '" + txtpayID.Text + "'";
                        Mem.Delete(query);

                        MessageBox.Show("Payment successfully deleted");

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

        private void bttnsearch_Click(object sender, EventArgs e)
        {

            Functions fun = new Functions();
            string query = "Select * from Payment where Payment_ID = '" + txtsearch.Text + "'";
            DataSet ds = fun.Show(query);

            dgvpay.DataSource = ds.Tables[0];
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

        private PrintDocument printDocument = new PrintDocument();

        private void Payment_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Example: Print some text on the document (you can replace this with your bill content)
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font subTitleFont = new Font("Arial", 16, FontStyle.Italic);
            Font labelFont = new Font("Arial", 14, FontStyle.Regular);
            Font valueFont = new Font("Arial", 14, FontStyle.Regular);
            Brush brush = Brushes.Black;

            float x = 100;  // Left margin
            float y = 100;  // Top margin
            float lineHeight = 30;  // Line height to separate content

            // Draw the text at a specified position on the page
            e.Graphics.DrawString("Member ID", titleFont, brush, x + 200, y);
            y += lineHeight * 2;
            e.Graphics.DrawString("Welcome to Fit_Forge!", subTitleFont, brush, x + 100, y);
            y += lineHeight * 1.5f;
            e.Graphics.DrawString("Payment_ID:", labelFont, brush, x, y);
            e.Graphics.DrawString(txtpayID.Text, valueFont, brush, x + 100, y);
            y += lineHeight;
            e.Graphics.DrawString("Amount:", labelFont, brush, x, y);
            e.Graphics.DrawString(txtamount.Text, valueFont, brush, x + 100, y);
            y += lineHeight;
           
            e.Graphics.DrawString("Thank you for your Payment!", subTitleFont, brush, x + 100, y);
        }


        private void Print_Click(object sender, EventArgs e)
        {
            const string message = "Payment Successful!";
            const string caption = "Payment";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Assign the PrintPage event handler

        // Show the Print dialog
        PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            // If the user clicks OK in the dialog, print the document
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }


        }
    }
}    


    
