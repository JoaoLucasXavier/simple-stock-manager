# simple-stock-manager
Simple stock manager é um sistema WEB MVC de gerenciamento de Fornecedores, Clientes, Produtos e Estoque construido usando a plataforma .NET CORE 3.x e ferramentas como Entity framework e Identity.


Segue abaixo algumas telas do sistema:

**Home page:**

![](https://github.com/JoaoLucasXavier/simple-stock-manager/blob/master/wwwroot/git/01.PNG)


**Cadastro de fornecedor:**

![](https://github.com/JoaoLucasXavier/simple-stock-manager/blob/master/wwwroot/git/02.PNG)


**Exclusão de fornecedor:**

![](https://github.com/JoaoLucasXavier/simple-stock-manager/blob/master/wwwroot/git/03.PNG)


**Listagem de produtos:**

![](https://github.com/JoaoLucasXavier/simple-stock-manager/blob/master/wwwroot/git/04.PNG)


**Edição produtos:**

![](https://github.com/JoaoLucasXavier/simple-stock-manager/blob/master/wwwroot/git/05.PNG)


**Detalhes de produto:**

![](https://github.com/JoaoLucasXavier/simple-stock-manager/blob/master/wwwroot/git/06.PNG)


**Listagem de estoque:**

![](https://github.com/JoaoLucasXavier/simple-stock-manager/blob/master/wwwroot/git/07.PNG)


**Listagem de clientes:**

![](https://github.com/JoaoLucasXavier/simple-stock-manager/blob/master/wwwroot/git/08.PNG)


**Compras:**

![](https://github.com/JoaoLucasXavier/simple-stock-manager/blob/master/wwwroot/git/10.PNG)


## Clonando, Construindo e executando a aplicação em seu computador

Abaixo veremos como você pode executar a aplicação localmente em seu computador, já tendo em vista que você possui todas as ferramentas para desenvolvimento e execução de projetos .NET CORE 3.1 devidamente configuradas em seu computador.

**Siga os seguintes passos:**



1. Clone o repositório do projeto simple-stock-manager do GitHub para o local desejado em seu computador



2. Abra seu terminal na pasta raiz do projeto



3. Restaure as dotnet nuget dependencies: `dotnet restore`



4. Restaure as dotnet nuget dependencies: `dotnet restore`



5. Construa a aplicação: `dotnet build`



6. Edite seu usuário e senha do Sql Server na Connection String no arquivo: `appsettings.json`



7. Execute as migrations no banco de dados: `dotnet ef database update -v`



8. Execute a aplicação: `dotnet watch run`

   

9. Acesse a URI https://localhost:5001 no seu browser, Cadastre um novo usuário e faça login no sistema!


Sinta-se a vontade para explorar o Simple stock manage!
