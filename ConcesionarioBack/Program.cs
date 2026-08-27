using ConcesionarioBack.Data;
using ConcesionarioBack.Services;
using Microsoft.EntityFrameworkCore;
using ConcesionarioBack.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//1. Añadimos la conexion a la bbdd y el contexto de datos.
builder.Services.AddDbContext<ConcesionarioDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//2. Añadimos los servicios de la capa de servicios.
builder.Services.AddScoped<IBrandsService,BrandsService>();
builder.Services.AddScoped<IModelsService,ModelsService>();
builder.Services.AddScoped<IVehiclesService,VehiclesService>();
builder.Services.AddScoped<ICustomersService,CustomersService>();
builder.Services.AddScoped<ISalesService,SalesService>();
builder.Services.AddScoped<IEmployeesService,EmployeesService>();

//3. Configuramos los CORS para permitir peticiones desde Angular, que normalmente se ejecuta en un puerto diferente al de la API.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

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

// 4. Usamos la política de CORS que hemos definido. ** Recuerda ponerlo antes de MapControllers y UseAuthorization para que se aplique a todas las rutas.
app.UseCors("AllowAngular");

app.UseAuthorization();

app.MapControllers();

app.Run();
