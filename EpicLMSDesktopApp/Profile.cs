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
    public partial class Profile : UserControl
    {
        private User user = new User();
        public Profile()
        {
            InitializeComponent();
        }
        public void setUser(User user)
        {
            this.user = user;
            
            txtName.Text = user.fname + " " + user.lname;
            
            txtDept.Text = user.dept_name;
            txtContact.Text = user.email;
            txtSemester.Text = user.semester.ToString();

            MySqlConnection con = MySQLConnection.openCon();

            string query = "select course_code as 'Course Code', course_name as 'Course Name' from course where course_id in (select course_id from student_course where student_id = " + user.user_id + ")";
            if (user.usertype == 2)
            {
                label5.Hide();
                txtSemester.Hide();
                label7.Location = label5.Location;
                txtContact.Location = txtSemester.Location;

                label1.Text = "Teaching the following courses:";

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
        }
    }
}
