using PrimeiroProjeto;

// Builder -> Configura��es MVC, Banco de Dados e etc (� um objeto com v�rios atributos e m�todos)

var builder = WebApplication.CreateBuilder(args);

// Pipeline -> Fluxo da aplica��o (Sequ�ncia de Middlewares)

// Middlewares -> S�o componentes em aplica��es web de request e response (Login, autentica��o, autoriza��o e etc)

// app.UseMiddleware<NomeDoMiddleware>();
// app.UseMiddleware<Middleware1>();
MeuMiddleware.Middleware1();
MeuMiddleware.Middleware2();
MeuMiddleware.Middleware3();

// Services -> Adi��o do Padr�o MVC

// builder.Services.AddMvc();

// App -> Comportamentos do App

var app = builder.Build();

var nome = "Arthur";

app.MapGet("/", () => $"Ol� {nome}, seja bem-vindo!");
app.MapGet("/teste", () => $"Ol� {nome}, isso � um teste!");

app.Run();