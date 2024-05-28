# Avaliação desenvolvedor - Cálculo CDB

Composição da solução:<br />

<b>Backend</b>: ASP.NET com .NET 8.0 e C#<br />
<b>Frontend</b>: Angular com TypeScript. Angular CLI versão 18.0.1 (https://github.com/angular/angular-cli)<br />


## Procedimentos para instalação

1. Clone o repositório:<br />
  <b>git clone https://github.com/arsmmd/AvaliacaoDevB3CDB.git</b><br />


## Procedimentos para instalação do Back-end

1. Navegue até a raiz do diretório clonado:<br />
  <b>cd .\AvaliacaoDevB3CDB\ </b><br />

2. Execute:<br />
  <b>dotnet build -c 'Release' </b><br />


## Executando a aplicação

1. Navegue até o diretório da construção:<br />
<b>cd .\Backend\B3.AvaliacaoDev.WebAPI\ </b><br />

2. Execute:<br />
<b>dotnet run </b><br />

A WebAPI estará sendo executada e pode ser acessada em <b>http://localhost:5032/swagger/index.html</b><br />


## Procedimentos para instalação do Front-end

1. Navegue até o diretório do Front-end no diretório clonado:<br />
  <b>cd .\AvaliacaoDevB3CDB\Frontend\B3.AvaliacaoDev.Client\ </b><br />

2. Execute:<br />
<b>npm install </b><br />

3. Execute:<br />
<b>ng serve </b><br />

A aplicação cliente estará sendo executada e pode ser acessada em <b>http://localhost:4200</b><br />


## Procedimentos para execução dos testes do Backend (Camada Domain)

1. Navegue até o diretório do projeto de testes no diretório clonado:<br />
  <b>cd .\AvaliacaoDevB3CDB\Backend\B3.AvaliacaoDev.UnitTesting\ </b><br />

2. Execute:<br />
  <b>dotnet build -c 'Release' </b><br />

3. Execute:<br />
<b>dotnet test </b><br />