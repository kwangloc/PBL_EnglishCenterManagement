namespace PBL_EnglishCenter.View
{
    partial class announcementManage
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
            this.lb_function = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lb_courseId = new System.Windows.Forms.Label();
            this.rtb_des = new System.Windows.Forms.RichTextBox();
            this.tb_courseName = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.lb_des = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_function
            // 
            this.lb_function.AutoSize = true;
            this.lb_function.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_function.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_function.Location = new System.Drawing.Point(18, 11);
            this.lb_function.Name = "lb_function";
            this.lb_function.Size = new System.Drawing.Size(708, 81);
            this.lb_function.TabIndex = 0;
            this.lb_function.Text = "Manage Announcement";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel1.Controls.Add(this.lb_function);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(746, 100);
            this.guna2Panel1.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel2.Controls.Add(this.guna2Button2);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.lb_courseId);
            this.guna2Panel2.Controls.Add(this.rtb_des);
            this.guna2Panel2.Controls.Add(this.tb_courseName);
            this.guna2Panel2.Controls.Add(this.tb_title);
            this.guna2Panel2.Controls.Add(this.lb_des);
            this.guna2Panel2.Controls.Add(this.lb_title);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 109);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(746, 642);
            this.guna2Panel2.TabIndex = 6;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 22;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(379, 461);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(194, 66);
            this.guna2Button2.TabIndex = 9;
            this.guna2Button2.Text = "Cancel";
            this.guna2Button2.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(118, 461);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(194, 66);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "OK";
            this.guna2Button1.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // lb_courseId
            // 
            this.lb_courseId.AutoSize = true;
            this.lb_courseId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_courseId.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_courseId.Location = new System.Drawing.Point(55, 132);
            this.lb_courseId.Name = "lb_courseId";
            this.lb_courseId.Size = new System.Drawing.Size(93, 31);
            this.lb_courseId.TabIndex = 14;
            this.lb_courseId.Text = "Course:";
            // 
            // rtb_des
            // 
            this.rtb_des.Location = new System.Drawing.Point(154, 236);
            this.rtb_des.Name = "rtb_des";
            this.rtb_des.Size = new System.Drawing.Size(558, 181);
            this.rtb_des.TabIndex = 10;
            this.rtb_des.Text = "";
            // 
            // tb_courseName
            // 
            this.tb_courseName.Location = new System.Drawing.Point(154, 141);
            this.tb_courseName.Name = "tb_courseName";
            this.tb_courseName.Size = new System.Drawing.Size(272, 22);
            this.tb_courseName.TabIndex = 7;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(154, 190);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(558, 22);
            this.tb_title.TabIndex = 8;
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_des.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_des.Location = new System.Drawing.Point(9, 236);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(144, 31);
            this.lb_des.TabIndex = 5;
            this.lb_des.Text = "Description:";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_title.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_title.Location = new System.Drawing.Point(80, 181);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(68, 31);
            this.lb_title.TabIndex = 6;
            this.lb_title.Text = "Title:";
            // 
            // announcementManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "announcementManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "announcementManage";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_function;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lb_courseId;
        private System.Windows.Forms.RichTextBox rtb_des;
        private System.Windows.Forms.TextBox tb_courseName;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.Label lb_title;
    }
}