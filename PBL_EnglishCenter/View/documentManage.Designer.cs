namespace PBL_EnglishCenter.View
{
    partial class documentManage
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_courseId = new System.Windows.Forms.Label();
            this.rtb_des = new System.Windows.Forms.RichTextBox();
            this.tb_courseName = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.lb_des = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.bt_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.bt_ok = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_function
            // 
            this.lb_function.AutoSize = true;
            this.lb_function.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_function.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_function.Location = new System.Drawing.Point(63, 11);
            this.lb_function.Name = "lb_function";
            this.lb_function.Size = new System.Drawing.Size(570, 81);
            this.lb_function.TabIndex = 7;
            this.lb_function.Text = "Manage Document";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel2.Controls.Add(this.lb_courseId);
            this.guna2Panel2.Controls.Add(this.rtb_des);
            this.guna2Panel2.Controls.Add(this.tb_courseName);
            this.guna2Panel2.Controls.Add(this.tb_title);
            this.guna2Panel2.Controls.Add(this.lb_des);
            this.guna2Panel2.Controls.Add(this.lb_title);
            this.guna2Panel2.Controls.Add(this.bt_cancel);
            this.guna2Panel2.Controls.Add(this.bt_ok);
            this.guna2Panel2.Location = new System.Drawing.Point(2, 109);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(746, 642);
            this.guna2Panel2.TabIndex = 15;
            // 
            // lb_courseId
            // 
            this.lb_courseId.AutoSize = true;
            this.lb_courseId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_courseId.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_courseId.Location = new System.Drawing.Point(61, 121);
            this.lb_courseId.Name = "lb_courseId";
            this.lb_courseId.Size = new System.Drawing.Size(93, 31);
            this.lb_courseId.TabIndex = 19;
            this.lb_courseId.Text = "Course:";
            // 
            // rtb_des
            // 
            this.rtb_des.Location = new System.Drawing.Point(154, 241);
            this.rtb_des.Name = "rtb_des";
            this.rtb_des.Size = new System.Drawing.Size(558, 181);
            this.rtb_des.TabIndex = 18;
            this.rtb_des.Text = "";
            // 
            // tb_courseName
            // 
            this.tb_courseName.Location = new System.Drawing.Point(154, 130);
            this.tb_courseName.Name = "tb_courseName";
            this.tb_courseName.Size = new System.Drawing.Size(272, 22);
            this.tb_courseName.TabIndex = 16;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(154, 179);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(558, 22);
            this.tb_title.TabIndex = 17;
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_des.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_des.Location = new System.Drawing.Point(10, 241);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(144, 31);
            this.lb_des.TabIndex = 14;
            this.lb_des.Text = "Description:";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_title.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_title.Location = new System.Drawing.Point(86, 170);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(68, 31);
            this.lb_title.TabIndex = 15;
            this.lb_title.Text = "Title:";
            // 
            // bt_cancel
            // 
            this.bt_cancel.BorderRadius = 22;
            this.bt_cancel.BorderThickness = 1;
            this.bt_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_cancel.FillColor = System.Drawing.Color.CornflowerBlue;
            this.bt_cancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.bt_cancel.ForeColor = System.Drawing.Color.White;
            this.bt_cancel.Location = new System.Drawing.Point(394, 479);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(203, 62);
            this.bt_cancel.TabIndex = 9;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.BorderRadius = 22;
            this.bt_ok.BorderThickness = 1;
            this.bt_ok.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_ok.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_ok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_ok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_ok.FillColor = System.Drawing.Color.CornflowerBlue;
            this.bt_ok.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.bt_ok.ForeColor = System.Drawing.Color.White;
            this.bt_ok.Location = new System.Drawing.Point(133, 479);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(203, 62);
            this.bt_ok.TabIndex = 11;
            this.bt_ok.Text = "OK";
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel1.Controls.Add(this.lb_function);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(746, 100);
            this.guna2Panel1.TabIndex = 14;
            // 
            // documentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "documentManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "documentManage";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_function;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lb_courseId;
        private System.Windows.Forms.RichTextBox rtb_des;
        private System.Windows.Forms.TextBox tb_courseName;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.Label lb_title;
        private Guna.UI2.WinForms.Guna2Button bt_cancel;
        private Guna.UI2.WinForms.Guna2Button bt_ok;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}