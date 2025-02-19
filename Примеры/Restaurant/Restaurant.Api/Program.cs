using Microsoft.AspNetCore.Mvc.Infrastructure;
using Restaurant.Api.Common.Errors;
using Restaurant.Application;
using Restaurant.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();

builder.Services.AddSingleton<ProblemDetailsFactory, RestaurantProblemDetailsFactory>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();


app.Run();