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
    public partial class FormFindSpace : System.Windows.Forms.Form
    {
        Garage garage;
        Student student;
        int ticks = 0;

        public FormFindSpace(Student s, Garage g)
        {
            garage = g;
            student = s;
            InitializeComponent();
            this.Text = garage.name;
            label1.Text = "Available Spaces: " + garage.availableSpaces(student.category);
            label2.Text = "Cars Waiting: " + garage.waitingCars;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (garage.availableSpaces(student.category) <= 0)
            {
                MessageBox.Show("No Available Spaces");
            }
            else
            {
                garage.parkCar(student.category);
                MessageBox.Show("Space Found");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks % 100 == 0)
            {
                Random r = new Random();
                int i = r.Next(0, 4);
                int j = r.Next(0, 3);
                string cat;
                if (j == 0)
                {
                    cat = "E";
                }
                else if (j == 1)
                {
                    cat = "S";
                }
                else
                {
                    cat = "R";
                }

                if (i == 0)
                {
                    garage.enterCar();
                }
                else if (i == 1)
                {
                    if (garage.waitingCars > 0)
                        garage.parkCar(cat);
                    else
                        garage.enterCar();
                }
                else if (i == 2)
                {
                    if (garage.waitingCars > 0)
                        garage.exitCar();
                    else
                        garage.exitCarFromSpace(cat);
                }
                else
                {
                    garage.exitCarFromSpace(cat);
                }
            }
            label1.Text = "Available Spaces: " + garage.availableSpaces(student.category);
            label2.Text = "Cars Waiting: " + garage.waitingCars;
        }

        private void FormFindSpace_Load(object sender, EventArgs e)
        {

        }
    }
}
