using System.Windows.Forms;

namespace PBL_EnglishCenter.View
{
    partial class accountManage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_pass2 = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_pass2 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.cb_searchtype = new System.Windows.Forms.ComboBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_gmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_view = new System.Windows.Forms.Button();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.lb_searchbyname = new System.Windows.Forms.Label();
            this.lb_searchbytype = new System.Windows.Forms.Label();
            this.gb_manage = new System.Windows.Forms.GroupBox();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_accmanage = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_search.SuspendLayout();
            this.gb_manage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 492);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(467, 318);
            this.bt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(127, 58);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(71, 318);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(127, 58);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.Location = new System.Drawing.Point(335, 318);
            this.bt_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(127, 58);
            this.bt_edit.TabIndex = 3;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(145, 86);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(219, 26);
            this.tb_search.TabIndex = 4;
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
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(145, 39);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(163, 26);
            this.tb_username.TabIndex = 6;
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(145, 100);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(163, 26);
            this.tb_pass.TabIndex = 7;
            // 
            // tb_pass2
            // 
            this.tb_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass2.Location = new System.Drawing.Point(145, 165);
            this.tb_pass2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pass2.Name = "tb_pass2";
            this.tb_pass2.PasswordChar = '*';
            this.tb_pass2.Size = new System.Drawing.Size(163, 26);
            this.tb_pass2.TabIndex = 8;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(24, 39);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(108, 25);
            this.lb_user.TabIndex = 9;
            this.lb_user.Text = "Username:";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.Location = new System.Drawing.Point(24, 100);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(104, 25);
            this.lb_pass.TabIndex = 10;
            this.lb_pass.Text = "Password:";
            // 
            // lb_pass2
            // 
            this.lb_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass2.Location = new System.Drawing.Point(24, 153);
            this.lb_pass2.Name = "lb_pass2";
            this.lb_pass2.Size = new System.Drawing.Size(109, 63);
            this.lb_pass2.TabIndex = 11;
            this.lb_pass2.Text = "Check password:";
            // 
            // cb_type
            // 
            this.cb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(145, 228);
            this.cb_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(163, 28);
            this.cb_type.TabIndex = 12;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.Location = new System.Drawing.Point(24, 228);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(63, 25);
            this.lb_type.TabIndex = 13;
            this.lb_type.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fullname:";
            // 
            // tb_fullname
            // 
            this.tb_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fullname.Location = new System.Drawing.Point(436, 39);
            this.tb_fullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(196, 26);
            this.tb_fullname.TabIndex = 15;
            // 
            // cb_searchtype
            // 
            this.cb_searchtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_searchtype.FormattingEnabled = true;
            this.cb_searchtype.Location = new System.Drawing.Point(145, 43);
            this.cb_searchtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_searchtype.Name = "cb_searchtype";
            this.cb_searchtype.Size = new System.Drawing.Size(219, 28);
            this.cb_searchtype.TabIndex = 16;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(453, 103);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(58, 20);
            this.rb_Male.TabIndex = 17;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(541, 103);
            this.rb_female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(74, 20);
            this.rb_female.TabIndex = 18;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.Location = new System.Drawing.Point(436, 165);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(196, 26);
            this.tb_Phone.TabIndex = 19;
            // 
            // tb_gmail
            // 
            this.tb_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gmail.Location = new System.Drawing.Point(436, 230);
            this.tb_gmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_gmail.Name = "tb_gmail";
            this.tb_gmail.Size = new System.Drawing.Size(196, 26);
            this.tb_gmail.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gmail:";
            // 
            // bt_view
            // 
            this.bt_view.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_view.Location = new System.Drawing.Point(203, 318);
            this.bt_view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_view.Name = "bt_view";
            this.bt_view.Size = new System.Drawing.Size(127, 58);
            this.bt_view.TabIndex = 23;
            this.bt_view.Text = "View";
            this.bt_view.UseVisualStyleBackColor = false;
            this.bt_view.Click += new System.EventHandler(this.bt_view_Click);
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.lb_searchbyname);
            this.gb_search.Controls.Add(this.lb_searchbytype);
            this.gb_search.Controls.Add(this.cb_searchtype);
            this.gb_search.Controls.Add(this.tb_search);
            this.gb_search.Controls.Add(this.bt_search);
            this.gb_search.Location = new System.Drawing.Point(708, 15);
            this.gb_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_search.Name = "gb_search";
            this.gb_search.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_search.Size = new System.Drawing.Size(640, 140);
            this.gb_search.TabIndex = 24;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Search";
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
            // lb_searchbytype
            // 
            this.lb_searchbytype.AutoSize = true;
            this.lb_searchbytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_searchbytype.Location = new System.Drawing.Point(24, 43);
            this.lb_searchbytype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_searchbytype.Name = "lb_searchbytype";
            this.lb_searchbytype.Size = new System.Drawing.Size(91, 25);
            this.lb_searchbytype.TabIndex = 17;
            this.lb_searchbytype.Text = "By Type:";
            // 
            // gb_manage
            // 
            this.gb_manage.Controls.Add(this.lb_gender);
            this.gb_manage.Controls.Add(this.tb_username);
            this.gb_manage.Controls.Add(this.bt_add);
            this.gb_manage.Controls.Add(this.bt_view);
            this.gb_manage.Controls.Add(this.bt_delete);
            this.gb_manage.Controls.Add(this.label3);
            this.gb_manage.Controls.Add(this.bt_edit);
            this.gb_manage.Controls.Add(this.label2);
            this.gb_manage.Controls.Add(this.tb_pass);
            this.gb_manage.Controls.Add(this.tb_gmail);
            this.gb_manage.Controls.Add(this.tb_pass2);
            this.gb_manage.Controls.Add(this.tb_Phone);
            this.gb_manage.Controls.Add(this.lb_user);
            this.gb_manage.Controls.Add(this.rb_female);
            this.gb_manage.Controls.Add(this.lb_pass);
            this.gb_manage.Controls.Add(this.rb_Male);
            this.gb_manage.Controls.Add(this.lb_pass2);
            this.gb_manage.Controls.Add(this.tb_fullname);
            this.gb_manage.Controls.Add(this.cb_type);
            this.gb_manage.Controls.Add(this.label1);
            this.gb_manage.Controls.Add(this.lb_type);
            this.gb_manage.Location = new System.Drawing.Point(708, 175);
            this.gb_manage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_manage.Name = "gb_manage";
            this.gb_manage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_manage.Size = new System.Drawing.Size(640, 406);
            this.gb_manage.TabIndex = 25;
            this.gb_manage.TabStop = false;
            this.gb_manage.Text = "Manage";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(339, 102);
            this.lb_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(83, 25);
            this.lb_gender.TabIndex = 17;
            this.lb_gender.Text = "Gender:";
            // 
            // lb_accmanage
            // 
            this.lb_accmanage.AutoSize = true;
            this.lb_accmanage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_accmanage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accmanage.Location = new System.Drawing.Point(176, 26);
            this.lb_accmanage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_accmanage.Name = "lb_accmanage";
            this.lb_accmanage.Size = new System.Drawing.Size(316, 44);
            this.lb_accmanage.TabIndex = 26;
            this.lb_accmanage.Text = "Account Manage";
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(577, 602);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(183, 46);
            this.bt_exit.TabIndex = 27;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // accountManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 660);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.lb_accmanage);
            this.Controls.Add(this.gb_manage);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "accountManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accountManage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            this.gb_manage.ResumeLayout(false);
            this.gb_manage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button bt_add;
        private Button bt_delete;
        private Button bt_edit;
        private TextBox tb_search;
        private Button bt_search;
        private TextBox tb_username;
        private TextBox tb_pass;
        private TextBox tb_pass2;
        private Label lb_user;
        private Label lb_pass;
        private Label lb_pass2;
        private ComboBox cb_type;
        private Label lb_type;
        private Label label1;
        private TextBox tb_fullname;
        private ComboBox cb_searchtype;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private RadioButton rb_Male;
        private RadioButton rb_female;
        private TextBox tb_Phone;
        private TextBox tb_gmail;
        private Label label2;
        private Label label3;
        private Button bt_view;
        private GroupBox gb_search;
        private GroupBox gb_manage;
        private Label lb_accmanage;
        private Label lb_searchbyname;
        private Label lb_searchbytype;
        private Label lb_gender;
        private Button bt_exit;
    }
}