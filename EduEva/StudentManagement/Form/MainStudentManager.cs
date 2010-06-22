using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduEva.CoreData;
using EduEva.StudentManagement.Controls;
using Ninject;

namespace EduEva.StudentManagement.Form
{
    public partial class MainStudentManager : UserControl
    {
        private StudentPopUp AddStudent { get; set; }
        private List<Student> Students { get; set; }

        public MainStudentManager(StudentPopUp addStudent)
        {
            AddStudent = addStudent;
            InitializeComponent();
            CreateTestStudents();
            dataGridView1.DataSource = GetDisplayableStudents();
        }

        //TODO: DELETE THESE STUDENTS WHEN WE GET SAVED DATA
        private void CreateTestStudents()
        {
            Students = new List<Student>
                           {
                               new Student
                                   {
                                       Name = "Jake",
                                       Note = "rike a ross",
                                       Age = new Age
                                                 {
                                                     DateOfBirth = new DateTime(1989,12,4)
                                                 },
                                   },
                               new Student
                                   {
                                       Name = "Jesus",
                                       Note = "rimiliar roo a ross",
                                       Age = new Age
                                                 {
                                                     DateOfBirth = new DateTime(100, 12, 24)
                                                 },
                                   },
                               new Student
                                   {
                                       Name = "Budha",
                                       Note = "RickRolla ross",
                                       Age = new Age
                                                 {
                                                     DateOfBirth = new DateTime(1284,2,5)
                                                 },
                                   }
                           };
        }

        private void AddStudentClick(object sender, EventArgs e)
        {
          AddStudent.ShowDialog();
        }

        public List<DisplayItem> GetDisplayableStudents()
        {
            var items = new List<DisplayItem>();
            Students.ForEach(student => items.Add(new DisplayItem
                                            {
                                                DateOfBirth = student.Age.DateOfBirth.ToShortDateString(),
                                                Age = student.Age.CurrentAge.ToString(),
                                                Name = student.Name,
                                                Note = student.Note
                                            }));
            return items;
        }
    }

    public class DisplayItem
    {
        public string Name { get; set; }
        public string Age { get; set;}
        public string DateOfBirth { get; set;}
        public string Note { get; set; }
    }
}
