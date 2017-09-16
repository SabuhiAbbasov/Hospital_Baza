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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addDepartment_Click(object sender, EventArgs e)
        {
            AddDepartment myForm = new AddDepartment();
            //this.Hide();//
            myForm.Show();


        }

        private void EditDepartment_Click(object sender, EventArgs e)
        {
            EditDepartment myForm = new EditDepartment();
            myForm.Show();
        }

        private void DeleteDepartment_Click(object sender, EventArgs e)
        {
            DeleteDep myform = new DeleteDep();
            myform.Show();
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {

        }
    }
}
