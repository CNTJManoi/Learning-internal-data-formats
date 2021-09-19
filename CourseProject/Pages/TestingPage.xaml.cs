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
using System.Windows.Shapes;

namespace CourseProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestingPage.xaml
    /// </summary>
    public partial class TestingPage : UserControl
    {
        public TestingPage()
        {
            InitializeComponent();
            ModeBox.SelectedIndex = 0;
        }

        private void ModeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimePanel.Opacity = ModeBox.SelectedIndex == 1 ? 1 : 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserDone.IsEnabled = true;
        }

        private void UserDone_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
