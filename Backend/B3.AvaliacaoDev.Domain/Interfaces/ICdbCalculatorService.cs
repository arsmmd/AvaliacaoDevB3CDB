namespace B3.AvaliacaoDev.Domain.Interfaces
{
  /// <summary>
  /// Define o contrato para o auxiliar a implementação dos métodos de cálculo do CDB.
  /// </summary>
  public interface ICdbCalculatorService
  {
    /// <summary>
    /// Calcula os valores brutos e líquidos do investimento com base no valor e prazo.
    /// </summary>
    /// <param name="valorInvestimento">Valor inicial do investimento.</param>
    /// <param name="quantidadeMeses">Prazo em meses.</param>
    /// <returns>Uma classe contendo os resultados dos cálculos.</returns>
    ResultadosCdb CalcularCDB(decimal valorInvestimento, short quantidadeMeses);

    /// <summary>
    /// Calcula o valor dos impostos com base no lucro e na quantidade de meses do investimento.
    /// </summary>
    /// <param name="lucro">Lucro obtido dentro do prazo.</param>
    /// <param name="quantidadeMeses">Prazo em meses.</param>
    /// <returns>o valor dos impostos aplicados sobre o lucro.</returns>
    decimal CalcularImpostos(decimal lucro, short quantidadeMeses);
  }
}