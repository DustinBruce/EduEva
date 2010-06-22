using System.Windows.Forms;
using EduEva.StudentManagement.Form;

namespace EduEva
{
    public partial class MainWindow : Form
    {
        private MainStudentManager StudentPane { get; set; }
        private MainModel ViewModel { get; set; }
        public MainWindow(MainStudentManager studentPane)
        {
            StudentPane = studentPane;
            InitializeComponent();
            ViewModel = new MainModel(this, studentPane);
        }
    }
}
