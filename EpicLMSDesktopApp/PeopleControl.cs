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
    public partial class PeopleControl : UserControl
    {
        private User user = new User();
        public PeopleControl()
        {
            InitializeComponent();
        }
        public void setUser(User user)
        {
            xGrid.DataSource = null;
            xGrid.Rows.Clear();
            xGrid.Columns.Clear();
            xGrid.Refresh();
            this.user = user;
            txtTitle.Text = "Students of " + user.dept_name + " - Semester " + user.semester + ":";

            xGrid.RowHeadersVisible = false;

            MySqlConnection con = MySQLConnection.openCon();
            string query = "select student_id AS 'ID', CONCAT(first_name, ' ', last_name) AS 'Full Name', email as 'Contact' from student where dept_id = (SELECT dept_id from student where student_id=" + user.user_id + ") AND semester = (SELECT semester from student where student_id = " + user.user_id + ") AND student_id != " + user.user_id;
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dtb1 = new DataTable();
            dtb1.Load(dataReader);

            if (dtb1.Rows.Count >= 1)
            {
                xGrid.DataSource = dtb1;

                xGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                xGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                xGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                xGrid.DataSource = null;
                xGrid.Rows.Clear();
                xGrid.Columns.Clear();
                xGrid.Refresh();
                
                xGrid.Columns.Add("A", "Oops!");

                xGrid.Rows.Add("No other students enrolled in " + user.dept_name + " - Semester " + user.semester + "!");
                xGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            con.Close();
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            xGrid.DataSource = null;
            xGrid.Rows.Clear();
            xGrid.Refresh();
            setUser(user);
        }
    }
}
