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
            this.dgv_allcourse = new System.Windows.Forms.DataGridView();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_course = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allcourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_allcourse
            // 
            this.dgv_allcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allcourse.Location = new System.Drawing.Point(239, 143);
            this.dgv_allcourse.Name = "dgv_allcourse";
            this.dgv_allcourse.RowHeadersWidth = 51;
            this.dgv_allcourse.RowTemplate.Height = 24;
            this.dgv_allcourse.Size = new System.Drawing.Size(842, 327);
            this.dgv_allcourse.TabIndex = 0;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(1129, 236);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(119, 29);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(1129, 292);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(119, 29);
            this.bt_delete.TabIndex = 1;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(1129, 341);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(119, 29);
            this.bt_edit.TabIndex = 1;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            // 
            // bt_course
            // 
            this.bt_course.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_course.Location = new System.Drawing.Point(56, 234);
            this.bt_course.Name = "bt_course";
            this.bt_course.Size = new System.Drawing.Size(119, 31);
            this.bt_course.TabIndex = 1;
            this.bt_course.Text = "Manage course";
            this.bt_course.UseVisualStyleBackColor = false;
            this.bt_course.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Location = new System.Drawing.Point(971, 62);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(57, 16);
            this.lb_fullname.TabIndex = 3;
            this.lb_fullname.Text = "fullname";
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(583, 498);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(119, 29);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // courseViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 567);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_course);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dgv_allcourse);
            this.Name = "courseViewAdmin";
            this.Text = "courseViewAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allcourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_allcourse;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_course;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Button bt_exit;
    }
}