using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGPA.Models
{
    public class Subject
    {
        public int Year { get; set; }
        public int Semester { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Grade { get; set; }

        public double Points { get; set; }

    }
}