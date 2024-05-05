
using WebApplication4.Models;

namespace WebApplication4;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<ILibrarianStorage, ManageStudentStorage>();
        var app = builder.Build();
        app.UseRouting();
        //app.UseEndpoints(endpoints => {
        //    endpoints.MapControllerRoute(
        //         name: "default",
        //          pattern: "{controller=Home}/{action=Index}/{id?}");
        //});
        app.MapControllerRoute(
                 name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");
        app.Run();
    }
}