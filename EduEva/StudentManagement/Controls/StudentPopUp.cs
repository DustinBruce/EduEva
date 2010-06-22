using EduEva.CoreControl;

namespace EduEva.StudentManagement.Controls
{
    public class StudentPopUp : PopUpBox
    {
        public AddStudentControl AddStudentWindow { get; set; }
     
        public StudentPopUp(AddStudentControl addStudentWindow)
        {
            AddStudentWindow = addStudentWindow;
            PopUpSheetPlugIn.Controls.Add(AddStudentWindow);
        }
    }
}
