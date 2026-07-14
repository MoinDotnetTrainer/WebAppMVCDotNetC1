using BusinessLogicLayer.Irepo;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Repo;
using Microsoft.EntityFrameworkCore;
using System;

namespace WebAppMVCLayred
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Passing teh conn from appsetting to App db

            builder.Services.AddDbContext<AppDb>(options =>
       options.UseSqlServer(
           builder.Configuration.GetConnectionString("DefaultConnection")));


            builder.Services.AddScoped<IOrders, OrdersOps>();
            builder.Services.AddScoped<IUsers, UsersTask>();
            builder.Services.AddScoped<IOrders, OrdersBlSP>();


            // register a session
            builder.Services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(20);
                option.Cookie.IsEssential = true;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


                app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=UsersOps}/{action=Login}/{id?}");

            app.Run();
        }
    }
}
