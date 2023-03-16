using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public HomeUi()
        {
            InitializeComponent();
            random= new Random();
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

                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(51, 51, 76);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
