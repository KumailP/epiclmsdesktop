namespace EpicLMSDesktopApp
{
    partial class PeopleControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.xGrid = new System.Windows.Forms.DataGridView();
            this.lblRefresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label1.Location = new System.Drawing.Point(325, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "People:";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTitle.Location = new System.Drawing.Point(15, 82);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(379, 23);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "Students of DEPARTMENT - Semester ?:";
            // 
            // xGrid
            // 
            this.xGrid.AllowUserToAddRows = false;
            this.xGrid.AllowUserToDeleteRows = false;
            this.xGrid.BackgroundColor = System.Drawing.Color.White;
            this.xGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xGrid.Location = new System.Drawing.Point(0, 110);
            this.xGrid.Name = "xGrid";
            this.xGrid.ReadOnly = true;
            this.xGrid.RowTemplate.Height = 24;
            this.xGrid.Size = new System.Drawing.Size(820, 299);
            this.xGrid.TabIndex = 3;
            // 
            // lblRefresh
            // 
            this.lblRefresh.AutoSize = true;
            this.lblRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRefresh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefresh.Location = new System.Drawing.Point(734, 84);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(69, 21);
            this.lblRefresh.TabIndex = 4;
            this.lblRefresh.Text = "Refresh";
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // PeopleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.xGrid);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "PeopleControl";
            this.Size = new System.Drawing.Size(820, 409);
            ((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.DataGridView xGrid;
        private System.Windows.Forms.Label lblRefresh;
    }
}
