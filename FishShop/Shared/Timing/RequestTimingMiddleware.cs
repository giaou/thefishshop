using System;
using System.Diagnostics;

namespace FishShop.Shared.Timing;

public class RequestTimingMiddleware (RequestDelegate next, ILogger<RequestTimingMiddleware> logger)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var stopwatch = new Stopwatch();
        try
        {
            stopwatch.Start();
            await next(context);
        }
        finally
        {
            stopwatch.Stop();
            var elaspedMilliseconds = stopwatch.ElapsedMilliseconds;
            logger.LogInformation("{RequestMethod} {RequestPath} completed with status {Status} in {ElapsedMilliseconds} ms",
                                        context.Request.Method,
                                        context.Request.Path,
                                        context.Response.StatusCode,
                                        elaspedMilliseconds);
        }
    }
}
