using SmartGPA.Models;
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
        private LoadFileData loadFileData;
        string gpa = "0.00";
        BackgroundWorker backgroundWorker1;
        public Home(HomeUi form1)
        {
            InitializeComponent();
            _form1 = form1;
            loadFileData = new LoadFileData();
            Shown += new EventHandler(Form1_Shown);
            backgroundWorker1= new BackgroundWorker();
            // To report progress from the background worker we need to set this property
            backgroundWorker1.WorkerReportsProgress = true;
            // This event will be raised on the worker thread when the worker starts
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            // This event will be raised when we call ReportProgress
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }

        void Form1_Shown(object sender, EventArgs e)
        {
            // Start the background worker
            backgroundWorker1.RunWorkerAsync();
        }
        // On worker thread so do our thing!
        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            double gpaProgess = double.Parse(gpa) * 25;
            // Your background task goes here
            for (int i = 0; i <= gpaProgess; i++)
            {
                // Report progress to 'UI' thread
                backgroundWorker1.ReportProgress(i);
                // Simulate long task
                System.Threading.Thread.Sleep(1);
            }
        }
        // Back on the 'UI' thread so we can update the progress bar
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            circularProgressBar1.Value = e.ProgressPercentage;
        }


        private void Home_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value= 0;
            circularProgressBar1.Minimum= 0;
            circularProgressBar1.Maximum= 100;

            var sbj = loadFileData.GetSubjects();
            if (sbj != null && sbj.Any())
            {
               gpa = loadFileData.CalculateGPA();
                classLabel.Text = findClass(double.Parse(gpa));
            }

            
            circularProgressBar1.Text= gpa;
            double gpaProgess = double.Parse(gpa)*25;
            
            
           /* for (int i=0; i <= gpaProgess; i++)
            {
                //Thread.Sleep(1);
               
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }*/
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
          /*  if (_form1.WindowState == FormWindowState.Normal)
            {
               // circularProgressBar1.Size = new System.Drawing.Size(250, 250);
            }
            else
            {
               // circularProgressBar1.Size = new System.Drawing.Size(320, 320);
            }*/
        }

        private string findClass(double gpaValue)
        {
            if(gpaValue<=4.0 && gpaValue >= 3.7)
            {
                return "First Class Honors";
            }
            else if(gpaValue >= 3.3)
            {
                return "Second Class(Upper Division) Honors";
            }
            else if (gpaValue >= 3.0)
            {
                return "Second Class(Lower Division) Honors";
            }
            else
            {
                return "";
            }
        }
    }
    
}
