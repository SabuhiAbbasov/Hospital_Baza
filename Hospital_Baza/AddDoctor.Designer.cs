namespace Hospital_Baza
{
    partial class AddDoctor
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
            this.Name = new System.Windows.Forms.TextBox();
            this.SurName = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.ComboBox();
            this.Novbe = new System.Windows.Forms.ComboBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(13, 13);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(116, 20);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // SurName
            // 
            this.SurName.Location = new System.Drawing.Point(135, 12);
            this.SurName.Name = "SurName";
            this.SurName.Size = new System.Drawing.Size(116, 20);
            this.SurName.TabIndex = 0;
            this.SurName.Text = "SurName";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(13, 39);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(116, 20);
            this.Phone.TabIndex = 0;
            this.Phone.Text = "Phone";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(135, 38);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(116, 20);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            // 
            // Department
            // 
            this.Department.FormattingEnabled = true;
            this.Department.Location = new System.Drawing.Point(13, 66);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(116, 21);
            this.Department.TabIndex = 1;
            this.Department.Text = "Department";
            // 
            // Novbe
            // 
            this.Novbe.FormattingEnabled = true;
            this.Novbe.Location = new System.Drawing.Point(136, 66);
            this.Novbe.Name = "Novbe";
            this.Novbe.Size = new System.Drawing.Size(115, 21);
            this.Novbe.TabIndex = 2;
            this.Novbe.Text = "Novbe";
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(13, 94);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(116, 20);
            this.StartDate.TabIndex = 3;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(136, 93);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(115, 20);
            this.EndDate.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(85, 119);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(91, 36);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 162);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Novbe);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.SurName);
            this.Controls.Add(this.Name);
            this.Text = "AddDoctor";
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox SurName;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.ComboBox Department;
        private System.Windows.Forms.ComboBox Novbe;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Button Add;
    }
}