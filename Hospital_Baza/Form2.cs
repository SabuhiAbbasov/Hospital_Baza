using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Baza
{
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }


        private void Add_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=SEBUHI\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=False;User ID=sa;Password=Aa135246;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            var textDepartament = Departament.Text;
            var textEmail = Email.Text;
            var textFax = Fax.Text;
            var textPhone = Phone.Text;

            var sql = "Insert into [dbo].[Department](Name,Email,Fax,Phone)Values('" + textDepartament + "','" + textEmail + "','" + textFax + "','" + textPhone + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            FullDepartment.Text = Departament.Text + " " + Email.Text + " " + Fax.Text + " " + Phone.Text;
        }
    }
}
