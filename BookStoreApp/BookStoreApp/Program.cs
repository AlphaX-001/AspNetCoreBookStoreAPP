
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Hosting;
using BookStoreApp;

class Program
{
       public static void Main(string[]args)
       {
            CreateHostbuilder(args).Build().Run();
       }
       public static IHostBuilder CreateHostbuilder(string[] args) =>
       Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
       {
           webBuilder.UseStartup<Startup>();
       });

   
}


//******** Program by Ani *********//

//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//*************************************************************** This is Multiple Middleware Handling ***********************************************************************//

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("\nThis is the First Middleware");
//    await next();
//    await context.Response.WriteAsync("\nThis is the First Middleware Response");

//});
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("\nThis is the Second Middleware");
//    await next();
//    await context.Response.WriteAsync("\nThis is the Second Middleware Response");

//});
//app.Use(async (context,next) =>
//{
//    await context.Response.WriteAsync("\nThis is the Third Middleware");
//    await next();
//});


//app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//   // endpoints.MapGet
//    endpoints.Map("/", async context =>
//     {
//         await context.Response.WriteAsync("\nHello From MiddleWare");
//     });
//});

//app.Run();

//****************************************** Example of Routing Through MiddleWare ***********************************************************//

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGet("/Ani", async context =>
//    {
//        await context.Response.WriteAsync("\nHello From Middleware Ani");
//    });
//});

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGet("/Ani/ASP", async context =>
//    {
//        await context.Response.WriteAsync("\nHello From Middleware Ani and ASP");
//    });
//});
