using B3.AvaliacaoDev.Domain;
using B3.AvaliacaoDev.Domain.Interfaces;
using B3.AvaliacaoDev.Domain.Services;
using System;

namespace B3.AvaliacaoDev.UnitTesting
{
  public class CdbCalculatorService_CdbTests
  {
    private readonly CdbCalculatorService cdbCalculatorService = new();

    /// <summary>
    /// Testa o cálculo do CDB com resultados válidos
    /// </summary>
    [Fact]
    public void Test_CalcularCDB_ResultadosValidos()
    {
      decimal valorInvestimento = 1000.0M;
      short quantidadeMeses = 12;

      ResultadosCdb resultado = cdbCalculatorService.CalcularCDB(valorInvestimento, quantidadeMeses);

      Assert.NotNull(resultado);
      Assert.True(resultado.ResultadoBruto > valorInvestimento);
      Assert.True(resultado.ResultadoLiquido > valorInvestimento);
    }

    /// <summary>
    /// Testa o cálculo do CDB com resultados diferentes para valores de investimentos
    /// </summary>
    [Fact]
    public void Test_CalcularCDB_ResultadosDiferentesParaDiferentesValoresInvestimentos()
    {
      decimal valorInvestimento1 = 1000.0M;
      decimal valorInvestimento2 = 1500.0M;
      short quantidadeMeses = 12;

      ResultadosCdb resultado1 = cdbCalculatorService.CalcularCDB(valorInvestimento1, quantidadeMeses);
      ResultadosCdb resultado2 = cdbCalculatorService.CalcularCDB(valorInvestimento2, quantidadeMeses);

      Assert.NotEqual(resultado1.ResultadoBruto, resultado2.ResultadoBruto);
      Assert.NotEqual(resultado1.ResultadoLiquido, resultado2.ResultadoLiquido);
    }

    /// <summary>
    /// Testa o cálculo do CDB com resultados diferentes para quantidades de meses
    /// </summary>
    [Fact]
    public void Test_CalcularCDB_ResultadosDiferentesParaDiferentesQuantidadesMeses()
    {
      decimal valorInvestimento = 1000.0M;
      short quantidadeMeses1 = 12;
      short quantidadeMeses2 = 24;

      ResultadosCdb resultado1 = cdbCalculatorService.CalcularCDB(valorInvestimento, quantidadeMeses1);
      ResultadosCdb resultado2 = cdbCalculatorService.CalcularCDB(valorInvestimento, quantidadeMeses2);

      Assert.NotEqual(resultado1.ResultadoBruto, resultado2.ResultadoBruto);
      Assert.NotEqual(resultado1.ResultadoLiquido, resultado2.ResultadoLiquido);
    }

    /// <summary>
    /// Testa o cálculo do CDB com 2 resultados diferentes para valores e meses
    /// </summary>
    [Fact]
    public void Test_CalcularCDB_ResultadosDiferentesParaEntradasDiferentes()
    {
      decimal valorInvestimento1 = 1000.0M;
      short quantidadeMeses1 = 12;
      ResultadosCdb resultado1 = cdbCalculatorService.CalcularCDB(valorInvestimento1, quantidadeMeses1);

      decimal valorInvestimento2 = 2000.0M;
      short quantidadeMeses2 = 24;
      ResultadosCdb resultado2 = cdbCalculatorService.CalcularCDB(valorInvestimento2, quantidadeMeses2);

      Assert.True(resultado1.ResultadoLiquido < resultado2.ResultadoLiquido);
      Assert.True(resultado1.ResultadoBruto < resultado2.ResultadoBruto);
    }

    /// <summary>
    /// Testa o cálculo do CDB com um valor de investimento inválido
    /// </summary>
    [Fact]
    public void Test_CalcularCDB_ValorInvestimentoInvalido()
    {
      Assert.Throws<ArgumentException>(() => cdbCalculatorService.CalcularCDB(0.0M, 12));
    }

    /// <summary>
    /// Testa o cálculo do CDB com uma quantidade de meses inválida
    /// </summary>
    [Fact]
    public void Test_CalcularCDB_QuantidadeMesesInvalida()
    {
      Assert.Throws<ArgumentException>(() => cdbCalculatorService.CalcularCDB(1000.0M, 0));
    }

    /// <summary>
    /// Testa o cálculo do CDB com o valor e prazo inválidos
    /// </summary>
    [Fact]
    public void Test_CalcularCDB_EntradasInvalidas()
    {
      Assert.Throws<ArgumentException>(() => cdbCalculatorService.CalcularCDB(0.0M, 0));
    }
  }
}