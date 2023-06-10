namespace PBL_EnglishCenter.View
{
    partial class courseViewStudent
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
            this.dgv_courseStu = new System.Windows.Forms.DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseStu)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Location = new System.Drawing.Point(975, 51);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(57, 16);
            this.lb_fullname.TabIndex = 11;
            this.lb_fullname.Text = "fullname";
            // 
            // bt_viewCourseDetails
            // 
            this.bt_viewCourseDetails.Location = new System.Drawing.Point(1102, 255);
            this.bt_viewCourseDetails.Name = "bt_viewCourseDetails";
            this.bt_viewCourseDetails.Size = new System.Drawing.Size(152, 40);
            this.bt_viewCourseDetails.TabIndex = 5;
            this.bt_viewCourseDetails.Text = "View Course Details";
            this.bt_viewCourseDetails.UseVisualStyleBackColor = true;
            this.bt_viewCourseDetails.Click += new System.EventHandler(this.bt_viewCourseDetails_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(32, 494);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(119, 29);
            this.bt_exit.TabIndex = 9;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // dgv_courseStu
            // 
            this.dgv_courseStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_courseStu.Location = new System.Drawing.Point(90, 132);
            this.dgv_courseStu.Name = "dgv_courseStu";
            this.dgv_courseStu.RowHeadersWidth = 51;
            this.dgv_courseStu.RowTemplate.Height = 24;
            this.dgv_courseStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_courseStu.Size = new System.Drawing.Size(995, 327);
            this.dgv_courseStu.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(374, 552);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(183, 46);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // courseViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.bt_viewCourseDetails);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.dgv_courseStu);
            this.Name = "courseViewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "courseViewStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Button bt_viewCourseDetails;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.DataGridView dgv_courseStu;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}