using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EpicLMSDesktopApp
{
    public partial class formMain : Form
    {   
        public User user = new User();
        private System.Drawing.Color activeColor = ColorTranslator.FromHtml("#4682b4");
        private System.Drawing.Color inactiveColor = ColorTranslator.FromHtml("#303030");


        public formMain(formLogin frm)
        {
            InitializeComponent();
            user = frm.user1;
        }


        private void formMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("user_id: " + user.user_id + "\nName: " + user.fname + " " + user.lname + "\nEmail: " + user.email + "\nDept_Id: " + user.dept_id + "\nSemester: " + user.semester);
            txtTime.Text = DateTime.Now.ToString("dd MMM, yyyy");
            txtName.Text = (user.fname + " " + user.lname).ToString();
            if (user.dept_id == 1)
            {
                user.dept_name = "Computer Science";
            }
            else if (user.dept_id == 2)
            {
                user.dept_name = "Mechanical Engineering";
            }
            else if (user.dept_id == 3)
            {
                user.dept_name = "Electrical Engineering";
            }
            else if (user.dept_id == 4)
            {
                user.dept_name = "Bachelors in Business Administration";
            }
            txtDept.Text = user.dept_name;
            if (user.usertype == 1)
            {
                btnAddCourses.Hide();
                addCoursesControl1.Hide();
            }
            homeControl1.setUser(user);

            if (user.usertype == 2)
            {
                btnPeople.Hide();
                btnAddCourses.Location = btnManageCourses.Location;
                btnManageCourses.Location = btnPeople.Location;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeControl hc1 = new HomeControl();
            this.Controls.Add(hc1);
            hc1.setUser(user);
            hc1.Location = new Point(155, 115);
            hc1.Size = new Size(820, 409);
            hc1.BringToFront();
            homeControl1.Visible = false;
            
            btnHome.BackColor = activeColor;
            btnProfile.BackColor = inactiveColor;
            btnPeople.BackColor = inactiveColor;
            btnManageCourses.BackColor = inactiveColor;
            btnAddCourses.BackColor = inactiveColor;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profile1.setUser(user);
            profile1.BringToFront();
            btnProfile.BackColor = activeColor;
            btnHome.BackColor = inactiveColor;
            btnPeople.BackColor = inactiveColor;
            btnManageCourses.BackColor = inactiveColor;
            btnAddCourses.BackColor = inactiveColor;
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            peopleControl1.setUser(user);
            peopleControl1.BringToFront();
            btnPeople.BackColor = activeColor;
            btnProfile.BackColor = inactiveColor;
            btnHome.BackColor = inactiveColor;
            btnManageCourses.BackColor = inactiveColor;
            btnAddCourses.BackColor = inactiveColor;
        }

        private void btnManageCourses_Click(object sender, EventArgs e)
        {
            ManageCoursesControl mc = new ManageCoursesControl();
            this.Controls.Add(mc);
            mc.setUser(user);
            mc.Location = new Point(155, 115);
            mc.Size = new Size(820, 409);
            mc.BringToFront();
            mc.setUser(user);

            btnManageCourses.BackColor = activeColor;
            btnPeople.BackColor = inactiveColor;
            btnProfile.BackColor = inactiveColor;
            btnHome.BackColor = inactiveColor;
            btnAddCourses.BackColor = inactiveColor;
        }

        private void btnAddCourses_Click(object sender, EventArgs e)
        {
            addCoursesControl1.setUser(user);
            addCoursesControl1.BringToFront();
            btnManageCourses.BackColor = inactiveColor;
            btnPeople.BackColor = inactiveColor;
            btnProfile.BackColor = inactiveColor;
            btnHome.BackColor = inactiveColor;
            btnAddCourses.BackColor = activeColor;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            formLogin frmLogin = new formLogin();
            frmLogin.Show();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
