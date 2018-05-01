namespace EpicLMSDesktopApp
{
    partial class AddCoursesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddCourses = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAllCourses = new System.Windows.Forms.Label();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.txtCCode = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.comboCHrs = new System.Windows.Forms.ComboBox();
            this.comboDept2 = new System.Windows.Forms.ComboBox();
            this.comboSem = new System.Windows.Forms.ComboBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddCourses
            // 
            this.lblAddCourses.AutoSize = true;
            this.lblAddCourses.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblAddCourses.Location = new System.Drawing.Point(277, 1);
            this.lblAddCourses.Name = "lblAddCourses";
            this.lblAddCourses.Size = new System.Drawing.Size(267, 49);
            this.lblAddCourses.TabIndex = 2;
            this.lblAddCourses.Text = "Add Courses";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView1.Location = new System.Drawing.Point(25, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(363, 225);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblAllCourses
            // 
            this.lblAllCourses.AutoSize = true;
            this.lblAllCourses.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblAllCourses.Location = new System.Drawing.Point(20, 59);
            this.lblAllCourses.Name = "lblAllCourses";
            this.lblAllCourses.Size = new System.Drawing.Size(243, 30);
            this.lblAllCourses.TabIndex = 3;
            this.lblAllCourses.Text = "All Existing Courses:";
            // 
            // comboDept
            // 
            this.comboDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.comboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDept.Font = new System.Drawing.Font("Verdana", 10F);
            this.comboDept.ForeColor = System.Drawing.Color.White;
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Location = new System.Drawing.Point(25, 92);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(363, 28);
            this.comboDept.TabIndex = 6;
            this.comboDept.SelectedIndexChanged += new System.EventHandler(this.comboDept_SelectedIndexChanged);
            // 
            // txtCCode
            // 
            this.txtCCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtCCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCode.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.txtCCode.ForeColor = System.Drawing.Color.White;
            this.txtCCode.Location = new System.Drawing.Point(429, 149);
            this.txtCCode.Margin = new System.Windows.Forms.Padding(8);
            this.txtCCode.Name = "txtCCode";
            this.txtCCode.Size = new System.Drawing.Size(344, 22);
            this.txtCCode.TabIndex = 11;
            this.txtCCode.Text = "course code";
            this.txtCCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCCode.Enter += new System.EventHandler(this.txtCCode_Enter);
            this.txtCCode.Leave += new System.EventHandler(this.txtCCode_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel2.Location = new System.Drawing.Point(415, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 41);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(410, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add New Course:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(415, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 41);
            this.panel1.TabIndex = 12;
            // 
            // txtCName
            // 
            this.txtCName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtCName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCName.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.txtCName.ForeColor = System.Drawing.Color.White;
            this.txtCName.Location = new System.Drawing.Point(429, 102);
            this.txtCName.Margin = new System.Windows.Forms.Padding(8);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(344, 22);
            this.txtCName.TabIndex = 11;
            this.txtCName.Text = "course name";
            this.txtCName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCName.Enter += new System.EventHandler(this.txtCName_Enter);
            this.txtCName.Leave += new System.EventHandler(this.txtCName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.label2.Location = new System.Drawing.Point(411, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "credit hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.label3.Location = new System.Drawing.Point(410, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "semester:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.label4.Location = new System.Drawing.Point(410, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "department:";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(414, 357);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(380, 36);
            this.btnAddCourse.TabIndex = 13;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // comboCHrs
            // 
            this.comboCHrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.comboCHrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCHrs.Font = new System.Drawing.Font("Verdana", 10F);
            this.comboCHrs.ForeColor = System.Drawing.Color.White;
            this.comboCHrs.FormattingEnabled = true;
            this.comboCHrs.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboCHrs.Location = new System.Drawing.Point(415, 209);
            this.comboCHrs.Name = "comboCHrs";
            this.comboCHrs.Size = new System.Drawing.Size(379, 28);
            this.comboCHrs.TabIndex = 14;
            // 
            // comboDept2
            // 
            this.comboDept2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.comboDept2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDept2.Font = new System.Drawing.Font("Verdana", 10F);
            this.comboDept2.ForeColor = System.Drawing.Color.White;
            this.comboDept2.FormattingEnabled = true;
            this.comboDept2.Location = new System.Drawing.Point(415, 323);
            this.comboDept2.Name = "comboDept2";
            this.comboDept2.Size = new System.Drawing.Size(379, 28);
            this.comboDept2.TabIndex = 14;
            // 
            // comboSem
            // 
            this.comboSem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.comboSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSem.Font = new System.Drawing.Font("Verdana", 10F);
            this.comboSem.ForeColor = System.Drawing.Color.White;
            this.comboSem.FormattingEnabled = true;
            this.comboSem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboSem.Location = new System.Drawing.Point(415, 266);
            this.comboSem.Name = "comboSem";
            this.comboSem.Size = new System.Drawing.Size(379, 28);
            this.comboSem.TabIndex = 14;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(624, 14);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(170, 36);
            this.btnLog.TabIndex = 13;
            this.btnLog.Text = "Course Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnRemoveCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCourse.FlatAppearance.BorderSize = 0;
            this.btnRemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCourse.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCourse.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCourse.Location = new System.Drawing.Point(25, 357);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(363, 36);
            this.btnRemoveCourse.TabIndex = 13;
            this.btnRemoveCourse.Text = "Delete Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = false;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // AddCoursesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboSem);
            this.Controls.Add(this.comboDept2);
            this.Controls.Add(this.comboCHrs);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboDept);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAllCourses);
            this.Controls.Add(this.lblAddCourses);
            this.Name = "AddCoursesControl";
            this.Size = new System.Drawing.Size(820, 409);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCourses;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAllCourses;
        private System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.TextBox txtCCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ComboBox comboCHrs;
        private System.Windows.Forms.ComboBox comboDept2;
        private System.Windows.Forms.ComboBox comboSem;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnRemoveCourse;

    }
}
