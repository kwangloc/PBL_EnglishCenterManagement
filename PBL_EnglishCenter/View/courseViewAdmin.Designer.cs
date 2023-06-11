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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(courseViewAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_searchbyname = new System.Windows.Forms.Label();
            this.lb_searchbystatus = new System.Windows.Forms.Label();
            this.lb_coursemanage = new System.Windows.Forms.Label();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.tb_searchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_searchLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbb_searchStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bt_search = new Guna.UI2.WinForms.Guna2Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.bt_viewDetails = new Guna.UI2.WinForms.Guna2Button();
            this.bt_delete = new Guna.UI2.WinForms.Guna2Button();
            this.bt_create = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_courseadmin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.bt_exit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gb_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseadmin)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_fullname.Location = new System.Drawing.Point(76, 28);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(210, 60);
            this.lb_fullname.TabIndex = 3;
            this.lb_fullname.Text = "fullname";
            // 
            // lb_searchbyname
            // 
            this.lb_searchbyname.AutoSize = true;
            this.lb_searchbyname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_searchbyname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_searchbyname.Location = new System.Drawing.Point(60, 143);
            this.lb_searchbyname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_searchbyname.Name = "lb_searchbyname";
            this.lb_searchbyname.Size = new System.Drawing.Size(172, 46);
            this.lb_searchbyname.TabIndex = 17;
            this.lb_searchbyname.Text = "By Name:";
            // 
            // lb_searchbystatus
            // 
            this.lb_searchbystatus.AutoSize = true;
            this.lb_searchbystatus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_searchbystatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_searchbystatus.Location = new System.Drawing.Point(60, 35);
            this.lb_searchbystatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_searchbystatus.Name = "lb_searchbystatus";
            this.lb_searchbystatus.Size = new System.Drawing.Size(176, 46);
            this.lb_searchbystatus.TabIndex = 17;
            this.lb_searchbystatus.Text = "By Status:";
            // 
            // lb_coursemanage
            // 
            this.lb_coursemanage.AutoSize = true;
            this.lb_coursemanage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_coursemanage.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_coursemanage.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_coursemanage.Location = new System.Drawing.Point(715, 28);
            this.lb_coursemanage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_coursemanage.Name = "lb_coursemanage";
            this.lb_coursemanage.Size = new System.Drawing.Size(528, 91);
            this.lb_coursemanage.TabIndex = 30;
            this.lb_coursemanage.Text = "Manage Course";
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.tb_searchName);
            this.gb_search.Controls.Add(this.label2);
            this.gb_search.Controls.Add(this.cbb_searchLocation);
            this.gb_search.Controls.Add(this.cbb_searchStatus);
            this.gb_search.Controls.Add(this.bt_search);
            this.gb_search.Controls.Add(this.lb_searchbyname);
            this.gb_search.Controls.Add(this.lb_searchbystatus);
            this.gb_search.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gb_search.Location = new System.Drawing.Point(30, 119);
            this.gb_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_search.Name = "gb_search";
            this.gb_search.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_search.Size = new System.Drawing.Size(915, 530);
            this.gb_search.TabIndex = 28;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Search";
            // 
            // tb_searchName
            // 
            this.tb_searchName.BorderThickness = 0;
            this.tb_searchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_searchName.DefaultText = "";
            this.tb_searchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_searchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_searchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchName.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchName.Location = new System.Drawing.Point(310, 160);
            this.tb_searchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_searchName.Name = "tb_searchName";
            this.tb_searchName.PasswordChar = '\0';
            this.tb_searchName.PlaceholderText = "";
            this.tb_searchName.SelectedText = "";
            this.tb_searchName.Size = new System.Drawing.Size(517, 44);
            this.tb_searchName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(60, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "By Location:";
            this.label2.Visible = false;
            // 
            // cbb_searchLocation
            // 
            this.cbb_searchLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbb_searchLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_searchLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_searchLocation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_searchLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_searchLocation.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_searchLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_searchLocation.ItemHeight = 30;
            this.cbb_searchLocation.Location = new System.Drawing.Point(310, 268);
            this.cbb_searchLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_searchLocation.Name = "cbb_searchLocation";
            this.cbb_searchLocation.Size = new System.Drawing.Size(516, 36);
            this.cbb_searchLocation.TabIndex = 33;
            this.cbb_searchLocation.Visible = false;
            // 
            // cbb_searchStatus
            // 
            this.cbb_searchStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbb_searchStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_searchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_searchStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_searchStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_searchStatus.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_searchStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_searchStatus.ItemHeight = 30;
            this.cbb_searchStatus.Location = new System.Drawing.Point(310, 44);
            this.cbb_searchStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_searchStatus.Name = "cbb_searchStatus";
            this.cbb_searchStatus.Size = new System.Drawing.Size(516, 36);
            this.cbb_searchStatus.TabIndex = 33;
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bt_search.BorderRadius = 22;
            this.bt_search.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_search.FillColor = System.Drawing.Color.CornflowerBlue;
            this.bt_search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.Color.White;
            this.bt_search.Image = ((System.Drawing.Image)(resources.GetObject("bt_search.Image")));
            this.bt_search.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_search.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_search.Location = new System.Drawing.Point(600, 219);
            this.bt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(227, 45);
            this.bt_search.TabIndex = 18;
            this.bt_search.Text = "Search";
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // bt_viewDetails
            // 
            this.bt_viewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bt_viewDetails.BorderRadius = 22;
            this.bt_viewDetails.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_viewDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_viewDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_viewDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_viewDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_viewDetails.FillColor = System.Drawing.Color.CornflowerBlue;
            this.bt_viewDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_viewDetails.ForeColor = System.Drawing.Color.White;
            this.bt_viewDetails.Image = ((System.Drawing.Image)(resources.GetObject("bt_viewDetails.Image")));
            this.bt_viewDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_viewDetails.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_viewDetails.Location = new System.Drawing.Point(349, 680);
            this.bt_viewDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_viewDetails.Name = "bt_viewDetails";
            this.bt_viewDetails.Size = new System.Drawing.Size(292, 57);
            this.bt_viewDetails.TabIndex = 18;
            this.bt_viewDetails.Text = "View Details";
            this.bt_viewDetails.Click += new System.EventHandler(this.bt_viewDetails_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bt_delete.BorderRadius = 22;
            this.bt_delete.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_delete.FillColor = System.Drawing.Color.Red;
            this.bt_delete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.Color.White;
            this.bt_delete.Image = ((System.Drawing.Image)(resources.GetObject("bt_delete.Image")));
            this.bt_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_delete.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_delete.Location = new System.Drawing.Point(676, 680);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(266, 57);
            this.bt_delete.TabIndex = 18;
            this.bt_delete.Text = "Delete";
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_create
            // 
            this.bt_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bt_create.BorderRadius = 22;
            this.bt_create.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_create.FillColor = System.Drawing.Color.CornflowerBlue;
            this.bt_create.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_create.ForeColor = System.Drawing.Color.White;
            this.bt_create.Image = ((System.Drawing.Image)(resources.GetObject("bt_create.Image")));
            this.bt_create.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_create.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_create.Location = new System.Drawing.Point(19, 680);
            this.bt_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(292, 57);
            this.bt_create.TabIndex = 18;
            this.bt_create.Text = "  Create a course";
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // dgv_courseadmin
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_courseadmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_courseadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_courseadmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_courseadmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_courseadmin.ColumnHeadersHeight = 29;
            this.dgv_courseadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_courseadmin.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_courseadmin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_courseadmin.GridColor = System.Drawing.Color.White;
            this.dgv_courseadmin.Location = new System.Drawing.Point(0, 151);
            this.dgv_courseadmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_courseadmin.Name = "dgv_courseadmin";
            this.dgv_courseadmin.RowHeadersVisible = false;
            this.dgv_courseadmin.RowHeadersWidth = 51;
            this.dgv_courseadmin.RowTemplate.Height = 24;
            this.dgv_courseadmin.Size = new System.Drawing.Size(1013, 831);
            this.dgv_courseadmin.TabIndex = 61;
            this.dgv_courseadmin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_courseadmin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_courseadmin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_courseadmin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_courseadmin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_courseadmin.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_courseadmin.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgv_courseadmin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
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
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.lb_coursemanage);
            this.guna2Panel1.Location = new System.Drawing.Point(-7, -4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(2008, 148);
            this.guna2Panel1.TabIndex = 62;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Tomato;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1948, 4);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox1.TabIndex = 31;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Panel2.Controls.Add(this.lb_fullname);
            this.guna2Panel2.Controls.Add(this.gb_search);
            this.guna2Panel2.Controls.Add(this.bt_exit);
            this.guna2Panel2.Controls.Add(this.bt_delete);
            this.guna2Panel2.Controls.Add(this.bt_create);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.bt_viewDetails);
            this.guna2Panel2.Location = new System.Drawing.Point(1020, 151);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(981, 831);
            this.guna2Panel2.TabIndex = 63;
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bt_exit.BorderRadius = 22;
            this.bt_exit.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_exit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.White;
            this.bt_exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_exit.Image")));
            this.bt_exit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_exit.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_exit.Location = new System.Drawing.Point(349, 752);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(292, 57);
            this.bt_exit.TabIndex = 18;
            this.bt_exit.Text = "Cancel";
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(441, 231);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(200, 36);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // courseViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1942, 985);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgv_courseadmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "courseViewAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "courseViewAdmin";
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseadmin)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_searchbyname;
        private System.Windows.Forms.Label lb_searchbystatus;
        private System.Windows.Forms.Label lb_coursemanage;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button bt_search;
        private Guna.UI2.WinForms.Guna2Button bt_viewDetails;
        private Guna.UI2.WinForms.Guna2Button bt_delete;
        private Guna.UI2.WinForms.Guna2Button bt_create;
        private Guna.UI2.WinForms.Guna2TextBox tb_searchName;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_searchLocation;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_searchStatus;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_courseadmin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button bt_exit;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}