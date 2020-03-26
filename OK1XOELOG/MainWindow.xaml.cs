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

namespace OK1XOELOG
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            OK1XOELOG.HRD_My_LogbookDataSet hRD_My_LogbookDataSet = ((OK1XOELOG.HRD_My_LogbookDataSet)(this.FindResource("hRD_My_LogbookDataSet")));
            // Načte data do tabulky TABLE_HRD_CONTACTS_V01. Tento kód lze upravovat podle potřeby.
            OK1XOELOG.HRD_My_LogbookDataSetTableAdapters.TABLE_HRD_CONTACTS_V01TableAdapter hRD_My_LogbookDataSetTABLE_HRD_CONTACTS_V01TableAdapter = new OK1XOELOG.HRD_My_LogbookDataSetTableAdapters.TABLE_HRD_CONTACTS_V01TableAdapter();
            hRD_My_LogbookDataSetTABLE_HRD_CONTACTS_V01TableAdapter.Fill(hRD_My_LogbookDataSet.TABLE_HRD_CONTACTS_V01);
            System.Windows.Data.CollectionViewSource tABLE_HRD_CONTACTS_V01ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tABLE_HRD_CONTACTS_V01ViewSource")));
            tABLE_HRD_CONTACTS_V01ViewSource.View.MoveCurrentToFirst();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.textBlock = MainWindow.textBox + MainWindow.textBox_Copy;
        }
    }
}
