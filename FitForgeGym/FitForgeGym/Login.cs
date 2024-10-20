
namespace FitForgeGym
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void bttnlogin_Click(object sender, EventArgs e)
        {
            string correctUsername = "Admin";
            string correctPassword = "12345";

            string UserEnterUsername = txtusername.Text;
            string UserEnterPassword = txtpassword.Text;

            if (UserEnterUsername == correctUsername && UserEnterPassword == correctPassword)
            {
                MessageBox.Show("Login Succes!!", "system info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmdashboard dashboard = new frmdashboard();
                this.Hide();
                dashboard.Show();

            }
            else
            {
                MessageBox.Show("Login Failed!!", "system info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //clear textbox
                txtusername.Clear();
                txtpassword.Clear();


            }
        }

        private void bttnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }








        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttnlogin_Click((object)sender, e);
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
