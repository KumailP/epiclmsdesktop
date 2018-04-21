using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EpicLMSDesktopApp
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            MySqlConnection con = MySQLConnection.openCon();
                

            //MessageBox.Show("Connection Open ! ");

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            string query = "SELECT * from student WHERE email='" + email + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dtb1 = new DataTable();
            dtb1.Load(dataReader);
            //cmd.ExecuteNonQuery();

            //new SqlDataAdapter(query, con).Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                bool doesmatch = BCrypt.CheckPassword(password, dtb1.Rows[0][4].ToString());
                if (doesmatch)
                {
                    formMain frm = new formMain();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Unable to login!");
                }
            }
            else
            {
                MessageBox.Show("User not found");
            }


            MySQLConnection.closeCon(con);
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "email")
            {
                txtEmail.Text = "";
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
            }
        }
    }
}
