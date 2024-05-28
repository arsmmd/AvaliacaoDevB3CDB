# Avalia��o desenvolvedor - C�lculo CDB

Composi��o da solu��o:

<b>Backend</b>: ASP.NET Core com C# .NET 8.0
<b>Frontend</b>: Angular com TypeScript. Angular CLI vers�o 18.0.1 (https://github.com/angular/angular-cli)


## Procedimentos para instala��o do Backend

1. Clone o reposit�rio:

   <b> git clone https://github.com/arsmmd/AvaliacaoDevB3CDB.git </b>

2. Navegue at� o diret�rio clonado e execute:
<b> dotnet build -c 'Release'</b>

Exemplo de sa�da do console:
MSBuild version 17.8.3+195e7f5a3 for .NET
&nbsp;&nbsp;Determining projects to restore...
&nbsp;&nbsp;All projects are up-to-date for restore.
&nbsp;&nbsp;B3.AvaliacaoDev.Domain -> D:\Projetos\AvaliacaoDevB3CDB\Backend\B3.AvaliacaoDev.Domain\bin\Release\net8.0\B3.AvaliacaoDev.Domain.dll
&nbsp;&nbsp;B3.AvaliacaoDev.UnitTesting -> D:\Projetos\AvaliacaoDevB3CDB\Backend\B3.AvaliacaoDev.UnitTesting\bin\Release\net8.0\B3.AvaliacaoDev.UnitTesting.dll
&nbsp;&nbsp;B3.AvaliacaoDev.WebAPI -> D:\Projetos\AvaliacaoDevB3CDB\Backend\B3.AvaliacaoDev.WebAPI\bin\Release\net8.0\B3.AvaliacaoDev.WebAPI.dll

Build succeeded.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>0 Warning(s)</b>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>0 Error(s)</b>

Time Elapsed 00:00:02.17


## Executando a aplica��o

1. Navegue at� o diret�rio da constru��o:  
<b>cd .\Backend\B3.AvaliacaoDev.WebAPI\ </b>

2. Execute:
<b> dotnet run </b> 

A WebAPI estar� sendo executada e pode ser acessada em <b>http://localhost:5032/swagger/index.html</b>


## Procedimentos para instala��o do Frontend
