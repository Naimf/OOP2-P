namespace C__Project.Resources.Project_UC
{
    partial class UC_NewAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Admin_u_nameTxt = new System.Windows.Forms.TextBox();
            this.con_admin_pass_txt = new System.Windows.Forms.TextBox();
            this.admin_passTxt = new System.Windows.Forms.TextBox();
            this.Admin_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(59, 180);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(90, 23);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // Admin_u_nameTxt
            // 
            this.Admin_u_nameTxt.Location = new System.Drawing.Point(273, 115);
            this.Admin_u_nameTxt.Multiline = true;
            this.Admin_u_nameTxt.Name = "Admin_u_nameTxt";
            this.Admin_u_nameTxt.Size = new System.Drawing.Size(291, 22);
            this.Admin_u_nameTxt.TabIndex = 3;
            // 
            // con_admin_pass_txt
            // 
            this.con_admin_pass_txt.Location = new System.Drawing.Point(273, 243);
            this.con_admin_pass_txt.Multiline = true;
            this.con_admin_pass_txt.Name = "con_admin_pass_txt";
            this.con_admin_pass_txt.Size = new System.Drawing.Size(291, 22);
            this.con_admin_pass_txt.TabIndex = 5;
            // 
            // admin_passTxt
            // 
            this.admin_passTxt.Location = new System.Drawing.Point(273, 181);
            this.admin_passTxt.Multiline = true;
            this.admin_passTxt.Name = "admin_passTxt";
            this.admin_passTxt.Size = new System.Drawing.Size(291, 22);
            this.admin_passTxt.TabIndex = 6;
            // 
            // Admin_save
            // 
            this.Admin_save.Location = new System.Drawing.Point(310, 330);
            this.Admin_save.Name = "Admin_save";
            this.Admin_save.Size = new System.Drawing.Size(136, 53);
            this.Admin_save.TabIndex = 7;
            this.Admin_save.Text = "Save";
            this.Admin_save.UseVisualStyleBackColor = true;
            this.Admin_save.Click += new System.EventHandler(this.Admin_save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UC_NewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C__Project.Properties.Resources._1000_F_245708642_0brMi7CSdqAGOGkfvdj2x9WTjsRCDIE31;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Admin_save);
            this.Controls.Add(this.admin_passTxt);
            this.Controls.Add(this.con_admin_pass_txt);
            this.Controls.Add(this.Admin_u_nameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Name = "UC_NewAdmin";
            this.Size = new System.Drawing.Size(608, 459);
            this.Load += new System.EventHandler(this.UC_NewAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Admin_u_nameTxt;
        private System.Windows.Forms.TextBox con_admin_pass_txt;
        private System.Windows.Forms.TextBox admin_passTxt;
        private System.Windows.Forms.Button Admin_save;
        private System.Windows.Forms.Button button2;
    }
}
