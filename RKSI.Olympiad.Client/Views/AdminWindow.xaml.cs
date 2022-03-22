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
using RKSI.Olympiad.Client.ViewModels;

namespace RKSI.Olympiad.Client.Views
{
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void DocumentType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedString = ((sender as ComboBox).SelectedValue as TextBlock).Text;
            if (selectedString == "Иностранный паспорт")
            {
                MigrationStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                MigrationStackPanel.Visibility = Visibility.Collapsed;
            }
        }
    }
}
