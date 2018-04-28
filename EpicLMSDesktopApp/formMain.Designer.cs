namespace EpicLMSDesktopApp
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCourses = new System.Windows.Forms.Button();
            this.btnManageCourses = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTime = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.homeControl1 = new EpicLMSDesktopApp.HomeControl();
            this.profile1 = new EpicLMSDesktopApp.Profile();
            this.addCoursesControl1 = new EpicLMSDesktopApp.AddCoursesControl();
            this.manageCoursesControl1 = new EpicLMSDesktopApp.ManageCoursesControl();
            this.peopleControl1 = new EpicLMSDesktopApp.PeopleControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btnAddCourses);
            this.panel1.Controls.Add(this.btnManageCourses);
            this.panel1.Controls.Add(this.btnPeople);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 559);
            this.panel1.TabIndex = 1;
            // 
            // btnAddCourses
            // 
            this.btnAddCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCourses.FlatAppearance.BorderSize = 0;
            this.btnAddCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourses.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourses.ForeColor = System.Drawing.Color.White;
            this.btnAddCourses.Location = new System.Drawing.Point(11, 344);
            this.btnAddCourses.Name = "btnAddCourses";
            this.btnAddCourses.Size = new System.Drawing.Size(188, 66);
            this.btnAddCourses.TabIndex = 0;
            this.btnAddCourses.Text = "Add Courses";
            this.btnAddCourses.UseVisualStyleBackColor = true;
            this.btnAddCourses.Click += new System.EventHandler(this.btnAddCourses_Click);
            // 
            // btnManageCourses
            // 
            this.btnManageCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCourses.FlatAppearance.BorderSize = 0;
            this.btnManageCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCourses.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCourses.ForeColor = System.Drawing.Color.White;
            this.btnManageCourses.Location = new System.Drawing.Point(11, 274);
            this.btnManageCourses.Name = "btnManageCourses";
            this.btnManageCourses.Size = new System.Drawing.Size(188, 66);
            this.btnManageCourses.TabIndex = 0;
            this.btnManageCourses.Text = "Manage Courses";
            this.btnManageCourses.UseVisualStyleBackColor = true;
            this.btnManageCourses.Click += new System.EventHandler(this.btnManageCourses_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.White;
            this.btnPeople.Location = new System.Drawing.Point(11, 204);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(188, 66);
            this.btnPeople.TabIndex = 0;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "EpicLMS";
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(12, 134);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(188, 66);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(12, 64);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(188, 66);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtTime);
            this.panel2.Controls.Add(this.txtDept);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 132);
            this.panel2.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(744, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 38);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(788, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(125, 79);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(61, 25);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "Time";
            // 
            // txtDept
            // 
            this.txtDept.AutoSize = true;
            this.txtDept.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtDept.ForeColor = System.Drawing.Color.White;
            this.txtDept.Location = new System.Drawing.Point(125, 54);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(132, 25);
            this.txtDept.TabIndex = 0;
            this.txtDept.Text = "Department";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(125, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 29);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Firstname Lastname";
            // 
            // homeControl1
            // 
            this.homeControl1.Location = new System.Drawing.Point(208, 141);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(820, 409);
            this.homeControl1.TabIndex = 3;
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(208, 141);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(820, 409);
            this.profile1.TabIndex = 4;
            // 
            // addCoursesControl1
            // 
            this.addCoursesControl1.Location = new System.Drawing.Point(208, 138);
            this.addCoursesControl1.Name = "addCoursesControl1";
            this.addCoursesControl1.Size = new System.Drawing.Size(820, 409);
            this.addCoursesControl1.TabIndex = 7;
            // 
            // manageCoursesControl1
            // 
            this.manageCoursesControl1.Location = new System.Drawing.Point(208, 141);
            this.manageCoursesControl1.Name = "manageCoursesControl1";
            this.manageCoursesControl1.Size = new System.Drawing.Size(820, 409);
            this.manageCoursesControl1.TabIndex = 6;
            // 
            // peopleControl1
            // 
            this.peopleControl1.Location = new System.Drawing.Point(208, 137);
            this.peopleControl1.Name = "peopleControl1";
            this.peopleControl1.Size = new System.Drawing.Size(820, 409);
            this.peopleControl1.TabIndex = 5;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.addCoursesControl1);
            this.Controls.Add(this.manageCoursesControl1);
            this.Controls.Add(this.peopleControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Label txtDept;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button btnAddCourses;
        private System.Windows.Forms.Button btnManageCourses;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnExit;
        private Profile profile1;
        private PeopleControl peopleControl1;
        private ManageCoursesControl manageCoursesControl1;
        private AddCoursesControl addCoursesControl1;
        private HomeControl homeControl1;
    }
}