using B3.AvaliacaoDev.Domain;
using B3.AvaliacaoDev.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace B3.AvaliacaoDev.WebAPI.Controllers
{
  /// <summary>
  /// Controller contendo um método para efetuar os cálculos dos CDB e retornar os resultados.
  /// </summary>
  /// <remarks>
  /// Construtor do Controller.
  /// </remarks>
  /// <param name="logger"></param>
  /// <param name="cdbCalculatorService">Serviço para cálculo do CDB injetado como depência.</param>
  [AllowAnonymous]
  [ApiController]
  [Route("[controller]")]
  public class CdbCalculatorController(ICdbCalculatorService cdbCalculatorService) : ControllerBase
  {
    private readonly ICdbCalculatorService _cdbCalculatorService = cdbCalculatorService;

    /// <summary>
    /// Método para efetuar os cálculos dos CDB e retornar os resultados com base nos parâmetros.
    /// </summary>
    /// <param name="valorInvestimento">Valor inicial do investimento.</param>
    /// <param name="quantidadeMeses">Prazo em meses.</param>
    /// <returns>Uma classe de resposta contendo os resultados dos cálculos ou erros de validação.</returns>
    [HttpGet]
    public IActionResult Get([FromQuery] decimal valorInvestimento, [FromQuery] short quantidadeMeses)
    {
      try
      {
        ResultadosCdb resultadosCdb = this._cdbCalculatorService.CalcularCDB(valorInvestimento, quantidadeMeses);
        return base.Ok(new ResponseBase<ResultadosCdb>() { Sucesso = true, Dados = resultadosCdb });
      }
      catch (ArgumentException ex)
      {
        return base.BadRequest(new ResponseBase() { Sucesso = false, Mensagem = ex.Message });
      }
      catch
      {
        return base.NoContent();
      }
    }
  }
}