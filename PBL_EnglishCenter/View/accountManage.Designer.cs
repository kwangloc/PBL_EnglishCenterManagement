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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(1073, 487);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(124, 42);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(749, 485);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(91, 47);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(943, 487);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(124, 42);
            this.bt_edit.TabIndex = 3;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(813, 56);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(139, 22);
            this.tb_search.TabIndex = 4;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(966, 55);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 23);
            this.bt_search.TabIndex = 5;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(869, 204);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 22);
            this.tb_username.TabIndex = 6;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(869, 269);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(100, 22);
            this.tb_pass.TabIndex = 7;
            // 
            // tb_pass2
            // 
            this.tb_pass2.Location = new System.Drawing.Point(869, 323);
            this.tb_pass2.Name = "tb_pass2";
            this.tb_pass2.PasswordChar = '*';
            this.tb_pass2.Size = new System.Drawing.Size(100, 22);
            this.tb_pass2.TabIndex = 8;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(783, 209);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(73, 16);
            this.lb_user.TabIndex = 9;
            this.lb_user.Text = "Username:";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(780, 275);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(70, 16);
            this.lb_pass.TabIndex = 10;
            this.lb_pass.Text = "Password:";
            // 
            // lb_pass2
            // 
            this.lb_pass2.AutoSize = true;
            this.lb_pass2.Location = new System.Drawing.Point(746, 327);
            this.lb_pass2.Name = "lb_pass2";
            this.lb_pass2.Size = new System.Drawing.Size(110, 16);
            this.lb_pass2.TabIndex = 11;
            this.lb_pass2.Text = "Check password:";
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(870, 368);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(99, 24);
            this.cb_type.TabIndex = 12;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(805, 377);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(39, 16);
            this.lb_type.TabIndex = 13;
            this.lb_type.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(993, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fullname:";
            // 
            // tb_fullname
            // 
            this.tb_fullname.Location = new System.Drawing.Point(1073, 206);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(100, 22);
            this.tb_fullname.TabIndex = 15;
            // 
            // cb_searchtype
            // 
            this.cb_searchtype.FormattingEnabled = true;
            this.cb_searchtype.Location = new System.Drawing.Point(813, 17);
            this.cb_searchtype.Name = "cb_searchtype";
            this.cb_searchtype.Size = new System.Drawing.Size(121, 24);
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
            this.rb_Male.Location = new System.Drawing.Point(1076, 241);
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
            this.rb_female.Location = new System.Drawing.Point(1076, 265);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(74, 20);
            this.rb_female.TabIndex = 18;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(1076, 308);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(100, 22);
            this.tb_Phone.TabIndex = 19;
            // 
            // tb_gmail
            // 
            this.tb_gmail.Location = new System.Drawing.Point(1076, 361);
            this.tb_gmail.Name = "tb_gmail";
            this.tb_gmail.Size = new System.Drawing.Size(100, 22);
            this.tb_gmail.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1015, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1018, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gmail:";
            // 
            // bt_view
            // 
            this.bt_view.Location = new System.Drawing.Point(847, 487);
            this.bt_view.Name = "bt_view";
            this.bt_view.Size = new System.Drawing.Size(87, 42);
            this.bt_view.TabIndex = 23;
            this.bt_view.Text = "View";
            this.bt_view.UseVisualStyleBackColor = true;
            this.bt_view.Click += new System.EventHandler(this.bt_view_Click);
            // 
            // accountManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 666);
            this.Controls.Add(this.bt_view);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_gmail);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_Male);
            this.Controls.Add(this.cb_searchtype);
            this.Controls.Add(this.tb_fullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.lb_pass2);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.tb_pass2);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "accountManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "accountManage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}