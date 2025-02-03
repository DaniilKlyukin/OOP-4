using Application.Services;
using Domain.Abstractions.Repositories;
using Domain.Abstractions.Services;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.DataAccess.Repositories;

namespace Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddSwaggerGen();
        builder.Services.AddControllers();

        builder.Services.AddDbContext<NotesDbContext>(options =>
        {
            options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(NotesDbContext)));
        });

        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                policy.WithOrigins("http://localhost:7164");
                policy.AllowAnyHeader();
                policy.AllowAnyMethod();
            });
        });

        builder.Services.AddScoped<ILargestNoteService, LargestDescriptionNoteService>();
        builder.Services.AddScoped<INotesRepository, NotesRepository>();
        builder.Services.AddScoped<INotesService, NotesService>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.MapControllers();

        app.Run();
    }
}
