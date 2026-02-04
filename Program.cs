
using ActividadEntregable1.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar controladores
builder.Services.AddControllers();

// Servicio en memoria
builder.Services.AddSingleton<TaskService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
