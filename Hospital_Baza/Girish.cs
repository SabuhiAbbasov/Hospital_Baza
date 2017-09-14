using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Baza
{
    public partial class Girish : Form
    {
        public Girish()
        {
            InitializeComponent();
            password_user.PasswordChar = '*';
            password_user.MaxLength = 10;
        }

        private void Girish_Load(object sender, EventArgs e)
        {
        }

        private void ClickUser_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=SEBUHI\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=False;User ID=sa;Password=Aa135246;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            var selectsql = "Select * from [dbo].[USERR]";
            var selectCmd = new SqlCommand(selectsql, conn);

            var adaptr = new SqlDataAdapter(selectCmd);
            var ds = new DataSet();
            adaptr.Fill(ds);

            var userText = userName.Text;
            var passText = password_user.Text;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToString(ds.Tables[0].Rows[i]["Username"])== userText && Convert.ToString(ds.Tables[0].Rows[i]["Password"]) == passText)
                {
                    Form1 myForm = new Form1();
                    this.Hide();
                    myForm.Show();
                }
                else
                {
                    label4.Visible = true;
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
