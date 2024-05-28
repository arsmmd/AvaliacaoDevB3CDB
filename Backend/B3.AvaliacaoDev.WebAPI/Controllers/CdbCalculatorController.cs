using B3.AvaliacaoDev.Domain;
using B3.AvaliacaoDev.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace B3.AvaliacaoDev.WebAPI.Controllers
{
  /// <summary>
  /// Controller contendo um m�todo para efetuar os c�lculos dos CDB e retornar os resultados.
  /// </summary>
  /// <remarks>
  /// Construtor do Controller.
  /// </remarks>
  /// <param name="logger"></param>
  /// <param name="cdbCalculatorService">Servi�o para c�lculo do CDB injetado como dep�ncia.</param>
  [AllowAnonymous]
  [ApiController]
  [Route("[controller]")]
  public class CdbCalculatorController(ICdbCalculatorService cdbCalculatorService) : ControllerBase
  {
    private readonly ICdbCalculatorService _cdbCalculatorService = cdbCalculatorService;

    /// <summary>
    /// M�todo para efetuar os c�lculos dos CDB e retornar os resultados com base nos par�metros.
    /// </summary>
    /// <param name="valorInvestimento">Valor inicial do investimento.</param>
    /// <param name="quantidadeMeses">Prazo em meses.</param>
    /// <returns>Uma classe de resposta contendo os resultados dos c�lculos ou erros de valida��o.</returns>
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