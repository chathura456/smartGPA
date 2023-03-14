using SmartGPA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGPA
{
    public partial class Form1 : Form
    {
        public string grade, credit;
        private List<Subject> subjects;
        public Form1()
        {
            InitializeComponent();

            // Initialize the subjects list and bind it to the DataGridView
            subjects = new List<Subject>();
            dataGridView1.DataSource = subjects;
            dataGridView1.AutoGenerateColumns = false;

            // Create the columns for the DataGridView

            dataGridView1.Columns.Remove("Year");
            dataGridView1.Columns.Remove("Semester");
        }

        private void credit_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            credit = credit_dropdown.SelectedItem.ToString();
        }

        private void grade_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            grade = grade_dropdown.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            credit = credit_dropdown.SelectedItem.ToString();
            label1.Text = credit;

            Subject subject = new Subject
            {
                Year = 1,
                Semester = 2,
                Name = name_input.Text.Trim(),
                Credits = int.Parse(credit),
                Grade = grade,
                Points = GetPointsForGrade(grade.ToString()),
            };

            // Add the subject to the list and bind the list to the DataGridView
            subjects.Add(subject);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = subjects; 

            /*
            // Group the data by year and semester
            var groups = subjects.GroupBy(s => new { s.Year, s.Semester });

            // Clear the DataGridView's rows and add a subheading row for each group
            dataGridView1.Rows.Clear();

            foreach (var group in groups)
            {
                DataGridViewRow subheadingRow = new DataGridViewRow();
                subheadingRow.CreateCells(dataGridView1);
                subheadingRow.SetValues($"Year {group.Key.Year}, Semester {group.Key.Semester}");
                subheadingRow.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);
                dataGridView1.Rows.Add(subheadingRow);

                // Add the subjects in the group as regular rows
                foreach (Subject s in group)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.SetValues(s.Name, s.Credits, s.Grade, s.Points);
                    dataGridView1.Rows.Add(row);
                }
            }*/

            // Calculate and display the GPA
            double totalPoints = subjects.Sum(s => s.Credits * s.Points);
            int totalCredits = subjects.Sum(s => s.Credits);
            double gpa = totalPoints / totalCredits;
            gpa_label.Text = $"GPA: {gpa.ToString("F2")}";

            this.ResumeLayout(false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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

            credit_dropdown.SelectedItem = 3;
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