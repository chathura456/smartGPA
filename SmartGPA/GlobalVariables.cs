using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGPA
{
    public static class GlobalVariables
    {
        public static readonly string CsvFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "subjects.csv");
    }
}
