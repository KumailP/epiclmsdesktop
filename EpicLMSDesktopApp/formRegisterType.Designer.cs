namespace EpicLMSDesktopApp
{
    partial class formRegisterType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.STUDENT = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FACULTY = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "EpicLMS - Register";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.STUDENT);
            this.panel1.Location = new System.Drawing.Point(77, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 69);
            this.panel1.TabIndex = 6;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // STUDENT
            // 
            this.STUDENT.AutoSize = true;
            this.STUDENT.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STUDENT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.STUDENT.Location = new System.Drawing.Point(100, 16);
            this.STUDENT.Name = "STUDENT";
            this.STUDENT.Size = new System.Drawing.Size(171, 36);
            this.STUDENT.TabIndex = 7;
            this.STUDENT.Text = "STUDENT";
            this.STUDENT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.STUDENT_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.FACULTY);
            this.panel2.Location = new System.Drawing.Point(77, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 69);
            this.panel2.TabIndex = 8;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // FACULTY
            // 
            this.FACULTY.AutoSize = true;
            this.FACULTY.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FACULTY.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FACULTY.Location = new System.Drawing.Point(100, 16);
            this.FACULTY.Name = "FACULTY";
            this.FACULTY.Size = new System.Drawing.Size(170, 36);
            this.FACULTY.TabIndex = 7;
            this.FACULTY.Text = "TEACHER";
            this.FACULTY.Click += new System.EventHandler(this.FACULTY_Click);
            // 
            // formRegisterType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(537, 282);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRegisterType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRegister";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label STUDENT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FACULTY;
    }
}