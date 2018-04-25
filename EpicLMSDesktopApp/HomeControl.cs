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
    public partial class HomeControl : UserControl
    {
        private User user = new User();
        public HomeControl()
        {
            InitializeComponent();


            

            //MessageBox.Show(user.fname);
        }

        public void setUser(User user)
        {
            this.user = user;
            MessageBox.Show(user.fname);
            setupCourses();
        }

        public void setupCourses()
        {
            MySqlConnection con = MySQLConnection.openCon();

            string query = "SELECT * FROM course INNER JOIN student_course WHERE student_id = " + user.user_id + " AND student_course.course_id = course.course_id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dtb1 = new DataTable();
            dtb1.Load(dataReader);
            con.Close();
            
            for (int i = 0; i < dtb1.Rows.Count; i++)
            {
                Button b = new Button();
                b.Text = dtb1.Rows[i][1].ToString();
                b.Width = 188;
                b.Height = 100;
                var margin = b.Margin;
                margin.Left = 30;
                b.Margin = margin;
                b.BackColor = ColorTranslator.FromHtml("#303030");
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.Font = new Font("Verdana", 10);
                b.ForeColor = ColorTranslator.FromHtml("#ffffff");
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);
            }
            flowLayoutPanel1.AutoScroll = true;
        }

        void b_Click(object sender, EventArgs e)
        {
            var btn = sender as Control;

            MySqlConnection con = MySQLConnection.openCon();

            string query = "SELECT course_name, course_id FROM course WHERE course_id IN (SELECT course_id from student_course WHERE student_id=" + user.user_id + " AND course_name='" + btn.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dtb1 = new DataTable();
            dtb1.Load(dataReader);

            if (dtb1.Rows.Count >= 1)
            {
                string cname = dtb1.Rows[0][0].ToString();
                string cid = dtb1.Rows[0][1].ToString();

                query = "SELECT * FROM course_data WHERE course_id = " + cid;
                MySqlCommand newcmd = new MySqlCommand(query, con);
                dataReader = newcmd.ExecuteReader();
                DataTable dtb2 = new DataTable();
                dtb2.Load(dataReader);

                if (dtb2.Rows.Count >= 1)
                {
                    MessageBox.Show(cname);
                }
                
            }
            con.Close();
            

            //new formLogin().Show();
        }
    }
}
