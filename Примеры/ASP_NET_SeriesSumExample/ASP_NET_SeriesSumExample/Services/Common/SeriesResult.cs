using System.Collections;

namespace ASP_NET_SeriesSumExample.Services.Common;

public record SeriesResult(IReadOnlyCollection<SeriesIteration> Iterations) : IEnumerable<SeriesIteration>
{
    public double TotalSum => Iterations.Last().CurrentSum;

    public IEnumerator<SeriesIteration> GetEnumerator()
    {
        return Iterations.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return Iterations.GetEnumerator();
    }
}
