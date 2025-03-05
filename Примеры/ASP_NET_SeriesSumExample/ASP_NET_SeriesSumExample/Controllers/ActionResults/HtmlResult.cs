using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_SeriesSumExample.Controllers.ActionResults;

public class HtmlResult : IActionResult
{
    private readonly string html;

    public HtmlResult(string html)
    {
        this.html = html;
    }

    public async Task ExecuteResultAsync(ActionContext context)
    {
        string fullHtmlCode = @$"
            <!DOCTYPE html>
            <html>
                <head>
                    <title>Лабораторная работа 1 Иванов И.И.</title>
                    <meta charset=utf-8 />
                </head>
                <body>{html}</body>
            </html>";

        await context.HttpContext.Response.WriteAsync(fullHtmlCode);
    }
}
