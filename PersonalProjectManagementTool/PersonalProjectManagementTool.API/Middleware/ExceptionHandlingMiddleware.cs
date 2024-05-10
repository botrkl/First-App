
namespace PersonalProjectManagementTool.API.Middleware
{
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await next(context);
            if (context.Response.StatusCode >= 400)
            {
                context.Response.Redirect("https://localhost:7109/");
            }
        }
    }
}
