using ASP_NET_SeriesSumExample.Services.Series;

namespace ASP_NET_SeriesSumExample;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddTransient<ISeriesService, SeriesService>();

        builder.Services.AddControllers();

        var app = builder.Build();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
