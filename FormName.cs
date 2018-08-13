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
    public partial class FormName : System.Windows.Forms.Form
    {
        public FormName(string name)
        {
            InitializeComponent();
            labelName.Text = "Hello " + name;
        }

        private void FormName_Load(object sender, EventArgs e)
        {

        }
    }
}
