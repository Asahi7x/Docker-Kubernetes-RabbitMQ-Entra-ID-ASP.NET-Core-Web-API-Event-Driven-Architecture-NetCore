using eCommerce.Infraestructure;
using eCommerce.Core;
using eCommerce.API.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Inyeccion de dependencias de Infraestructura
builder.Services.AddInfraestructure();
// Inyeccion de dependencias de Core
builder.Services.AddCore();

//Controladores
builder.Services.AddControllers();

//Construye la app
var app = builder.Build();

//Middleware
app.UseExceptionHandingMiddleware();

// Routing
app.UseRouting();

// Auth
app.UseAuthentication();
app.UseAuthorization();

// Map Controllers
app.MapControllers();

app.Run();
