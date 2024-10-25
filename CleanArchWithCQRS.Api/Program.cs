using CleanArchWithCQRS.Application;
using CleanArchWithCQRS.Persistance;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.ConfigureApplicationServices();
builder.Services.ConfigurePersistanceServices(builder.Configuration);


builder.Services.AddCors(o =>
{
o.AddPolicy("corsPolicy",b=>b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("corsPolicy");

app.MapControllers();

app.Run();
