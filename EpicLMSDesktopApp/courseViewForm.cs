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
    public partial class courseViewForm : Form
    {
        private DataTable dtb = new DataTable();
        private User user = new User();
        private int cid;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public courseViewForm(User user, string course_name)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            lblCName.Text = course_name;
            this.Text = course_name;

            this.user = user;
            xGrid.RowHeadersVisible = false;
            if (user.usertype == 1)
            {
                btnAdd.Hide();
                btnDelete.Hide();
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
            }
            setupCourses();
        }

        public void setupCourses()
        {
            xGrid.DataSource = null;
            xGrid.Rows.Clear();
            xGrid.Columns.Clear();
            xGrid.Refresh();
            MySqlConnection con = MySQLConnection.openCon();

            string query = "SELECT course_name, course_id FROM course WHERE course_id IN (SELECT course_id from student_course WHERE student_id=" + user.user_id + " AND course_name='" + this.Text + "')";
            if (user.usertype == 2)
            {
                query = "SELECT course_name, course_id FROM course WHERE course_id IN (SELECT course_id from faculty_course WHERE faculty_id=" + user.user_id + " AND course_name='" + this.Text + "')";
            }
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dtb1 = new DataTable();
            dtb1.Load(dataReader);
            cid = Int32.Parse(dtb1.Rows[0][1].ToString());

            if (dtb1.Rows.Count >= 1)
            {
                string cname = dtb1.Rows[0][0].ToString();

                query = "SELECT id as ID, file_name as 'File Name', date_uploaded as 'Date Uploaded', file_title as Title, description as Description FROM course_data WHERE course_id = " + cid.ToString();
                MySqlCommand newcmd = new MySqlCommand(query, con);
                dataReader = newcmd.ExecuteReader();
                DataTable dtb2 = new DataTable();
                dtb2.Load(dataReader);

                if (dtb2.Rows.Count >= 1)
                {

                    this.dtb = dtb2;
                    xGrid.DataSource = dtb;

                    //xGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    xGrid.Columns[0].Visible = false;
                    xGrid.Columns[1].Width = 100;
                    xGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    xGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    xGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;



                }
                else
                {
                    xGrid.Columns.Add("A", "Oops!");
                    xGrid.Rows.Add("No data found for this course");
                    xGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAddCourseData frm = new formAddCourseData(user, cid);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            setupCourses();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void courseViewForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(ColorTranslator.FromHtml("#303030"), 3),
                            this.DisplayRectangle);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the selected data?", "Delete Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewCell oneCell in xGrid.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        MySqlConnection con = MySQLConnection.openCon();
                        string data_id = xGrid.CurrentRow.Cells["ID"].Value.ToString();
                        string query = "DELETE FROM course_data WHERE id = " + data_id.ToString();
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        xGrid.Rows.RemoveAt(oneCell.RowIndex);
                    }
                }
                setupCourses();

            }
        }

        private void xGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRow = xGrid.CurrentCell.RowIndex;

                string fName = xGrid.Rows[selectedRow].Cells["File Name"].Value.ToString();

                string appPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "course_data");
                string filePath = System.IO.Path.Combine(appPath, fName);
                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
