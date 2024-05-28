namespace B3.AvaliacaoDev.WebAPI
{
  /// <summary>
  /// Uma classe para efetuar todos os retornos padrão dos métodos das Controllers.
  /// </summary>
  public class ResponseBase
  {
    /// <summary>
    /// Um campo que indica verdadeiro se a execução do método foi completada com sucesso ou falso caso contrário.
    /// </summary>
    public bool Sucesso { get; set; }

    /// <summary>
    /// Uma mensagem de texto quando é necessário fornecer mais informações para o cliente.
    /// </summary>
    public string? Mensagem { get; set; }
  }

  /// <summary>
  /// Uma classe para efetuar todos os retornos padrão dos métodos das Controllers. Esta classe herda da ResponseBase porém contem uma própriedade com dados genéricos para serem retornados para o cliente.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class ResponseBase<T> : ResponseBase
  {
    /// <summary>
    /// Os dados genéricos que podem ser retornados para o cliente.
    /// </summary>
    public T? Dados { get; set; }
  }
}