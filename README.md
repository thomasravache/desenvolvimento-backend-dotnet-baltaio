# Fundamentos do CSharp

- [Fundamentos do CSharp](#fundamentos-do-csharp)
  - [.NET](#net)
    - [Como criar aplicativo console via dotnet CLI](#como-criar-aplicativo-console-via-dotnet-cli)
    - [Comandos principais do dotnet](#comandos-principais-do-dotnet)

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
