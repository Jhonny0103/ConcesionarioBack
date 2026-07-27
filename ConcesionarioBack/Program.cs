using ConcesionarioBack.Data;
using ConcesionarioBack.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//1. Añadimos la conexion a la bbdd y el contexto de datos.
builder.Services.AddDbContext<ConcesionarioDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//2. Añadimos los servicios de la capa de servicios.
builder.Services.AddScoped<BrandsService>();
builder.Services.AddScoped<ModelsService>();
builder.Services.AddScoped<VehiclesService>();
builder.Services.AddScoped<CustomersService>();
builder.Services.AddScoped<SalesService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Añadir los permisos para el consumo desde el front Angular


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
