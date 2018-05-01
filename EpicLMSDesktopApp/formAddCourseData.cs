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
    public partial class formAddCourseData : Form
    {
        int course_id;
        User user;
        string fileName = "";
        string appPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "course_data");
        public formAddCourseData(User user, int course_id)
        {
            InitializeComponent();
            this.user = user;
            this.course_id = course_id;
            chkAddFile.Checked = false;
            txtFileName.Enabled = false;
            btnBrowse.Enabled = false;
            btnBrowse.Hide();
            txtFileName.Hide();
            pnlFileName.Hide();
            this.Height = this.Height - 50;
            btnAdd.Location = new Point(btnAdd.Location.X, btnAdd.Location.Y - 50);
            btnCancel.Location = new Point(btnCancel.Location.X, btnCancel.Location.Y - 50);
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

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text == "title")
            {
                txtTitle.Text = "";
            }
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Text = "title";
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddFile.Checked)
            {
                txtFileName.Enabled = true;
                btnBrowse.Enabled = true;
                btnBrowse.Show();
                txtFileName.Show();
                pnlFileName.Show();
                this.Height = this.Height + 50;
                btnAdd.Location = new Point(btnAdd.Location.X, btnAdd.Location.Y + 50);
                btnCancel.Location = new Point(btnCancel.Location.X, btnCancel.Location.Y + 50);
            }
            else
            {
                txtFileName.Enabled = false;
                btnBrowse.Enabled = false;
                btnBrowse.Hide();
                txtFileName.Hide();
                pnlFileName.Hide();
                this.Height = this.Height - 50;
                btnAdd.Location = new Point(btnAdd.Location.X, btnAdd.Location.Y - 50);
                btnCancel.Location = new Point(btnCancel.Location.X, btnCancel.Location.Y - 50);
            }
        }
       


        private void formAddCourseData_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(ColorTranslator.FromHtml("#303030"), 3),
                            this.DisplayRectangle);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileName.Text = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string title = txtTitle.Text.ToString();

                string des = rtDesc.Text.ToString();

                string description = des.Replace("'", "\"");

                string query = "INSERT INTO course_data (course_id, faculty_id, file_name, date_uploaded, file_title, description) VALUES (" + course_id + ", " + user.user_id + ", '" + fileName.ToString() + "', NOW(), '" + title + "', '" + description + "')";
                if (!chkAddFile.Checked)
                {
                    query = "INSERT INTO course_data (course_id, faculty_id, file_name, date_uploaded, file_title, description) VALUES (" + course_id + ", " + user.user_id + ", null, NOW(), '" + title + "', '" + description + "')";
                }
                

                MySqlConnection con = MySQLConnection.openCon();
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.ExecuteNonQuery();

                if (chkAddFile.Checked)
                {
                    string sourceFile = txtFileName.Text;
                    string targetPath = @"C:\users\kc\desktop";
                    string destFile = System.IO.Path.Combine(appPath, fileName);

                    if (!System.IO.Directory.Exists(targetPath))
                    {
                        System.IO.Directory.CreateDirectory(targetPath);
                    }

                    System.IO.File.Copy(sourceFile, destFile, true);
                }
                MessageBox.Show("Data added.");

                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rtDesc_Enter(object sender, EventArgs e)
        {
            if (rtDesc.Text == "description...")
            {
                rtDesc.Text = "";
            }
        }

        private void rtDesc_Leave(object sender, EventArgs e)
        {
            if (rtDesc.Text == "")
            {
                rtDesc.Text = "description...";
            }
        }
    }
}
