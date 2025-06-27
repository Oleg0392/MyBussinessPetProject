using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace BuildingTools.Behaviors
{
    public class LoggingBehavior<TRequest, TResponse>(ILogger<LoggingBehavior<TRequest, TResponse>> logger) : IPipelineBehavior<TRequest, TResponse>
        where TRequest : notnull, IRequest<TResponse>
        where TResponse : notnull
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            logger.LogInformation("[START] Обработка запроса - {Request}, ответ - {Response}, данные запроса - {RequestData}",
                typeof(TRequest).Name, typeof(TResponse).Name, request);

            var timer = Stopwatch.StartNew();

            var response = await next();

            timer.Stop();

            var timeTaken = timer.Elapsed;

            if (timeTaken.Seconds > 3)
            {
                logger.LogWarning("[PERFORMANCE] Запрос {Request} занимает {TimeTaken} секунд.",
                    typeof(TRequest).Name, timeTaken.Seconds);
            }

            logger.LogInformation("[END] Запрос - {Request} обработан с ответом - {Response}", typeof(TRequest).Name, typeof(TResponse).Name);

            return response;
        }
    }
}
