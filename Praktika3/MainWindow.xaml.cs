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
using Praktika3.BookStoreDataSet1TableAdapters;

namespace Praktika3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OrderInfoTableAdapter OrderInfo = new OrderInfoTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            OrdersFullDataGrid.ItemsSource = OrderInfo.GetDataFullInfo();

        }

        private void New_Loaded(object sender, RoutedEventArgs e) 
        {
            OrdersFullDataGrid.Columns[0].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[1].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[2].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[3].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[6].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[7].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[8].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[11].Visibility = Visibility.Collapsed;
            

        }

    }
}
