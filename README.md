# Fundamentos do CSharp

- [Fundamentos do CSharp](#fundamentos-do-csharp)
  - [.NET](#net)
    - [Como criar aplicativo console via dotnet CLI](#como-criar-aplicativo-console-via-dotnet-cli)
    - [Comandos principais do dotnet](#comandos-principais-do-dotnet)
    - [Variáveis de ambiente](#variáveis-de-ambiente)
    - [Estrutura do App](#estrutura-do-app)

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
