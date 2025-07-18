using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Diagnostics;

namespace FishShop.Shared.ErrorHandling;

public class GlobalExceptionHandler (ILogger<GlobalExceptionHandler> logger) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        var traceId = Activity.Current?.TraceId;
        logger.LogError(
            exception,
            "Could not process a request on machine {Machine}, TraceId: {TraceId}",
            Environment.MachineName,
            traceId);
        await Results.Problem(
            title: "An error occurred while trying to lookup your input",
            statusCode: StatusCodes.Status500InternalServerError,
            extensions: new Dictionary<string, object?>
            {
                        { "traceId",traceId.ToString()}
            }
        ).ExecuteAsync(httpContext);
        return true;
    }
}
