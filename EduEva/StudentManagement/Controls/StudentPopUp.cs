using EduEva.CoreControl;

namespace EduEva.StudentManagement.Controls
{
    public class StudentPopUp : PopUpBox
    {
        private AddStudentControl AddStudentWindow { get; set; }
     
        public StudentPopUp(AddStudentControl addStudentWindow)
        {
            AddStudentWindow = addStudentWindow;
            PopUpSheetPlugIn.Controls.Add(AddStudentWindow);
        }
    }
}
