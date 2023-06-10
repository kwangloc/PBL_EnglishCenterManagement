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
            this.bt_delete = new System.Windows.Forms.Button();
            this.lb_searchbyname = new System.Windows.Forms.Label();
            this.lb_searchbystatus = new System.Windows.Forms.Label();
            this.lb_coursemanage = new System.Windows.Forms.Label();
            this.bt_viewDetails = new System.Windows.Forms.Button();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_searchLocation = new System.Windows.Forms.ComboBox();
            this.cbb_searchStatus = new System.Windows.Forms.ComboBox();
            this.tb_searchName = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dgv_courseadmin = new System.Windows.Forms.DataGridView();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_create = new System.Windows.Forms.Button();
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
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.Crimson;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(1122, 581);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(293, 65);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
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
            // bt_viewDetails
            // 
            this.bt_viewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_viewDetails.Location = new System.Drawing.Point(1122, 509);
            this.bt_viewDetails.Name = "bt_viewDetails";
            this.bt_viewDetails.Size = new System.Drawing.Size(293, 62);
            this.bt_viewDetails.TabIndex = 29;
            this.bt_viewDetails.Text = "View Details";
            this.bt_viewDetails.UseVisualStyleBackColor = true;
            this.bt_viewDetails.Click += new System.EventHandler(this.bt_viewDetails_Click);
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.label2);
            this.gb_search.Controls.Add(this.label1);
            this.gb_search.Controls.Add(this.lb_searchbyname);
            this.gb_search.Controls.Add(this.lb_searchbystatus);
            this.gb_search.Controls.Add(this.cbb_searchLocation);
            this.gb_search.Controls.Add(this.cbb_searchStatus);
            this.gb_search.Controls.Add(this.tb_searchName);
            this.gb_search.Controls.Add(this.bt_search);
            this.gb_search.Location = new System.Drawing.Point(977, 148);
            this.gb_search.Margin = new System.Windows.Forms.Padding(4);
            this.gb_search.Name = "gb_search";
            this.gb_search.Padding = new System.Windows.Forms.Padding(4);
            this.gb_search.Size = new System.Drawing.Size(640, 242);
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
            // cbb_searchLocation
            // 
            this.cbb_searchLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_searchLocation.FormattingEnabled = true;
            this.cbb_searchLocation.Location = new System.Drawing.Point(145, 136);
            this.cbb_searchLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_searchLocation.Name = "cbb_searchLocation";
            this.cbb_searchLocation.Size = new System.Drawing.Size(219, 28);
            this.cbb_searchLocation.TabIndex = 16;
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
            this.dgv_courseadmin.Size = new System.Drawing.Size(897, 620);
            this.dgv_courseadmin.TabIndex = 27;
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
            // bt_create
            // 
            this.bt_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_create.Location = new System.Drawing.Point(1122, 441);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(293, 62);
            this.bt_create.TabIndex = 31;
            this.bt_create.Text = "Create a course";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // courseViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.bt_viewDetails);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.lb_coursemanage);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.dgv_courseadmin);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_delete);
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
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Label lb_searchbyname;
        private System.Windows.Forms.Label lb_searchbystatus;
        private System.Windows.Forms.Label lb_coursemanage;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.ComboBox cbb_searchStatus;
        private System.Windows.Forms.TextBox tb_searchName;
        private System.Windows.Forms.Button bt_search;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataGridView dgv_courseadmin;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_viewDetails;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_searchLocation;
    }
}