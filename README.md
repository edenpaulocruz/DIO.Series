# Criando um APP simples de cadastro de séries em .NET

Projeto prático realizado durante *bootcamp* na [Digital Innovation One](https://digitalinnovation.one/).

## Descrição do projeto

O projeto visa aplicar de forma prática conhecimentos de orientação a objetos, o principal paradigma de programação utilizado no mercado.

Consiste num sistema básico de CRUD de séries de TV, onde é possível cadastrar, visualizar, alterar e excluir uma série, além de visualizar todas as séries cadastradas. Os dados são salvos em memória, não foi utilizado nenhum recurso de banco de dados..

Foi utilizada uma classe abstrata (EntidadeBase) para o controle de *Id*, outra classe para a série (Serie) que faz uso de um *Enum* para listar os gêneros (Genero) e outra classe para a coleção de séries (SerieRepositorio). Esta última se utilizando de uma *Interface* (IRepositorio). 

## Como executar

Foi utilizada no desenvolvimento a versão 3.1.410 do .NET Core.

Para a execução é recomendada a instalação da mesma versão ou superior.

Com o .NET Core instalado, acessar a pasta do projeto e executar o comando `dotnet run`.