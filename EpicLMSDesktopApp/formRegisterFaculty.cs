using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EpicLMSDesktopApp
{
    public partial class formRegisterFaculty : Form
    {
        public formRegisterFaculty()
        {
            InitializeComponent();
            comboDept.SelectedIndex = 0;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerLbl_Click(object sender, EventArgs e)
        {
            formLogin frmLogin = new formLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void txtFname_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtFname.Text == "first name")
            {
                txtFname.Text = "";
            }
        }

        private void txtLname_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtLname.Text == "last name")
            {
                txtLname.Text = "";
            }
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
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
            }
        }

        private void txtLname_Enter(object sender, EventArgs e)
        {
            if (txtLname.Text == "last name")
            {
                txtLname.Text = "";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "email")
            {
                txtEmail.Text = "";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtFname.Text == "" || txtLname.Text == "" || txtPassword.Text == "" || txtEmail.Text == "email" || txtFname.Text == "first name" || txtLname.Text == "last name" || txtPassword.Text == "password" || comboDept.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please enter all the fields");
            }
            else
            {
                string email = txtEmail.Text.Trim();
                string fname = txtFname.Text.Trim();
                string lname = txtLname.Text.Trim();
                string pw = txtPassword.Text;
                //int dept = comboDept.SelectedIndex;
                int dept = comboDept.SelectedIndex + 1;
                //MessageBox.Show("email: " + email + ", fname: " + fname + ", lname: " + lname + ", pw: " + pw + "deptid: " + dept + ", semester: " + semester);
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Enter a valid email address!");
                }
                else
                {
                    string myHash = BCrypt.HashPassword(pw, BCrypt.GenerateSalt());


                    MySqlConnection con = MySQLConnection.openCon();

                    string query = "INSERT INTO faculty (first_name, last_name, email, password, dept_id, photo) VALUES('" + fname + "', '" + lname + "', '" + email + "', '" + myHash + "', " + dept + ", 'default.jpg')";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registered!");
                    formLogin frmLogin = new formLogin();
                    this.Hide();
                    frmLogin.Show();
                }
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtFname_Leave(object sender, EventArgs e)
        {
            if (txtFname.Text == "")
            {
                txtFname.Text = "first name";
            }
        }

        private void txtLname_Leave(object sender, EventArgs e)
        {
            if (txtLname.Text == "")
            {
                txtLname.Text = "last name";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "email";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "password";
            }
        }
    }
}
