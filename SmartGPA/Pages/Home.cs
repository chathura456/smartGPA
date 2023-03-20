using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGPA.Pages
{
    public partial class Home : Form
    {
        private HomeUi _form1;
        public Home(HomeUi form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value= 0;
            circularProgressBar1.Minimum= 0;
            circularProgressBar1.Maximum= 100;

            string gpa = _form1.GetGpaLabelText();
            circularProgressBar1.Text= gpa;
            double gpaProgess = double.Parse(gpa)*25;
            

            for (int i=0; i <= gpaProgess; i++)
            {
                Thread.Sleep(30);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            if (_form1.WindowState == FormWindowState.Normal)
            {
                circularProgressBar1.Size = new System.Drawing.Size(250, 250);
            }
            else
            {
                circularProgressBar1.Size = new System.Drawing.Size(320, 320);
            }
        }
    }
    
}
