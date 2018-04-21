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
    }
}
