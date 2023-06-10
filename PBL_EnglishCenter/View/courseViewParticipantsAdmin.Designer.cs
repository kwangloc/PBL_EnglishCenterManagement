namespace PBL_EnglishCenter.View
{
    partial class courseViewParticipantsAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_infor = new System.Windows.Forms.GroupBox();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.tb_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_search = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bt_remove = new Guna.UI2.WinForms.Guna2Button();
            this.tb_searchToAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_searchToAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bt_add = new Guna.UI2.WinForms.Guna2Button();
            this.gb_infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_infor
            // 
            this.gb_infor.Controls.Add(this.dataGridView2);
            this.gb_infor.Controls.Add(this.bt_add);
            this.gb_infor.Controls.Add(this.bt_searchToAdd);
            this.gb_infor.Controls.Add(this.tb_searchToAdd);
            this.gb_infor.Location = new System.Drawing.Point(885, 92);
            this.gb_infor.Name = "gb_infor";
            this.gb_infor.Size = new System.Drawing.Size(516, 580);
            this.gb_infor.TabIndex = 3;
            this.gb_infor.TabStop = false;
            this.gb_infor.Text = "Add student";
            // 
            // lb_quantity
            // 
            this.lb_quantity.AutoSize = true;
            this.lb_quantity.Location = new System.Drawing.Point(75, 689);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(102, 16);
            this.lb_quantity.TabIndex = 4;
            this.lb_quantity.Text = "This course has";
            // 
            // tb_search
            // 
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.DefaultText = "";
            this.tb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.Location = new System.Drawing.Point(394, 65);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PlaceholderText = "";
            this.tb_search.SelectedText = "";
            this.tb_search.Size = new System.Drawing.Size(229, 28);
            this.tb_search.TabIndex = 5;
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
            this.bt_search.Location = new System.Drawing.Point(641, 62);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(180, 34);
            this.bt_search.TabIndex = 18;
            this.bt_search.Text = "Search";
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(78, 122);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 550);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 29;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // bt_remove
            // 
            this.bt_remove.BackColor = System.Drawing.Color.White;
            this.bt_remove.BorderRadius = 22;
            this.bt_remove.BorderThickness = 1;
            this.bt_remove.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_remove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.bt_remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_remove.ForeColor = System.Drawing.Color.Black;
            this.bt_remove.Location = new System.Drawing.Point(585, 689);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(180, 45);
            this.bt_remove.TabIndex = 20;
            this.bt_remove.Text = "Remove";
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // tb_searchToAdd
            // 
            this.tb_searchToAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_searchToAdd.DefaultText = "";
            this.tb_searchToAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_searchToAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_searchToAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchToAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchToAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchToAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_searchToAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchToAdd.Location = new System.Drawing.Point(56, 30);
            this.tb_searchToAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_searchToAdd.Name = "tb_searchToAdd";
            this.tb_searchToAdd.PasswordChar = '\0';
            this.tb_searchToAdd.PlaceholderText = "";
            this.tb_searchToAdd.SelectedText = "";
            this.tb_searchToAdd.Size = new System.Drawing.Size(247, 30);
            this.tb_searchToAdd.TabIndex = 5;
            // 
            // bt_searchToAdd
            // 
            this.bt_searchToAdd.BackColor = System.Drawing.Color.White;
            this.bt_searchToAdd.BorderRadius = 22;
            this.bt_searchToAdd.BorderThickness = 1;
            this.bt_searchToAdd.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_searchToAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_searchToAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_searchToAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_searchToAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_searchToAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.bt_searchToAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_searchToAdd.ForeColor = System.Drawing.Color.Black;
            this.bt_searchToAdd.Location = new System.Drawing.Point(314, 27);
            this.bt_searchToAdd.Name = "bt_searchToAdd";
            this.bt_searchToAdd.Size = new System.Drawing.Size(176, 36);
            this.bt_searchToAdd.TabIndex = 18;
            this.bt_searchToAdd.Text = "Search to add";
            this.bt_searchToAdd.Click += new System.EventHandler(this.bt_searchToAdd_Click);
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView2.Location = new System.Drawing.Point(24, 85);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(477, 342);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView2.ThemeStyle.HeaderStyle.Height = 29;
            this.dataGridView2.ThemeStyle.ReadOnly = false;
            this.dataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView2.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.White;
            this.bt_add.BorderRadius = 22;
            this.bt_add.BorderThickness = 1;
            this.bt_add.CheckedState.FillColor = System.Drawing.Color.Red;
            this.bt_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.bt_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_add.ForeColor = System.Drawing.Color.Black;
            this.bt_add.Location = new System.Drawing.Point(351, 444);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(124, 36);
            this.bt_add.TabIndex = 18;
            this.bt_add.Text = "Add";
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // courseViewParticipantsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lb_quantity);
            this.Controls.Add(this.gb_infor);
            this.Name = "courseViewParticipantsAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "courseViewParticipantsAdmin";
            this.gb_infor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_infor;
        private System.Windows.Forms.Label lb_quantity;
        private Guna.UI2.WinForms.Guna2TextBox tb_search;
        private Guna.UI2.WinForms.Guna2Button bt_search;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button bt_remove;
        private Guna.UI2.WinForms.Guna2TextBox tb_searchToAdd;
        private Guna.UI2.WinForms.Guna2Button bt_searchToAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2Button bt_add;
    }
}