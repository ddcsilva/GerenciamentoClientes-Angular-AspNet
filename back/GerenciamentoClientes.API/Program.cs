// Cria um novo WebHostBuilder a partir dos argumentos de entrada
var builder = WebApplication.CreateBuilder(args);

// Adiciona o servi�o de controladores � cole��o de servi�os do aplicativo
builder.Services.AddControllers();

// Adiciona o servi�o CORS � cole��o de servi�os do aplicativo e define uma pol�tica padr�o que permite qualquer origem, m�todo e cabe�alho
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Cria uma inst�ncia do aplicativo a partir do WebHostBuilder
var app = builder.Build();

// Habilita o roteamento de solicita��es HTTP
app.UseRouting();

// Habilita o middleware CORS para permitir solicita��es de qualquer origem
app.UseCors();

// Configura o pipeline de solicita��es HTTP para mapear solicita��es para controladores
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

// Inicia o aplicativo e espera por solicita��es HTTP
app.Run();
