using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_SeriesSumExample.Controllers.ActionResults;

public class HtmlResult : IActionResult
{
    private string htmlCode;
    public HtmlResult(string html) => htmlCode = html;
    public async Task ExecuteResultAsync(ActionContext context)
    {
        string fullHtmlCode = @$"<!DOCTYPE html>
            <html>
                <head>
                    <title>Лабораторная работа 1 Иванов И.И.</title>
                    <meta charset=utf-8 />
                </head>
                <body>{htmlCode}</body>
            </html>";
        await context.HttpContext.Response.WriteAsync(fullHtmlCode);
    }
}
