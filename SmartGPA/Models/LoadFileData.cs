using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
