using CSharpLab2.ViewModel;
using System.Windows.Controls;

namespace CSharpLab2.View
{
    /// <summary>
    /// Логика взаимодействия для UserFormView.xaml
    /// </summary>
    public partial class UserFormView : UserControl
    {
        public UserFormView()
        {
            DataContext = new UserFormViewModel();
            InitializeComponent();
        }
    }
}
