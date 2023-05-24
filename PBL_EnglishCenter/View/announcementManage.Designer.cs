namespace PBL_EnglishCenter.View
{
    partial class announcementManage
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
            this.lb_function = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_des = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.rtb_des = new System.Windows.Forms.RichTextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.lb_courseId = new System.Windows.Forms.Label();
            this.tb_courseId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_function
            // 
            this.lb_function.AutoSize = true;
            this.lb_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_function.Location = new System.Drawing.Point(499, 106);
            this.lb_function.Name = "lb_function";
            this.lb_function.Size = new System.Drawing.Size(319, 32);
            this.lb_function.TabIndex = 0;
            this.lb_function.Text = "ADD ANNOUNCEMENT";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Location = new System.Drawing.Point(314, 212);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(33, 16);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Title";
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Location = new System.Drawing.Point(314, 274);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(75, 16);
            this.lb_des.TabIndex = 0;
            this.lb_des.Text = "Description";
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(410, 212);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(558, 22);
            this.tb_title.TabIndex = 1;
            // 
            // rtb_des
            // 
            this.rtb_des.Location = new System.Drawing.Point(410, 274);
            this.rtb_des.Name = "rtb_des";
            this.rtb_des.Size = new System.Drawing.Size(558, 181);
            this.rtb_des.TabIndex = 2;
            this.rtb_des.Text = "";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(502, 508);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(125, 36);
            this.bt_add.TabIndex = 3;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(773, 508);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(125, 36);
            this.bt_cancel.TabIndex = 3;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // lb_courseId
            // 
            this.lb_courseId.AutoSize = true;
            this.lb_courseId.Location = new System.Drawing.Point(317, 163);
            this.lb_courseId.Name = "lb_courseId";
            this.lb_courseId.Size = new System.Drawing.Size(66, 16);
            this.lb_courseId.TabIndex = 4;
            this.lb_courseId.Text = "Course ID";
            // 
            // tb_courseId
            // 
            this.tb_courseId.Location = new System.Drawing.Point(410, 163);
            this.tb_courseId.Name = "tb_courseId";
            this.tb_courseId.Size = new System.Drawing.Size(139, 22);
            this.tb_courseId.TabIndex = 1;
            // 
            // announcementManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 977);
            this.Controls.Add(this.lb_courseId);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.rtb_des);
            this.Controls.Add(this.tb_courseId);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.lb_des);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lb_function);
            this.Name = "announcementManage";
            this.Text = "announcementManage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_function;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.RichTextBox rtb_des;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label lb_courseId;
        private System.Windows.Forms.TextBox tb_courseId;
    }
}