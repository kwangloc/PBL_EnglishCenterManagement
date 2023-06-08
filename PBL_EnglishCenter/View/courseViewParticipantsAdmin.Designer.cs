namespace PBL_EnglishCenter.View
{
    partial class courseViewParticipantsAdmin
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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.gb_infor = new System.Windows.Forms.GroupBox();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.bt_remove = new System.Windows.Forms.Button();
            this.tb_searchToAdd = new System.Windows.Forms.TextBox();
            this.bt_searchToAdd = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bt_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 555);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(490, 69);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(225, 22);
            this.tb_search.TabIndex = 1;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(734, 58);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(121, 44);
            this.bt_search.TabIndex = 2;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // gb_infor
            // 
            this.gb_infor.Controls.Add(this.bt_add);
            this.gb_infor.Controls.Add(this.dataGridView2);
            this.gb_infor.Controls.Add(this.bt_searchToAdd);
            this.gb_infor.Controls.Add(this.tb_searchToAdd);
            this.gb_infor.Location = new System.Drawing.Point(885, 92);
            this.gb_infor.Name = "gb_infor";
            this.gb_infor.Size = new System.Drawing.Size(516, 580);
            this.gb_infor.TabIndex = 3;
            this.gb_infor.TabStop = false;
            this.gb_infor.Text = "Add student";
            // 
            // lb_quantity
            // 
            this.lb_quantity.AutoSize = true;
            this.lb_quantity.Location = new System.Drawing.Point(84, 718);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(102, 16);
            this.lb_quantity.TabIndex = 4;
            this.lb_quantity.Text = "This course has";
            // 
            // bt_remove
            // 
            this.bt_remove.Location = new System.Drawing.Point(508, 704);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(121, 44);
            this.bt_remove.TabIndex = 2;
            this.bt_remove.Text = "Remove";
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // tb_searchToAdd
            // 
            this.tb_searchToAdd.Location = new System.Drawing.Point(115, 30);
            this.tb_searchToAdd.Name = "tb_searchToAdd";
            this.tb_searchToAdd.Size = new System.Drawing.Size(225, 22);
            this.tb_searchToAdd.TabIndex = 1;
            // 
            // bt_searchToAdd
            // 
            this.bt_searchToAdd.Location = new System.Drawing.Point(371, 25);
            this.bt_searchToAdd.Name = "bt_searchToAdd";
            this.bt_searchToAdd.Size = new System.Drawing.Size(121, 33);
            this.bt_searchToAdd.TabIndex = 2;
            this.bt_searchToAdd.Text = "Search to add";
            this.bt_searchToAdd.UseVisualStyleBackColor = true;
            this.bt_searchToAdd.Click += new System.EventHandler(this.bt_searchToAdd_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 94);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(468, 370);
            this.dataGridView2.TabIndex = 3;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(357, 498);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(88, 39);
            this.bt_add.TabIndex = 4;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // courseViewParticipantsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 796);
            this.Controls.Add(this.lb_quantity);
            this.Controls.Add(this.gb_infor);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "courseViewParticipantsAdmin";
            this.Text = "courseViewParticipantsAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_infor.ResumeLayout(false);
            this.gb_infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.GroupBox gb_infor;
        private System.Windows.Forms.Label lb_quantity;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bt_searchToAdd;
        private System.Windows.Forms.TextBox tb_searchToAdd;
    }
}