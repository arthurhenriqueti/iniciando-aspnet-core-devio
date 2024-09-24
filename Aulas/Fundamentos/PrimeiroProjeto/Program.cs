// Configuração do Builder

var builder = WebApplication.CreateBuilder(args);

// Configuração do Pipeline

// Middlewares
// Services

// builder.Services.AddMvc();

// Configuração do App

var app = builder.Build();

// Configuração de Comportamentos do App

var nome = "Arthur";

app.MapGet("/", () => $"Olá {nome}, seja bem-vindo!");
app.MapGet("/teste", () => $"Olá {nome}, isso é um teste!");

// Iniciando o App

app.Run();