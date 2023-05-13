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
            this.bt_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.Location = new System.Drawing.Point(21, 350);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(2);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(125, 61);
            this.bt_logout.TabIndex = 0;
            this.bt_logout.Text = "Log out";
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_courseAdmin
            // 
            this.bt_courseAdmin.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_courseAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_courseAdmin.Location = new System.Drawing.Point(21, 105);
            this.bt_courseAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.bt_courseAdmin.Name = "bt_courseAdmin";
            this.bt_courseAdmin.Size = new System.Drawing.Size(125, 61);
            this.bt_courseAdmin.TabIndex = 0;
            this.bt_courseAdmin.Text = "Manage Course";
            this.bt_courseAdmin.UseVisualStyleBackColor = false;
            // 
            // bt_accountAdmin
            // 
            this.bt_accountAdmin.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_accountAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_accountAdmin.Location = new System.Drawing.Point(21, 187);
            this.bt_accountAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.bt_accountAdmin.Name = "bt_accountAdmin";
            this.bt_accountAdmin.Size = new System.Drawing.Size(125, 61);
            this.bt_accountAdmin.TabIndex = 0;
            this.bt_accountAdmin.Text = "Manage Account";
            this.bt_accountAdmin.UseVisualStyleBackColor = false;
            this.bt_accountAdmin.Click += new System.EventHandler(this.bt_accountAdmin_Click);
            // 
            // dgvAnnAdm
            // 
            this.dgvAnnAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnnAdm.Location = new System.Drawing.Point(169, 59);
            this.dgvAnnAdm.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAnnAdm.Name = "dgvAnnAdm";
            this.dgvAnnAdm.RowHeadersWidth = 51;
            this.dgvAnnAdm.RowTemplate.Height = 24;
            this.dgvAnnAdm.Size = new System.Drawing.Size(804, 391);
            this.dgvAnnAdm.TabIndex = 1;
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(199, 18);
            this.lb_fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(87, 28);
            this.lb_fullname.TabIndex = 2;
            this.lb_fullname.Text = "fullname";
            // 
            // bt_profile
            // 
            this.bt_profile.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_profile.Location = new System.Drawing.Point(21, 268);
            this.bt_profile.Margin = new System.Windows.Forms.Padding(2);
            this.bt_profile.Name = "bt_profile";
            this.bt_profile.Size = new System.Drawing.Size(125, 61);
            this.bt_profile.TabIndex = 0;
            this.bt_profile.Text = "Profile";
            this.bt_profile.UseVisualStyleBackColor = false;
            this.bt_profile.Click += new System.EventHandler(this.bt_profile_Click);
            // 
            // mainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.dgvAnnAdm);
            this.Controls.Add(this.bt_accountAdmin);
            this.Controls.Add(this.bt_courseAdmin);
            this.Controls.Add(this.bt_profile);
            this.Controls.Add(this.bt_logout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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