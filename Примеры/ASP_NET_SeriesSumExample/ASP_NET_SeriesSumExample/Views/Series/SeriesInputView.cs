using ASP_NET_SeriesSumExample.Views.ActionResults;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_SeriesSumExample.Views.Series;

public class SeriesInputView : IActionResult
{
    public async Task ExecuteResultAsync(ActionContext context)
    {
        string content = @$"
            <h1>Лабораторная работа 1</h1>
            <h2>Работу выполнил Иванов И.И.</h2>
            <form method='post'>
                {GetSeriesHTML()}
                <label>Номер первого члена ряда n0:</label><br>
                <input name='request.n0' /><br>
                <label>Количество членов ряда N:</label><br>
                <input name='request.N' /><br>
                <input type='submit' value='Send'/>
            </form>";

        var result = new HtmlResult(content);

        await context.HttpContext.Response.WriteAsync(result.GetHTML());
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