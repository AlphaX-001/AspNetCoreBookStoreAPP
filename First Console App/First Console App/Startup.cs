
namespace First_Console_App
{
    public class Startup
    {
        public void ConfigurationServices(IServiceCollection Service)
        {
        }
        public void Configure(IApplicationBuilder App,IWebHostEnvironment env)
        {

            //App.Use(async (context, next) =>
            // {
            //     await context.Response.WriteAsync("\nThis is the First Middleware");
            //     await next();
            //     await context.Response.WriteAsync("\nThis is the First Middleware Response");

            //});
            //App.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("\nThis is the Second Middleware");
            //    await next();
            //    await context.Response.WriteAsync("\nThis is the Second Middleware Response");

            //});
            App.UseRouting();
            App.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async (context) =>
                 {
                     for (int i = 0; i < 10; i++)
                     {
                         await context.Response.WriteAsync("\nConverting ConSole Application into Web Applications");
                     }
                 });
            });
        }
    }
}
