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
    public partial class formSettings : Form
    {
        User user = new User();
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int semester { get; set; }
        public bool updatename { get; set; }
        public bool updatesemester { get; set; }
        public formSettings(ref User user)
        {
            this.user = user;
            InitializeComponent();
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFname_Enter(object sender, EventArgs e)
        {
            if (txtFname.Text == "first name")
            {
                txtFname.Text = "";
            }
        }

        private void txtFname_Leave(object sender, EventArgs e)
        {
            if (txtFname.Text == "")
            {
                txtFname.Text = "first name";
            }
        }

        private void txtOldPw_Leave(object sender, EventArgs e)
        {
            if (txtOldPw.Text == "")
            {
                txtOldPw.UseSystemPasswordChar = false;
                txtOldPw.Text = "old password";
            }
        }

        private void txtOldPw_Enter(object sender, EventArgs e)
        {
            if (txtOldPw.Text == "old password")
            {
                txtOldPw.UseSystemPasswordChar = true;
                txtOldPw.Text = "";
            }
        }

        private void txtLName_Enter(object sender, EventArgs e)
        {
            if (txtLName.Text == "last name")
            {
                txtLName.Text = "";
            }
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            if (txtLName.Text == "")
            {
                txtLName.Text = "last name";
            }
        }

        private void txtNewPw_Leave(object sender, EventArgs e)
        {
            if (txtNewPw.Text == "")
            {
                txtNewPw.UseSystemPasswordChar = false;
                txtNewPw.Text = "new password";
            }
        }

        private void txtNewPw_Enter(object sender, EventArgs e)
        {
            if (txtNewPw.Text == "new password")
            {
                txtNewPw.UseSystemPasswordChar = true;
                txtNewPw.Text = "";
            }
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            if ((txtFname.Text == "first name") && (txtLName.Text != "last name"))
            {
                MessageBox.Show("Please enter first name");
            }
            else if ((txtLName.Text == "last name") && (txtFname.Text != "first name"))
            {
                MessageBox.Show("Please enter last name");
            }
            else
            {
                string query = "UPDATE student SET first_name = '" + txtFname.Text.ToString().Trim() + "', last_name = '" + txtLName.Text.ToString().Trim() + "' WHERE student_id = " + user.user_id;
                if (user.usertype == 2)
                {
                    query = "UPDATE faculty SET first_name = '" + txtFname.Text.ToString().Trim() + "', last_name = '" + txtLName.Text.ToString().Trim() + "' WHERE faculty_id = " + user.user_id;
                }
                try
                {
                    MySqlConnection con = MySQLConnection.openCon();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    this.updatename = true;
                    this.first_name = txtFname.Text;
                    this.last_name = txtLName.Text;
                    MessageBox.Show("Updated name!");
                }
                catch (MySqlException ex2)
                {
                    MessageBox.Show(ex2.Message);
                    }
            }
        }

        private void btnUpdatePw_Click(object sender, EventArgs e)
        {
            if (txtOldPw.Text == "old password" && txtNewPw.Text != "new password")
            {
                MessageBox.Show("Please enter old password");
            }
            else if (txtNewPw.Text == "new password" && txtOldPw.Text != "old password")
            {
                MessageBox.Show("Please enter new password");
            }
            else
            {
                try
                {
                    MySqlConnection con = MySQLConnection.openCon();
                    string query = "SELECT * FROM student WHERE student_id = " + user.user_id;
                    if (user.usertype == 2)
                    {
                        query = "SELECT * FROM faculty WHERE faculty_id = " + user.user_id;
                    }

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    DataTable dtb1 = new DataTable();
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dtb1.Load(dataReader);
                    //cmd.ExecuteNonQuery();

                    //new SqlDataAdapter(query, con).Fill(dtb1);
                    if (dtb1.Rows.Count == 1)
                    {
                        bool doesmatch = BCrypt.CheckPassword(txtOldPw.Text, dtb1.Rows[0][4].ToString());
                        if (doesmatch)
                        {
                            string myHash = BCrypt.HashPassword(txtNewPw.Text, BCrypt.GenerateSalt());
                            query = "UPDATE student SET password = '" + myHash + "' WHERE student_id = " + user.user_id;
                            if (user.usertype == 2)
                            {
                                query = "UPDATE faculty SET password = '" + myHash + "' WHERE faculty_id = " + user.user_id;
                            }
                            try
                            {
                                cmd = new MySqlCommand(query, con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated password!");
                            }
                            catch (MySqlException ex2)
                            {
                                MessageBox.Show(ex2.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Old password incorrect!");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQLException: " + ex.Message);
                }
            }
        }

        private void btnUpdateSem_Click(object sender, EventArgs e)
        { 
            string query = "UPDATE student SET semester = " + comboSemester.SelectedItem.ToString() + " WHERE student_id = " + user.user_id;
                    
            try
            {

                MySqlConnection con = MySQLConnection.openCon();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery(); ;
                this.updatesemester = true;
                if (this.comboSemester.SelectedItem != null)
                {
                    this.semester = Int32.Parse(comboSemester.SelectedItem.ToString());
                }
                MessageBox.Show("Updated semester!");
            }
            catch (MySqlException ex2)
            {
                MessageBox.Show(ex2.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
