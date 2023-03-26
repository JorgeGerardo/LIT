using System;
using System.Windows;
using System.Windows.Controls;
using SQLite;
using System.Data.OleDb;

namespace LIT
{
    public partial class MainWindow : Window
    {
        SQLite.SQLiteConnection conn;
    }

    // CTOR'S and UI
    public partial class MainWindow : Window
    {
        private Boolean _isStarted = true;
        public MainWindow() => InitializeComponent();
        private void TabMenuPrincipal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_isStarted)
            {
                _isStarted = false;
                return;
            }

            if (TIAgregar.IsSelected)
            {
                UC_Contestar.Visibility = Visibility.Collapsed;
                UC_Agregar.Visibility = Visibility.Visible;
            }
            //MessageBox.Show("Contestar");
            else
            {
                UC_Agregar.Visibility = Visibility.Collapsed;
                UC_Contestar.Visibility = Visibility.Visible;
            }
            //MessageBox.Show("Agregar");
        }
    }
}