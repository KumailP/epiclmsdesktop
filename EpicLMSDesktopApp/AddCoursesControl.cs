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
    public partial class AddCoursesControl : UserControl
    {
        private User user = new User();
        public AddCoursesControl()
        {
            InitializeComponent();
        }
        public void setUser(User user)
        {
            this.user = user;
            comboDept.Items.Clear();
            comboDept2.Items.Clear();

            dataGridView1.RowHeadersVisible = false;
            MySqlConnection con = MySQLConnection.openCon();

            string query = "SELECT * FROM department";

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dtb1 = new DataTable();
            dtb1.Load(dataReader);

            for (int i = 0; i < dtb1.Rows.Count; i++)
            {
                comboDept.Items.Add(dtb1.Rows[i]["department_name"]);
                comboDept2.Items.Add(dtb1.Rows[i]["department_name"]);
            }
        }

        private void comboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            string query = "select course_code AS 'Course Code', course_name AS 'Course Name', course_hours AS 'Credit Hours', semester AS 'Semester' from course where dept_id = (select department_id from department where department_name = '" + comboDept.SelectedItem.ToString() + "')";
            MySqlConnection con = MySQLConnection.openCon();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dtb = new DataTable();
            dtb.Load(dataReader);

            if (dtb.Rows.Count >= 1)
            {

                dataGridView1.DataSource = dtb;

                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            else
            {

                dataGridView1.Columns.Add("A", "Oops!");

                dataGridView1.Rows.Add("No courses found!");
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string cname = txtCName.Text.ToString();
            string ccode = txtCCode.Text.ToString();
            string chours = comboCHrs.SelectedItem.ToString();
            if (ccode.Length == 6)
            {

                string semester = comboSem.SelectedItem.ToString();
                string dept = (comboDept2.SelectedIndex + 1).ToString();

                string query = "INSERT INTO course(course_name, course_code, course_hours, semester, dept_id) VALUES('" + cname + "', '" + ccode + "', " + chours + ", " + semester + ", " + dept + ")";
                MySqlConnection con = MySQLConnection.openCon();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Added!");

                dataGridView1.Refresh();
                txtCName.Text = "course name";
                txtCCode.Text = "course code";
                comboCHrs.SelectedIndex = -1;
                comboDept.SelectedIndex = -1;
                comboSem.SelectedIndex = -1;
                
            }
            else
            {
                MessageBox.Show("Invalid course code.");
            }
        }

        private void txtCName_Leave(object sender, EventArgs e)
        {
            if (txtCName.Text == "")
            {
                txtCName.Text = "course name";
            }
        }

        private void txtCCode_Leave(object sender, EventArgs e)
        {
            if (txtCCode.Text == "")
            {
                txtCCode.Text = "course code";
            }
        }

        private void txtCName_Enter(object sender, EventArgs e)
        {
            if (txtCName.Text == "course name")
            {
                txtCName.Text = "";
            }
        }

        private void txtCCode_Enter(object sender, EventArgs e)
        {
            if (txtCCode.Text == "course code")
            {
                txtCCode.Text = "";
            }
        }
    }
}
