namespace PBL_EnglishCenter.View
{
    partial class courseViewAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_searchbyname = new System.Windows.Forms.Label();
            this.lb_searchbystatus = new System.Windows.Forms.Label();
            this.lb_coursemanage = new System.Windows.Forms.Label();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.bt_exit = new System.Windows.Forms.Button();
            this.dgv_courseadmin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bt_search = new Guna.UI2.WinForms.Guna2Button();
            this.bt_viewDetails = new Guna.UI2.WinForms.Guna2Button();
            this.bt_delete = new Guna.UI2.WinForms.Guna2Button();
            this.bt_create = new Guna.UI2.WinForms.Guna2Button();
            this.cbb_searchStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbb_searchLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_searchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gb_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Location = new System.Drawing.Point(776, 18);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(57, 16);
            this.lb_fullname.TabIndex = 3;
            this.lb_fullname.Text = "fullname";
            // 
            // lb_searchbyname
            // 
            this.lb_searchbyname.AutoSize = true;
            this.lb_searchbyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_searchbyname.Location = new System.Drawing.Point(24, 86);
            this.lb_searchbyname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_searchbyname.Name = "lb_searchbyname";
            this.lb_searchbyname.Size = new System.Drawing.Size(98, 25);
            this.lb_searchbyname.TabIndex = 17;
            this.lb_searchbyname.Text = "By Name:";
            // 
            // lb_searchbystatus
            // 
            this.lb_searchbystatus.AutoSize = true;
            this.lb_searchbystatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_searchbystatus.Location = new System.Drawing.Point(24, 43);
            this.lb_searchbystatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_searchbystatus.Name = "lb_searchbystatus";
            this.lb_searchbystatus.Size = new System.Drawing.Size(102, 25);
            this.lb_searchbystatus.TabIndex = 17;
            this.lb_searchbystatus.Text = "By Status:";
            // 
            // lb_coursemanage
            // 
            this.lb_coursemanage.AutoSize = true;
            this.lb_coursemanage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_coursemanage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_coursemanage.Location = new System.Drawing.Point(383, 40);
            this.lb_coursemanage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_coursemanage.Name = "lb_coursemanage";
            this.lb_coursemanage.Size = new System.Drawing.Size(300, 44);
            this.lb_coursemanage.TabIndex = 30;
            this.lb_coursemanage.Text = "Course Manage";
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.tb_searchName);
            this.gb_search.Controls.Add(this.label2);
            this.gb_search.Controls.Add(this.cbb_searchLocation);
            this.gb_search.Controls.Add(this.label1);
            this.gb_search.Controls.Add(this.cbb_searchStatus);
            this.gb_search.Controls.Add(this.bt_search);
            this.gb_search.Controls.Add(this.lb_searchbyname);
            this.gb_search.Controls.Add(this.lb_searchbystatus);
            this.gb_search.Location = new System.Drawing.Point(977, 94);
            this.gb_search.Margin = new System.Windows.Forms.Padding(4);
            this.gb_search.Name = "gb_search";
            this.gb_search.Padding = new System.Windows.Forms.Padding(4);
            this.gb_search.Size = new System.Drawing.Size(640, 296);
            this.gb_search.TabIndex = 28;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "By Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "By Name:";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(611, 768);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(127, 58);
            this.bt_exit.TabIndex = 2;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // dgv_courseadmin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_courseadmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_courseadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_courseadmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_courseadmin.ColumnHeadersHeight = 29;
            this.dgv_courseadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_courseadmin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_courseadmin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_courseadmin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_courseadmin.Location = new System.Drawing.Point(41, 155);
            this.dgv_courseadmin.Name = "dgv_courseadmin";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_courseadmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_courseadmin.RowHeadersVisible = false;
            this.dgv_courseadmin.RowHeadersWidth = 51;
            this.dgv_courseadmin.RowTemplate.Height = 24;
            this.dgv_courseadmin.Size = new System.Drawing.Size(908, 559);
            this.dgv_courseadmin.TabIndex = 32;
            this.dgv_courseadmin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_courseadmin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_courseadmin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_courseadmin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_courseadmin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_courseadmin.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_courseadmin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_courseadmin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgv_courseadmin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_courseadmin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_courseadmin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_courseadmin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_courseadmin.ThemeStyle.HeaderStyle.Height = 29;
            this.dgv_courseadmin.ThemeStyle.ReadOnly = false;
            this.dgv_courseadmin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_courseadmin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_courseadmin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_courseadmin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_courseadmin.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_courseadmin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_courseadmin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.White;
            this.bt_search.BorderRadius = 22;
            this.bt_search.BorderThickness = 1;
            this.bt_search.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.bt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_search.ForeColor = System.Drawing.Color.Black;
            this.bt_search.Location = new System.Drawing.Point(325, 194);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(200, 36);
            this.bt_search.TabIndex = 18;
            this.bt_search.Text = "Search";
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_viewDetails
            // 
            this.bt_viewDetails.BackColor = System.Drawing.Color.White;
            this.bt_viewDetails.BorderRadius = 22;
            this.bt_viewDetails.BorderThickness = 1;
            this.bt_viewDetails.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_viewDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_viewDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_viewDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_viewDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_viewDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.bt_viewDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_viewDetails.ForeColor = System.Drawing.Color.Black;
            this.bt_viewDetails.Location = new System.Drawing.Point(1066, 478);
            this.bt_viewDetails.Name = "bt_viewDetails";
            this.bt_viewDetails.Size = new System.Drawing.Size(227, 47);
            this.bt_viewDetails.TabIndex = 18;
            this.bt_viewDetails.Text = "View Details";
            this.bt_viewDetails.Click += new System.EventHandler(this.bt_viewDetails_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.White;
            this.bt_delete.BorderRadius = 22;
            this.bt_delete.BorderThickness = 1;
            this.bt_delete.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_delete.FillColor = System.Drawing.Color.Red;
            this.bt_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_delete.ForeColor = System.Drawing.Color.Black;
            this.bt_delete.Location = new System.Drawing.Point(1066, 548);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(227, 47);
            this.bt_delete.TabIndex = 18;
            this.bt_delete.Text = "Delete";
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_create
            // 
            this.bt_create.BackColor = System.Drawing.Color.White;
            this.bt_create.BorderRadius = 22;
            this.bt_create.BorderThickness = 1;
            this.bt_create.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.bt_create.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_create.ForeColor = System.Drawing.Color.Black;
            this.bt_create.Location = new System.Drawing.Point(1066, 415);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(227, 47);
            this.bt_create.TabIndex = 18;
            this.bt_create.Text = "Create a course";
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // cbb_searchStatus
            // 
            this.cbb_searchStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbb_searchStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_searchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_searchStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_searchStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_searchStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_searchStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_searchStatus.ItemHeight = 30;
            this.cbb_searchStatus.Location = new System.Drawing.Point(150, 35);
            this.cbb_searchStatus.Name = "cbb_searchStatus";
            this.cbb_searchStatus.Size = new System.Drawing.Size(375, 36);
            this.cbb_searchStatus.TabIndex = 33;
            // 
            // cbb_searchLocation
            // 
            this.cbb_searchLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbb_searchLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_searchLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_searchLocation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_searchLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_searchLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_searchLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_searchLocation.ItemHeight = 30;
            this.cbb_searchLocation.Location = new System.Drawing.Point(151, 133);
            this.cbb_searchLocation.Name = "cbb_searchLocation";
            this.cbb_searchLocation.Size = new System.Drawing.Size(374, 36);
            this.cbb_searchLocation.TabIndex = 33;
            // 
            // tb_searchName
            // 
            this.tb_searchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_searchName.DefaultText = "";
            this.tb_searchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_searchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_searchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_searchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchName.Location = new System.Drawing.Point(150, 85);
            this.tb_searchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_searchName.Name = "tb_searchName";
            this.tb_searchName.PasswordChar = '\0';
            this.tb_searchName.PlaceholderText = "";
            this.tb_searchName.SelectedText = "";
            this.tb_searchName.Size = new System.Drawing.Size(375, 36);
            this.tb_searchName.TabIndex = 34;
            // 
            // courseViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 753);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_viewDetails);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.dgv_courseadmin);
            this.Controls.Add(this.lb_coursemanage);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.bt_exit);
            this.Name = "courseViewAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "courseViewAdmin";
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseadmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_searchbyname;
        private System.Windows.Forms.Label lb_searchbystatus;
        private System.Windows.Forms.Label lb_coursemanage;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_courseadmin;
        private Guna.UI2.WinForms.Guna2Button bt_search;
        private Guna.UI2.WinForms.Guna2Button bt_viewDetails;
        private Guna.UI2.WinForms.Guna2Button bt_delete;
        private Guna.UI2.WinForms.Guna2Button bt_create;
        private Guna.UI2.WinForms.Guna2TextBox tb_searchName;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_searchLocation;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_searchStatus;
    }
}