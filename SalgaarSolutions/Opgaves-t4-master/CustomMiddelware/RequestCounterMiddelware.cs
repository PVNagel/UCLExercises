using Opgavesæt4.Counter;

namespace Opgavesæt4.CustomMiddelware
{
    public class RequestCounterMiddelware
    {
        private readonly RequestDelegate _next;

        public RequestCounterMiddelware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Analyser URL for at bestemme, om det er en sang eller et album
            if (context.Request.Path.StartsWithSegments("/albums/Details"))
            {
                // Tæl anmodningen for et album og gem dataen
                AlbumRequestCounter.IncrementCounter(context.Request.Path.Value);

                // Log anmodningen
                RequestLogger.LogRequest(context.Request.Path.Value);
            }
            else if (context.Request.Path.StartsWithSegments("/songs/Details"))
            {
                // Tæl anmodningen for en sang og gem dataen
                SongRequestCounter.IncrementCounter(context.Request.Path.Value);

                // Log anmodningen
                RequestLogger.LogRequest(context.Request.Path.Value);
            }

            // Kalder næste middleware i pipelinen
            await _next(context);
        }
    }
}
