using TreyResearch.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TreyResearch.Data;
using AutoMapper;
using TreyResearch.Configurations;

namespace TreyResearch
{
    public class Program
    {
        // startup.csは統合された
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<TreyResearchContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("TreyResearchContext") ?? 
                throw new InvalidOperationException("Connection string 'TreyResearchContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // config custom services
            ConfigureServices(builder.Services);

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

        private static void ConfigureServices(IServiceCollection services)
        {
            // Add custom services 
            services.AddScoped<IRoomRepository, AdoNetRoomRepository>();
            services.AddScoped<IMessageRepository, AdoNetMessageRepository>();
            services.AddScoped<IConnectionIsolationFactory, ConnectionIsolationFactory>();
            services.AddScoped<IRoomViewModelReader, RoomViewModelService>();
            services.AddScoped<IRoomViewModelWriter, RoomViewModelService>();

            // Mapping
            services.AddAutoMapper(cfg => cfg.AddProfile<RoomProfile>());
            services.AddAutoMapper(cfg => cfg.AddProfile<MessageProfile>());
            services.AddSingleton<IMapper, Mapper>();
        }
    }
}