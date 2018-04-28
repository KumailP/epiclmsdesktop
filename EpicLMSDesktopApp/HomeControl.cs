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
            //MessageBox.Show(user.fname);
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
                b.Tag = "Course Button";
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
            btn.BackColor = ColorTranslator.FromHtml("#505050");

            
            courseViewForm cForm = new courseViewForm(user, btn.Text.ToString());
            cForm.StartPosition = FormStartPosition.CenterParent;
            cForm.ShowDialog();


            btn.BackColor = ColorTranslator.FromHtml("#303030");
                    
            //MessageBox.Show(cname);

            //new formLogin().Show();
        }
    }
}
