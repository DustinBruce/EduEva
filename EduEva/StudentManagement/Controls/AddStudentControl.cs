using System;
using System.IO;
using System.Windows.Forms;
using EduEva.CoreData;
using EduEva.Properties;

namespace EduEva.StudentManagement.Controls
{
    public partial class AddStudentControl : UserControl
    {
        public AddStudentControl()
        {
            InitializeComponent();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            ClosePopup();
        }

        private void SaveExSaveButtonClick(object sender, EventArgs e)
        {
            SaveStudent();
            ClosePopup();
        }

        private void SaveStudent()
        {
            var sw = File.AppendText(Resources.SaveFile);
            sw.WriteLine(CreateStudent().SaveStudent());
            sw.Close();
        }

        private Student CreateStudent()
        {
            return new Student
                              {
                                  Age = {DateOfBirth = DateTime.Parse(DateOfBirthPicker.Text)},
                                  Name = firstNameBox.Text + " " + MiddleNameBox.Text + " " + LastNameBox.Text,
                                  Class = new ClassRoom
                                              {
                                                  Grade = gradeBox.SelectedText
                                              },
                                Note = NoteRTB.Text
                              };
        }

        private void ClosePopup()
        {
            Parent.Parent.Hide();
        }

        private void SaveClicked(object sender, EventArgs e)
        {
            SaveStudent();
        }
    }
}
