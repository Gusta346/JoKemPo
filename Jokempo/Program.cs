// See https://aka.ms/new-console-template for more information
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var nomeJogador = ObterNomeJogador();
var continuar = ExibirBoasVindas(nomeJogador);

while(continuar == '1')
{
    Console.Clear();
    Console.WriteLine("\n" + new string('=', 50));
    Console.WriteLine("🎮 NOVA RODADA");
    Console.WriteLine(new string('=', 50) + "\n");

    var opcaoJogador = ObterEscolhaJogador();
    var opcaoPC = GerarEscolhaComputador();

    Console.WriteLine();
    ExibirEscolhaJogador(opcaoJogador);
    ExibirEscolhaComputador(opcaoPC);

    Console.WriteLine("\n" + new string('-', 50));
    ExibirResultado(opcaoJogador, opcaoPC, nomeJogador);
    Console.WriteLine(new string('-', 50));

    continuar = PerguntarJogarNovamente();
}

ExibirDespedida(nomeJogador);

static string ObterNomeJogador()
{
    Console.WriteLine("\n" + new string('=', 50));
    Console.WriteLine("🎮 BEM-VINDO AO JOKEMPO!");
    Console.WriteLine(new string('=', 50));
    Console.Write("\n😀 Olá! Qual é o seu nome? ");
    var nome = Console.ReadLine();
    return string.IsNullOrWhiteSpace(nome) ? "Jogador" : nome;
}

static char ExibirBoasVindas(string nomeJogador)
{
    Console.WriteLine($"\n\n😀 Olá {nomeJogador}! Vamos jogar Jokempo?");
    Console.WriteLine("\n1 - Sim\n0 - Não\n");
    Console.Write("Sua escolha: ");
    return ObterEntradaValida(new[] { '0', '1' });
}

static char ObterEscolhaJogador()
{
    Console.WriteLine("Escolha sua jogada:");
    Console.WriteLine("\n  0 - Pedra ✊");
    Console.WriteLine("  1 - Papel ✋");
    Console.WriteLine("  2 - Tesoura ✌\n");
    Console.Write("Sua escolha: ");
    return ObterEntradaValida(new[] { '0', '1', '2' });
}

static int GerarEscolhaComputador()
{
    return new Random().Next(3);
}

static void ExibirEscolhaJogador(char opcao)
{
    switch (opcao)
    {
        case '0':
            Console.WriteLine("\n👤 Você escolheu: Pedra ✊");
            break;
        case '1':
            Console.WriteLine("\n👤 Você escolheu: Papel ✋");
            break;
        case '2':
            Console.WriteLine("\n👤 Você escolheu: Tesoura ✌");
            break;
    }
}

static void ExibirEscolhaComputador(int opcaoPC)
{
    switch (opcaoPC)
    {
        case 0:
            Console.WriteLine("🤖 Computador escolheu: Pedra ✊");
            break;
        case 1:
            Console.WriteLine("🤖 Computador escolheu: Papel ✋");
            break;
        case 2:
            Console.WriteLine("🤖 Computador escolheu: Tesoura ✌");
            break;
    }
}

static bool VerificarVitoria(char opcaoJogador, int opcaoPC)
{
    return opcaoJogador switch
    {
        '0' => opcaoPC == 2,
        '1' => opcaoPC == 0,
        '2' => opcaoPC == 1,
        _ => false
    };
}

static void ExibirResultado(char opcaoJogador, int opcaoPC, string nomeJogador)
{
    if (int.Parse(opcaoJogador.ToString()) == opcaoPC)
        Console.WriteLine("\n🤝 EMPATE! Nós empatamos!");
    else if (VerificarVitoria(opcaoJogador, opcaoPC))
        Console.WriteLine($"\n🎉 VITÓRIA! Parabéns {nomeJogador}! Você venceu!");
    else
        Console.WriteLine($"\n😢 DERROTA! Não foi dessa vez {nomeJogador}. Tente novamente!");
}

static char PerguntarJogarNovamente()
{
    Console.WriteLine("\n\nQuer jogar de novo?");
    Console.WriteLine("\n1 - Sim\n0 - Não\n");
    Console.Write("Sua escolha: ");
    return ObterEntradaValida(new[] { '0', '1' });
}

static char ObterEntradaValida(char[] opcoesValidas)
{
    char entrada;
    do
    {
        entrada = Console.ReadKey().KeyChar;

        if (!opcoesValidas.Contains(entrada))
        {
            Console.WriteLine($"\n❌ Opção inválida! Por favor, escolha uma das opções válidas.");
        }
    } while (!opcoesValidas.Contains(entrada));

    return entrada;
}

static void ExibirDespedida(string nomeJogador)
{
    Console.Clear();
    Console.WriteLine("\n" + new string('=', 50));
    Console.WriteLine($"👋 Tchau {nomeJogador}! Até a próxima!");
    Console.WriteLine("   Obrigado por jogar Jokempo! 🎮");
    Console.WriteLine(new string('=', 50) + "\n");
}
