using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USFParking
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Database2DataSetTableAdapters.usf_parkingTableAdapter adapter = new Database2DataSetTableAdapters.usf_parkingTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        public Student getStudent()
        {
            return new Student(adapter.FirstName(textUserName.Text, textPassword.Text), adapter.LastName(textUserName.Text, textPassword.Text), textUserName.Text, textPassword.Text, adapter.Category(textUserName.Text, textPassword.Text));
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           
            if(adapter.Login(textUserName.Text,textPassword.Text).Rows.Count > 0)
            {
                FormParking parking = new FormParking(getStudent());
                parking.Show();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
