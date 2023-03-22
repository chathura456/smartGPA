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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }
        }
        int top = 26;
        int left = 198;
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Label l1 = new Label();
            this.Controls.Add(l1);

            l1.Text = "Year 0";

            l1.AutoSize = true;
            l1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l1.Location = new System.Drawing.Point(97, 178);
            l1.Name = "label7";
            l1.Size = new System.Drawing.Size(left, top);
            top += 50;
            count--;
        }
    }
}
