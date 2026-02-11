using Microsoft.EntityFrameworkCore;
using WebApiClass.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DataContext>( option =>
 option.UseSqlServer(connection));

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

 builder.Services.AddEndpointsApiExplorer();
 builder.Services.AddSwaggerGen();  


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
