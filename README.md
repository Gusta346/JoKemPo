# 🎮 Jokempo - Jogo de Pedra, Papel e Tesoura

Um jogo interativo de Pedra, Papel e Tesoura (Jokempo) desenvolvido em C# com interface de console, sistema de múltiplos jogadores e estatísticas detalhadas.

---

## 📋 Sobre o Projeto

Este projeto foi desenvolvido como parte de uma atividade acadêmica, implementando um jogo clássico de Jokempo com recursos avançados como sistema de estatísticas, suporte a múltiplos jogadores e interface amigável com emojis.

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

### 1️⃣ Início
- Digite seu nome quando solicitado
- Você será direcionado ao menu principal

### 2️⃣ Menu Principal
```
==================================================
🎮 JOKEMPO - MENU PRINCIPAL
==================================================

👤 Jogador atual: [Seu Nome]

  1 - Jogar 🎲
  2 - Trocar de jogador 🔄
  3 - Ver estatísticas 📊
  4 - Sair 🚪
```

### 3️⃣ Opções Disponíveis

#### 🎲 Jogar
- Escolha sua jogada (0 - Pedra, 1 - Papel, 2 - Tesoura)
- Veja o resultado contra o computador
- Suas estatísticas são atualizadas automaticamente
- Continue jogando ou retorne ao menu

#### 🔄 Trocar de Jogador
- Digite o nome de outro jogador
- Jogadores novos são cadastrados automaticamente
- Jogadores existentes têm suas estatísticas carregadas

#### 📊 Ver Estatísticas
- Visualize o desempenho de todos os jogadores
- Veja vitórias, derrotas, empates e taxa de sucesso
- Compare seu desempenho com outros jogadores

#### 🚪 Sair
- Encerra o jogo com mensagem personalizada de despedida

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem**: C# 12.0
- **Framework**: .NET 8.0
- **Paradigma**: Programação Procedural
- **Estruturas de Dados**:
  - `Dictionary<string, Estatisticas>` para armazenamento de dados
  - `Enum` para definição de resultados
  - `Class` para modelagem de estatísticas

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

### Classes e Enums

```csharp
// Classe para armazenar estatísticas do jogador
class Estatisticas
{
    public int Vitorias { get; set; }
    public int Derrotas { get; set; }
    public int Empates { get; set; }
}

// Enum para tipos de resultado
enum ResultadoPartida
{
    Vitoria,
    Derrota,
    Empate
}
```

---

## 🎨 Características Técnicas

### ✅ Validação de Dados
- Validação de todas as entradas do usuário
- Tratamento de entradas vazias ou inválidas
- Loop de validação até entrada correta

### 🔄 Modularização
- Código organizado em métodos específicos
- Responsabilidade única para cada função
- Fácil manutenção e expansão

### 💾 Persistência de Dados (em memória)
- Estatísticas mantidas durante toda a sessão
- Suporte para múltiplos jogadores simultâneos
- Dados organizados em estrutura Dictionary

### 🎯 Lógica de Jogo
- Implementação correta das regras do Jokempo
- Geração aleatória de jogadas do computador
- Detecção precisa de vitória, derrota e empate

---

## 📊 Exemplo de Estatísticas

```
📊 ESTATÍSTICAS DOS JOGADORES

👤 Gustavo
   ├─ 🎉 Vitórias: 15
   ├─ 😢 Derrotas: 8
   ├─ 🤝 Empates: 5
   ├─ 🎮 Total de partidas: 28
   └─ 📈 Taxa de vitória: 53.6%

👤 Gabriel
   ├─ 🎉 Vitórias: 12
   ├─ 😢 Derrotas: 10
   ├─ 🤝 Empates: 3
   ├─ 🎮 Total de partidas: 25
   └─ 📈 Taxa de vitória: 48.0%
```

---

## 👥 Desenvolvedores

Este projeto foi desenvolvido por:

| Nome | RM |
|------|-----|
| **Gustavo Oliveira** | 559163 |
| **Gabriel Vasque** | 557056 |
| **Augusto Mendonça** | 558371 |

---

## 📝 Histórico de Versões

- **v1.0** - Versão inicial com jogo básico
- **v2.0** - Adição de modularização do código
- **v3.0** - Implementação de validação de entradas
- **v4.0** - Sistema de cadastro de nome do jogador
- **v5.0** - Interface melhorada com melhor legibilidade
- **v6.0** - Sistema de múltiplos jogadores e estatísticas completas

---

## 🔮 Funcionalidades Futuras (Roadmap)

- [ ] Persistência de dados em arquivo/banco de dados
- [ ] Modo de jogo multiplayer (jogador vs jogador)
- [ ] Ranking global de jogadores
- [ ] Histórico detalhado de partidas
- [ ] Temas de cores personalizáveis
- [ ] Modo torneio

---

## 📄 Licença

Este projeto foi desenvolvido para fins educacionais.

---

## 🤝 Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para:
- Reportar bugs
- Sugerir novas funcionalidades
- Melhorar a documentação
- Submeter pull requests

---

## 📞 Contato

Para dúvidas ou sugestões sobre o projeto, entre em contato com os desenvolvedores através do GitHub.

---

**Desenvolvido com 💙 em C#**
