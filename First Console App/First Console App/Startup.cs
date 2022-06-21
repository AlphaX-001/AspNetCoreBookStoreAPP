namespace First_Console_App
{
    public class Startup
    {
        public void ConfigurationServices(IServiceCollection Service)
        {
        }
        public void Configure(IApplicationBuilder App,IWebHostEnvironment env)
        {
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
