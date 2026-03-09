// See https://aka.ms/new-console-template for more information
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var continuar = ExibirBoasVindas();

while(continuar == '1')
{
    Console.WriteLine("Então vamos começar...");

    var opcaoJogador = ObterEscolhaJogador();
    var opcaoPC = GerarEscolhaComputador();

    ExibirEscolhaJogador(opcaoJogador);
    ExibirEscolhaComputador(opcaoPC);

    ExibirResultado(opcaoJogador, opcaoPC);

    continuar = PerguntarJogarNovamente();
}

ExibirDespedida();

static char ExibirBoasVindas()
{
    Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");
    Console.WriteLine("1 - Sim ou 0 - Não");
    return ObterEntradaValida(new[] { '0', '1' });
}

static char ObterEscolhaJogador()
{
    Console.WriteLine("Escolha uma opção: 0 - Pedra ✊, 1 - Papel ✋ ou 2 - Tesoura ✌");
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
            Console.WriteLine("\nVocê escoheu Pedra ✊!");
            break;
        case '1':
            Console.WriteLine("\nVocê escoheu Papel ✋");
            break;
        case '2':
            Console.WriteLine("\nVocê escoheu Tesoura ✌");
            break;
    }
}

static void ExibirEscolhaComputador(int opcaoPC)
{
    switch (opcaoPC)
    {
        case 0:
            Console.WriteLine("\nEu escolhi Pedra ✊!");
            break;
        case 1:
            Console.WriteLine("\nEu escolhi Papel ✋");
            break;
        case 2:
            Console.WriteLine("\nEu escolhi Tesoura ✌");
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

static void ExibirResultado(char opcaoJogador, int opcaoPC)
{
    if (int.Parse(opcaoJogador.ToString()) == opcaoPC)
        Console.WriteLine("\n😀 Legal! Nós empatamos!");
    else if (VerificarVitoria(opcaoJogador, opcaoPC))
        Console.WriteLine("\n😀 Parabéns! Você venceu.");
    else
        Console.WriteLine("\n😀 Haha, eu venci! Não foi dessa vez. Você pode ter mais sorte na próxima.");
}

static char PerguntarJogarNovamente()
{
    Console.WriteLine("\nQuer jogar de novo?");
    Console.WriteLine("1 - Sim ou 0 - Não");
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

static void ExibirDespedida()
{
    Console.WriteLine("👋 Tchau! Até a próxima");
}