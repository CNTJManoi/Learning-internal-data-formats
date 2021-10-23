using System.Windows;
using System.Windows.Controls;

namespace CourseProject
{
    /// <summary>
    ///     Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Parameters.Mw = this;
        }

        private void Buttons_Click(object sender, RoutedEventArgs e)
        {
            var but = (Button) sender;
            var name = but.Name;
            if (name == "HomeButton" && Transitioner.SelectedIndex != 0)
            {
                Transitioner.SelectedIndex = 0;
                MenuToggleButton.IsChecked = !MenuToggleButton.IsChecked;
            }
            else if (name == "LearnButton" && Transitioner.SelectedIndex != 1)
            {
                Transitioner.SelectedIndex = 1;
                MenuToggleButton.IsChecked = !MenuToggleButton.IsChecked;
            }
            else if (name == "TestButton" && Transitioner.SelectedIndex != 2)
            {
                Transitioner.SelectedIndex = 2;
                MenuToggleButton.IsChecked = !MenuToggleButton.IsChecked;
            }
            else if (name == "HelpButton" && Transitioner.SelectedIndex != 3)
            {
                Transitioner.SelectedIndex = 3;
                MenuToggleButton.IsChecked = !MenuToggleButton.IsChecked;
            }
            else if (name == "AboutButton" && Transitioner.SelectedIndex != 4)
            {
                Transitioner.SelectedIndex = 4;
                MenuToggleButton.IsChecked = !MenuToggleButton.IsChecked;
            }
            else if (name == "PointerButton" && Transitioner.SelectedIndex != 5)
            {
                Transitioner.SelectedIndex = 5;
                MenuToggleButton.IsChecked = !MenuToggleButton.IsChecked;
            }
        }
    }
}