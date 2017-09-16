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
    public partial class EditDepartment : Form
    {
        public EditDepartment()
        {
            InitializeComponent();
        }

        private void EditDepartment_Load(object sender, EventArgs e)
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

        private void Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connString = @"Data Source=SEBUHI\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=False;User ID=sa;Password=Aa135246;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            var texName = Department.Text;

            var selectsql = "Select from [dbo].[Department] Where Name = '" + texName + "'";
            var selectCmd = new SqlCommand(selectsql, conn);
            selectCmd.ExecuteNonQuery();
            var adaptr = new SqlDataAdapter(selectCmd);
            var ds = new DataSet();
            adaptr.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Name.Text = ds.Tables[0].Rows[i]["Name"].ToString();
                Email.Text = ds.Tables[0].Rows[i]["Email"].ToString();
                Fax.Text = ds.Tables[0].Rows[i]["Fax"].ToString();
                Phone.Text = ds.Tables[0].Rows[i]["Phone"].ToString();
            }
            conn.Close();
        }
    }
}
