using dark_roasted_coffee_api;
using dark_roasted_coffee_api.data.HandleData;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Make IGetData available to endpoints via dependency injection system
builder.Services.AddSingleton<IGetData, GetData>();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "0.1.0",
        Title = "Coffee API",
    });
    options.EnableAnnotations();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Endpoint mapping happens here
app.ConfigureApi();

app.Run();

//Make Program class accessible to unit tests
public partial class Program { }