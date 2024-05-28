# Avalia��o desenvolvedor - C�lculo CDB

Composi��o da solu��o:<br />

<b>Backend</b>: ASP.NET com .NET 8.0 e C#<br />
<b>Frontend</b>: Angular com TypeScript. Angular CLI vers�o 18.0.1 (https://github.com/angular/angular-cli)<br />


## Procedimentos para instala��o do Backend

1. Clone o reposit�rio:<br />
  <b>git clone https://github.com/arsmmd/AvaliacaoDevB3CDB.git</b><br />

2. Navegue at� o diret�rio clonado:<br />
  <b>cd .\AvaliacaoDevB3CDB\ </b><br />

3. Execute:<br />
  <b>dotnet build -c 'Release' </b><br />

Exemplo de sa�da do console:<br />
MSBuild version 17.8.3+195e7f5a3 for .NET<br />
&nbsp;&nbsp;Determining projects to restore...<br />
&nbsp;&nbsp;All projects are up-to-date for restore.<br />
&nbsp;&nbsp;B3.AvaliacaoDev.Domain -> D:\Projetos\AvaliacaoDevB3CDB\Backend\B3.AvaliacaoDev.Domain\bin\Release\net8.0\B3.AvaliacaoDev.Domain.dll<br />
&nbsp;&nbsp;B3.AvaliacaoDev.UnitTesting -> D:\Projetos\AvaliacaoDevB3CDB\Backend\B3.AvaliacaoDev.UnitTesting\bin\Release\net8.0\B3.AvaliacaoDev.UnitTesting.dll<br />
&nbsp;&nbsp;B3.AvaliacaoDev.WebAPI -> D:\Projetos\AvaliacaoDevB3CDB\Backend\B3.AvaliacaoDev.WebAPI\bin\Release\net8.0\B3.AvaliacaoDev.WebAPI.dll<br />

Build succeeded.<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>0 Warning(s)</b><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>0 Error(s)</b><br />

Time Elapsed 00:00:02.17<br />


## Executando a aplica��o

1. Navegue at� o diret�rio da constru��o:<br />
<b>cd .\Backend\B3.AvaliacaoDev.WebAPI\ </b><br />

2. Execute:<br />
<b> dotnet run </b><br />

A WebAPI estar� sendo executada e pode ser acessada em <b>http://localhost:5032/swagger/index.html</b><br />


## Procedimentos para instala��o do Frontend
