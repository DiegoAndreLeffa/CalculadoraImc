namespace CalculadoraImc.Core
{
    /// <summary>
    /// Classe responsável unicamente por fornecer a classificação do IMC.
    /// </summary>
    public static class Classificacao
    {
        /// <summary>
        /// Retorna a descrição da classificação com base no valor do IMC.
        /// </summary>
        /// <param name="imc">O valor do IMC calculado.</param>
        /// <returns>A string contendo a classificação.</returns>
        public static string ObterClassificacao(double imc)
        {
            if (imc < 18.5) return "Abaixo do peso";
            if (imc < 25) return "Peso normal";
            if (imc < 30) return "Sobrepeso";
            if (imc < 35) return "Obesidade Grau I";
            if (imc < 40) return "Obesidade Grau II";
            return "Obesidade Grau III";
        }
    }
}