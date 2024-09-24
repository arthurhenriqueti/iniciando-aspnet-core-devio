// Configura��o do Builder

var builder = WebApplication.CreateBuilder(args);

// Configura��o do Pipeline

// Middlewares
// Services

// builder.Services.AddMvc();

// Configura��o do App

var app = builder.Build();

// Configura��o de Comportamentos do App

var nome = "Arthur";

app.MapGet("/", () => $"Ol� {nome}, seja bem-vindo!");
app.MapGet("/teste", () => $"Ol� {nome}, isso � um teste!");

// Iniciando o App

app.Run();