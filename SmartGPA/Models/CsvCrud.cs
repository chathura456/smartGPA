using SmartGPA.Models;
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
        private List<Subject> subjects;
        private readonly string filename;

        public CsvCrud(string filename)
        {
            this.filename = filename;
            this.subjects = new List<Subject>();
            LoadData();
        }

        public List<Subject> GetSubjects()
        {
            return subjects;
        }

        public void AddSubject(Subject sbj)
        {
            subjects.Add(sbj);
            SaveData();
        }

        public void UpdateSubject(int year, int semester, string name, int credits, string grade, Subject editSbj)
        {
            Subject subjectToUpdate = subjects.FirstOrDefault(s => s.Year == year && s.Semester == semester && s.Name == name && s.Grade == grade && s.Credits == credits);
            if (subjectToUpdate == null)
            {
                throw new Exception("Subject not found");
            }

            // Update the subject's properties
            subjectToUpdate.Credits = editSbj.Credits;
            subjectToUpdate.Grade = editSbj.Grade;
            subjectToUpdate.Points = editSbj.Points;
            subjectToUpdate.Name = editSbj.Name;
            subjectToUpdate.Year = editSbj.Year;
            subjectToUpdate.Semester = editSbj.Semester;

            SaveData();
        }

        public bool DeleteSubject(int year, int semester, string name)
        {
            Subject subjectToDelete = subjects.FirstOrDefault(s => s.Year == year && s.Semester == semester && s.Name == name);
            if (subjectToDelete == null)
            {
                return false;
            }

            subjects.Remove(subjectToDelete);

            SaveData();

            return true;
        }

        private void SaveData()
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Subject subject in subjects)
                {
                    string line = $"{subject.Year},{subject.Semester},{subject.Name},{subject.Credits},{subject.Grade},{subject.Points}";
                    writer.WriteLine(line);
                }
            }
        }

        public void LoadData()
        {
            if (!File.Exists(filename))
            {
                return;
            }

            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }

                    string[] fields = line.Split(',');
                    if (fields.Length != 6)
                    {
                        throw new Exception("Invalid data in CSV file");
                    }

                    int year = int.Parse(fields[0]);
                    int semester = int.Parse(fields[1]);
                    string name = fields[2];
                    int credits = int.Parse(fields[3]);
                    string grade = fields[4];
                    double points = double.Parse(fields[5]);

                    subjects.Add(new Subject { Year = year, Semester = semester, Name = name, Credits = credits, Grade = grade, Points = points });
                }
            }
        }

        public string CalculateGPA()
        {
            // Calculate and display the GPA
            double totalPoints = this.subjects.Sum(s => s.Credits * s.Points);
            int totalCredits = this.subjects.Sum(s => s.Credits);
            double gpa = totalPoints / totalCredits;
            //gpa_label.Text = $"Your GPA: {gpa.ToString("F2")}";

            return ($"{gpa.ToString("F2")}");
        }

    }

}

/*
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
            this.subjects.Add(sbj);
            /* dataGridView1.DataSource = null;
             dataGridView1.DataSource = subjects;*/
/*
using (StreamWriter writer = new StreamWriter(filename))
{
    foreach (Subject subject0 in subjects)
    {
        string line = $"{subject0.Year},{subject0.Semester},{subject0.Name},{subject0.Credits},{subject0.Grade},{subject0.Points}";
        writer.WriteLine(line);
    }.
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
    if (subjects.Count > 0)
    {
        return; // The data has already been loaded, so skip the rest of the method
    }

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
            this.subjects.Add(subject);
        }
    }
}

public void UpdateData(int year, int semester, string name, int credits, string grade, Subject editSbj)
{
    // Find the subject to update in the subjects list
    Subject subjectToUpdate = subjects.FirstOrDefault
        (s => s.Year == year && s.Semester == semester && s.Name == name
    && s.Grade == grade && s.Credits == credits);
    if (subjectToUpdate == null)
    {
        throw new Exception("Subject not found");
    }

    // Update the subject's properties
    subjectToUpdate.Credits = editSbj.Credits;
    subjectToUpdate.Grade = editSbj.Grade;
    subjectToUpdate.Points = editSbj.Points;
    subjectToUpdate.Name = editSbj.Name;
    subjectToUpdate.Year = editSbj.Year;
    subjectToUpdate.Semester = editSbj.Semester;

    // Save the updated data to the CSV file
    SaveAllData(subjects);
}

public void DeleteData(int year, int semester, string name)
{
    LoadData();
    GetSubjects();

    // Find the subject to delete in the subjects list
    Subject subjectToDelete = this.subjects.FirstOrDefault(s => s.Year == year && s.Semester == semester && s.Name == name);
    if (subjectToDelete == null)
    {
        throw new Exception("Subject not found");
    }

    // Remove the subject from the subjects list
    this.subjects.Remove(subjectToDelete);

    // Save the updated data to the CSV file
    SaveAllData(subjects);
}

public string CalculateGPA()
{
    // Calculate and display the GPA
    double totalPoints = this.subjects.Sum(s => s.Credits * s.Points);
    int totalCredits = this.subjects.Sum(s => s.Credits);
    double gpa = totalPoints / totalCredits;
    //gpa_label.Text = $"Your GPA: {gpa.ToString("F2")}";

    return ($"{gpa.ToString("F2")}");
}




    } 


 * */