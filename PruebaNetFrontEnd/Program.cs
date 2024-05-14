using PruebaNetFrontEnd.Services;
using PruebaNetFrontEnd.Services.IServices;
using PruebaNetFrontEnd.Utility;

namespace PruebaNetFrontEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddHttpClient<IAreaService, AreaService>();
            builder.Services.AddHttpClient<IEmpleadoService, EmpleadoService>();

            SD.PruebaNet = builder.Configuration["ServiceUrls:PruebaNetApi"];

            builder.Services.AddScoped<IAreaService, AreaService>();
            builder.Services.AddScoped<IEmpleadoService, EmpleadoService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsProduction()) ;
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
