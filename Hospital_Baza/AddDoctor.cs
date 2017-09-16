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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            var connString = @"Data Source=SEBUHI\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=False;User ID=sa;Password=Aa135246;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);

            var selectsql = "Select * from [dbo].[Department]";
            var selectCmd = new SqlCommand(selectsql, conn);

            var adaptr = new SqlDataAdapter(selectCmd);
            var ds = new DataSet();
            adaptr.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Department.Items.Add(ds.Tables[0].Rows[i]["Name"].ToString());

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=SEBUHI\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=False;User ID=sa;Password=Aa135246;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            var textName = Name.Text;
            var textSurName = SurName.Text;
            var textPhone = Phone.Text;
            var textEmail = Email.Text;
            var textDepartment = Department.Text;

            var sql = "Insert into [dbo].[Doctor](Name,Email,Fax,Phone)Values('" + textDepartament + "','" + textEmail + "','" + textFax + "','" + textPhone + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
