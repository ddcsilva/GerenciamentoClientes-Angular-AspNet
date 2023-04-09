// Cria um novo WebHostBuilder a partir dos argumentos de entrada
var builder = WebApplication.CreateBuilder(args);

// Adiciona o serviço de controladores à coleção de serviços do aplicativo
builder.Services.AddControllers();

// Adiciona o serviço CORS à coleção de serviços do aplicativo e define uma política padrão que permite qualquer origem, método e cabeçalho
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Cria uma instância do aplicativo a partir do WebHostBuilder
var app = builder.Build();

// Habilita o roteamento de solicitações HTTP
app.UseRouting();

// Habilita o middleware CORS para permitir solicitações de qualquer origem
app.UseCors();

// Configura o pipeline de solicitações HTTP para mapear solicitações para controladores
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

// Inicia o aplicativo e espera por solicitações HTTP
app.Run();
