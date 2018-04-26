namespace EpicLMSDesktopApp
{
    partial class courseViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xGrid = new System.Windows.Forms.DataGridView();
            this.lblCName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // xGrid
            // 
            this.xGrid.AllowUserToAddRows = false;
            this.xGrid.AllowUserToDeleteRows = false;
            this.xGrid.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.xGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.xGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.xGrid.GridColor = System.Drawing.Color.SteelBlue;
            this.xGrid.Location = new System.Drawing.Point(12, 55);
            this.xGrid.Name = "xGrid";
            this.xGrid.ReadOnly = true;
            this.xGrid.RowTemplate.Height = 24;
            this.xGrid.Size = new System.Drawing.Size(842, 364);
            this.xGrid.TabIndex = 0;
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Font = new System.Drawing.Font("Century Gothic", 21.2F);
            this.lblCName.Location = new System.Drawing.Point(12, 9);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(261, 43);
            this.lblCName.TabIndex = 1;
            this.lblCName.Text = "Course Name";
            // 
            // courseViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 432);
            this.Controls.Add(this.xGrid);
            this.Controls.Add(this.lblCName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "courseViewForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "courseViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView xGrid;
        private System.Windows.Forms.Label lblCName;

    }
}