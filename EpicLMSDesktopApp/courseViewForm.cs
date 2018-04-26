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
        public courseViewForm(User user, string course_name)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            lblCName.Text = course_name;
            this.Text = course_name;

            this.user = user;

            MySqlConnection con = MySQLConnection.openCon();
            string query = "SELECT course_name, course_id FROM course WHERE course_id IN (SELECT course_id from student_course WHERE student_id=" + user.user_id + " AND course_name='" + course_name + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dtb1 = new DataTable();
            dtb1.Load(dataReader);

            if (dtb1.Rows.Count >= 1)
            {
                string cname = dtb1.Rows[0][0].ToString();
                string cid = dtb1.Rows[0][1].ToString();

                query = "SELECT id as ID, date_uploaded as Date_Uploaded, file_title as Title, description as Description FROM course_data WHERE course_id = " + cid;
                MySqlCommand newcmd = new MySqlCommand(query, con);
                dataReader = newcmd.ExecuteReader();
                DataTable dtb2 = new DataTable();
                dtb2.Load(dataReader);

                if (dtb2.Rows.Count >= 1)
                {

                    this.dtb = dtb2;
                    xGrid.DataSource = dtb;
                    xGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    xGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    xGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    xGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    xGrid.Columns[0].Frozen = false;
                    xGrid.Columns[1].Frozen = false;
                    xGrid.Columns[2].Frozen = false;
                    xGrid.Columns[3].Frozen = false;


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

    }
}
