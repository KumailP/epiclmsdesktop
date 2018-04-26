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
            if (user.dept_id == 1)
            {
                txtDept.Text = "Computer Science";
            }
            else if (user.dept_id == 2)
            {
                txtDept.Text = "Mechanical Engineering";
            }
            else if (user.dept_id == 3)
            {
                txtDept.Text = "Electrical Engineering";
            }
            else if (user.dept_id == 4)
            {
                txtDept.Text = "Bachelors in Business Administration";
            }
            txtContact.Text = user.email;
            txtSemester.Text = user.semester.ToString();

            MySqlConnection con = MySQLConnection.openCon();

            string query = "select course_code as 'Course Code', course_name as 'Course Name' from course where course_id in (select course_id from student_course where student_id = " + user.user_id + ")";
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
