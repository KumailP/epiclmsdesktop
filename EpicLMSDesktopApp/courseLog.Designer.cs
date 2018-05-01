namespace EpicLMSDesktopApp
{
    partial class courseLog
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
            this.gridCourseLog = new System.Windows.Forms.DataGridView();
            this.lblCourseLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseLog)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCourseLog
            // 
            this.gridCourseLog.AllowUserToAddRows = false;
            this.gridCourseLog.AllowUserToDeleteRows = false;
            this.gridCourseLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourseLog.Location = new System.Drawing.Point(12, 55);
            this.gridCourseLog.Name = "gridCourseLog";
            this.gridCourseLog.ReadOnly = true;
            this.gridCourseLog.RowTemplate.Height = 24;
            this.gridCourseLog.Size = new System.Drawing.Size(578, 382);
            this.gridCourseLog.TabIndex = 0;
            // 
            // lblCourseLog
            // 
            this.lblCourseLog.AutoSize = true;
            this.lblCourseLog.Font = new System.Drawing.Font("Century Gothic", 21F);
            this.lblCourseLog.Location = new System.Drawing.Point(84, 9);
            this.lblCourseLog.Name = "lblCourseLog";
            this.lblCourseLog.Size = new System.Drawing.Size(434, 42);
            this.lblCourseLog.TabIndex = 1;
            this.lblCourseLog.Text = "Course Modification Log";
            // 
            // courseLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 449);
            this.Controls.Add(this.lblCourseLog);
            this.Controls.Add(this.gridCourseLog);
            this.Name = "courseLog";
            this.ShowIcon = false;
            this.Text = "Course Modification Log";
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCourseLog;
        private System.Windows.Forms.Label lblCourseLog;
    }
}