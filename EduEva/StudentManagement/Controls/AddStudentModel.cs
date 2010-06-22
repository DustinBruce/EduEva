using System;
using System.IO;
using EduEva.CoreData;
using EduEva.Properties;

namespace EduEva.StudentManagement.Controls
{
    public class AddStudentModel
    {
        private AddStudentControl AddStudentControl { get; set; }
        public Action Update { get; set; }

        public AddStudentModel(AddStudentControl addStudentControl)
        {
            AddStudentControl = addStudentControl;
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            ClosePopup();
            Update();
        }

        private void SaveExSaveButtonClick(object sender, EventArgs e)
        {
            SaveStudent();
            ClosePopup();
            Update();
        }

        private void SaveStudent()
        {
            var sw = File.AppendText(Resources.SaveFile);
            sw.WriteLine(CreateStudent().SaveStudent());
            sw.Close();
            Update();
        }

        private Student CreateStudent()
        {
            return new Student
            {
                Age = { DateOfBirth = DateTime.Parse(AddStudentControl.DateOfBirthPicker.Text) },
                Name = AddStudentControl.firstNameBox.Text + " " + AddStudentControl.MiddleNameBox.Text + " " + AddStudentControl.LastNameBox.Text,
                Class = new ClassRoom
                {
                    Grade = AddStudentControl.gradeBox.SelectedText
                },
                Note = AddStudentControl.NoteRTB.Text
            };
        }

        private void ClosePopup()
        {
            AddStudentControl.Parent.Parent.Hide();
        }

        private void SaveClicked(object sender, EventArgs e)
        {
            SaveStudent();
        }
        
        internal void HookUpEvents()
        {
            AddStudentControl.SaveAndExit.Click += SaveExSaveButtonClick;
            AddStudentControl.saveButton.Click += SaveClicked;
            AddStudentControl.exitButton.Click += ExitButtonClick;
        }
    }
}
