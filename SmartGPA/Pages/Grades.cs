using SmartGPA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using MessageBox = System.Windows.Forms.MessageBox;
using Point = System.Drawing.Point;


namespace SmartGPA.Pages
{
    public partial class Grades : Form
    {
        public string grade, name;
        public int year, semester, credit;
        private List<Subject> subjects;
        private CsvCrud csvCrud;
        private HomeUi _form1;
        private Update updateForm;
        private Delete deleteForm;
        private string filename = "subjects.csv";

        public Grades(HomeUi form1)
        {
            InitializeComponent();
            _form1 = form1;
            // Initialize the subjects list and bind it to the DataGridView
            //subjects = new List<Subject>();
            csvCrud = new CsvCrud(filename);
            updateForm = new Update(this);
            deleteForm = new Delete(this);
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            csvCrud.LoadData();
            subjects = csvCrud.GetSubjects();
            updateForm.MaximizeBox = false;
            updateForm.MinimizeBox = false;

            labelListLoad();


            year_confirm.BackColor = ThemeColor.PrimaryColor;
            add_results.BackColor = ThemeColor.PrimaryColor;
            add_year.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, +0.3);

            this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns[4].HeaderText = "";
            this.dataGridView1.Columns[5].HeaderText = "";

            this.dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            this.dataGridView2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.ColumnHeadersHeight = 40;


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
            if (name_input.Text == "")
            {
                errorProvider1.Clear();
                name_input.Focus();
                errorProvider1.SetError(name_input, "Please Enter Module name");
            }
            else if (grade == null)
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

                //add data to csv file 
                csvCrud.AddSubject(subject);

                // Update the DataGridView with the list of subjects
                UpdateDataGridView();

                //clear inputs
                clearResults();
            }

        }

        //clear results inputs
        public void clearResults()
        {
            name_input.Clear();
            credit_dropdown.SelectedItem = 3;
            grade_dropdown.SelectedIndex = -1;
            name = "";
            grade = null;
            credit = 0;
        }

        //add year button
        private void add_year_Click(object sender, EventArgs e)
        {
            subject_panel.Visible = false;
            year_panel.Visible = true;
            resultGroup_panel.Visible = true;
            allResults_panel.Visible = false;

            year_dropdown.SelectedIndex = -1;
            year = 0;

            semester_dropdown.SelectedIndex = -1;
            semester = 0;

            csvCrud.LoadData();
            subjects = csvCrud.GetSubjects();

            labelListLoad();
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

                }
                else
                {
                    //newLabelCreate();

                }

            }
        }

        int top = 47;
        int left = 3;

        public void labelListLoad()
        {
            /* subjects.Clear();

             // Load the data from the CSV file
             loadFileData.LoadData();
             var groups1 = subjects.GroupBy(s => new { s.Year, s.Semester });
             foreach (var group in groups1)
             {
                 newLabelCreate(group.Key.Year, group.Key.Semester);
             }*/
            /*
                // Clear the year_panel
                year_panel.Controls.Clear();

                // Load the data from the CSV file
                loadFileData.LoadData();

                // Group the subjects by year and semester
                var groups = subjects.GroupBy(s => new { s.Year, s.Semester });

                // Create a label for each year and semester and add it to the year_panel
                foreach (var group in groups.OrderBy(g => g.Key.Year).ThenBy(g => g.Key.Semester))
                {
                    newLabelCreate(group.Key.Year, group.Key.Semester);
                }

                // Sort the labels in the year_panel based on their text
                year_panel.Controls.Cast<Label>().OrderBy(l => l.Text).ToList().ForEach(l => year_panel.Controls.SetChildIndex(l, 0));*/
            // Remove any existing labels from the year_panel
            foreach (Control control in year_panel.Controls.OfType<Label>().ToList())
            {
                if (control != label3 && control != label1 && control != label2 && control != label7 && control != label8)
                {
                    year_panel.Controls.Remove(control);
                }

            }

            // Load the data from the CSV file
            csvCrud.LoadData();
            var subjects1 = csvCrud.GetSubjects();

            // Group the subjects by year and semester
            var groups = subjects1.GroupBy(s => new { s.Year, s.Semester });

            // Create a label for each year and semester and add it to the year_panel
            foreach (var group in groups.OrderBy(g => g.Key.Year).ThenBy(g => g.Key.Semester))
            {
                newLabelCreate(group.Key.Year, group.Key.Semester);
            }

            // Sort the labels in the year_panel based on their text
            year_panel.Controls.OfType<Label>().OrderBy(l => l.Text).ToList().ForEach(l => year_panel.Controls.SetChildIndex(l, 0));

            // Reposition the labels based on the current state of the year_panel
            left = 3;
            top = 47;
            foreach (Control control in year_panel.Controls.OfType<Label>())
            {
                if (control != label3 && control != label1 && control != label2 && control != label7 && control != label8)
                {
                    control.Location = new Point(3, top);
                    //control.Anchor = System.Windows.Forms.AnchorStyles.Top;
                    top += 30;
                }

            }
        }

        public void newLabelCreate(int year0, int semester0)
        {
            // Check if the label already exists in the panel
            foreach (Label label in year_panel.Controls.OfType<Label>())
            {
                if (label.Text == "Year 0" + year0 + " Semester 0" + semester0 + " Results")
                {
                    return; // Label already exists, so return without creating a new one
                }
            }

            // If the label does not exist, create and add it to the panel
            Label l1 = new Label();
            listPanel.Controls.Add(l1);

            l1.Text = "Year 0" + year0 + " Semester 0" + semester0 + " Results";
            l1.AutoSize = true;
            l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l1.Location = new System.Drawing.Point(3, top);
            l1.ForeColor = System.Drawing.Color.White;
            l1.Name = "label9";
            l1.Size = new System.Drawing.Size(198, 17);
            l1.Click += new EventHandler(newLabelClick);
            l1.MouseEnter += new EventHandler(newLabelMouseEnter);
            l1.MouseLeave += new EventHandler(newLabelMouseLeave);
            l1.Anchor = System.Windows.Forms.AnchorStyles.Top;

            // Add the year and semester values to the Tag property of the label
            l1.Tag = new Tuple<int, int>(year0, semester0);


            top += 30;
        }

        private void newLabelMouseEnter(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            clickedLabel.ForeColor = System.Drawing.Color.Yellow;
        }

        private void newLabelMouseLeave(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            clickedLabel.ForeColor = System.Drawing.Color.White;
        }

        private void newLabelClick(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            // Get the year and semester values from the Tag property of the label
            Tuple<int, int> values = (Tuple<int, int>)clickedLabel.Tag;
            year = values.Item1;
            semester = values.Item2;

            subject_panel.Visible = true;
            year_panel.Visible = false;
            year_label.Text = "Year 0" + year + " Semester 0" + semester + " Results";
            if (subjects != null && subjects.Any())
            {
                UpdateDataGridView();
            }
        }



        private void grade_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (grade_dropdown.SelectedIndex != -1)
            {
                grade = grade_dropdown.SelectedItem.ToString();
            }

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

        //All results Label
        private void label7_Click(object sender, EventArgs e)
        {
            subject_panel.Visible = true;
            resultGroup_panel.Visible = false;
            allResults_panel.Visible = true;
            year_panel.Visible = false;
            year_label.Text = "All Results";
            //536,337

            if (subjects != null && subjects.Any())
            {
                getAllDatatoTable();
            }

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {


        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = System.Drawing.Color.Yellow;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = System.Drawing.Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a button cell
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                updateForm.year = year;
                updateForm.semester = semester;
                updateForm.name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                updateForm.grade = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                updateForm.credit = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                updateForm.ShowDialog();
            }
            else if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                /* deleteForm.name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                 deleteForm.year = year;
                 deleteForm.sem = semester;*/

                bool subjectDeleted = csvCrud.DeleteSubject(year, semester, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                // deleteForm.ShowDialog();
                if (subjectDeleted)
                {
                    UpdateDataGridView();

                }
                else
                {
                    MessageBox.Show("Subject not found");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a button cell
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                updateForm.yearData = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                updateForm.name = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                updateForm.grade = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                updateForm.credit = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
                updateForm.ShowDialog();
            }
            else if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                deleteForm.yearData = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                deleteForm.name = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                deleteForm.ShowDialog();
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


        public void UpdateDataGridView()
        {
            // Clear the existing rows
            dataGridView1.Rows.Clear();

            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.GridColor = System.Drawing.Color.White;
            // dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridView1.RowTemplate.SetValues(Height, true);

            // Clear the existing subjects
            subjects.Clear();

            // Load the data from the CSV file
            csvCrud.LoadData();
            _form1.SetGpaLabelText(csvCrud.CalculateGPA());

            if (dataGridView1.Columns["YearData"] != null)
            {
                dataGridView1.Columns.Remove("YearData");
            }

            // Filter the subjects by the selected year and semester
            var filteredSubjects = subjects.Where(s => s.Year == year && s.Semester == semester);

            // Add the rows for each subject in the filtered list
            foreach (var subject in filteredSubjects)
            {
                dataGridView1.Rows.Add(
                    subject.Name,
                    subject.Credits,
                    subject.Grade,
                    subject.Points
                );
            }
        }




        public void getAllDatatoTable()
        {
            // Clear the existing rows
            dataGridView2.Rows.Clear();

            dataGridView2.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridView2.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView2.GridColor = System.Drawing.Color.White;
            dataGridView2.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridView2.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // Clear the existing subjects
            subjects.Clear();

            // Load the data from the CSV file
            csvCrud.LoadData();
            if(csvCrud.CalculateGPA() != "" )
            {
                _form1.SetGpaLabelText(csvCrud.CalculateGPA());
            }
            

            var groups = subjects.GroupBy(s => new { s.Year, s.Semester });

            // Insert the "YearData" column as the first column in the DataGridView
           /* if (dataGridView2.Columns["YearData"] == null)
            {
                // If the column does not exist, insert it as the first column
                dataGridView2.Columns.Insert(0, new DataGridViewTextBoxColumn()
                {
                    Name = "YearData",
                    HeaderText = "Year Data"
                });

                dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }*/

            //DataGridViewRow previousRow = null;

            foreach (var group in groups)
            {
                // Merge the year and semester data into one string
                string yearData = $"Year 0{group.Key.Year}, Semester 0{group.Key.Semester}";

                foreach (Subject s in group)
                {

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView2);

                // Add the yearData to the first cell

                row.Cells[0].Value = yearData;
                row.Cells[1].Value = s.Name;
                    row.Cells[2].Value = s.Credits;
                    row.Cells[3].Value = s.Grade;
                    row.Cells[4].Value = s.Points;
                    dataGridView2.Rows.Add(row);
                }
                
                
            }
            


        }
    }
}

