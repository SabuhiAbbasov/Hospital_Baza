namespace Hospital_Baza
{
    partial class EditDepartment
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
            this.label1 = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.ComboBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Fax = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şöbə seç";
            // 
            // Department
            // 
            this.Department.FormattingEnabled = true;
            this.Department.Location = new System.Drawing.Point(89, 13);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(133, 21);
            this.Department.TabIndex = 1;
            this.Department.SelectedIndexChanged += new System.EventHandler(this.Department_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(16, 51);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(122, 51);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // Fax
            // 
            this.Fax.Location = new System.Drawing.Point(16, 77);
            this.Fax.Name = "Fax";
            this.Fax.Size = new System.Drawing.Size(100, 20);
            this.Fax.TabIndex = 2;
            this.Fax.Text = "Fax";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(122, 77);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(100, 20);
            this.Phone.TabIndex = 2;
            this.Phone.Text = "Phone";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(82, 103);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // EditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 132);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Fax);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.label1);
            this.Text = "EditDepartment";
            this.Load += new System.EventHandler(this.EditDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Department;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Fax;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button Edit;
    }
}