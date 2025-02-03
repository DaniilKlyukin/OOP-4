namespace ASP_NET_SeriesSumExample.Utilities
{
    public class SeriesCalculator
    {
        private readonly Func<long, double> seriesF;
        private readonly Action<long, double, double>? logger;

        public SeriesCalculator(Func<long, double> seriesF, Action<long, double, double>? logger = null)
        {
            this.seriesF = seriesF;
            this.logger = logger;
        }

        public double Run(long n0, long N)
        {
            var sum = 0.0;

            for (var i = n0; i < n0 + N; i++)
            {
                var element = seriesF(i);
                sum += element;

                logger?.Invoke(i, element, sum);
            }

            return sum;
        }
    }
}