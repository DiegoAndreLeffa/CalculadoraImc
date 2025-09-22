// tests/CalculadoraImc.Core.Tests/CoreTests.cs
using CalculadoraImc.Core;

namespace CalculadoraImc.Core.Tests
{
    public class CoreTests
    {
        // O [Fact] indica que este é um método de teste simples.
        [Fact]
        public void Calcular_ComValoresValidos_RetornaImcCorreto()
        {
            // Arrange (Organização): Preparamos os dados do teste.
            double peso = 80;
            double altura = 1.80;
            double imcEsperado = 24.69;

            // Act (Ação): Executamos o método que queremos testar.
            double imcCalculado = Calculadora.Calcular(peso, altura);

            // Assert (Verificação): Verificamos se o resultado foi o esperado.
            Assert.Equal(imcEsperado, imcCalculado);
        }

        // O [Theory] permite testar o mesmo método com diferentes conjuntos de dados.
        [Theory]
        [InlineData(18.4, "Abaixo do peso")]
        [InlineData(24.9, "Peso normal")]
        [InlineData(29.9, "Sobrepeso")]
        [InlineData(39.9, "Obesidade Grau II")]
        [InlineData(45.0, "Obesidade Grau III")]
        public void ObterClassificacao_ComValoresDiferentes_RetornaClassificacaoCorreta(double imc, string classificacaoEsperada)
        {
            // Arrange & Act
            var resultado = Classificacao.ObterClassificacao(imc);

            // Assert
            Assert.Equal(classificacaoEsperada, resultado);
        }
    }
}