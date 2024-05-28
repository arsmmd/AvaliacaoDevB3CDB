import { Component, ChangeDetectorRef } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
  public valorInvestimento: number | undefined;
  public quantidadeMeses: number | undefined;

  public ResultadoBruto: number | undefined = 0.0;
  public ResultadoLiquido: number | undefined = 0.0;
  public Mensagem: string | undefined = '';

  constructor(private http: HttpClient, private cdRef: ChangeDetectorRef) { }

  validarCampos(): boolean {
    return this.valorInvestimento === undefined || this.valorInvestimento === null || this.valorInvestimento === 0 ||
      this.quantidadeMeses === undefined || this.quantidadeMeses === null || this.quantidadeMeses <= 1;
  }

  enviarRequisicao() {
    const headers = new HttpHeaders().set('Content-Type', 'application/json');

    this.http.get(`http://localhost:5032/CdbCalculator?valorInvestimento=${this.valorInvestimento}&quantidadeMeses=${this.quantidadeMeses}`, { headers }).subscribe(
      (data: any) => {
        this.ResultadoBruto = data.dados.resultadoBruto;
        this.ResultadoLiquido = data.dados.resultadoLiquido;
        this.Mensagem = data.mensagem;
        this.cdRef.detectChanges();
      },

      (error: any) => {
        this.Mensagem = error.error.mensagem;
        console.error('Erro:', error);
      }
    );
  }
}