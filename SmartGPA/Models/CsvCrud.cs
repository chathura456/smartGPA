using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartGPA.Models
{
    public class CsvCrud
    {
        private List<Subject> subjects = new List<Subject>();
        private string filename = "subjects.csv";

        public CsvCrud() 
        { 
           LoadData();
        }

        public List<Subject> GetSubjects()
        {
            return subjects;
        }

        public void SaveData(Subject sbj)
        {
            // Add the subject to the list and bind the list to the DataGridView
            subjects.Add(sbj);
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
        }

        public void SaveAllData(List<Subject> subjects1)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Subject subject in subjects1)
                {
                    string line = $"{subject.Year},{subject.Semester},{subject.Name},{subject.Credits},{subject.Grade},{subject.Points}";
                    writer.WriteLine(line);
                }
            }
        }

        public void LoadData()
        {
            // Read the contents of the "subjects.csv" file and populate the subjects list
            using (StreamReader reader = new StreamReader(filename))
            {

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue; // Skip empty lines
                    }
                    string[] fields = line.Split(',');
                    Subject subject = new Subject();
                    subject.Year = int.Parse(fields[0]);
                    subject.Semester = int.Parse(fields[1]);
                    subject.Name = fields[2];
                    subject.Credits = int.Parse(fields[3]);
                    subject.Grade = fields[4];
                    subject.Points = double.Parse(fields[5]);
                    subjects.Add(subject);
                }
            }
        }

        public void UpdateData(int year, int semester, string name, int credits, string grade, double points)
        {
            // Find the subject to update in the subjects list
            Subject subjectToUpdate = subjects.FirstOrDefault(s => s.Year == year && s.Semester == semester && s.Name == name);
            if (subjectToUpdate == null)
            {
                throw new Exception("Subject not found");
            }

            // Update the subject's properties
            subjectToUpdate.Credits = credits;
            subjectToUpdate.Grade = grade;
            subjectToUpdate.Points = points;

            // Save the updated data to the CSV file
            SaveAllData(subjects);
        }

        public void DeleteData(int year, int semester, string name)
        {
            // Find the subject to delete in the subjects list
            Subject subjectToDelete = subjects.FirstOrDefault(s => s.Year == year && s.Semester == semester && s.Name == name);
            if (subjectToDelete == null)
            {
                throw new Exception("Subject not found");
            }

            // Remove the subject from the subjects list
            subjects.Remove(subjectToDelete);

            // Save the updated data to the CSV file
            SaveAllData(subjects);
        }

        public string CalculateGPA()
        {
            // Calculate and display the GPA
            double totalPoints = subjects.Sum(s => s.Credits * s.Points);
            int totalCredits = subjects.Sum(s => s.Credits);
            double gpa = totalPoints / totalCredits;
            //gpa_label.Text = $"Your GPA: {gpa.ToString("F2")}";

            return ($"{gpa.ToString("F2")}");
        }




    }
}
