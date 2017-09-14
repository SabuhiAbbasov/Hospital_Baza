namespace Hospital_Baza
{
    partial class Girish
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClickUser = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "İstifadəçi adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Programa giriş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(47, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parol";
            // 
            // password_user
            // 
            this.password_user.Location = new System.Drawing.Point(109, 100);
            this.password_user.Name = "password_user";
            this.password_user.Size = new System.Drawing.Size(148, 20);
            this.password_user.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Istifadeçi adı və ya parol səfdir";
            this.label4.Visible = false;
            // 
            // ClickUser
            // 
            this.ClickUser.Location = new System.Drawing.Point(140, 127);
            this.ClickUser.Name = "ClickUser";
            this.ClickUser.Size = new System.Drawing.Size(75, 23);
            this.ClickUser.TabIndex = 6;
            this.ClickUser.Text = "Daxil ol";
            this.ClickUser.UseVisualStyleBackColor = true;
            this.ClickUser.Click += new System.EventHandler(this.ClickUser_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(109, 65);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(148, 20);
            this.userName.TabIndex = 7;
            this.userName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Girish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 188);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.ClickUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Girish";
            this.Text = "Girish";
            this.Load += new System.EventHandler(this.Girish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClickUser;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password_user;
    }
}