using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SmartGPA.Pages
{
    public partial class Delete : Form
    {
        private readonly Grades _parent;
        public Delete(Grades parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            cancel_btn.ForeColor = ThemeColor.PrimaryColor;
            confirm_button.BackColor= ThemeColor.PrimaryColor;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
            btnClose.IconColor = ThemeColor.DarkGrey;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.White;
            btnClose.BackColor = ThemeColor.DarkGrey;
        }
    }
}
