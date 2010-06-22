using System;
using System.Windows.Forms;
using EduEva.StudentManagement.Controls;

namespace EduEva.StudentManagement.Form
{
    public partial class MainStudentManager : UserControl
    {
        public StudentPopUp AddStudent { get; set; }
        private StudentManagerModel Model { get; set; }

        public MainStudentManager(StudentPopUp addStudent)
        {
            AddStudent = addStudent;
            InitializeComponent();
            Model = new StudentManagerModel(this);
        }
    }
}

