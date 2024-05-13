namespace C__Project.Resources.Project_UC
{
    partial class UC_Admin_property
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Admin_Prop_show = new System.Windows.Forms.Button();
            this.Admn_del_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P_id_del = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(534, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Admin_Prop_show
            // 
            this.Admin_Prop_show.Location = new System.Drawing.Point(96, 126);
            this.Admin_Prop_show.Name = "Admin_Prop_show";
            this.Admin_Prop_show.Size = new System.Drawing.Size(144, 41);
            this.Admin_Prop_show.TabIndex = 1;
            this.Admin_Prop_show.Text = "Show";
            this.Admin_Prop_show.UseVisualStyleBackColor = true;
            this.Admin_Prop_show.Click += new System.EventHandler(this.Admin_Prop_show_Click);
            // 
            // Admn_del_btn
            // 
            this.Admn_del_btn.Location = new System.Drawing.Point(391, 409);
            this.Admn_del_btn.Name = "Admn_del_btn";
            this.Admn_del_btn.Size = new System.Drawing.Size(173, 41);
            this.Admn_del_btn.TabIndex = 2;
            this.Admn_del_btn.Text = "Delete";
            this.Admn_del_btn.UseVisualStyleBackColor = true;
            this.Admn_del_btn.Click += new System.EventHandler(this.Admn_del_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(309, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // P_id_del
            // 
            this.P_id_del.Location = new System.Drawing.Point(67, 418);
            this.P_id_del.Multiline = true;
            this.P_id_del.Name = "P_id_del";
            this.P_id_del.Size = new System.Drawing.Size(256, 32);
            this.P_id_del.TabIndex = 4;
            // 
            // UC_Admin_property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C__Project.Properties.Resources.city_urban_design_24908_32801;
            this.Controls.Add(this.P_id_del);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Admn_del_btn);
            this.Controls.Add(this.Admin_Prop_show);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_Admin_property";
            this.Size = new System.Drawing.Size(608, 459);
            this.Load += new System.EventHandler(this.UC_Admin_property_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Admin_Prop_show;
        private System.Windows.Forms.Button Admn_del_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox P_id_del;
    }
}
