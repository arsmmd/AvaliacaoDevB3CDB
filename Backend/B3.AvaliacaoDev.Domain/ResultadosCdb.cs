namespace B3.AvaliacaoDev.Domain
{
  /// <summary>
  /// Contém as resultados dos cálculos do CDB.
  /// </summary>
  public class ResultadosCdb
  {
    /// <summary>
    /// Resultado bruto do cálculo do CDB.
    /// </summary>
    public decimal ResultadoBruto { get; set; }

    /// <summary>
    /// Resultado líquido do cálculo do CDB.
    /// </summary>
    public decimal ResultadoLiquido { get; set; }
  }
}