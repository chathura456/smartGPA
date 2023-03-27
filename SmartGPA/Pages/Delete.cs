using SmartGPA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SmartGPA.Pages
{
    public partial class Delete : Form
    {
        private readonly Grades _parent;
        public string name, yearData;
        public int year, sem;
        private CsvCrud csvCrud;
        private string filename = "subjects.csv";
        public bool response;

        public Delete(Grades parent)
        {
            InitializeComponent();
            _parent = parent;
            csvCrud = new CsvCrud(filename);
            response= false;
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            cancel_btn.ForeColor = ThemeColor.PrimaryColor;
            confirm_button.BackColor= ThemeColor.PrimaryColor;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            response = true;
                if (yearData != null)
                {
                    // Extract the year and semester values from the YearData column using a regex pattern
                    string pattern = @"Year\s+(\d+),\s+Semester\s+(\d+)";
                    Match match = Regex.Match(yearData, pattern);
                    if (!match.Success)
                    {
                        throw new ArgumentException("Invalid yearData format");
                    }
                    int year1 = int.Parse(match.Groups[1].Value);
                    int semester1 = int.Parse(match.Groups[2].Value);

                    csvCrud.DeleteSubject(year1, semester1, name);
                    _parent.getAllDatatoTable();
                    this.Close();
                    
                }
                else

                {/*
                    csvCrud.DeleteSubject(year, sem, name);
                    _parent.UpdateDataGridView();
                    this.Close();*/
              /* bool subjectDeleted = csvCrud.DeleteSubject(year, sem, name);
                if (subjectDeleted)
                {
                    _parent.UpdateDataGridView();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Subject not found");
                }*/
            }
   
        this.Close();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
            btnClose.IconColor = ThemeColor.DarkGrey;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.White;
            btnClose.BackColor = ThemeColor.DarkGrey;
        }
    }
}
