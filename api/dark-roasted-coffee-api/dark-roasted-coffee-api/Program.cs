using dark_roasted_coffee_api;
using dark_roasted_coffee_api.data.HandleData;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// In order to display enums as strings
//builder.Services.Configure<JsonOptions>(o => o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

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
    //options.SchemaFilter<Filtering>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Endpoint mapping happens here
app.ConfigureApi();

app.Run();

//Make app accessible to unit tests
public partial class Program { }