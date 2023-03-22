using SmartGPA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using Point = System.Drawing.Point;

namespace SmartGPA.Pages
{
    public partial class Grades : Form
    {
        public string grade, name;
        public int year, semester, credit;
        private List<Subject> subjects;
        private string filename = "subjects.csv";
        private LoadFileData loadFileData;

        private HomeUi _form1;

        public Grades(HomeUi form1)
        {
            InitializeComponent();
            _form1 = form1;
            // Initialize the subjects list and bind it to the DataGridView
            //subjects = new List<Subject>();
            loadFileData= new LoadFileData();
        }

        private void Grades_Load(object sender, EventArgs e)
        {
           loadFileData.LoadData();
            subjects =loadFileData.GetSubjects();

            

            year_confirm.BackColor = ThemeColor.PrimaryColor;
            add_results.BackColor = ThemeColor.PrimaryColor;
            add_year.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, +0.3);

            this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            

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
           /* dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Credits", "Credits");
            dataGridView1.Columns.Add("Grade", "Grade");
            dataGridView1.Columns.Add("Points", "Points");*/

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

                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Subject subject0 in subjects)
                    {
                        string line = $"{subject0.Year},{subject0.Semester},{subject0.Name},{subject0.Credits},{subject0.Grade},{subject0.Points}";
                        writer.WriteLine(line);
                    }
                }


                /*

                // Calculate and display the GPA
                double totalPoints = subjects.Sum(s => s.Credits * s.Points);
                 int totalCredits = subjects.Sum(s => s.Credits);
                 double gpa = totalPoints / totalCredits;
                 //gpa_label.Text = $"Your GPA: {gpa.ToString("F2")}";

                 _form1.SetGpaLabelText($"{gpa.ToString("F2")}");*/

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
                if (subjects != null && subjects.Any())
                {
                   UpdateDataGridView();
                    var groups1 = subjects.GroupBy(s => new { s.Year, s.Semester });
                    foreach (var group in groups1)
                    {
                        if ((group.Key.Year) == year && (group.Key.Semester) == semester)
                        {

                        }
                        else
                        {
                            /* Label l1 = new Label();
                             l1.Text = "Year 0" + year + " Semester 0" + semester + " Results";
                             this.Controls.Add(l1);*/
                            
                        }
                    }
                }
                else 
                {
                    //newLabelCreate();
                }
                
            }
        }

        int top =178;
        int left = 97;
        int count = 0;

        public void newLabelCreate()
        {
            count++;
            for(int i=0; i<count; i++)
            {
                 Label l1 = new Label();
            year_panel.Controls.Add(l1);

            l1.Text = "Year 0";

            l1.AutoSize = true;
            l1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l1.Location = new System.Drawing.Point(left, top);
            l1.Name = "label7";
            l1.Size = new System.Drawing.Size(198, 26);
                top += 50;
                count--;
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

            // Clear the existing subjects
            subjects.Clear();

            // Load the data from the CSV file
            loadFileData.LoadData();
            _form1.SetGpaLabelText(loadFileData.CalculateGPA());

            // Add the rows for each subject in the list
            /* foreach (var subject in subjects)
             {
                 dataGridView1.Rows.Add(
                     subject.Name,
                     subject.Credits,
                     subject.Grade,
                     subject.Points
                 );
             }*/

            var groups = subjects.GroupBy(s => new { s.Year, s.Semester });
            foreach (var group in groups)
            {
                /*DataGridViewRow subheadingRow = new DataGridViewRow();
                subheadingRow.CreateCells(dataGridView1);
                //subheadingRow.SetValues($"Year {group.Key.Year}, Semester {group.Key.Semester}");
                subheadingRow.Cells[0].Dispose();
                //subheadingRow.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);
                dataGridView1.Rows.Add(subheadingRow);*/

                if ((group.Key.Year) == year && (group.Key.Semester) == semester)
                {
                    foreach (Subject s in group)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1);
                        row.SetValues(s.Name, s.Credits, s.Grade, s.Points);
                        dataGridView1.Rows.Add(row);
                    }

                    // Add the subjects in the group as regular rows
                }
            }

        }

       

    }
}
