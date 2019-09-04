using JogoDaVelha;
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

namespace JogoDaVelhaWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public TabuleiroJogo Tabuleiro { get; set; } = new TabuleiroJogo();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Posicao00_Click(object sender, RoutedEventArgs e)
        {
            this.Tabuleiro.Jogar(this.Tabuleiro.JogadorAtual, 0, 0);
        }
    }
}
