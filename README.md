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
    - [Números inteiros](#números-inteiros)
    - [Números reais](#números-reais)
    - [Boolean](#boolean)
    - [Char](#char)
    - [String](#string)
    - [Var](#var)
    - [Object](#object)
    - [Nullabel Types](#nullabel-types)
    - [Alias](#alias)
    - [Valores padrões](#valores-padrões)
    - [Conversão Implícita](#conversão-implícita)
    - [Conversão Explícita](#conversão-explícita)
    - [Parse](#parse)
    - [Convert](#convert)
    - [Convertendo tipos](#convertendo-tipos)
    - [Operações aritméticas](#operações-aritméticas)
    - [Operações de atribuição](#operações-de-atribuição)
    - [Operações de Comparação](#operações-de-comparação)
    - [Utilizando Operadores](#utilizando-operadores)
    - [Operadores Lógicos](#operadores-lógicos)
    - [Estrutura Condicional: If](#estrutura-condicional-if)

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

### Números inteiros

- definidos por, os que começam com "u" não possuem sinal negativo
  - short / ushort (16-bit)
  - int / uint (32-bit)
  - long / ulong (64-bit)

```csharp
  uint idade = -25; // erro
  uint idade = 25; // ok
  int idade = 25; // ok
```

### Números reais

- Unsigned ("u") não existe para números reais
- float (notação F) (32-bit)
- double (64-bit)
- decimal (notação M) (128-bit)

```csharp
  int idade = 25.3; // erro
  var salario = 10; // inferencia de int
  var salario = 20.5; // inferencia de double
  double salario = 2.500; // ok
  float salario = 2.500f; // ok
  decimal salario = 25.000m; // ok
```

### Boolean

Armazena verdadeiro ou falso (true or false)

- Usa 8 bits

```csharp
  bool usuarioCadastrado = false;
  bool pagamentoRecebido = true;
  var usuarioExpirado = false;
```

### Char

- Armazenar apenas um caractere no formato Unicode
  - ocupa 16-bit
  - tem que ser utilizado com aspas simples para representar a char

Exemplo:

```csharp
  char primeiraLetra = 'a';
  var segundaLetra = 'b';
```

### String

Armazena cadeia de caracteres (uma lista de `char`)

- Atribuição por aspas duplas ("")
- Uso de memória depende do tamanho da string

```csharp
  string primeiraLetra = "C";
  string texto = "um texto qualquer";
  var documento = "meu documento 789";
```

### Var

Substitui o nome de qualquer tipo (por inferência de tipo). Vai assumir o tipo do primeiro valor que for atribuído a ele

```csharp
  var idade = 25; // idade passa a ser do tipo int
  idade = "André"; // erro

  IEnumerable<MeuTipoComplexo> aluno = new IEnumerable<MeuTipoComplexo>();

  var aluno = new IEnumerable<MeutipoComplexo>();
```

### Object

- Tipo objeto
- Recebe qualquer valor ou objeto
  - Serve pra caso não o tipo que se recebe ou quer passer não é definido
- Não tem intelisense

```csharp
  object quantidade; // pode ser qualquer coisa

  quantidade = 2.5; // ok
  quantidade = "teste"; // ok
```

### Nullabel Types

- `void` significa vazio (sem retorno)
- Tipo `null` é a mesma coisa, significa vazio
- Deve ser marcado como nullable se quiser dizer que é null
  - Utilizar a interrogação para demonstrar que aquele valor pode ser um nulo

```csharp
  int idade = null; // erro pois o int é um non-nullable
  int? idade = null; // ok
```

### Alias

É um apelido que todo tipo no .NET possui

- Exemplo
  - quando utilizamos `string` pra declarar variáveis estamos usando o `System.String`
  - `string` é um `alias` de `System.String`
  - recomendado utilizar o alias

```csharp
  int idade = 20; // Alias
  Int32 idade = 20; // Tipo

  string texto = "oi"; // Alias
  String texto = "oi"; // Tipo
```

### Valores padrões

Todos os tipos built-in possuem valor padrão.

- int = 0
- float = 0
- decimal = 0
- bool = false
- char = '\0'
- String = ""

### Conversão Implícita

- Pra transformar dados de uma variável X para Y
  - Converter um float pra um número inteiro ou vice-versa
- São conversões que podem ser executadas apenas com passagem de dados e tem que possuír `tipos compatíveis`
- Só ocorre se os tipos de dado forem compatíveis, senão dá erro

```csharp
float valor = 25.8F;
int outro = 25;

valor = outro; // conversão implícita;
// sabemos que 25 é 25.0
```

### Conversão Explícita

- Tem que obrigatóriamente informar o tipo que estamos convertendo
- Quando os tipos não são compatíveis
- Se puder evitar, melhor

```csharp
int inteiro = 100;
uint inteiroSemSinal = (uint)inteiro; // Conversão explícita
```

### Parse

- Formas que  temos de converter um tipo para outro
- Ex: converter uma string pra outro tipo qualquer
- Se houver imcompatibilidade, gera um erro

```csharp
int inteiro = int.Parse("100"); // tentando converter string pra número
```

### Convert

- Similar ao `Parse`
- Objeto que permite que convertamos vários tipos de valor, não apenas string
- Tenta converter, se não conseguir é gerado um erro

```csharp
int inteiro = Convert.ToInt32("100");
```

### Convertendo tipos

```csharp
  int inteiro = 100;
  float real = 25.5f;

  real = inteiro; // conversão implícita
  inteiro = (int)real; // conversão explícita
```

### Operações aritméticas

- soma -> +
- subtração -> -
- multiplicação -> *
- divisão -> /
- Aceitam `short, int, float, double e decimal`
- Mesma regra da matemática **(executar multiplicação / divisão primeiro)**
  - utilizar parênteses se quiser utilizar uma ordem específica

```csharp
int soma = 25 + 22; // 47
int subtracao = 25 - 22; // 3
int divisao = 25 / 5; // 4 - foi arredondado
int multiplicacao = 25 * 22 // 550
```

### Operações de atribuição

- utilizar `=` para realizar a atribuição de um valor
- há como simplificar incrementos, decrementos ets, na atribuição;

```csharp
  int x = 0; // Atribuição
  x += 5; // x = x + 5
  x -= 5; // x = x - 5
  x *= 5; // x = x * 5
  x /= 2 // x = x / 2
```

### Operações de Comparação

- Compara qualquer tipo de dado
  - Números, strings, bytes
- Definições:
  - igual -> `==`
  - diferente -> `!=`
  - maior que -> `>`
  - menor que -> `<`
  - maior ou igual -> `>=`
  - menor ou igual -> `<=`

### Utilizando Operadores

- Operadores Aritméticos

  ```csharp
    int x = 2;
    x = 2 / 2; // 1
    x = 2 + 2 * 2; // 6
    x = 2 + (2 * 2); // 6
    x = (2 + 2) * 2; // 8
  ```

- Operadores de atribuição

  ```csharp
  int x = 2;

  x += 1; // 3
  x = 2;

  x *=2 // 4
  x = 2;

  x -=2 // 0
  ```

- Operadores de comparação

  ```csharp
  int x = 2;

  Console.WriteLine(x == 25); // false
  Console.WriteLine(x != 25); // true
  Console.WriteLine(x > 25); // false
  Console.WriteLine(x < 25); // true
  Console.WriteLine(x >= 2); // true
  Console.WriteLine(x <= 2); // true
  ```

### Operadores Lógicos

- Para operações condicionais
- Retornam sempre um **verdadeiro** ou **falso**
- Se atender uma condição, retorna **verdadeiro**
- Operadores:
  - E - AND
    - Todas condições **tem** que ser verdadeiras para retornar **verdadeiro**
  - OU - OR
    - Se atendar ao menos uma condição, retorna **verdadeiro**
  - Negação - NOT
    - !

```csharp
int x = 12;
bool entre = (x > 25) && (x < 40); // False
bool ou = (x > 25) || (x < 40); // True
bool negacao = !(x < 25); // False
```

### Estrutura Condicional: If

- Se uma condição for atendida, faça algo.
- Composto também por `else` (senão) ou `else if(condição)`

```csharp
if (condicao) { // se for verdadeiro...
  // faça algo
}

if (condicao)
  // faça algo se for só uma linha
else
  // algo se for só uma linha

if (condicao) {
  // faça algo
} else if (outraCondicao) {
  // faça algo
}
```
