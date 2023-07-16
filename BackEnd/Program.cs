using BackEnd;
using BackEnd.DataAccess;
using BackEnd.DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddDbContext<DBTestBGContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DBTestBGContext")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region "Implementación automatica"

/*Obtengo las clases a implementar con su respectiva interfaz*/
var typesToRegister = typeof(Program).Assembly.GetTypes()
 .Where(type => !type.IsAbstract && !type.IsGenericTypeDefinition)
 .Where(type => type.GetInterfaces().Any(i => i == typeof(IAutomaticImplementation)))
 .Select(type => new
 {
     Service = type.GetInterfaces().First(i => i != typeof(IAutomaticImplementation)),
     Implementation = type
 });
// Registra las clases encontradas en el contenedor de inyección de dependencias
foreach (var registration in typesToRegister)
    builder.Services.AddScoped(registration.Service, registration.Implementation);
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MigrateDatabase<DBTestBGContext>();
app.Run();
