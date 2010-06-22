using System.Windows.Forms;

namespace EduEva.StudentManagement.Controls
{
    public partial class AddStudentControl : UserControl
    {
        public AddStudentModel Model { get; set; }
        public AddStudentControl()
        {
            InitializeComponent();
            Model = new AddStudentModel(this);
            Model.HookUpEvents();
        }
    }
}
