using SmartGPA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace SmartGPA.Pages
{
    public partial class Grades : Form
    {
        public string grade, name;
        public int year, semester, credit;
        private List<Subject> subjects;

        private HomeUi _form1;

        public Grades(HomeUi form1)
        {
            InitializeComponent();
            _form1 = form1;
            // Initialize the subjects list and bind it to the DataGridView
            subjects = new List<Subject>();
           /* dataGridView1.DataSource = subjects;
            dataGridView1.AutoGenerateColumns = false;

            // Create the columns for the DataGridView

            dataGridView1.Columns.Remove("Year");
            dataGridView1.Columns.Remove("Semester");*/
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            year_confirm.BackColor = ThemeColor.PrimaryColor;
            add_results.BackColor = ThemeColor.PrimaryColor;
            add_year.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, +0.3);

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

            subject_panel.Visible = false;

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
            credit_dropdown.SelectedItem = 3;

            year = 0;
            semester = 0;

            // Add column headers to the DataGridView
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Credits", "Credits");
            dataGridView1.Columns.Add("Grade", "Grade");
            dataGridView1.Columns.Add("Points", "Points");

        }

        //add results button
        private void add_results_Click(object sender, EventArgs e)
        {
            if (grade == null)
            {
                errorProvider1.Clear();
                grade_dropdown.Focus();
                errorProvider1.SetError(grade_dropdown, "Please select grade");
            }
            else
            {
                errorProvider1.Clear();
                credit = int.Parse(credit_dropdown.SelectedItem.ToString());
                Subject subject = new Subject
                {
                    Year = year,
                    Semester = semester,
                    Name = name_input.Text.Trim(),
                    Credits = credit,
                    Grade = grade,
                    Points = GetPointsForGrade(grade.ToString()),
                };

                // Add the subject to the list and bind the list to the DataGridView
                 subjects.Add(subject);
                /* dataGridView1.DataSource = null;
                 dataGridView1.DataSource = subjects;*/

                // Calculate and display the GPA
                double totalPoints = subjects.Sum(s => s.Credits * s.Points);
                 int totalCredits = subjects.Sum(s => s.Credits);
                 double gpa = totalPoints / totalCredits;
                 //gpa_label.Text = $"Your GPA: {gpa.ToString("F2")}";

                 _form1.SetGpaLabelText($"{gpa.ToString("F2")}");

                // Update the DataGridView with the list of subjects
                UpdateDataGridView();
            }
        }

        //add year button
        private void add_year_Click(object sender, EventArgs e)
        {
            subject_panel.Visible = false;
            year_panel.Visible = true;

            year_dropdown.SelectedIndex = -1;
            year = 0;

            semester_dropdown.SelectedIndex = -1;
            semester = 0;
        }

        //confirm year button
        private void year_confirm_Click(object sender, EventArgs e)
        {
            if (year == 0)
            {
                errorProvider1.Clear();
                year_dropdown.Focus();
                errorProvider1.SetError(year_dropdown, "Please Select Year");
            }
            else if (semester == 0)
            {
                errorProvider1.Clear();
                semester_dropdown.Focus();
                errorProvider1.SetError(semester_dropdown, "Please Select Semester");
            }
            else
            {
                subject_panel.Visible = true;
                year_panel.Visible = false;
                year_label.Text = "Year 0" + year + " Semester 0" + semester + " Results";
            }
        }

        private void grade_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            grade = grade_dropdown.SelectedItem.ToString();
        }

        private void credit_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            credit = int.Parse(credit_dropdown.SelectedItem.ToString());
        }

        //dropdowns
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

        private void UpdateDataGridView()
        {
            // Clear the existing rows
            dataGridView1.Rows.Clear();

            // Add the rows for each subject in the list
            foreach (var subject in subjects)
            {
                dataGridView1.Rows.Add(
                    subject.Name,
                    subject.Credits,
                    subject.Grade,
                    subject.Points
                );
            }

        }
    }
}
