using ASP_NET_SeriesSumExample.Controllers.ActionResults;
using ASP_NET_SeriesSumExample.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ASP_NET_SeriesSumExample.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        string content = @$"
            <h1>Лабораторная работа 1</h1>
            <h2>Работу выполнил Иванов И.И.</h2>
            <form method='post'>
                {GetSeriesHTML()}
                <label>Номер первого члена ряда n0:</label><br/>
                <input name='request.n0' /><br/>
                <label>Количество членов ряда N:</label><br/>
                <input name='request.N' /><br/>
                <input type='submit' value='Send'/>
            </form>";

        return new HtmlResult(content);
    }

    [HttpPost]
    public IActionResult Index([FromServices] ISeriesService seriesService, SeriesRequest request)
    {
        var seriesResult = seriesService.Calculate((n) => 1.0 / (n * n), request.n0, request.N);

        var sb = new StringBuilder();

        sb.Append(@$"Сумма первых N={request.N} членов ряда равна: {seriesResult.TotalSum:F8}</br>");
        sb.Append("Расчёты представлены в таблице ниже</br>");

        sb.Append("""
            <table>
                <tr>
                  <th>Итерация</th>
                  <th>Член ряда</th>
                  <th>Сумма</th>
                </tr>
            """);

        foreach (var (iteration, element, sum) in seriesResult)
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

        return new HtmlResult(sb.ToString());
    }

    /// <summary>
    /// Математическая формула ряда в формате html
    /// </summary>
    /// <returns></returns>
    private string GetSeriesHTML()
    {
        return """
            <p>
              <math display="block">
                <mrow>
                  <munderover>
                    <mo>∑</mo>
                    <mrow>
                      <mi>n</mi>
                      <mo>=</mo>
                      <mn>n0</mn>
                    </mrow>
                    <mrow>
                      <mn>n0 + N</mn>
                    </mrow>
                  </munderover>
                  <mfrac>
                    <mn>1</mn>
                    <msup>
                      <mi>n</mi>
                      <mn>2</mn>
                    </msup>
                  </mfrac>
                </mrow>
              </math>
            </p>
            """;
    }
}
