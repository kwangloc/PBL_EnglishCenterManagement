namespace PBL_EnglishCenter.View
{
    partial class mainFormTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormTeacher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_logout = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAnnTea = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bt_courseTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.bt_profile = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnTea)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_logout
            // 
            this.bt_logout.BorderRadius = 20;
            this.bt_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_logout.FillColor = System.Drawing.Color.Tomato;
            this.bt_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.ForeColor = System.Drawing.Color.White;
            this.bt_logout.Image = ((System.Drawing.Image)(resources.GetObject("bt_logout.Image")));
            this.bt_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_logout.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_logout.Location = new System.Drawing.Point(32, 455);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(180, 85);
            this.bt_logout.TabIndex = 14;
            this.bt_logout.Text = "   Logout";
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // dgvAnnTea
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAnnTea.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnnTea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnnTea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnnTea.ColumnHeadersHeight = 29;
            this.dgvAnnTea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnnTea.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAnnTea.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAnnTea.GridColor = System.Drawing.Color.White;
            this.dgvAnnTea.Location = new System.Drawing.Point(235, 126);
            this.dgvAnnTea.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAnnTea.Name = "dgvAnnTea";
            this.dgvAnnTea.RowHeadersVisible = false;
            this.dgvAnnTea.RowHeadersWidth = 51;
            this.dgvAnnTea.RowTemplate.Height = 24;
            this.dgvAnnTea.Size = new System.Drawing.Size(1267, 677);
            this.dgvAnnTea.TabIndex = 12;
            this.dgvAnnTea.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAnnTea.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAnnTea.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAnnTea.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAnnTea.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAnnTea.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAnnTea.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvAnnTea.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvAnnTea.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAnnTea.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAnnTea.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAnnTea.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAnnTea.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvAnnTea.ThemeStyle.ReadOnly = false;
            this.dgvAnnTea.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAnnTea.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAnnTea.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAnnTea.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAnnTea.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAnnTea.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAnnTea.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lb_fullname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_fullname.Location = new System.Drawing.Point(194, 24);
            this.lb_fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(228, 65);
            this.lb_fullname.TabIndex = 2;
            this.lb_fullname.Text = "fullname";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel1.Controls.Add(this.bt_courseTeacher);
            this.guna2Panel1.Controls.Add(this.bt_logout);
            this.guna2Panel1.Controls.Add(this.bt_profile);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 126);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(232, 677);
            this.guna2Panel1.TabIndex = 13;
            // 
            // bt_courseTeacher
            // 
            this.bt_courseTeacher.BorderRadius = 20;
            this.bt_courseTeacher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_courseTeacher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_courseTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_courseTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_courseTeacher.FillColor = System.Drawing.Color.CornflowerBlue;
            this.bt_courseTeacher.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_courseTeacher.ForeColor = System.Drawing.Color.White;
            this.bt_courseTeacher.Image = ((System.Drawing.Image)(resources.GetObject("bt_courseTeacher.Image")));
            this.bt_courseTeacher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_courseTeacher.Location = new System.Drawing.Point(32, 120);
            this.bt_courseTeacher.Name = "bt_courseTeacher";
            this.bt_courseTeacher.Size = new System.Drawing.Size(180, 85);
            this.bt_courseTeacher.TabIndex = 15;
            this.bt_courseTeacher.Text = "     My Course";
            this.bt_courseTeacher.Click += new System.EventHandler(this.bt_courseTeacher_Click);
            // 
            // bt_profile
            // 
            this.bt_profile.BorderRadius = 20;
            this.bt_profile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_profile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_profile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_profile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_profile.FillColor = System.Drawing.Color.CornflowerBlue;
            this.bt_profile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_profile.ForeColor = System.Drawing.Color.White;
            this.bt_profile.Image = ((System.Drawing.Image)(resources.GetObject("bt_profile.Image")));
            this.bt_profile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_profile.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_profile.Location = new System.Drawing.Point(32, 290);
            this.bt_profile.Name = "bt_profile";
            this.bt_profile.Size = new System.Drawing.Size(180, 85);
            this.bt_profile.TabIndex = 14;
            this.bt_profile.Text = "   Profile";
            this.bt_profile.Click += new System.EventHandler(this.bt_profile_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Controls.Add(this.lb_fullname);
            this.guna2Panel2.Location = new System.Drawing.Point(233, -2);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1269, 126);
            this.guna2Panel2.TabIndex = 14;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Tomato;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1224, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 9;
            this.guna2ControlBox1.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(80, 80);
            this.guna2Button1.Location = new System.Drawing.Point(76, 13);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(76, 73);
            this.guna2Button1.TabIndex = 6;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.guna2Button1);
            this.guna2Panel3.Location = new System.Drawing.Point(-2, 1);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(232, 123);
            this.guna2Panel3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(58, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "English Center";
            // 
            // mainFormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.dgvAnnTea);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainFormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainFormTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnTea)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button bt_logout;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAnnTea;
        private System.Windows.Forms.Label lb_fullname;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button bt_courseTeacher;
        private Guna.UI2.WinForms.Guna2Button bt_profile;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label4;
    }
}