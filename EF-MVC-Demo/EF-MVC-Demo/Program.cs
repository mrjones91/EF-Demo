using EF_MVC_Demo.Data;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EF_MVC_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<DemoContext>(options =>
                options.UseSqlServer(
                    builder
                    .Configuration
                    .GetConnectionString("DefaultConnection")));
            
            // dotnet ef database update

            //services.AddDbContext<SchoolDbContext>(options =>
            //{
            //    string connectionString = Configuration.GetConnectionString("DefaultConnection");
            //    options.UseSqlServer(connectionString);
            //});

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
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