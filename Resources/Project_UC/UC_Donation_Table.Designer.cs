namespace C__Project.Resources.Project_UC
{
    partial class UC_Donation_Table
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
            this.Sh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(573, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // Sh
            // 
            this.Sh.Location = new System.Drawing.Point(431, 29);
            this.Sh.Name = "Sh";
            this.Sh.Size = new System.Drawing.Size(135, 41);
            this.Sh.TabIndex = 1;
            this.Sh.Text = "Show";
            this.Sh.UseVisualStyleBackColor = true;
            this.Sh.Click += new System.EventHandler(this.Sh_Click);
            // 
            // UC_Donation_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C__Project.Properties.Resources.donate_charity_for_medical_and_health_background_vector;
            this.Controls.Add(this.Sh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_Donation_Table";
            this.Size = new System.Drawing.Size(608, 459);
            this.Load += new System.EventHandler(this.UC_Donation_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Sh;
    }
}
