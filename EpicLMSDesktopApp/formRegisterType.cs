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
    public partial class formRegisterType : Form
    {
        public formRegisterType()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            formRegisterStudent frmRegStudent = new formRegisterStudent();
            this.Hide();
            frmRegStudent.Show();
        }

        private void STUDENT_MouseClick(object sender, MouseEventArgs e)
        {
            formRegisterStudent frmRegStudent = new formRegisterStudent();
            this.Hide();
            frmRegStudent.Show();
        }

        private void FACULTY_Click(object sender, EventArgs e)
        {
            formRegisterFaculty frmRegFaculty = new formRegisterFaculty();
            this.Hide();
            frmRegFaculty.Show();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            formRegisterFaculty frmRegFaculty = new formRegisterFaculty();
            this.Hide();
            frmRegFaculty.Show();
        }
    }
}
