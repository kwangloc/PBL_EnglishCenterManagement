namespace PBL_EnglishCenter.View
{
    partial class mainFormStudent
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
            this.bt_profile = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.dgvAnnStu = new System.Windows.Forms.DataGridView();
            this.bt_courseStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnStu)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.lb_fullname.Location = new System.Drawing.Point(268, 22);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(111, 37);
            this.lb_fullname.TabIndex = 5;
            this.lb_fullname.Text = "fullname";
            // 
            // bt_profile
            // 
            this.bt_profile.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bt_profile.Location = new System.Drawing.Point(29, 268);
            this.bt_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_profile.Name = "bt_profile";
            this.bt_profile.Size = new System.Drawing.Size(165, 75);
            this.bt_profile.TabIndex = 3;
            this.bt_profile.Text = "Profile";
            this.bt_profile.UseVisualStyleBackColor = false;
            this.bt_profile.Click += new System.EventHandler(this.bt_profile_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bt_logout.Location = new System.Drawing.Point(29, 377);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(165, 75);
            this.bt_logout.TabIndex = 4;
            this.bt_logout.Text = "Log out";
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // dgvAnnStu
            // 
            this.dgvAnnStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnnStu.Location = new System.Drawing.Point(225, 73);
            this.dgvAnnStu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAnnStu.Name = "dgvAnnStu";
            this.dgvAnnStu.RowHeadersWidth = 51;
            this.dgvAnnStu.RowTemplate.Height = 24;
            this.dgvAnnStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnnStu.Size = new System.Drawing.Size(1072, 481);
            this.dgvAnnStu.TabIndex = 6;
            // 
            // bt_courseStudent
            // 
            this.bt_courseStudent.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_courseStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bt_courseStudent.Location = new System.Drawing.Point(29, 159);
            this.bt_courseStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_courseStudent.Name = "bt_courseStudent";
            this.bt_courseStudent.Size = new System.Drawing.Size(165, 75);
            this.bt_courseStudent.TabIndex = 8;
            this.bt_courseStudent.Text = "My Course";
            this.bt_courseStudent.UseVisualStyleBackColor = false;
            this.bt_courseStudent.Click += new System.EventHandler(this.bt_courseStudent_Click);
            // 
            // mainFormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.bt_courseStudent);
            this.Controls.Add(this.dgvAnnStu);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.bt_profile);
            this.Controls.Add(this.bt_logout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainFormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainFormStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Button bt_profile;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.DataGridView dgvAnnStu;
        private System.Windows.Forms.Button bt_courseStudent;
    }
}