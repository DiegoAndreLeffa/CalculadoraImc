namespace CalculadoraImc.Core
{
    /// <summary>
    /// Classe responsável unicamente pelo cálculo do IMC.
    /// </summary>
    public static class Calculadora
    {
        /// <summary>
        /// Realiza o cálculo do IMC (Peso / Altura²).
        /// </summary>
        /// <param name="peso">Peso em quilogramas (kg).</param>
        /// <param name="altura">Altura em metros (m).</param>
        /// <returns>O valor do IMC com duas casas decimais.</returns>
        public static double Calcular(double peso, double altura)
        {
            if (altura <= 0)
            {
                // É uma boa prática lançar uma exceção para entradas inválidas,
                // pois a altura não pode ser zero ou negativa no cálculo.
                throw new ArgumentException("A altura deve ser um valor positivo.", nameof(altura));
            }

            // A fórmula do IMC é peso dividido pela altura ao quadrado.
            double imc = peso / (altura * altura);

            // Arredonda o resultado para duas casas decimais para melhor leitura.
            return Math.Round(imc, 2);
        }
    }
}