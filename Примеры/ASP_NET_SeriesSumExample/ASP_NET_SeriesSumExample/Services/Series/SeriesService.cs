using ASP_NET_SeriesSumExample.Services.Common;

namespace ASP_NET_SeriesSumExample.Services.Series;

public class SeriesService : ISeriesService
{
    public SeriesResult Calculate(Func<long, double> function, long n0, long N)
    {
        var iterations = new List<SeriesIteration>();

        var sum = 0.0;

        for (var i = n0; i < n0 + N; i++)
        {
            var element = function(i);
            sum += element;

            iterations.Add(new SeriesIteration(i, element, sum));
        }

        return new SeriesResult(iterations);
    }
}