namespace Hospital_Baza
{
    partial class Form1
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
            this.addDepartment = new System.Windows.Forms.Button();
            this.EditDepartment = new System.Windows.Forms.Button();
            this.DeleteDepartment = new System.Windows.Forms.Button();
            this.AddDoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDepartment
            // 
            this.addDepartment.Location = new System.Drawing.Point(12, 12);
            this.addDepartment.Name = "addDepartment";
            this.addDepartment.Size = new System.Drawing.Size(121, 37);
            this.addDepartment.TabIndex = 0;
            this.addDepartment.Text = "Şöbə əlavə et";
            this.addDepartment.UseVisualStyleBackColor = true;
            this.addDepartment.Click += new System.EventHandler(this.addDepartment_Click);
            // 
            // EditDepartment
            // 
            this.EditDepartment.Location = new System.Drawing.Point(267, 12);
            this.EditDepartment.Name = "EditDepartment";
            this.EditDepartment.Size = new System.Drawing.Size(120, 37);
            this.EditDepartment.TabIndex = 1;
            this.EditDepartment.Text = "EditDepartment";
            this.EditDepartment.UseVisualStyleBackColor = true;
            this.EditDepartment.Click += new System.EventHandler(this.EditDepartment_Click);
            // 
            // DeleteDepartment
            // 
            this.DeleteDepartment.Location = new System.Drawing.Point(140, 12);
            this.DeleteDepartment.Name = "DeleteDepartment";
            this.DeleteDepartment.Size = new System.Drawing.Size(121, 37);
            this.DeleteDepartment.TabIndex = 2;
            this.DeleteDepartment.Text = "Delete Department";
            this.DeleteDepartment.UseVisualStyleBackColor = true;
            this.DeleteDepartment.Click += new System.EventHandler(this.DeleteDepartment_Click);
            // 
            // AddDoctor
            // 
            this.AddDoctor.Location = new System.Drawing.Point(12, 56);
            this.AddDoctor.Name = "AddDoctor";
            this.AddDoctor.Size = new System.Drawing.Size(121, 37);
            this.AddDoctor.TabIndex = 3;
            this.AddDoctor.Text = "Add Doctor";
            this.AddDoctor.UseVisualStyleBackColor = true;
            this.AddDoctor.Click += new System.EventHandler(this.AddDoctor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 287);
            this.Controls.Add(this.AddDoctor);
            this.Controls.Add(this.DeleteDepartment);
            this.Controls.Add(this.EditDepartment);
            this.Controls.Add(this.addDepartment);
            this.Name = "Form1";
            this.Text = "Departament";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDepartment;
        private System.Windows.Forms.Button EditDepartment;
        private System.Windows.Forms.Button DeleteDepartment;
        private System.Windows.Forms.Button AddDoctor;
    }
}

