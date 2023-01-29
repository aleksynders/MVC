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

namespace MVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.tbTextOperation = tbTextOperation;
            Model.tbResult = tbResult;
            cbOperation.ItemsSource = Model.dataListOperationStr;
            cbOperation.SelectedIndex = 0;
        }

        private void cbOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.Operation = cbOperation.SelectedIndex;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Model.One = tbOne.Text;
            Model.Two = tbTwo.Text;
            Model.Result = cbOperation.SelectedIndex;
        }
    }
}
