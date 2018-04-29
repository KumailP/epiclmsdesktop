using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EpicLMSDesktopApp
{
    public partial class ManageCoursesControl : UserControl
    {
        private User user = new User();
        public ManageCoursesControl()
        {
            InitializeComponent();
        }
        public void setUser(User user)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Refresh();
            this.user = user;

            

            MySqlConnection con = MySQLConnection.openCon();

            string query = "select course_code as 'Course Code', course_name as 'Course Name' from course where course_id in (select course_id from student_course where student_id = " + user.user_id + ")";


            if (user.usertype == 2)
            {
                label2.Text = "Currently Teaching:";
                label3.Text = "Available to Teach:";

                query = "select course_code as 'Course Code', course_name as 'Course Name' from course where course_id in (select course_id from faculty_course where faculty_id = " + user.user_id + ")";
            }

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dtb1 = new DataTable();
            dtb1.Load(dataReader);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = dtb1;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            query = "SELECT c.course_id, c.course_code as 'Course Code', c.course_name as 'Course Name' FROM course c INNER JOIN student s ON c.semester = s.semester AND c.dept_id = s.dept_id LEFT JOIN student_course sc ON c.course_id = sc.course_id WHERE s.student_id = '"  + user.user_id + "' AND sc.course_id IS NULL";
            if (user.usertype == 2)
            {
                query = "SELECT c.course_id, c.course_code as 'Course Code', c.course_name as 'Course Name' FROM course c INNER JOIN faculty f ON c.dept_id = f.dept_id LEFT JOIN faculty_course fc ON c.course_id = fc.course_id WHERE f.faculty_id = '" + user.user_id + "' AND fc.course_id IS NULL";
            }

            cmd = new MySqlCommand(query, con);
            dataReader = cmd.ExecuteReader();
            DataTable dtb2 = new DataTable();
            dtb2.Load(dataReader);
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.DataSource = dtb2;

            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to drop the selected courses?", "Drop Courses?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
               {
                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                            MySqlConnection con = MySQLConnection.openCon();
                            string ccode = dataGridView1.CurrentRow.Cells["Course Code"].Value.ToString();
                            string query = "SELECT course_id from course where course_code = '" + ccode + "'";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            MySqlDataReader dataReader = cmd.ExecuteReader();
                            DataTable dtb1 = new DataTable();
                            dtb1.Load(dataReader);
                            query = "DELETE from student_course WHERE student_id = " + user.user_id + " AND course_id = " + dtb1.Rows[0][0];
                            if (user.usertype == 2)
                            {
                                query = "DELETE from faculty_course WHERE faculty_id = " + user.user_id + " AND course_id = " + dtb1.Rows[0][0];
                            }
                            MySqlCommand newcmd = new MySqlCommand(query, con);
                            newcmd.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                        }
                    }
                setUser(user);

            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (user.usertype == 1)
            {
                dialogResult = MessageBox.Show("Do you want to enroll in the selected courses?", "Enroll Courses?", MessageBoxButtons.YesNo);
            }
            else
            {
                dialogResult = MessageBox.Show("Do you want to teach the selected courses?", "Teach Courses?", MessageBoxButtons.YesNo);
            }
            if (dialogResult == DialogResult.Yes)
            {
            foreach (DataGridViewCell oneCell in dataGridView2.SelectedCells)
            {
                if (oneCell.Selected)
                {
                        MySqlConnection con = MySQLConnection.openCon();
                        string cid = dataGridView2.CurrentRow.Cells["course_id"].Value.ToString();
                        string query = "INSERT INTO  student_course (student_id, course_id) VALUES(" + user.user_id + ", " + cid + ")";
                        if (user.usertype == 2)
                        {
                            query = "INSERT INTO  faculty_course (faculty_id, course_id) VALUES(" + user.user_id + ", " + cid + ")";
                        }
                        MySqlCommand newcmd = new MySqlCommand(query, con);
                        newcmd.ExecuteNonQuery();
                        dataGridView2.Rows.RemoveAt(oneCell.RowIndex);
                    }
                }
            setUser(user);
            }
        }
    }
}
