using ASP_NET_SeriesSumExample.Services.Common;

namespace ASP_NET_SeriesSumExample.Services.Series;

public interface ISeriesService
{
    SeriesResult Calculate(Func<long, double> function, long n0, long N);
}