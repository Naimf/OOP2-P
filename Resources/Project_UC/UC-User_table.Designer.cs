namespace C__Project.Resources.Project_UC
{
    partial class UC_User_table
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.showallBtn = new System.Windows.Forms.Button();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(348, 369);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(119, 48);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // showallBtn
            // 
            this.showallBtn.Location = new System.Drawing.Point(187, 369);
            this.showallBtn.Name = "showallBtn";
            this.showallBtn.Size = new System.Drawing.Size(119, 48);
            this.showallBtn.TabIndex = 2;
            this.showallBtn.Text = "Show All";
            this.showallBtn.UseVisualStyleBackColor = true;
            this.showallBtn.Click += new System.EventHandler(this.showallBtn_Click);
            // 
            // ID_box
            // 
            this.ID_box.Location = new System.Drawing.Point(126, 49);
            this.ID_box.Multiline = true;
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(302, 22);
            this.ID_box.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 252);
            this.dataGridView1.TabIndex = 4;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = global::C__Project.Properties.Resources.city_urban_design_24908_328012;
            this.SearchBtn.Location = new System.Drawing.Point(464, 42);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(105, 29);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // UC_User_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::C__Project.Properties.Resources._1000_F_245708642_0brMi7CSdqAGOGkfvdj2x9WTjsRCDIE3;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ID_box);
            this.Controls.Add(this.showallBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SearchBtn);
            this.Name = "UC_User_table";
            this.Size = new System.Drawing.Size(608, 459);
            this.Load += new System.EventHandler(this.UC_User_table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button showallBtn;
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
