using ASP_NET_SeriesSumExample.Controllers.Common;
using ASP_NET_SeriesSumExample.Services.Series;
using ASP_NET_SeriesSumExample.Views.Series;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_SeriesSumExample.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return new SeriesInputView();
    }

    [HttpPost]
    public IActionResult Index([FromServices] ISeriesService seriesService, SeriesRequest request)
    {
        var seriesResult = seriesService.Calculate((n) => 1.0 / (n * n), request.n0, request.N);

        return new SeriesResultView(request, seriesResult);
    }
}