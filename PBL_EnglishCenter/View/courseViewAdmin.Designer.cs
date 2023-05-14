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
            this.lb_fullname = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_view = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_searchbyname = new System.Windows.Forms.Label();
            this.lb_searchbystatus = new System.Windows.Forms.Label();
            this.lb_coursemanage = new System.Windows.Forms.Label();
            this.gb_manage = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.dtp_timeend = new System.Windows.Forms.DateTimePicker();
            this.dtp_timebegin = new System.Windows.Forms.DateTimePicker();
            this.cbb_teacher = new System.Windows.Forms.ComboBox();
            this.cbb_status = new System.Windows.Forms.ComboBox();
            this.rtb_des = new System.Windows.Forms.RichTextBox();
            this.tb_limit = new System.Windows.Forms.TextBox();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_limit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.cbb_searchStatus = new System.Windows.Forms.ComboBox();
            this.tb_searchName = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dgv_courseadmin = new System.Windows.Forms.DataGridView();
            this.bt_exit = new System.Windows.Forms.Button();
            this.cbb_location = new System.Windows.Forms.ComboBox();
            this.gb_manage.SuspendLayout();
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
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(145, 39);
            this.tb_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(163, 26);
            this.tb_id.TabIndex = 6;
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(468, 483);
            this.bt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(127, 58);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = false;
            // 
            // bt_view
            // 
            this.bt_view.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_view.Location = new System.Drawing.Point(204, 483);
            this.bt_view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_view.Name = "bt_view";
            this.bt_view.Size = new System.Drawing.Size(127, 58);
            this.bt_view.TabIndex = 23;
            this.bt_view.Text = "View";
            this.bt_view.UseVisualStyleBackColor = false;
            this.bt_view.Click += new System.EventHandler(this.bt_view_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(72, 483);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(127, 58);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.Location = new System.Drawing.Point(336, 483);
            this.bt_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(127, 58);
            this.bt_edit.TabIndex = 3;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(24, 39);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(37, 25);
            this.lb_id.TabIndex = 9;
            this.lb_id.Text = "ID:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(24, 100);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(70, 25);
            this.lb_name.TabIndex = 10;
            this.lb_name.Text = "Name:";
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
            this.lb_coursemanage.Location = new System.Drawing.Point(175, 60);
            this.lb_coursemanage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_coursemanage.Name = "lb_coursemanage";
            this.lb_coursemanage.Size = new System.Drawing.Size(300, 44);
            this.lb_coursemanage.TabIndex = 30;
            this.lb_coursemanage.Text = "Course Manage";
            // 
            // gb_manage
            // 
            this.gb_manage.Controls.Add(this.cbb_location);
            this.gb_manage.Controls.Add(this.tb_name);
            this.gb_manage.Controls.Add(this.dtp_timeend);
            this.gb_manage.Controls.Add(this.dtp_timebegin);
            this.gb_manage.Controls.Add(this.cbb_teacher);
            this.gb_manage.Controls.Add(this.cbb_status);
            this.gb_manage.Controls.Add(this.rtb_des);
            this.gb_manage.Controls.Add(this.tb_id);
            this.gb_manage.Controls.Add(this.bt_add);
            this.gb_manage.Controls.Add(this.bt_view);
            this.gb_manage.Controls.Add(this.bt_delete);
            this.gb_manage.Controls.Add(this.bt_edit);
            this.gb_manage.Controls.Add(this.tb_limit);
            this.gb_manage.Controls.Add(this.tb_cost);
            this.gb_manage.Controls.Add(this.label6);
            this.gb_manage.Controls.Add(this.lb_limit);
            this.gb_manage.Controls.Add(this.lb_id);
            this.gb_manage.Controls.Add(this.label7);
            this.gb_manage.Controls.Add(this.label4);
            this.gb_manage.Controls.Add(this.label5);
            this.gb_manage.Controls.Add(this.label3);
            this.gb_manage.Controls.Add(this.label2);
            this.gb_manage.Controls.Add(this.label1);
            this.gb_manage.Controls.Add(this.lb_name);
            this.gb_manage.Location = new System.Drawing.Point(923, 184);
            this.gb_manage.Margin = new System.Windows.Forms.Padding(4);
            this.gb_manage.Name = "gb_manage";
            this.gb_manage.Padding = new System.Windows.Forms.Padding(4);
            this.gb_manage.Size = new System.Drawing.Size(759, 559);
            this.gb_manage.TabIndex = 29;
            this.gb_manage.TabStop = false;
            this.gb_manage.Text = "Manage";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(146, 102);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(598, 22);
            this.tb_name.TabIndex = 27;
            // 
            // dtp_timeend
            // 
            this.dtp_timeend.Location = new System.Drawing.Point(146, 417);
            this.dtp_timeend.Name = "dtp_timeend";
            this.dtp_timeend.Size = new System.Drawing.Size(295, 22);
            this.dtp_timeend.TabIndex = 26;
            // 
            // dtp_timebegin
            // 
            this.dtp_timebegin.Location = new System.Drawing.Point(146, 364);
            this.dtp_timebegin.Name = "dtp_timebegin";
            this.dtp_timebegin.Size = new System.Drawing.Size(295, 22);
            this.dtp_timebegin.TabIndex = 26;
            // 
            // cbb_teacher
            // 
            this.cbb_teacher.FormattingEnabled = true;
            this.cbb_teacher.Location = new System.Drawing.Point(524, 304);
            this.cbb_teacher.Name = "cbb_teacher";
            this.cbb_teacher.Size = new System.Drawing.Size(219, 24);
            this.cbb_teacher.TabIndex = 25;
            // 
            // cbb_status
            // 
            this.cbb_status.FormattingEnabled = true;
            this.cbb_status.Location = new System.Drawing.Point(145, 304);
            this.cbb_status.Name = "cbb_status";
            this.cbb_status.Size = new System.Drawing.Size(219, 24);
            this.cbb_status.TabIndex = 25;
            // 
            // rtb_des
            // 
            this.rtb_des.Location = new System.Drawing.Point(145, 150);
            this.rtb_des.Name = "rtb_des";
            this.rtb_des.Size = new System.Drawing.Size(598, 94);
            this.rtb_des.TabIndex = 24;
            this.rtb_des.Text = "";
            // 
            // tb_limit
            // 
            this.tb_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_limit.Location = new System.Drawing.Point(526, 253);
            this.tb_limit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_limit.Name = "tb_limit";
            this.tb_limit.Size = new System.Drawing.Size(218, 26);
            this.tb_limit.TabIndex = 7;
            // 
            // tb_cost
            // 
            this.tb_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cost.Location = new System.Drawing.Point(145, 254);
            this.tb_cost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(219, 26);
            this.tb_cost.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Location:";
            // 
            // lb_limit
            // 
            this.lb_limit.AutoSize = true;
            this.lb_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_limit.Location = new System.Drawing.Point(405, 253);
            this.lb_limit.Name = "lb_limit";
            this.lb_limit.Size = new System.Drawing.Size(58, 25);
            this.lb_limit.TabIndex = 10;
            this.lb_limit.Text = "Limit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time end:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time begin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description:";
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.lb_searchbyname);
            this.gb_search.Controls.Add(this.lb_searchbystatus);
            this.gb_search.Controls.Add(this.cbb_searchStatus);
            this.gb_search.Controls.Add(this.tb_searchName);
            this.gb_search.Controls.Add(this.bt_search);
            this.gb_search.Location = new System.Drawing.Point(923, 36);
            this.gb_search.Margin = new System.Windows.Forms.Padding(4);
            this.gb_search.Name = "gb_search";
            this.gb_search.Padding = new System.Windows.Forms.Padding(4);
            this.gb_search.Size = new System.Drawing.Size(640, 140);
            this.gb_search.TabIndex = 28;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Search";
            // 
            // cbb_searchStatus
            // 
            this.cbb_searchStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_searchStatus.FormattingEnabled = true;
            this.cbb_searchStatus.Location = new System.Drawing.Point(145, 43);
            this.cbb_searchStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_searchStatus.Name = "cbb_searchStatus";
            this.cbb_searchStatus.Size = new System.Drawing.Size(219, 28);
            this.cbb_searchStatus.TabIndex = 16;
            // 
            // tb_searchName
            // 
            this.tb_searchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchName.Location = new System.Drawing.Point(145, 86);
            this.tb_searchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_searchName.Name = "tb_searchName";
            this.tb_searchName.Size = new System.Drawing.Size(219, 26);
            this.tb_searchName.TabIndex = 4;
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(436, 43);
            this.bt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(127, 58);
            this.bt_search.TabIndex = 5;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
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
            // dgv_courseadmin
            // 
            this.dgv_courseadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_courseadmin.Location = new System.Drawing.Point(14, 123);
            this.dgv_courseadmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_courseadmin.Name = "dgv_courseadmin";
            this.dgv_courseadmin.RowHeadersWidth = 51;
            this.dgv_courseadmin.RowTemplate.Height = 24;
            this.dgv_courseadmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_courseadmin.Size = new System.Drawing.Size(867, 620);
            this.dgv_courseadmin.TabIndex = 27;
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Crimson;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(857, 768);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(127, 58);
            this.bt_exit.TabIndex = 2;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // cbb_location
            // 
            this.cbb_location.FormattingEnabled = true;
            this.cbb_location.Location = new System.Drawing.Point(449, 39);
            this.cbb_location.Name = "cbb_location";
            this.cbb_location.Size = new System.Drawing.Size(280, 24);
            this.cbb_location.TabIndex = 28;
            // 
            // courseViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 859);
            this.Controls.Add(this.lb_coursemanage);
            this.Controls.Add(this.gb_manage);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.dgv_courseadmin);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.bt_exit);
            this.Name = "courseViewAdmin";
            this.Text = "courseViewAdmin";
            this.gb_manage.ResumeLayout(false);
            this.gb_manage.PerformLayout();
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseadmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_view;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_searchbyname;
        private System.Windows.Forms.Label lb_searchbystatus;
        private System.Windows.Forms.Label lb_coursemanage;
        private System.Windows.Forms.GroupBox gb_manage;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.ComboBox cbb_searchStatus;
        private System.Windows.Forms.TextBox tb_searchName;
        private System.Windows.Forms.Button bt_search;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataGridView dgv_courseadmin;
        private System.Windows.Forms.RichTextBox rtb_des;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_timeend;
        private System.Windows.Forms.DateTimePicker dtp_timebegin;
        private System.Windows.Forms.ComboBox cbb_status;
        private System.Windows.Forms.TextBox tb_limit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_limit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_teacher;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.ComboBox cbb_location;
    }
}