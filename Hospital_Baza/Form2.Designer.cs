namespace Hospital_Baza
{
    partial class Form2
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
            this.Add = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Fax = new System.Windows.Forms.TextBox();
            this.Departament = new System.Windows.Forms.TextBox();
            this.FullDepartment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(135, 64);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(12, 38);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(147, 20);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(187, 38);
            this.Phone.Multiline = true;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(137, 20);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "Phone";
            // 
            // Fax
            // 
            this.Fax.Location = new System.Drawing.Point(187, 12);
            this.Fax.Multiline = true;
            this.Fax.Name = "Fax";
            this.Fax.Size = new System.Drawing.Size(137, 20);
            this.Fax.TabIndex = 4;
            this.Fax.Text = "Fax";
            // 
            // Departament
            // 
            this.Departament.Location = new System.Drawing.Point(12, 12);
            this.Departament.Multiline = true;
            this.Departament.Name = "Departament";
            this.Departament.Size = new System.Drawing.Size(147, 20);
            this.Departament.TabIndex = 5;
            this.Departament.Text = "Şöbə";
            // 
            // FullDepartment
            // 
            this.FullDepartment.Location = new System.Drawing.Point(12, 93);
            this.FullDepartment.Multiline = true;
            this.FullDepartment.Name = "FullDepartment";
            this.FullDepartment.Size = new System.Drawing.Size(312, 20);
            this.FullDepartment.TabIndex = 5;
            this.FullDepartment.Text = "Şöbə,Fax,Email,Phone";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 120);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Fax);
            this.Controls.Add(this.FullDepartment);
            this.Controls.Add(this.Departament);
            this.Name = "Form2";
            this.Text = "AddDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Fax;
        private System.Windows.Forms.TextBox Departament;
        private System.Windows.Forms.TextBox FullDepartment;
    }
}