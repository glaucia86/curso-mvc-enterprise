# Curso de ASP.NET MVC 5 – Enterprise Applications

Códigos desenvolvidos durante o Curso de ASP.NET MVC 5 – Enterprise Applications do Eduardo Pires Consultoria. Durante o curso foram abordados os principais conceitos sobre o padrão MVC e como desenvolver aplicações: desde pequenas à complexas com o uso do DDD (Domain Driven Design).

## Recursos utilizados no desenvolvimento:

- Visual Studio 2015/2017;
- Asp.NET MVC 5;
- Entity Framework 6;
- FluentAPI;
- DDD (Domain Driven Design);
- Bootstrap Framework;

## Ementa do Curso:

- Básico

- Intermédiário

- Avançado

## Execução do Entity Framework nas IDE's: VS 2015/2017:

Ao realizar os comandos:

```
Enable-Migrations

```
e

```
Update-Database -Verbose
```

Se faz necessário criar uma 'connectionString' no arquigo 'WebConfig' com a seguinte descrição:

```
<connectionStrings>
    <add name="Aula1Context"
         connectionString="Data Source=(LocalDb)\v12.0;AttachDbFilename=|DataDirectory|\Aula1BD.mdf;
         Initial Catalog=Aula1BD;
         Integrated Security=True"
         providerName="System.Data.SqlClient" />  
  </connectionStrings>

```

Nas versões mais recentes do Visual Studio (2015/2017), se faz necessário criar uma nova instância do localdb do sql no seu computador. A qual poderá ser criado da seguinte maneira:

1) Passo: Abrir o cmd e executar o seguinte comando:

```
> sqllocaldb create "v12.0"

```

2) Passo: Ir até o 'Package Manager Console' e executar o seguinte comando:

```
> Update-Database -Verbose

```

Ao seguir esses passos, evitará de ocorrer o problema/error 50, de conexão com o SQL Server, erro que evita a criação da tabela via 'Code First' do Entity Framework.


(Documentação em Desenvolvimento)
