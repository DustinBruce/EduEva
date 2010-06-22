using EduEva.CoreControl;
using EduEva.StudentManagement.Controls;
using EduEva.StudentManagement.Form;
using Ninject.Modules;

namespace EduEva
{
    class EduModule : NinjectModule
    {
        public override void Load()
        {
            BindMainWindow();
            BindStudent();
        }

        private void BindStudent()
        {
            Kernel.Bind<AddStudentControl>().ToSelf().InTransientScope();
            Kernel.Bind<MainStudentManager>().ToSelf().InSingletonScope();
            Kernel.Bind<StudentPopUp>().ToSelf().InTransientScope();
        }

        private void BindMainWindow()
        {
            Kernel.Bind<MainWindow>().ToSelf().InSingletonScope();
            Kernel.Bind<PopUpBox>().ToSelf().InTransientScope();
        }
    }
}
