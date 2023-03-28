using SmartGPA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGPA.Pages
{
    public partial class HomeUi : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private CsvCrud loadFileData;
        private string filename = GlobalVariables.CsvFilePath;


        public HomeUi()
        {
            InitializeComponent();
            random= new Random();
            loadFileData = new CsvCrud(filename);
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCaptur();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hllnd, int wMsg, int wParam, int lParam);

        protected override void WndProc(ref Message m)
        {
            const int WM_SETREDRAW = 0x0083;
            if(m.Msg== WM_SETREDRAW && m.WParam.ToInt32()==1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private Color SelectThemeColor() 
        { 
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btn)
        {
            if (btn != null)
            {
                if(currentButton != (Button)btn)
                {
                    DisableButton();
                    Color color= SelectThemeColor();
                    currentButton = (Button)btn;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBox.BackColor= color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color,-0.3);  
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(39, 39, 58);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();

            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            this.panelMiddle.Controls.Add(childForm);
            this.panelMiddle.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
            lblTitle.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home(this), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Pages.Grades(this), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Pages.Info(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Pages.Settings(), sender);
        }

        private void HomeUi_Load(object sender, EventArgs e)
        {
            
            Color color = SelectThemeColor();
            currentButton = btnHome;
            currentButton.BackColor = color;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //panelTitleBox.BackColor = color;
            ThemeColor.PrimaryColor = color;
            ThemeColor.SecondaryColor = color;

            var sbj = loadFileData.GetSubjects();
            if (sbj!=null && sbj.Any())
            {
                SetGpaLabelText(loadFileData.CalculateGPA());
               
            }

            activeForm = new Home(this);
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            this.panelMiddle.Controls.Add(activeForm);
            this.panelMiddle.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
            lblTitle.Text = activeForm.Text;

        }

        private void panelTitleBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptur();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void HomeUi_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptur();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void SetGpaLabelText(string text)
        {
            gpa_label.Text = text;
        }

        public string GetGpaLabelText()
        {
            return gpa_label.Text;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new System.Drawing.Size(949, 558);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
            btnClose.IconColor = ThemeColor.LightGrey;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.White;
            btnClose.BackColor = ThemeColor.LightGrey;
        }

        private void btnMaximize_MouseEnter(object sender, EventArgs e)
        {
            btnMaximize.BackColor = Color.White;
            btnMaximize.IconColor = ThemeColor.LightGrey;
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.IconColor = Color.White;
            btnMaximize.BackColor = ThemeColor.LightGrey;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.White;
            btnMinimize.IconColor = ThemeColor.LightGrey;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.IconColor = Color.White;
            btnMinimize.BackColor = ThemeColor.LightGrey;
        }

       
    }
}
