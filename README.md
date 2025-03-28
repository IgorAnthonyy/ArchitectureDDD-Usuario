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
    git clone https://github.com/seu-usuario/seu-repositorio.git
    ```
3. Navegue até a pasta do projeto:
    ```bash
    cd seu-repositorio
    ```

## Configuração do MongoDB (Opcional)

Caso você utilize **Docker** para rodar o MongoDB, você pode subir o container utilizando o seguinte comando:
```bash
docker run --name mongodb-container -d -p 27017:27017 -e MONGO_INITDB_ROOT_USERNAME=admin -e MONGO_INITDB_ROOT_PASSWORD=admin mongo

Instalando as Dependências
Navegue até a pasta onde o projeto API está localizado. Se você estiver utilizando uma estrutura típica, provavelmente será algo como /src/ArchitectureDDDUsuario.Api.

Execute o comando para instalar as dependências do projeto:

bash
Copiar
Editar
dotnet restore
Executando o Projeto
Navegue até a pasta onde o projeto API está localizado (novamente, geralmente em /src/ArchitectureDDDUsuario.Api).

Para rodar o projeto, execute o comando:

bash
Copiar
Editar
dotnet run
O servidor será iniciado e estará disponível em http://localhost:5000.

Estrutura do Projeto
/Api: Contém as configurações da API e controllers.

/Application: Contém a lógica de aplicação, como serviços e DTOs.

/Domain: Contém as entidades, interfaces de repositórios e regras de negócio.

/Infrastructure: Contém as implementações de acesso a dados, como repositórios e configurações do MongoDB.

Licença
Este projeto está licenciado sob a MIT License.
