// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var estatisticas = new Dictionary<string, Estatisticas>();
var nomeJogador = ObterNomeJogador();

if (!estatisticas.ContainsKey(nomeJogador))
    estatisticas[nomeJogador] = new Estatisticas();

bool sair = false;

while (!sair)
{
    Console.Clear();
    var opcaoMenu = ExibirMenuPrincipal(nomeJogador);

    switch (opcaoMenu)
    {
        case '1': // Jogar
            JogarPartida(nomeJogador, estatisticas);
            break;
        case '2': // Trocar jogador
            nomeJogador = TrocarJogador(estatisticas);
            break;
        case '3': // Ver estatísticas
            ExibirEstatisticas(estatisticas);
            break;
        case '4': // Sair
            sair = true;
            break;
    }
}

ExibirDespedida(nomeJogador);

static void JogarPartida(string nomeJogador, Dictionary<string, Estatisticas> estatisticas)
{
    var continuar = ExibirBoasVindas(nomeJogador);

    while (continuar == '1')
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
        var resultado = ExibirResultado(opcaoJogador, opcaoPC, nomeJogador);
        AtualizarEstatisticas(estatisticas[nomeJogador], resultado);
        Console.WriteLine(new string('-', 50));

        continuar = PerguntarJogarNovamente();
    }
}

static char ExibirMenuPrincipal(string nomeJogador)
{
    Console.WriteLine("\n" + new string('=', 50));
    Console.WriteLine("🎮 JOKEMPO - MENU PRINCIPAL");
    Console.WriteLine(new string('=', 50));
    Console.WriteLine($"\n👤 Jogador atual: {nomeJogador}\n");
    Console.WriteLine("  1 - Jogar 🎲");
    Console.WriteLine("  2 - Trocar de jogador 🔄");
    Console.WriteLine("  3 - Ver estatísticas 📊");
    Console.WriteLine("  4 - Sair 🚪\n");
    Console.Write("Sua escolha: ");
    return ObterEntradaValida(new[] { '1', '2', '3', '4' });
}

static string ObterNomeJogador()
{
    Console.WriteLine("\n" + new string('=', 50));
    Console.WriteLine("🎮 BEM-VINDO AO JOKEMPO!");
    Console.WriteLine(new string('=', 50));
    Console.Write("\n😀 Olá! Qual é o seu nome? ");
    var nome = Console.ReadLine();
    return string.IsNullOrWhiteSpace(nome) ? "Jogador" : nome;
}

static string TrocarJogador(Dictionary<string, Estatisticas> estatisticas)
{
    Console.Clear();
    Console.WriteLine("\n" + new string('=', 50));
    Console.WriteLine("🔄 TROCAR DE JOGADOR");
    Console.WriteLine(new string('=', 50));
    Console.Write("\n😀 Digite o nome do jogador: ");
    var nome = Console.ReadLine();
    var nomeJogador = string.IsNullOrWhiteSpace(nome) ? "Jogador" : nome;

    if (!estatisticas.ContainsKey(nomeJogador))
    {
        estatisticas[nomeJogador] = new Estatisticas();
        Console.WriteLine($"\n✨ Novo jogador '{nomeJogador}' cadastrado!");
    }
    else
    {
        Console.WriteLine($"\n👋 Bem-vindo de volta, {nomeJogador}!");
    }

    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    return nomeJogador;
}

static void ExibirEstatisticas(Dictionary<string, Estatisticas> estatisticas)
{
    Console.Clear();
    Console.WriteLine("\n" + new string('=', 50));
    Console.WriteLine("📊 ESTATÍSTICAS DOS JOGADORES");
    Console.WriteLine(new string('=', 50) + "\n");

    if (estatisticas.Count == 0)
    {
        Console.WriteLine("Nenhum jogador cadastrado ainda.\n");
    }
    else
    {
        foreach (var jogador in estatisticas)
        {
            var stats = jogador.Value;
            var total = stats.Vitorias + stats.Derrotas + stats.Empates;
            var taxaVitoria = total > 0 ? (stats.Vitorias * 100.0 / total) : 0;

            Console.WriteLine($"👤 {jogador.Key}");
            Console.WriteLine($"   ├─ 🎉 Vitórias: {stats.Vitorias}");
            Console.WriteLine($"   ├─ 😢 Derrotas: {stats.Derrotas}");
            Console.WriteLine($"   ├─ 🤝 Empates: {stats.Empates}");
            Console.WriteLine($"   ├─ 🎮 Total de partidas: {total}");
            Console.WriteLine($"   └─ 📈 Taxa de vitória: {taxaVitoria:F1}%\n");
        }
    }

    Console.WriteLine(new string('=', 50));
    Console.WriteLine("\nPressione qualquer tecla para voltar...");
    Console.ReadKey();
}

static void AtualizarEstatisticas(Estatisticas stats, ResultadoPartida resultado)
{
    switch (resultado)
    {
        case ResultadoPartida.Vitoria:
            stats.Vitorias++;
            break;
        case ResultadoPartida.Derrota:
            stats.Derrotas++;
            break;
        case ResultadoPartida.Empate:
            stats.Empates++;
            break;
    }
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

static ResultadoPartida ExibirResultado(char opcaoJogador, int opcaoPC, string nomeJogador)
{
    ResultadoPartida resultado;

    if (int.Parse(opcaoJogador.ToString()) == opcaoPC)
    {
        Console.WriteLine("\n🤝 EMPATE! Nós empatamos!");
        resultado = ResultadoPartida.Empate;
    }
    else if (VerificarVitoria(opcaoJogador, opcaoPC))
    {
        Console.WriteLine($"\n🎉 VITÓRIA! Parabéns {nomeJogador}! Você venceu!");
        resultado = ResultadoPartida.Vitoria;
    }
    else
    {
        Console.WriteLine($"\n😢 DERROTA! Não foi dessa vez {nomeJogador}. Tente novamente!");
        resultado = ResultadoPartida.Derrota;
    }

    return resultado;
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

class Estatisticas
{
    public int Vitorias { get; set; }
    public int Derrotas { get; set; }
    public int Empates { get; set; }
}

enum ResultadoPartida
{
    Vitoria,
    Derrota,
    Empate
}
