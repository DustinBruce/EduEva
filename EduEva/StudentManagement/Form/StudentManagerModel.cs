using System;
using EduEva.StudentManagement.Controls;

namespace EduEva.StudentManagement.Form
{
    public class StudentManagerModel
    {
        internal MainStudentManager MainStudentManager { get; set; }

        public StudentManagerModel(MainStudentManager mainStudentManager)
        {
            MainStudentManager = mainStudentManager;
            WireUpEvents();
            MainStudentManager.AddStudent.AddStudentWindow.Model.Update();
        }

        private void WireUpEvents()
        {
           MainStudentManager.AddStudent.AddStudentWindow.Model.Update = SetUpDataGrid;
           MainStudentManager.AddButton.Click += AddStudentClick;
        }
        private void SetUpDataGrid()
        {
            MainStudentManager.dataGridView1.DataSource = ReadStudentFile.GetDisplayableStudents();
        }

        private void AddStudentClick(object sender, EventArgs e)
        {
            MainStudentManager.AddStudent.ShowDialog();
        }
    }
}
