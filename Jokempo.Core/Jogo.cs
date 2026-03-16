using System;

namespace Jokempo.Core
{
    public class Jogo
    {
        private Random random = new Random();

        public Estatisticas Estatisticas { get; private set; } = new Estatisticas();

        public Escolha GerarEscolhaComputador()
        {
            return (Escolha)random.Next(0, 3);
        }

        public string Jogar(Escolha escolhaJogador)
        {
            Escolha escolhaComputador = GerarEscolhaComputador();

            if (escolhaJogador == escolhaComputador)
            {
                Estatisticas.Empates++;
                return "Empate";
            }

            if (
                (escolhaJogador == Escolha.Pedra && escolhaComputador == Escolha.Tesoura) ||
                (escolhaJogador == Escolha.Papel && escolhaComputador == Escolha.Pedra) ||
                (escolhaJogador == Escolha.Tesoura && escolhaComputador == Escolha.Papel)
               )
            {
                Estatisticas.VitoriasJogador++;
                return "Jogador";
            }

            Estatisticas.VitoriasComputador++;
            return "Computador";
        }
    }
}