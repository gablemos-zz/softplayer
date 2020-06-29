
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

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

[![Product Name Screen Shot][product-screenshot]](https://example.com)

Descrição das escolhas tomadas:

Será perceptivel algumas falhas devido como a forma errada de se versionar as apis, ou a ausencia da injeção de dependencia ou de mock.


Todas estas decisões foram tomadas de forma deliberada como escolha para que outra implementação pudesse ser feita, testes, deploy, configuração de pipeline.

Outra decisão que tomei foi a de não separar em duas aplicações, decidi por uma abordagem de apis asincronas para que eu pudesse fazer um único deploy, mas no repositorio é possível ver o segundo projeto de api. Trabalhando com apenas serviços asincronos não houve lock e assim a aplicação pode fazer chamadas a si mesma sem problemas. Novamente, decisão para que os custos de publicação do meu teste para vocÊs fosse um pouco menor e eu pudesse entregar algo além do que foi solicitado e demonstrar um pouco mais do que sei, espero que levem em consideração.

Gostaria de pontuar que deixei os arquivos de docker no projeto.

Também tentei fazer o máximo de commits para que pudessem ver a forma como desenvolvo, apesar de não ter o hábito de seguir TDD a risca, é na fase de criação de testes onde vem a grande parte do refactor e melhoria do meu código, em minha opinião. Espero que tenha conseguido ter registrado isso através da timeline dos commits.

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

Ou siga os passos a seguintes.

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
2. Acesse o diretório sofplayer acima do diretório da solution
```sh
cd ~/softplayer/softplayer
``` 
3. Restaure os pacotes
```sh
dotnet restore
```
4. Rode o projeto
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
