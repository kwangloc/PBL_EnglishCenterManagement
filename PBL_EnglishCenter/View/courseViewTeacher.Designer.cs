namespace PBL_EnglishCenter.View
{
    partial class courseViewTeacher
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
            this.lb_fullname = new System.Windows.Forms.Label();
            this.bt_viewCourseDetails = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.dgv_courseTea = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseTea)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Location = new System.Drawing.Point(899, 51);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(57, 16);
            this.lb_fullname.TabIndex = 15;
            this.lb_fullname.Text = "fullname";
            // 
            // bt_viewCourseDetails
            // 
            this.bt_viewCourseDetails.Location = new System.Drawing.Point(1035, 265);
            this.bt_viewCourseDetails.Name = "bt_viewCourseDetails";
            this.bt_viewCourseDetails.Size = new System.Drawing.Size(119, 48);
            this.bt_viewCourseDetails.TabIndex = 13;
            this.bt_viewCourseDetails.Text = "View course details";
            this.bt_viewCourseDetails.UseVisualStyleBackColor = true;
            this.bt_viewCourseDetails.Click += new System.EventHandler(this.bt_viewCourseDetails_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(511, 487);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(119, 29);
            this.bt_exit.TabIndex = 14;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // dgv_courseTea
            // 
            this.dgv_courseTea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_courseTea.Location = new System.Drawing.Point(167, 132);
            this.dgv_courseTea.Name = "dgv_courseTea";
            this.dgv_courseTea.RowHeadersWidth = 51;
            this.dgv_courseTea.RowTemplate.Height = 24;
            this.dgv_courseTea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_courseTea.Size = new System.Drawing.Size(842, 327);
            this.dgv_courseTea.TabIndex = 12;
            // 
            // courseViewTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.bt_viewCourseDetails);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.dgv_courseTea);
            this.Name = "courseViewTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "courseViewTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseTea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Button bt_viewCourseDetails;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.DataGridView dgv_courseTea;
    }
}