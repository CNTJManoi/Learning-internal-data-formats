using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Parameters.mw = this;
        }

        private void Buttons_Click(object sender, RoutedEventArgs e)
        {
            Button but = (Button)sender;
            string name = but.Name;
            if (name == "HomeButton" && Transitioner.SelectedIndex != 0) { Transitioner.SelectedIndex = 0; MenuToggleButton.IsChecked = !MenuToggleButton.IsChecked; }
            else if (name == "LearnButton" && Transitioner.SelectedIndex != 1) { Transitioner.SelectedIndex = 1; MenuToggleButton.IsChecked = !MenuToggleButton.IsChecked; }
            else if (name == "TestButton" && Transitioner.SelectedIndex != 2) { Transitioner.SelectedIndex = 2; MenuToggleButton.IsChecked = !MenuToggleButton.IsChecked; }
            else if (name == "HelpButton" && Transitioner.SelectedIndex != 3) { Transitioner.SelectedIndex = 3; MenuToggleButton.IsChecked = !MenuToggleButton.IsChecked; }
            else if (name == "AboutButton" && Transitioner.SelectedIndex != 4) { Transitioner.SelectedIndex = 4; MenuToggleButton.IsChecked = !MenuToggleButton.IsChecked; }
        }
    }
}
