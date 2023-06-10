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
            this.lb_fullname = new System.Windows.Forms.Label();
            this.dgvAnnTea = new System.Windows.Forms.DataGridView();
            this.bt_courseTeacher = new System.Windows.Forms.Button();
            this.bt_profile = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnTea)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.lb_fullname.Location = new System.Drawing.Point(285, 22);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(111, 37);
            this.lb_fullname.TabIndex = 8;
            this.lb_fullname.Text = "fullname";
            // 
            // dgvAnnTea
            // 
            this.dgvAnnTea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnnTea.Location = new System.Drawing.Point(225, 73);
            this.dgvAnnTea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAnnTea.Name = "dgvAnnTea";
            this.dgvAnnTea.RowHeadersWidth = 51;
            this.dgvAnnTea.RowTemplate.Height = 24;
            this.dgvAnnTea.Size = new System.Drawing.Size(1072, 481);
            this.dgvAnnTea.TabIndex = 7;
            // 
            // bt_courseTeacher
            // 
            this.bt_courseTeacher.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_courseTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_courseTeacher.ForeColor = System.Drawing.Color.Black;
            this.bt_courseTeacher.Location = new System.Drawing.Point(31, 158);
            this.bt_courseTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_courseTeacher.Name = "bt_courseTeacher";
            this.bt_courseTeacher.Size = new System.Drawing.Size(165, 75);
            this.bt_courseTeacher.TabIndex = 4;
            this.bt_courseTeacher.Text = "My Course";
            this.bt_courseTeacher.UseVisualStyleBackColor = false;
            this.bt_courseTeacher.Click += new System.EventHandler(this.bt_courseTeacher_Click);
            // 
            // bt_profile
            // 
            this.bt_profile.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_profile.ForeColor = System.Drawing.Color.Black;
            this.bt_profile.Location = new System.Drawing.Point(31, 270);
            this.bt_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_profile.Name = "bt_profile";
            this.bt_profile.Size = new System.Drawing.Size(165, 75);
            this.bt_profile.TabIndex = 5;
            this.bt_profile.Text = "Profile";
            this.bt_profile.UseVisualStyleBackColor = false;
            this.bt_profile.Click += new System.EventHandler(this.bt_profile_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.Location = new System.Drawing.Point(31, 383);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(165, 75);
            this.bt_logout.TabIndex = 6;
            this.bt_logout.Text = "Log out";
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // mainFormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.dgvAnnTea);
            this.Controls.Add(this.bt_courseTeacher);
            this.Controls.Add(this.bt_profile);
            this.Controls.Add(this.bt_logout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainFormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainFormTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnTea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.DataGridView dgvAnnTea;
        private System.Windows.Forms.Button bt_courseTeacher;
        private System.Windows.Forms.Button bt_profile;
        private System.Windows.Forms.Button bt_logout;
    }
}