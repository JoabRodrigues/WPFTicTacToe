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

        private void Jogar(int x, int y)
        {
            try
            {
                this.Tabuleiro.Jogar(this.Tabuleiro.JogadorAtual, x, y);

                switch (this.Tabuleiro.VerificarGanhador())
                {
                    case 1:
                        MessageBox.Show("Jogador 1 Ganhou!");
                        break;
                    case 2:
                        MessageBox.Show("Jogador 2 Ganhou!");
                        break;
                    case -1:
                        MessageBox.Show("Não Houve vencedores :(");
                        break;
                }
                if(this.Tabuleiro.VerificarGanhador() != 0)
                {
                    this.ReiniciarJogo();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Jogo da Velha");
            }
        }

        private void ReiniciarJogo()
        {
            this.Tabuleiro = new TabuleiroJogo();
        }

        private void Posicao00_Click(object sender, RoutedEventArgs e)
        {
            this.Jogar(0, 0);           
        }

        private void Posicao01_Click(object sender, RoutedEventArgs e)
        {
            this.Jogar(0, 1);
        }

        private void Posicao02_Click(object sender, RoutedEventArgs e)
        {
            this.Jogar(0, 2);
        }

        private void Posicao10_Click(object sender, RoutedEventArgs e)
        {
            this.Jogar(1, 0);
        }

        private void Posicao11_Click(object sender, RoutedEventArgs e)
        {
            this.Jogar(1, 1);
        }

        private void Posicao12_Click(object sender, RoutedEventArgs e)
        {
            this.Jogar(1, 2);
        }

        private void Posicao20_Click(object sender, RoutedEventArgs e)
        {
            this.Jogar(2, 0);
        }

        private void Posicao21_Click(object sender, RoutedEventArgs e)
        {
            this.Jogar(2, 1);
        }

        private void Posicao22_Click(object sender, RoutedEventArgs e)
        {
            this.Jogar(2, 2);
        }
    }
}
