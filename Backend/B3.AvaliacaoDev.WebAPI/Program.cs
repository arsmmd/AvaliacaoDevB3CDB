using B3.AvaliacaoDev.Domain.Interfaces;
using B3.AvaliacaoDev.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace B3.AvaliacaoDev.WebAPI
{
  /// <summary>
  /// Ponto principal de execução da aplicação
  /// </summary>
  public static class Program
  {
    /// <summary>
    /// Ponto principal de execução da aplicação
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public static async Task Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddScoped<ICdbCalculatorService, CdbCalculatorService>();

      builder.Services.AddCors(o => o.AddPolicy("CORSPolicy", b => b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowedToAllowWildcardSubdomains().SetPreflightMaxAge(System.TimeSpan.FromDays(1))));

      builder.Services.AddControllers();
      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();

      WebApplication app = builder.Build();

      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseHttpsRedirection();
      app.UseCors("CORSPolicy");

      app.UseAuthorization();

      app.MapControllers();

      await app.RunAsync();
    }
  }
}