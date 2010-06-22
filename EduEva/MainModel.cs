using System;
using EduEva.StudentManagement.Form;

namespace EduEva
{
    public class MainModel
    {
        public MainWindow Window { get; set; }
        public MainStudentManager MainStudentManagerger { get; set; }

        public MainModel(MainWindow window, MainStudentManager mainStudentManagerger)
        {
            Window = window;
            MainStudentManagerger = mainStudentManagerger;
            HookUpEvents();
        }

        private void HookUpEvents()
        {
            Window.StudentManagement.Click += StudentManagerClicked;

        }

        #region EventMethods
        public void StudentManagerClicked(object whoSentMe, EventArgs eventInfoSentWithCall)
        {
            Window.panel1.Controls.Add(MainStudentManagerger);
        }


        #endregion
    }
}
