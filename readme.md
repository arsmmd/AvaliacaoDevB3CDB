# Avalia��o desenvolvedor - C�lculo CDB

Composi��o da solu��o:<br />

<b>Backend</b>: ASP.NET com .NET 8.0 e C#<br />
<b>Frontend</b>: Angular com TypeScript. Angular CLI vers�o 18.0.1 (https://github.com/angular/angular-cli)<br />


## Procedimentos para instala��o

1. Clone o reposit�rio:<br />
  <b>git clone https://github.com/arsmmd/AvaliacaoDevB3CDB.git</b><br />


## Procedimentos para instala��o do Back-end

1. Navegue at� a raiz do diret�rio clonado:<br />
  <b>cd .\AvaliacaoDevB3CDB\ </b><br />

2. Execute:<br />
  <b>dotnet build -c 'Release' </b><br />


## Executando a aplica��o

1. Navegue at� o diret�rio da constru��o:<br />
<b>cd .\Backend\B3.AvaliacaoDev.WebAPI\ </b><br />

2. Execute:<br />
<b>dotnet run </b><br />

A WebAPI estar� sendo executada e pode ser acessada em <b>http://localhost:5032/swagger/index.html</b><br />


## Procedimentos para instala��o do Front-end

1. Navegue at� o diret�rio do Front-end no diret�rio clonado:<br />
  <b>cd .\AvaliacaoDevB3CDB\Frontend\B3.AvaliacaoDev.Client\ </b><br />

2. Execute:<br />
<b>npm install </b><br />

3. Execute:<br />
<b>ng serve </b><br />

A aplica��o cliente estar� sendo executada e pode ser acessada em <b>http://localhost:4200</b><br />


## Procedimentos para execu��o dos testes do Backend (Camada Domain)

1. Navegue at� o diret�rio do projeto de testes no diret�rio clonado:<br />
  <b>cd .\AvaliacaoDevB3CDB\Backend\B3.AvaliacaoDev.UnitTesting\ </b><br />

2. Execute:<br />
  <b>dotnet build -c 'Release' </b><br />

3. Execute:<br />
<b>dotnet test </b><br />