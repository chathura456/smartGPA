using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGPA.Models
{
    public class LoadFileData
    {
        private List<Subject> subjects = new List<Subject>();
        private string filename = "subjects.csv";


        public LoadFileData() 
        { 
           LoadData();
        }

        public List<Subject> GetSubjects()
        {
            return subjects;
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
