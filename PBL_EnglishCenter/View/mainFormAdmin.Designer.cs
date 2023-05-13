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
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_courseAdmin = new System.Windows.Forms.Button();
            this.bt_accountAdmin = new System.Windows.Forms.Button();
            this.dgvAnnAdm = new System.Windows.Forms.DataGridView();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.bt_profile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(1130, 46);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(143, 39);
            this.bt_logout.TabIndex = 0;
            this.bt_logout.Text = "Log out";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_courseAdmin
            // 
            this.bt_courseAdmin.Location = new System.Drawing.Point(53, 229);
            this.bt_courseAdmin.Name = "bt_courseAdmin";
            this.bt_courseAdmin.Size = new System.Drawing.Size(167, 46);
            this.bt_courseAdmin.TabIndex = 0;
            this.bt_courseAdmin.Text = "Manage Course";
            this.bt_courseAdmin.UseVisualStyleBackColor = true;
            // 
            // bt_accountAdmin
            // 
            this.bt_accountAdmin.Location = new System.Drawing.Point(53, 300);
            this.bt_accountAdmin.Name = "bt_accountAdmin";
            this.bt_accountAdmin.Size = new System.Drawing.Size(167, 46);
            this.bt_accountAdmin.TabIndex = 0;
            this.bt_accountAdmin.Text = "Manage Account";
            this.bt_accountAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvAnnAdm
            // 
            this.dgvAnnAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnnAdm.Location = new System.Drawing.Point(261, 125);
            this.dgvAnnAdm.Name = "dgvAnnAdm";
            this.dgvAnnAdm.RowHeadersWidth = 51;
            this.dgvAnnAdm.RowTemplate.Height = 24;
            this.dgvAnnAdm.Size = new System.Drawing.Size(1104, 383);
            this.dgvAnnAdm.TabIndex = 1;
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Location = new System.Drawing.Point(761, 57);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(57, 16);
            this.lb_fullname.TabIndex = 2;
            this.lb_fullname.Text = "fullname";
            // 
            // bt_profile
            // 
            this.bt_profile.Location = new System.Drawing.Point(942, 46);
            this.bt_profile.Name = "bt_profile";
            this.bt_profile.Size = new System.Drawing.Size(143, 39);
            this.bt_profile.TabIndex = 0;
            this.bt_profile.Text = "Profile";
            this.bt_profile.UseVisualStyleBackColor = true;
            this.bt_profile.Click += new System.EventHandler(this.bt_profile_Click);
            // 
            // mainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 632);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.dgvAnnAdm);
            this.Controls.Add(this.bt_accountAdmin);
            this.Controls.Add(this.bt_courseAdmin);
            this.Controls.Add(this.bt_profile);
            this.Controls.Add(this.bt_logout);
            this.Name = "mainFormAdmin";
            this.Text = "mainFormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnAdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_courseAdmin;
        private System.Windows.Forms.Button bt_accountAdmin;
        private System.Windows.Forms.DataGridView dgvAnnAdm;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Button bt_profile;
    }
}