namespace BookStoreApp
{
    public class Startup
    {
        public void ConfigurationServices(IServiceCollection services)
        {
            //services.AddControllersWithViews();
        }


        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapDefaultControllerRoute();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello Guys!!");
                });
            });
        }
    }
}
