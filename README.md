# Calculadora de IMC em C#

Calculadora de Índice de Massa Corporal (IMC) em C# com foco em boas práticas, SOLID e testes unitários.

## ✨ Funcionalidades

- Calcula o IMC com base no peso (kg) e altura (m).
- Exibe a classificação do IMC (Abaixo do peso, Peso normal, etc.).

## 🚀 Como Executar

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) ou superior.

### Passo a Passo

1. **Clone o repositório:**

2. **Execute a aplicação:**

    ```bash
    dotnet run --project src/CalculadoraImc.App/CalculadoraImc.App.csproj
    ```

## ✅ Executando os Testes

Para verificar a integridade da lógica de negócio, execute os testes unitários com o comando:

```bash
dotnet test
```

## 🏛️ Arquitetura

O projeto foi estruturado seguindo o Princípio da Responsabilidade Única (SRP):

- **`CalculadoraImc.Core`**: Uma biblioteca de classes que contém toda a lógica de negócio.
  - `Calculadora.cs`: Responsável apenas pelo cálculo matemático do IMC.
  - `Classificacao.cs`: Responsável apenas por determinar a classificação com base no resultado do IMC.
- **`CalculadoraImc.App`**: Uma aplicação de console responsável apenas pela interação com o usuário (entrada e saída de dados).
- **`CalculadoraImc.Core.Tests`**: Projeto de testes unitários (xUnit) que valida o comportamento do `CalculadoraImc.Core`.
