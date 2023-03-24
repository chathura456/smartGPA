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
    public partial class Update : Form
    {
        public string grade, name;
        public int year, semester, credit;
        private readonly Grades _parent;

        public Update(Grades parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        //form load
        private void Update_Load(object sender, EventArgs e)
        {
            //credit dropdown item added
            credit_dropdown.Items.Clear();
            credit_dropdown.Items.Add(1);
            credit_dropdown.Items.Add(2);
            credit_dropdown.Items.Add(3);
            credit_dropdown.Items.Add(4);
            credit_dropdown.Items.Add(5);
            credit_dropdown.Items.Add(6);
            credit_dropdown.Items.Add(7);
            credit_dropdown.Items.Add(8);
            credit_dropdown.Items.Add(9);
            credit_dropdown.Items.Add(10);

            //grades dropdown item added
            grade_dropdown.Items.Clear();
            grade_dropdown.Items.Add("A+");
            grade_dropdown.Items.Add("A");
            grade_dropdown.Items.Add("A-");
            grade_dropdown.Items.Add("B+");
            grade_dropdown.Items.Add("B");
            grade_dropdown.Items.Add("B-");
            grade_dropdown.Items.Add("C+");
            grade_dropdown.Items.Add("C");
            grade_dropdown.Items.Add("C-");
            grade_dropdown.Items.Add("D+");
            grade_dropdown.Items.Add("D");
            grade_dropdown.Items.Add("F");

            //year dropdown item add
            year_dropdown.Items.Clear();
            year_dropdown.Items.Add(1);
            year_dropdown.Items.Add(2);
            year_dropdown.Items.Add(3);
            year_dropdown.Items.Add(4);
            year_dropdown.Items.Add(5);

            //semester dropdown item added
            semester_dropdown.Items.Clear();
            semester_dropdown.Items.Add(1);
            semester_dropdown.Items.Add(2);
            semester_dropdown.Items.Add(3);
            semester_dropdown.Items.Add(4);

            update_button.BackColor = ThemeColor.PrimaryColor;
            cancel_btn.ForeColor= ThemeColor.PrimaryColor;
        }

        /****************************Buttons**********************/

        //update button
        private void update_button_Click(object sender, EventArgs e)
        {

        }

        //cancel button
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        /****************************Dropdowns**********************/
        private void grade_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (grade_dropdown.SelectedIndex != -1)
            {
                grade = grade_dropdown.SelectedItem.ToString();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
            btnClose.IconColor = Color.Black;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor= Color.White;
            btnClose.BackColor = ThemeColor.DarkGrey;
        }

        private void credit_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            credit = int.Parse(credit_dropdown.SelectedItem.ToString());
        }

        private void year_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (year_dropdown.SelectedIndex != -1)
            {
                year = int.Parse(year_dropdown.SelectedItem.ToString());
            }

        }

        private void semester_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (semester_dropdown.SelectedIndex != -1)
            {
                semester = int.Parse(semester_dropdown.SelectedItem.ToString());
            }


        }
    }
}
