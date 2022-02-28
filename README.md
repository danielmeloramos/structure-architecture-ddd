# Estrutura de Arquitetura com DDD
> Estrutura simples de arquitetura utilizando DDD.

> Repositório [_aqui_](https://github.com/danielmeloramos/structure-architecture-ddd-example).

## Índice
* [Informacoes gerais](#informacoes-gerais)
* [Tecnologias usadas](#tecnologias-usadas)
* [Bibliocatecas](#bibliotecas)
* [Estrutura](#estrutura)
* [Configuracao](#configuracao)
* [Uso](#uso)
* [Status do projeto](#status-do-projeto)
* [Espaco para melhorias](#espaco-para-melhorias)
* [Contato](#contato)

## Informacoes gerais
- Objetivo é fornecer arquitetura de solução, com uma estrutura utilizando DDD.

## Tecnologias usadas
- .NET 6.

## Bibliocatecas
- AutoMapper - 10.1.1
- AutoMapper.Extensions.Microsoft.DependencyInjection - 8.1.1
- coverlet.collector - 3.1.0
- coverlet.msbuild - 3.1.0
- CsvHelper - 27.2.1
- FluentAssertions - 6.4.0
- ILogger.Moq - 1.1.10
- Microsoft.AspNetCore.Hosting - 2.2.7
- Microsoft.EntityFrameworkCore - 3.1.22
- Microsoft.EntityFrameworkCore.Design - 3.1.22
- Microsoft.EntityFrameworkCore.Proxies - 3.1.22
- Microsoft.EntityFrameworkCore.Relational - 3.1.22
- Microsoft.EntityFrameworkCore.Tools - 3.1.22
- Microsoft.EntityFrameworkCore.Tools - 3.1.22
- Microsoft.Extensions.Configuration.UserSecrets - 5.0.0
- Microsoft.Extensions.Hosting - MultipleVersions
- Microsoft.Extensions.Logging - 3.1.22
- Serilog.Expressions" Version - 3.2.1
- Microsoft.NET.Test.Sdk - 17.0.0
- Moq - 4.16.1
- Npgsql.EntityFrameworkCore.PostgreSQL - 3.1.18
- NUnit - 3.13.2
- NUniNUnit3TestAdapter - 4.2.1

## Estrutura

Camadas
```sh
├── 1.0 - Distribution  # Camada responsável por realizar a distribuição de entrada da solução
├── 2.0 - Application # Camada responsável por realizar a orquestração dos casos de uso
├── 3.0 - Domain # Camada responsável pra centralizar as regras de negócio
├── 4.0 - Integration # Camada responsável pelos projetos de integração externo
├── 5.0 - Infra # Camada responsável por centralizar features compartilhadas e pela base dados
├── 6.0 - Tests # Camada responsável pelos testes unitários
├── 7.0 - Tools # Camada responsável pelas ferramentas de debug
├── 8.0 - ObjectMothers # Camada responsável por montar os objetos a serem usados nos testes unitários
└── 9.0 - Solution Items # Camada responsável pra referenciar os arquivos que não estão contidos nas layers
```

Projetos
```sh
├── Product.Functions  # Projeto responsável pelos serviços de eventos do Product
├── Product.Worker  # Projeto responsável pelos serviços de eventos do Product
├── Product.Application # Projeto responsável pela orquestração dos eventos do Product
├── Product.Domain # Projeto responsável pelas regras de negócio do Product
├── Product.Integration.Partnership # Projeto responsável pela integração do Product com parceiro
├── Product.Infra # Projeto responsável por compartilhar featureas comuns com os demais projetos, com exceção do dominio
├── Product.Infra.Data # Projeto responsável do contexto da base de dados
├── Product.Application.Tests # Projeto responsável pelos testes unitários do Application
├── Product.Domain.Tests # Projeto responsável pelos testes unitários do Domain
├── Product.Functions.Tests # Projeto responsável pelos testes unitários da Function
├── Product.Infra.Tests # Projeto responsável pelos testes unitários da Infra
├── Product.Integration.Partnership.Tests # Projeto responsável pelos testes do Integration.Partnership
├── Product.Worker.Tests # Projeto responsável pelos testes do Worker
├── Product.Functions.Tools # Projeto responsável pelo envio de mensages de testes da Function
├── Product.Toll.Worker # Projeto responsável pelo envio de mensages de testes do Worker
├── Product.Application.ObjectMother # Projeto responsável por manter os objetos de entrada do Application
├── Product.Domain.ObjectMother # Projeto responsável por manter os objetos de entrada do Domain
├── Product.Functions.ObjectMother # Projeto responsável por manter os objetos de entrada da Function
├── Product.Infra.ObjectMother # Projeto responsável por manter os objetos de entrada da Infra
├── Product.Integration.Partnership.ObjectMother # Projeto responsável por manter os objetos de entrada do Integration.Bifrost
└── Product.Worker.ObjectMother # Projeto responsável por manter os objetos de entrada do Worker
```

## Configuracao
Para conseguir instalar o projeto é necessário baixar o repositorio na máquina local. Realizar restore do NUGET e rodar aplicação. 

## Uso
Para utilizar, deve rodar o serviço Worker ou Functions. 

Em: 
```sh
├── 1.0 - Distribution  # Product.Functions ou Product.Worker
```

Com isso aplicação estará rodando rodando no modo de desenvolvimento.

Para testar consumo, pode ser utilizado o Sample. Ferramenta criada, para envio de uma mensagem.

Em: 
```sh
├── 7.0 - Tools  # Product.Functions.Tools ou Product.Worker.Tolls
```

## Status do projeto
Projeto está: _em progresso_.

## Espaco para melhorias
- Utilização de cache;

## Contato
Criado por <meloramosdaniel@gmail.com.br> - Sinta-se livre para me contatar!