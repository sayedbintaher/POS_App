using Microsoft.EntityFrameworkCore;
using PosApi.DataContext;
using PosAPI.DependencyInjection;
using PosService.Contracts;
using PosService.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectonString =builder.Configuration.GetConnectionString("DefaultConnection");
Services.RegisterDependencies(builder.Services, connectonString);

builder.Services.AddCors(options => options.AddPolicy(name: "CorsPolicy", policy =>
{
    policy.WithOrigins("https://localhost:7093").AllowAnyMethod().AllowAnyHeader();
}));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
