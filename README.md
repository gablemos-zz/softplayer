
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
![Build and deploy ASP.Net Core app to Azure Web App - softplayer](https://github.com/gablemos/softplayer/workflows/Build%20and%20deploy%20ASP.Net%20Core%20app%20to%20Azure%20Web%20App%20-%20softplayer/badge.svg)

<br />
<p align="center">
  <a href="https://www.softplan.com.br">
    <img src="images/logo.jpg" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Desafio Técnino .NET</h3>

  <p align="center">
    Repositório para o desafio do processo seletivo da Sofplan
    <br />
    <a href="https://github.com/gablemos/softplayer"><strong>Explore o doc »</strong></a>
    <br />
    <br />
    <a href="https://softplayer.azurewebsites.net/swagger/index.html">View Demo</a>
    ·
    <a href="https://github.com/gablemos/softplayer/issues">Report Bug</a>
    ·
    <a href="https://github.com/gablemos/softplayer/issues">Request Feature</a>
  </p>
</p>


## Table of Contents

* [Sobre o Projeto](#sobre-o-projeto)
  * [Técnologias](#técnologias)
* [Começando](#começando)
  * [Requisitos](#requisitos)
  * [Instalações](#instalações)
  * [Atenção](#atenção)
* [Licença](#licença)
* [Contato](#contato)


## Sobre o Projeto

[![Product Name Screen Shot][product-screenshot]](https://softplayer.azurewebsites.net/swagger/index.html)

Descrição das escolhas tomadas:

Todas estas decisões foram tomadas de forma deliberada como escolha para que outra implementação pudesse ser feita, testes, deploy, configuração de pipeline.

Outra decisão que tomei foi a de não separar em duas aplicações para o deploy de demonstração que preparei, mas no repositorio é possível ver o segundo serviço funcionando de forma integrada entre si. Novamente, decisão para que os custos de publicação do meu teste para vocês fosse um pouco menor e eu pudesse entregar algo além do que foi solicitado e demonstrar um pouco mais do que sei, espero que levem em consideração.

Gostaria de pontuar que deixei os arquivos de docker nos projeto e infelizmente não tive tempo de fazer um um compose para levantar as duas aplicações de forma mais simples.

Também tentei fazer o máximo de commits para que pudessem ver a forma como desenvolvo, apesar de não ter o hábito de seguir TDD a risca, é na fase de criação de testes onde vem a grande parte do refactor e melhoria do meu código, em minha opinião. Espero que tenha conseguido ter registrado isso através da timeline dos commits, um pouco de arquitetura e design.

Update: Tive problemas no deploy por terem 2 projetos web e tive que excluir o projetos de softplayerApi2, vou deixar as instruções abaixo (readicionar o csproj a solution para voltar a ter dois serviços de api, sinto muito e este não é o nível de trabalho que costumo entregar espero que possam perdoar esta falha)

Update: Para finalizar atualizei a pipeline para executar os testes antes de publicar.

Nas actions do Github poderão ver o deploy e para acessar a aplicação no azure: 

https://softplayer.azurewebsites.net/swagger/index.html


### Técnologias

* .NET Core 3.1
* RestSharp
* XUnit + FluentAssert
* Docker
* Azure App Services
* Github Actions (CI/CD)

## Começando

Pode acessar a aplicação por: https://softplayer.azurewebsites.net/swagger/index.html

Ou siga os passos a seguintes (alguns passos podem mudar caso utilize visual studio, a maioria dos passo a seguir é pensando no VS Code).

### Requisitos

.NET 3.1 (última versão LTS).
* Download
```C#
https://dotnet.microsoft.com/download
```

### Instalações
 
1. Clone o repo
```sh
git clone https://github.com/gablemos/softplayer.git
```
2. Adicione o projeto softplayerApi2 a solution
3. Acesse o diretório sofplayer acima do diretório da solution
```sh
cd ~/softplayer/softplayer
``` 
4. Restaure os pacotes
```sh
dotnet restore
```
5. Rode o projeto
```sh
dotnet run
```
6. Acesse o diretório sofplayer acima do diretório da solution
```sh
cd ~/softplayer/softplayerApi2
``` 
7. Restaure os pacotes
```sh
dotnet restore
```
8. Rode o projeto
```sh
dotnet run
```

### Atenção

1. Verificar a url nos testes e nos services, no último commit foram apontados para os endereços de que fiz o deploy
```sh
Checar URL e Portas (dependendo se estiver executando pelo IIS ou pelo docker)
```

## Licença

Distribuido sobre a licença MIT. Veja `LICENSE` para mais informações.


## Contato

Gabriel Lemos - [E-mail](gabrielelias.lemos@gmail.com)

Project Link: [https://github.com/gablemos/softplayer](https://github.com/gablemos/softplayer)

<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/gablemos/softplayer.svg?style=flat-square
[contributors-url]: https://github.com/gablemos/softplayer/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/gablemos/softplayer.svg?style=flat-square
[forks-url]: https://github.com/gablemos/softplayer/network/members
[stars-shield]: https://img.shields.io/github/stars/gablemos/softplayer.svg?style=flat-square
[stars-url]: https://github.com/gablemos/softplayer/stargazers
[issues-shield]: https://img.shields.io/github/issues/gablemos/softplayer.svg?style=flat-square
[issues-url]: https://github.com/gablemos/softplayer/issues
[license-shield]: https://img.shields.io/github/license/gablemos/softplayer.svg?style=flat-square
[license-url]: https://github.com/gablemos/softplayer/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/lemosgabriel/
[product-screenshot]: images/screenshot.jpg
