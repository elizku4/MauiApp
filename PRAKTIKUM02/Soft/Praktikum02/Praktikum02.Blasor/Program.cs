using Microsoft.EntityFrameworkCore;
using Praktikum02.Blasor.Data;
using Praktikum02.Blasor.Components;
using Praktikum02.Blasor.Domain;
using Praktikum02.Blasor.Infra;
namespace Praktikum02.Blasor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddDbContext<MovieContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MovieContext")
        ?? "Data Source=movies.db"));
        builder.Services.AddScoped<ICountriesRepo, CountriesRepo>();
        builder.Services.AddScoped<ICurrenciesRepo, CurrenciesRepo>();
        builder.Services.AddScoped<IMoviesRepo, MoviesRepo>();
            builder.Services.AddScoped<IMoniesRepo, MoniesRepo>();
            builder.Services.AddScoped<ICountryCurrenciesRepo, CountryCurrenciesRepo>();
            builder.Services.AddScoped<LoginService>();
            var app = builder.Build();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();
            app.Run();
        }
        
    }
}
