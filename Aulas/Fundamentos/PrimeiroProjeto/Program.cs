using PrimeiroProjeto;

// Builder -> Configurações MVC, Banco de Dados e etc (É um objeto com vários atributos e métodos)

var builder = WebApplication.CreateBuilder(args);

// Pipeline -> Fluxo da aplicação (Sequência de Middlewares)

// Middlewares -> São componentes em aplicações web de request e response (Login, autenticação, autorização e etc)

// app.UseMiddleware<NomeDoMiddleware>();
// app.UseMiddleware<Middleware1>();
MeuMiddleware.Middleware1();
MeuMiddleware.Middleware2();
MeuMiddleware.Middleware3();

// Services -> Adição do Padrão MVC

// builder.Services.AddMvc();

// App -> Comportamentos do App

var app = builder.Build();

var nome = "Arthur";

app.MapGet("/", () => $"Olá {nome}, seja bem-vindo!");
app.MapGet("/teste", () => $"Olá {nome}, isso é um teste!");

app.Run();