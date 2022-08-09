# Fundamentos do CSharp

- [Fundamentos do CSharp](#fundamentos-do-csharp)
  - [.NET](#net)
    - [Como criar aplicativo console via dotnet CLI](#como-criar-aplicativo-console-via-dotnet-cli)
    - [Comandos principais do dotnet](#comandos-principais-do-dotnet)
    - [Variáveis de ambiente](#variáveis-de-ambiente)
    - [Estrutura do App](#estrutura-do-app)
  - [Linguagem de Programação CSharp](#linguagem-de-programação-csharp)
    - [Escopo de um programa](#escopo-de-um-programa)
    - [Namespaces](#namespaces)
    - [Using](#using)
    - [Variáveis](#variáveis)
    - [Constantes](#constantes)
    - [Palavras reservadas](#palavras-reservadas)
    - [Comentários](#comentários)
    - [Tipos primitivos](#tipos-primitivos)
    - [System](#system)
    - [Byte](#byte)

## .NET

### Como criar aplicativo console via dotnet CLI

- Criar na pasta atual:

  ```powershell
  dotnet new console
  ```

- Criar em uma outra pasta:

  ```powershell
  dotnet new console -o NomeDoProjeto
  ```

**OBS: Utilizar nomes de projeto sempre com letra maiúscula, evitando utilizar traços, etc...**

### Comandos principais do dotnet

- `dotnet restore` - busca todos os pacotes que a aplicação precisa pra executar e fazer a instalação deles. Só executa em pastas que possuam arquivos com extensão `.csproj`
- `dotnet build` - para compilar a aplicação
- `dotnet clean` - limpar arquivos de cache da aplicação. Pois alguns pacotes o SO guarda em cache pra quando você utiliza outro projeto o SO aproveitar os pacotes salvos em cache
- `dotnet run` - executar aplicação

**Fluxo de execução**: rodar um `dotnet clean` antes para evitar acumulo de "sujeira"

### Variáveis de ambiente

Ambientes de desenvolvimento principais:

- Desenvolvimento
- Testes
- Homologação
- Produção

É possível passar o ambiente que estamos utilizando na execução de nossas aplicações:

```powershell
  dotnet run --environment=Development
  dotnet run --environment=Production
```

comando `run` não executa depuração (Debug)

### Estrutura do App

Toda aplicação pra ser executada procura o arquivo padrão que no caso seria o `Program.cs`

**OBS: Os projetos são criados baseados no nome da pasta, por isso não é legal utilizar caracteres especiais**.

## Linguagem de Programação CSharp

### Escopo de um programa

- `Importações`: importações de módulos (acesso a banco de dados, etc...)
- `Namespace`: separações lógicas (nomes que criamos pra separar lógicamente a aplicação)
- `Classe`
- `Método Principal`

A ordem de execução de um projeto console seria a seguinte:

- Buscar Program.cs
- Ler Classe Program.cs
- Ler Método Main

### Namespaces

- Não podemos ter 2 classes com mesmo nome no mesmo namespace
- Ideal ter um name space e uma classe por arquivo
- Pra utilizar classe do namespace, pode-se usar a diretiva `using`
- Durante a compilação o que sobrará será apenas a divisão lógica (os namespaces), pois a divisão física (arquivos) será unificada.

### Using

- São importações de bibliotecas que podem ser nativas ou não

### Variáveis

- Criar uma varíavel ou instanciar uma variável é a mesma coisa
- Não é possível criar variáveis com palavras reservadas da linguagem
- Primeiras letras das variáveis são minúsculas
- Utilizar declarações em `camelCase`

```csharp
  int idade = 10; // correto, inicia com zero
  int idade = 10; // declaração tipo inteiro
  var idade = 25; // inferência de tipo int
```

### Constantes

- Não podem ser alteradas depois que forem declaradas
- Não pode usar `var` em constantes
- Comum ver sempre com notação em maiúsculo

```csharp
  const int IDADE_MINIMA; // inicia com zero
  const int IDADE_MINIMA = 25; // correto
  const var IDADE_MINIMA = 25; // errado
```

### Palavras reservadas

- Também chamados de keywords
- palavras nativas do sistema

### Comentários

- Tem três tipos
  - em linha
  - multilinha
  - em XML (metadata)
    - Documentações e etc

```csharp
  /*
  Comentário multilinha
  */
  // Comentário em linha
```

### Tipos primitivos

- Tipos base existentes no dotnet
  - inteiros
  - cadeia de caracteres
  - pontos flutuantes
  - etc...
- Chamados de **tipos de valor**
  - Classificados em
    - tipos simples (simple types)
    - enumeradores (enums)
    - estruturas (structs)
    - tipos nulos (nullable types)
- cada tipo aloca um espaço específico na memória

### System

- É o tipo raiz
- Todos derivam do `system`

### Byte

- igual a 8 bits
- sbyte permite valores negativos
- não é comum criar ele na mão

```csharp
  byte meuByte = 127;
```
