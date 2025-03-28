# Projeto ArchitectureDDD-Usuario

Este projeto é uma aplicação baseada na arquitetura **DDD (Domain-Driven Design)**, utilizando **.NET** para o backend e **MongoDB** como banco de dados.

## Pré-Requisitos

- **.NET 6.0** ou superior: [Instalar .NET](https://dotnet.microsoft.com/download)
- **Docker** (para rodar o MongoDB em container): [Instalar Docker](https://docs.docker.com/get-docker/)
- **Git** (para clonar o repositório): [Instalar Git](https://git-scm.com/downloads)

## Clonando o Repositório

1. Abra o terminal no diretório desejado.
2. Clone o repositório utilizando o comando:

    ```bash
    https://github.com/IgorAnthonyy/ArchitectureDDD-Usuario.git
    ```

3. Navegue até a pasta do projeto:

    ```bash
    cd ArchitectureDDD-Usuario
    ```

## Configuração do MongoDB (Opcional)

Caso você utilize **Docker** para rodar o MongoDB, você pode subir o container utilizando o seguinte comando:

```bash
docker run --name mongodb-container -d -p 27017:27017 -e MONGO_INITDB_ROOT_USERNAME=admin -e MONGO_INITDB_ROOT_PASSWORD=admin mongo
```
### Instalando as Dependências

1. Navegue até a pasta onde o projeto API está localizado. ```/src/ArchitectureDDDUsuario.Api.```

2. Execute o comando para instalar as dependências do projeto:
```bash
dotnet restore
```
### Executando o Projeto

1. Navegue até a pasta onde o projeto API está localizado. ```/src/ArchitectureDDDUsuario.Api).```

2. Para rodar o projeto, execute o comando:

```bash
dotnet run
```

### Estrutura do Projeto
/Api: Contém as configurações da API e controllers.

/Application: Contém a lógica de aplicação, como serviços e DTOs.

/Domain: Contém as entidades, interfaces de repositórios e regras de negócio.

/Infrastructure: Contém as implementações de acesso a dados, como repositórios e configurações do MongoDB.