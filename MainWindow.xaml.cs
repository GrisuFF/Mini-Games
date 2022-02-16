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

namespace Mini_Games
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnTetris_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Das Spiel befindet sich in Entwicklung!", "Tetris", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnTicTacToe_Click(object sender, RoutedEventArgs e)
        {
            TicTacToe_Start wnd = new TicTacToe_Start();
            wnd.ShowDialog();
        }
    }
}
