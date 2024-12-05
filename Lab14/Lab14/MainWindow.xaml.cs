using System.Windows;

namespace Lab14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new BookViewModel();
        }
    }
}
