using First_Console_App;

class Program
{
    public static void Main(String [] args)
    {
        //for (int i = 0; i < 7; i++)
        //{
        //    Console.WriteLine("I wll be A Sucessfull Person, I Am Anith Bairagi");
        //}
        CreateHostBuilder(args).Build().Run();  

    }
    public static IHostBuilder CreateHostBuilder(String []args)=>
    
        Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => {

            webBuilder.UseStartup<Startup>();
        }
        );
    
}