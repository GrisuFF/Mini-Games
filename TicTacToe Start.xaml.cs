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

namespace Mini_Games
{
    /// <summary>
    /// Interaktionslogik für TicTacToe_Start.xaml
    /// </summary>
    public partial class TicTacToe_Start : Window
    {
        public TicTacToe_Start()
        {
            InitializeComponent();
        }

        private void btnStartTicTacToe_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnCancelTicTacToe_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbNamePlayer1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbNamePlayer1.Text == "" && tbNamePlayer2.Text == "")
            {
                btnStartTicTacToe.IsEnabled = false;
            }
            else
            {
                btnStartTicTacToe.IsEnabled = true;
            }
        }
    }
}
