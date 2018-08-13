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
    public partial class FormGarages : System.Windows.Forms.Form
    {
        Student student;
        EISDatabase2DataSetTableAdapters.usf_parking_database2TableAdapter adapter = new EISDatabase2DataSetTableAdapters.usf_parking_database2TableAdapter();
        public FormGarages(Student s)
        {
            InitializeComponent();
            student = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int E = Int32.Parse(adapter.RichardE().ToString());
            int R = Int32.Parse(adapter.RichardR().ToString());
            int S = Int32.Parse(adapter.RichardS().ToString());
            int cars = Int32.Parse(adapter.RichardCars().ToString());
            FormFindSpace next = new FormFindSpace(student, new Garage(button1.Text, R, S, E, cars));
            next.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int E = Int32.Parse(adapter.LaurelE().ToString());
            int R = Int32.Parse(adapter.LaurelR().ToString());
            int S = Int32.Parse(adapter.LaurelS().ToString());
            int cars = Int32.Parse(adapter.LaurelCars().ToString());
            FormFindSpace next = new FormFindSpace(student, new Garage(button2.Text, R, S, E, cars));
            next.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int E = Int32.Parse(adapter.CrescentE().ToString());
            int R = Int32.Parse(adapter.CrescentR().ToString());
            int S = Int32.Parse(adapter.CrescentS().ToString());
            int cars = Int32.Parse(adapter.CrescentCars().ToString());
            FormFindSpace next = new FormFindSpace(student, new Garage(button3.Text, R, S, E, cars));
            next.Show();
        }

        private void FormGarages_Load(object sender, EventArgs e)
        {

        }
    }
}
