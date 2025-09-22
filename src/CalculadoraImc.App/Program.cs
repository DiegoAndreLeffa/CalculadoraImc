using CalculadoraImc.Core;

// Define um bloco try-catch para tratar possíveis erros de digitação do usuário.
try
{
    Console.WriteLine("--- Calculadora de IMC ---");

    Console.Write("Digite seu peso em kg (ex: 75,5): ");
    // Lê a entrada do usuário e a converte para o tipo double.
    double peso = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite sua altura em metros (ex: 1,80): ");
    double altura = Convert.ToDouble(Console.ReadLine());

    // Chama o método estático da nossa classe de lógica para calcular o IMC.
    double imc = Calculadora.Calcular(peso, altura);

    // Chama o método para obter a classificação correspondente.
    string classificacao = Classificacao.ObterClassificacao(imc);

    // Exibe os resultados formatados para o usuário.
    Console.WriteLine($"\nSeu IMC é: {imc}");
    Console.WriteLine($"Classificação: {classificacao}");
}
catch (FormatException)
{
    // Este bloco é executado se o usuário digitar um texto em vez de um número.
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nErro: Peso e altura devem ser valores numéricos.");
    Console.ResetColor();
}
catch (ArgumentException ex)
{
    // Este bloco captura a exceção específica que criamos para altura inválida.
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\nErro de validação: {ex.Message}");
    Console.ResetColor();
}
catch (Exception ex)
{
    // Este bloco captura qualquer outro erro inesperado.
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\nAconteceu um erro inesperado: {ex.Message}");
    Console.ResetColor();
}
