namespace PBL_EnglishCenter.View
{
    partial class courseDetailsStudent
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
            this.bt_exit = new System.Windows.Forms.Button();
            this.lb_ann = new System.Windows.Forms.Label();
            this.lb_doc = new System.Windows.Forms.Label();
            this.lb_exa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bt_viewResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(783, 810);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(116, 43);
            this.bt_exit.TabIndex = 0;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // lb_ann
            // 
            this.lb_ann.AutoSize = true;
            this.lb_ann.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ann.Location = new System.Drawing.Point(105, 70);
            this.lb_ann.Name = "lb_ann";
            this.lb_ann.Size = new System.Drawing.Size(179, 29);
            this.lb_ann.TabIndex = 1;
            this.lb_ann.Text = "Announcement:";
            // 
            // lb_doc
            // 
            this.lb_doc.AutoSize = true;
            this.lb_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doc.Location = new System.Drawing.Point(105, 317);
            this.lb_doc.Name = "lb_doc";
            this.lb_doc.Size = new System.Drawing.Size(128, 29);
            this.lb_doc.TabIndex = 1;
            this.lb_doc.Text = "Document:";
            // 
            // lb_exa
            // 
            this.lb_exa.AutoSize = true;
            this.lb_exa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exa.Location = new System.Drawing.Point(105, 566);
            this.lb_exa.Name = "lb_exa";
            this.lb_exa.Size = new System.Drawing.Size(79, 29);
            this.lb_exa.TabIndex = 1;
            this.lb_exa.Text = "Exam:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(836, 204);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(296, 356);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(836, 204);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(296, 600);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(836, 204);
            this.dataGridView3.TabIndex = 2;
            // 
            // bt_viewResult
            // 
            this.bt_viewResult.Location = new System.Drawing.Point(1157, 683);
            this.bt_viewResult.Name = "bt_viewResult";
            this.bt_viewResult.Size = new System.Drawing.Size(136, 31);
            this.bt_viewResult.TabIndex = 0;
            this.bt_viewResult.Text = "View result";
            this.bt_viewResult.UseVisualStyleBackColor = true;
            this.bt_viewResult.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // courseDetailsStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 859);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_exa);
            this.Controls.Add(this.lb_doc);
            this.Controls.Add(this.lb_ann);
            this.Controls.Add(this.bt_viewResult);
            this.Controls.Add(this.bt_exit);
            this.Name = "courseDetailsStudent";
            this.Text = "courseDetailsStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label lb_ann;
        private System.Windows.Forms.Label lb_doc;
        private System.Windows.Forms.Label lb_exa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        internal System.Windows.Forms.Button bt_viewResult;
    }
}