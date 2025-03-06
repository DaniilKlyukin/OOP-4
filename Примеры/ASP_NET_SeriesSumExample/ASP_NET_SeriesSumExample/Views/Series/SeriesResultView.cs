using System.Text;
using ASP_NET_SeriesSumExample.Controllers.Common;
using ASP_NET_SeriesSumExample.Services.Common;
using ASP_NET_SeriesSumExample.Views.ActionResults;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_SeriesSumExample.Views.Series;

public class SeriesResultView : IActionResult
{
    private readonly SeriesRequest _request;
    private readonly SeriesResult _result;

    public SeriesResultView(SeriesRequest request, SeriesResult result)
    {
        _request = request;
        _result = result;
    }

    public async Task ExecuteResultAsync(ActionContext context)
    {
        var sb = new StringBuilder();

        sb.Append($"Сумма первых N={_request.N} членов ряда равна: {_result.TotalSum:F8}<br>");
        sb.Append("Расчёты представлены в таблице ниже<br>");

        sb.Append("""
            <table>
                <tr>
                  <th>Итерация</th>
                  <th>Член ряда</th>
                  <th>Сумма</th>
                </tr>
            """);

        foreach (var (iteration, element, sum) in _result)
        {
            sb.Append($"""
                <tr>
                  <td>{iteration}</td>
                  <td>{element}</td>
                  <td>{sum}</td>
                </tr>
                """);
        }

        sb.Append("</table>");

        var html = new HtmlResult(sb.ToString());

        await context.HttpContext.Response.WriteAsync(html.GetHTML());
    }
}