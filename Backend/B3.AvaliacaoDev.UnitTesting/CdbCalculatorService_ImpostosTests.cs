using B3.AvaliacaoDev.Domain.Interfaces;
using B3.AvaliacaoDev.Domain.Services;
using System;

namespace B3.AvaliacaoDev.UnitTesting
{
  public class CdbCalculatorService_ImpostosTests
  {
    private readonly CdbCalculatorService cdbCalculatorService = new();

    /// <summary>
    /// Testa o cálculo dos impostos com quantidade de meses negativa
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos_ValidacaoEntradaNegativa_QtdMeses()
    {
      Assert.Throws<ArgumentException>(() => cdbCalculatorService.CalcularImpostos(1000.0M, -1));
    }

    /// <summary>
    /// Testa o cálculo dos impostos com lucro negativo
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos_ValidacaoEntradaNegativa_Lucro()
    {
      Assert.Throws<ArgumentException>(() => cdbCalculatorService.CalcularImpostos(-1000.0M, 12));
    }

    /// <summary>
    /// Testa o cálculo dos impostos com quantidade de meses inválida
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos_ValidacaoQuantidadeMeses()
    {
      Assert.Throws<ArgumentException>(() => cdbCalculatorService.CalcularImpostos(1000.0M, 0));
    }

    /// <summary>
    /// Testa o cálculo dos impostos com lucro inválido
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos_ValidacaoLucro()
    {
      Assert.Throws<ArgumentException>(() => cdbCalculatorService.CalcularImpostos(0.0M, 12));
    }

    /// <summary>
    /// Testa o cálculo dos impostos com um valor esperado
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos()
    {
      decimal resultado = cdbCalculatorService.CalcularImpostos(1000.0M, 6);
      decimal impostoEsperado = 225.0M; // Valor esperado para 6 meses e 1000 de lucro
      Assert.Equal(resultado, impostoEsperado, 1);
    }

    /// <summary>
    /// Testa o cálculo dos impostos com lucro inválido
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos_TaxaImpostoCorreta()
    {
      decimal resultado = cdbCalculatorService.CalcularImpostos(1000.0M, 3);
      decimal impostoEsperado = 1000.0M * 0.225M; // Imposto de 22.5% para 3 meses
      Assert.Equal(resultado, impostoEsperado, 1);
    }

    /// <summary>
    /// Testa o cálculo dos impostos com lucro positivo
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos_ValorInvestimentoPositivo()
    {
      decimal resultado = cdbCalculatorService.CalcularImpostos(1000.0M, 12);
      Assert.True(resultado >= 0);
    }

    /// <summary>
    /// Testa o cálculo dos impostos com quantidade de meses menor que 2
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos_QuantidadeMesesMenorQueDois()
    {
      Assert.Throws<ArgumentException>(() => cdbCalculatorService.CalcularImpostos(1000.0M, 1));
    }

    /// <summary>
    /// Testa o cálculo dos impostos com quantidade de 6 meses
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos_PrazoSeisMeses()
    {
      decimal resultado = cdbCalculatorService.CalcularImpostos(1000.0M, 6);
      decimal impostoEsperado = 1000.0M * 0.225M; // Imposto de 22.5%
      Assert.Equal(resultado, impostoEsperado, 1);
    }

    /// <summary>
    /// Testa o cálculo dos impostos com quantidade de 12 meses
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos_PrazoDozeMeses()
    {
      decimal resultado = cdbCalculatorService.CalcularImpostos(1000.0M, 12);
      decimal impostoEsperado = 1000.0M * 0.20M; // Imposto de 20.0%
      Assert.Equal(resultado, impostoEsperado, 1);
    }

    /// <summary>
    /// Testa o cálculo dos impostos com quantidade de 24 meses
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos_PrazoVinteQuatroMeses()
    {
      decimal resultado = cdbCalculatorService.CalcularImpostos(1000.0M, 24);
      decimal impostoEsperado = 1000.0M * 0.175M; // Imposto de 17.5%
      Assert.Equal(resultado, impostoEsperado, 1);
    }

    /// <summary>
    /// Testa o cálculo dos impostos com quantidade de 36 meses
    /// </summary>
    [Fact]
    public void Test_CalcularImpostos_TaxaAcimaVinteQuatroMeses()
    {
      decimal resultado = cdbCalculatorService.CalcularImpostos(1000.0M, 36);
      decimal impostoEsperado = 1000.0M * 0.15M; // Imposto de 15.0%
      Assert.Equal(resultado, impostoEsperado, 1);
    }
  }
}