Esse projeto desenvolvido durante o bootcamp da Rocketseat, com o objetivo de gerenciar o fluxo de caixa, permitindo que os usuários acompanhem suas receitas e despesas de forma eficiente.

## Funcionalidades

- **Cadastro de Transações**: Permite ao usuário registrar entradas (receitas) e saídas (despesas) com detalhes como descrição, valor e data.
- **Listagem de Transações**: Exibe uma lista com todas as transações cadastradas, possibilitando a visualização rápida do histórico financeiro.
- **Resumo Financeiro**: Apresenta um balanço com o total de entradas, saídas e o saldo atual.

## Tecnologias Utilizadas

- **Backend**: Construído com .NET Core, proporcionando uma API robusta e escalável.
- **Banco de Dados**: Utiliza o Entity Framework Core para interagir com o banco de dados, facilitando operações de CRUD.
- **Docker**: Configuração de contêineres para facilitar o deploy e a escalabilidade da aplicação.

## Pré-requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/download) instalado na máquina.
- [Docker](https://www.docker.com/get-started) instalado para execução dos contêineres.

## Como Executar o Projeto

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/pedroaba/CashFlow.git
   ```

2. **Navegue até o diretório do projeto**:
   ```bash
   cd CashFlow
   ```

3. **Configure o Banco de Dados**:
   - Certifique-se de que o Docker está em execução.
   - Execute o comando para iniciar o contêiner do banco de dados:
     ```bash
     docker-compose up -d
     ```

4. **Execute as Migrações**:
   - No diretório do backend, aplique as migrações para criar as tabelas no banco de dados:
     ```bash
     dotnet ef database update
     ```

5. **Inicie o Backend**:
   - No diretório do backend, execute:
     ```bash
     dotnet run
     ```

6. **Acesse a Aplicação**:
   - A API estará disponível em `http://localhost:5000`.
