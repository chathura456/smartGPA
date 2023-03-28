using SmartGPA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGPA.Pages
{
    public partial class Update : Form
    {
        public string grade, name, grade1,name1, yearData;
        public int year, semester, credit,year1,semester1,credit1;
        private readonly Grades _parent;
        private CsvCrud csvCrud;
        private string filename = GlobalVariables.CsvFilePath;

        public Update(Grades parent)
        {
            InitializeComponent();
            _parent = parent;
            csvCrud = new CsvCrud(filename);
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
            if (credit != 0)
            {
                credit_dropdown.SelectedItem = credit;
            }

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
            if(grade != null)
            {
                grade_dropdown.SelectedItem=grade;
            }

            //year dropdown item add
            year_dropdown.Items.Clear();
            year_dropdown.Items.Add(1);
            year_dropdown.Items.Add(2);
            year_dropdown.Items.Add(3);
            year_dropdown.Items.Add(4);
            year_dropdown.Items.Add(5);

            if(yearData!= null)
            {
                // Extract the year and semester values from the YearData column using a regex pattern
                string pattern = @"Year\s+(\d+),\s+Semester\s+(\d+)";
                Match match = Regex.Match(yearData, pattern);
                if (!match.Success)
                {
                    throw new ArgumentException("Invalid yearData format");
                }
                year = int.Parse(match.Groups[1].Value);
                semester = int.Parse(match.Groups[2].Value);
            
            }

            if (year != 0)
            {
                year_dropdown.SelectedItem= year;
            }

            //semester dropdown item added
            semester_dropdown.Items.Clear();
            semester_dropdown.Items.Add(1);
            semester_dropdown.Items.Add(2);
            semester_dropdown.Items.Add(3);
            semester_dropdown.Items.Add(4);
            if (semester != 0)
            {
                semester_dropdown.SelectedItem= semester;
            }
            if (name != null)
            {
                name_input.Text=name;
            }

            update_button.BackColor = ThemeColor.PrimaryColor;
            cancel_btn.ForeColor= ThemeColor.PrimaryColor;
        }

        /****************************Buttons**********************/

        //update button
        private void update_button_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
            this.Close();
           /* if (year!=0 && semester!=0 && credit!=0 && grade != null && name != null)
            {
                name1 = name_input.Text.Trim();
                double points1 = GetPointsForGrade(grade1);
                Subject sbj = new Subject();
                sbj.Name = name1;
                sbj.Points = points1;
                sbj.Year = year1;
                sbj.Semester = semester1;
                sbj.Grade = grade1;
                sbj.Credits = credit1;
                csvCrud.UpdateSubject(year, semester, name, credit, grade, sbj);
                // _parent.UpdateDataGridView();
                //_parent.getAllDatatoTable();
                this.Close();
            }*/

        }

        public Subject GetUpdatedSubject()
        {
            name1 = name_input.Text.Trim();
            double points1 = GetPointsForGrade(grade1);
            return new Subject
            {
                Name = name1,
                Credits = credit1,
                Grade = grade1,
                Points = points1,
                Year = year1,
                Semester = semester1
            };
        }

        private void label3_Click(object sender, EventArgs e)
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
                grade1 = grade_dropdown.SelectedItem.ToString();
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
            credit1 = int.Parse(credit_dropdown.SelectedItem.ToString());
        }

        private void year_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (year_dropdown.SelectedIndex != -1)
            {
                year1 = int.Parse(year_dropdown.SelectedItem.ToString());
            }

        }

        private void semester_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (semester_dropdown.SelectedIndex != -1)
            {
                semester1 = int.Parse(semester_dropdown.SelectedItem.ToString());
            }


        }

        private double GetPointsForGrade(string grade)
        {
            switch (grade)
            {
                case "A+":
                    return 4.0;
                case "A":
                    return 4.0;
                case "A-":
                    return 3.7;
                case "B+":
                    return 3.3;
                case "B":
                    return 3.0;
                case "B-":
                    return 2.7;
                case "C+":
                    return 2.3;
                case "C":
                    return 2.0;
                case "C-":
                    return 1.7;
                case "D+":
                    return 1.3;
                case "D":
                    return 1.0;
                case "F":
                    return 0.0;
                default:
                    throw new ArgumentException("Invalid grade.");
            }
        }
    }
}
