using B3.AvaliacaoDev.Domain.Interfaces;
using System;

namespace B3.AvaliacaoDev.Domain.Services
{
  /// <summary>
  /// Implementa os métodos necessários para o cálculo do CDB.
  /// </summary>
  public class CdbCalculatorService : ICdbCalculatorService
  {
    /// <summary>
    /// Calcula os valores brutos e líquidos do investimento com base no valor e prazo.
    /// </summary>
    /// <param name="valorInvestimento">Valor inicial do investimento.</param>
    /// <param name="quantidadeMeses">Prazo em meses.</param>
    /// <returns>Uma classe contendo as resultados dos cálculos do CDB.</returns>
    /// <exception cref="ArgumentException"></exception>
    public ResultadosCdb CalcularCDB(decimal valorInvestimento, short quantidadeMeses)
    {
      if (valorInvestimento <= 0)
        throw new ArgumentException("O valor do investimento deve ser maior que 0.", nameof(valorInvestimento));

      if (quantidadeMeses <= 1)
        throw new ArgumentException("A quantidade de meses deve ser maior que 1.", nameof(quantidadeMeses));


      const decimal TB = 108M / 100M;
      const decimal CDI = 0.9M / 100M;

      decimal resultadoBruto = valorInvestimento;
      for (int i = 0; i < quantidadeMeses; i++)
        resultadoBruto *= (1.0M + (CDI * TB));

      decimal lucro = resultadoBruto - valorInvestimento;
      decimal valorImpostos = this.CalcularImpostos(lucro, quantidadeMeses);
      decimal resultadoLiquido = valorInvestimento + (lucro - valorImpostos);

      ResultadosCdb resultadosCdb = new()
      {
        ResultadoBruto = Math.Round(resultadoBruto, 2),
        ResultadoLiquido = Math.Round(resultadoLiquido, 2)
      };

      return resultadosCdb;
    }

    /// <summary>
    /// Calcula o valor dos impostos com base no lucro e na quantidade de meses do investimento.
    /// </summary>
    /// <param name="lucro">Lucro obtido dentro do prazo.</param>
    /// <param name="quantidadeMeses">Prazo em meses.</param>
    /// <returns>o valor dos impostos aplicados sobre o lucro.</returns>
    /// <exception cref="ArgumentException"></exception>
    public decimal CalcularImpostos(decimal lucro, short quantidadeMeses)
    {
      if (lucro <= 0)
        throw new ArgumentException("O lucro deve ser maior que 0.", nameof(lucro));

      if (quantidadeMeses <= 1)
        throw new ArgumentException("A quantidade de meses deve ser maior que 1.", nameof(quantidadeMeses));

      /*
       Regras para cálculo dos impostos:
        -      Até 06 meses: 22,5%
        -      Até 12 meses: 20%
        -      Até 24 meses 17,5%
        - Acima de 24 meses 15%
       */

      decimal percentualImposto = 15.0M;
      if (quantidadeMeses <= 6)
        percentualImposto = 22.5M;
      else if (quantidadeMeses <= 12)
        percentualImposto = 20.0M;
      else if (quantidadeMeses <= 24)
        percentualImposto = 17.5M;

      decimal valorImpostos = lucro * (percentualImposto / 100.0M);
      return valorImpostos;
    }
  }
}
