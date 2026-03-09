# 🎮 Jokempo - Jogo de Pedra, Papel e Tesoura

Jogo interativo de Pedra, Papel e Tesoura desenvolvido em C# com sistema de múltiplos jogadores e estatísticas.

## 👥 Desenvolvedores

| Nome | RM |
|------|-----|
| **Gustavo Oliveira** | 559163 |
| **Gabriel Vasquez** | 557056 |
| **Augusto Mendonça** | 558371 |

---

## ✨ Funcionalidades

### 🎲 Sistema de Jogo
- **Jogo contra o computador**: Escolha entre Pedra ✊, Papel ✋ ou Tesoura ✌
- **Validação de entrada**: Sistema robusto que aceita apenas entradas válidas
- **Feedback visual**: Interface colorida com emojis para melhor experiência
- **Jogadas ilimitadas**: Continue jogando até decidir parar

### 👥 Sistema de Jogadores
- **Múltiplos jogadores**: Suporte para diversos jogadores no mesmo sistema
- **Troca de jogador**: Alterne entre diferentes jogadores a qualquer momento
- **Cadastro automático**: Novos jogadores são registrados automaticamente
- **Boas-vindas personalizadas**: Mensagens customizadas com o nome do jogador

### 📊 Sistema de Estatísticas
- **Estatísticas individuais**: Cada jogador possui seu próprio histórico
- **Métricas detalhadas**:
  - 🎉 Total de vitórias
  - 😢 Total de derrotas
  - 🤝 Total de empates
  - 🎮 Total de partidas jogadas
  - 📈 Taxa de vitória em porcentagem
- **Visualização organizada**: Interface clara e hierárquica para consulta de dados

### 🎨 Interface do Usuário
- **Menu principal intuitivo**: Navegação fácil entre opções
- **Mensagens personalizadas**: Feedback específico para cada ação
- **Separadores visuais**: Organização clara das seções
- **Limpeza de tela**: Telas organizadas para melhor legibilidade

---

## 🚀 Como Executar

### Pré-requisitos
- .NET 8.0 ou superior
- Sistema operacional: Windows, Linux ou macOS

### Passos para execução

1. **Clone o repositório**
   ```bash
   git clone https://github.com/Gusta346/JoKemPo.git
   cd JoKemPo
   ```

2. **Execute o projeto**
   ```bash
   dotnet run --project Jokempo
   ```

3. **Ou compile e execute**
   ```bash
   dotnet build
   dotnet run
   ```

---

## 🎯 Como Jogar

1. Digite seu nome
2. Escolha uma opção no menu:
   - **1 - Jogar** → Escolha Pedra (0), Papel (1) ou Tesoura (2)
   - **2 - Trocar jogador** → Mude para outro jogador
   - **3 - Ver estatísticas** → Veja o desempenho de todos
   - **4 - Sair** → Encerra o jogo

---



## 📁 Estrutura do Código

### Principais Métodos

| Método | Descrição |
|--------|-----------|
| `ExibirMenuPrincipal()` | Exibe o menu principal e captura opção |
| `JogarPartida()` | Gerencia uma sessão de jogo completa |
| `TrocarJogador()` | Permite alternar entre jogadores |
| `ExibirEstatisticas()` | Mostra estatísticas de todos os jogadores |
| `ObterEscolhaJogador()` | Captura a jogada do jogador com validação |
| `GerarEscolhaComputador()` | Gera jogada aleatória do computador |
| `VerificarVitoria()` | Implementa lógica de vitória do jogo |
| `AtualizarEstatisticas()` | Atualiza contadores após cada partida |
| `ObterEntradaValida()` | Valida entrada do usuário |






## 📝 Histórico de Versões

- **v1.0** - Versão inicial com jogo básico
- **v2.0** - Adição de modularização do código
- **v3.0** - Implementação de validação de entradas
- **v4.0** - Sistema de cadastro de nome do jogador
- **v5.0** - Interface melhorada com melhor legibilidade
- **v6.0** - Sistema de múltiplos jogadores e estatísticas completas

---

