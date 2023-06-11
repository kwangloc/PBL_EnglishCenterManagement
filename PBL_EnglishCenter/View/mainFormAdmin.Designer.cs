namespace PBL_EnglishCenter.View
{
    partial class mainFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bt_logout = new Guna.UI2.WinForms.Guna2Button();
            this.bt_courseAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.bt_profile = new Guna.UI2.WinForms.Guna2Button();
            this.bt_accountAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAnnAdm = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnAdm)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_fullname.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lb_fullname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_fullname.Location = new System.Drawing.Point(259, 30);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(285, 83);
            this.lb_fullname.TabIndex = 2;
            this.lb_fullname.Text = "fullname";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel1.Controls.Add(this.bt_logout);
            this.guna2Panel1.Controls.Add(this.bt_courseAdmin);
            this.guna2Panel1.Controls.Add(this.bt_profile);
            this.guna2Panel1.Controls.Add(this.bt_accountAdmin);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 153);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(309, 833);
            this.guna2Panel1.TabIndex = 4;
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
            this.bt_logout.Location = new System.Drawing.Point(43, 636);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(240, 105);
            this.bt_logout.TabIndex = 14;
            this.bt_logout.Text = "   Logout";
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_courseAdmin
            // 
            this.bt_courseAdmin.BorderRadius = 20;
            this.bt_courseAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_courseAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_courseAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_courseAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_courseAdmin.FillColor = System.Drawing.Color.CornflowerBlue;
            this.bt_courseAdmin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_courseAdmin.ForeColor = System.Drawing.Color.White;
            this.bt_courseAdmin.Image = ((System.Drawing.Image)(resources.GetObject("bt_courseAdmin.Image")));
            this.bt_courseAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_courseAdmin.Location = new System.Drawing.Point(43, 90);
            this.bt_courseAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_courseAdmin.Name = "bt_courseAdmin";
            this.bt_courseAdmin.Size = new System.Drawing.Size(240, 105);
            this.bt_courseAdmin.TabIndex = 14;
            this.bt_courseAdmin.Text = "       Manage       Course";
            this.bt_courseAdmin.Click += new System.EventHandler(this.bt_courseAdmin_Click);
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
            this.bt_profile.Location = new System.Drawing.Point(43, 460);
            this.bt_profile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_profile.Name = "bt_profile";
            this.bt_profile.Size = new System.Drawing.Size(240, 105);
            this.bt_profile.TabIndex = 14;
            this.bt_profile.Text = "   Profile";
            this.bt_profile.Click += new System.EventHandler(this.bt_profile_Click);
            // 
            // bt_accountAdmin
            // 
            this.bt_accountAdmin.BorderRadius = 20;
            this.bt_accountAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_accountAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_accountAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_accountAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_accountAdmin.FillColor = System.Drawing.Color.CornflowerBlue;
            this.bt_accountAdmin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_accountAdmin.ForeColor = System.Drawing.Color.White;
            this.bt_accountAdmin.Image = ((System.Drawing.Image)(resources.GetObject("bt_accountAdmin.Image")));
            this.bt_accountAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_accountAdmin.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_accountAdmin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.bt_accountAdmin.Location = new System.Drawing.Point(43, 277);
            this.bt_accountAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_accountAdmin.Name = "bt_accountAdmin";
            this.bt_accountAdmin.Size = new System.Drawing.Size(240, 105);
            this.bt_accountAdmin.TabIndex = 14;
            this.bt_accountAdmin.Text = "       Manage          Account";
            this.bt_accountAdmin.Click += new System.EventHandler(this.bt_accountAdmin_Click);
            // 
            // dgvAnnAdm
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAnnAdm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnnAdm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAnnAdm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnnAdm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnnAdm.ColumnHeadersHeight = 29;
            this.dgvAnnAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnnAdm.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAnnAdm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAnnAdm.GridColor = System.Drawing.Color.White;
            this.dgvAnnAdm.Location = new System.Drawing.Point(312, 153);
            this.dgvAnnAdm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAnnAdm.Name = "dgvAnnAdm";
            this.dgvAnnAdm.RowHeadersVisible = false;
            this.dgvAnnAdm.RowHeadersWidth = 51;
            this.dgvAnnAdm.RowTemplate.Height = 24;
            this.dgvAnnAdm.Size = new System.Drawing.Size(1689, 833);
            this.dgvAnnAdm.TabIndex = 1;
            this.dgvAnnAdm.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAnnAdm.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAnnAdm.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAnnAdm.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAnnAdm.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAnnAdm.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAnnAdm.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvAnnAdm.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvAnnAdm.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAnnAdm.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAnnAdm.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAnnAdm.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAnnAdm.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvAnnAdm.ThemeStyle.ReadOnly = false;
            this.dgvAnnAdm.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAnnAdm.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAnnAdm.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAnnAdm.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAnnAdm.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAnnAdm.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAnnAdm.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Controls.Add(this.lb_fullname);
            this.guna2Panel2.Location = new System.Drawing.Point(311, -5);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1689, 155);
            this.guna2Panel2.TabIndex = 5;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Tomato;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1629, 4);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
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
            this.guna2Button1.Location = new System.Drawing.Point(101, 16);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(101, 90);
            this.guna2Button1.TabIndex = 6;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.guna2Button1);
            this.guna2Panel3.Location = new System.Drawing.Point(-1, -1);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(309, 151);
            this.guna2Panel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(77, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "English Center";
            // 
            // mainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1924, 985);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.dgvAnnAdm);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "mainFormAdmin";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnAdm)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_fullname;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAnnAdm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button bt_accountAdmin;
        private Guna.UI2.WinForms.Guna2Button bt_logout;
        private Guna.UI2.WinForms.Guna2Button bt_courseAdmin;
        private Guna.UI2.WinForms.Guna2Button bt_profile;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label4;
    }
}