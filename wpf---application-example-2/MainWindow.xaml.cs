using System.Windows;
using System.Windows.Input;


namespace wpf___application_example_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void DragBarClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
                this.DragMove();
        }
        private void CloseProgramClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
