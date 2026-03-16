/*namespace Jokempo.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
*/

using System;
using System.Windows.Forms;
using Jokempo.Core;

namespace Jokempo.UI
{
    public partial class Form1 : Form
    {
        private Jogo jogo = new Jogo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            Jogar(Escolha.Pedra);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            Jogar(Escolha.Papel);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            Jogar(Escolha.Tesoura);
        }

        private void Jogar(Escolha escolhaJogador)
        {
            var resultado = jogo.Jogar(escolhaJogador);

            lblResultado.Text = "Resultado: " + resultado;

            lblJogador.Text = "Jogador: " + jogo.Estatisticas.VitoriasJogador;
            lblComputador.Text = "Computador: " + jogo.Estatisticas.VitoriasComputador;
            lblEmpate.Text = "Empates: " + jogo.Estatisticas.Empates;
        }
    }
}