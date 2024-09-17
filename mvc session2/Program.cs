namespace mvc_session2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
            // app.MapGet("/product/Get/2", () => "Hello World!");
            app.UseRouting();
            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllerRoute(
                    name:"default",
                    pattern:"{Controller=Home}/{Action=Index}/{id:int?}"
                    );
            });
            app.Run();
        }
    }
}