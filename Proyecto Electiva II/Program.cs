using ActividadEntregable1.Interface;
using ActividadEntregable1.Services;

var builder = WebApplication.CreateBuilder(args);

// Controladores
builder.Services.AddControllers();

// Inyección de dependencias
builder.Services.AddScoped<ITaskServices, TaskServices>();

var app = builder.Build();

// Middleware
app.UseAuthorization();

app.MapControllers();

app.Run();
