using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_SeriesSumExample.Views.ActionResults;

public class HtmlResult : IActionResult
{
    private readonly string body;

    public HtmlResult(string body)
    {
        this.body = body;
    }

    public string GetHTML()
    {
        return @$"
            <!DOCTYPE html>
            <html>
                <head>
                    <title>Лабораторная работа 1 Иванов И.И.</title>
                    <meta charset=utf-8 />
                </head>
                <body>{body}</body>
            </html>";
    }

    public async Task ExecuteResultAsync(ActionContext context)
    {
        var fullHtmlCode = GetHTML();

        await context.HttpContext.Response.WriteAsync(fullHtmlCode);
    }

    public override string ToString()
    {
        return GetHTML();
    }
}