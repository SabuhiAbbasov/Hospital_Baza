namespace Hospital_Baza
{
    partial class DeleteDep
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
            this.DepartamentName = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepartamentName
            // 
            this.DepartamentName.FormattingEnabled = true;
            this.DepartamentName.Location = new System.Drawing.Point(12, 12);
            this.DepartamentName.Name = "DepartamentName";
            this.DepartamentName.Size = new System.Drawing.Size(190, 21);
            this.DepartamentName.TabIndex = 0;
            this.DepartamentName.Text = "Şöbə seç";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(70, 39);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 69);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.DepartamentName);
            this.Name = "DeleteDep";
            this.Text = "DeleteDep";
            this.Load += new System.EventHandler(this.DeleteDep_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox DepartamentName;
        private System.Windows.Forms.Button Delete;
    }
}