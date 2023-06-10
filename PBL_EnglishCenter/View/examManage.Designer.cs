namespace PBL_EnglishCenter.View
{
    partial class examManage
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
            this.lb_courseId = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.rtb_des = new System.Windows.Forms.RichTextBox();
            this.tb_courseName = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.lb_des = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_function = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_courseId
            // 
            this.lb_courseId.AutoSize = true;
            this.lb_courseId.Location = new System.Drawing.Point(404, 160);
            this.lb_courseId.Name = "lb_courseId";
            this.lb_courseId.Size = new System.Drawing.Size(53, 16);
            this.lb_courseId.TabIndex = 13;
            this.lb_courseId.Text = "Course:";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(860, 505);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(125, 36);
            this.bt_cancel.TabIndex = 11;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(589, 505);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(125, 36);
            this.bt_ok.TabIndex = 12;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // rtb_des
            // 
            this.rtb_des.Location = new System.Drawing.Point(497, 271);
            this.rtb_des.Name = "rtb_des";
            this.rtb_des.Size = new System.Drawing.Size(558, 181);
            this.rtb_des.TabIndex = 10;
            this.rtb_des.Text = "";
            // 
            // tb_courseName
            // 
            this.tb_courseName.Location = new System.Drawing.Point(497, 160);
            this.tb_courseName.Name = "tb_courseName";
            this.tb_courseName.Size = new System.Drawing.Size(272, 22);
            this.tb_courseName.TabIndex = 8;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(497, 209);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(558, 22);
            this.tb_title.TabIndex = 9;
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Location = new System.Drawing.Point(401, 271);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(75, 16);
            this.lb_des.TabIndex = 5;
            this.lb_des.Text = "Description";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Location = new System.Drawing.Point(401, 209);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(33, 16);
            this.lb_title.TabIndex = 6;
            this.lb_title.Text = "Title";
            // 
            // lb_function
            // 
            this.lb_function.AutoSize = true;
            this.lb_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_function.Location = new System.Drawing.Point(583, 88);
            this.lb_function.Name = "lb_function";
            this.lb_function.Size = new System.Drawing.Size(196, 32);
            this.lb_function.TabIndex = 7;
            this.lb_function.Text = "Manage Exam";
            // 
            // examManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 977);
            this.Controls.Add(this.lb_courseId);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.rtb_des);
            this.Controls.Add(this.tb_courseName);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.lb_des);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lb_function);
            this.Name = "examManage";
            this.Text = "examManage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_courseId;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.RichTextBox rtb_des;
        private System.Windows.Forms.TextBox tb_courseName;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_function;
    }
}