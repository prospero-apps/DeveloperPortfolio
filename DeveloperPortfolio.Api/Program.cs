using DeveloperPortfolio.Api.Data;
using DeveloperPortfolio.Api.Repositories;
using DeveloperPortfolio.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace DeveloperPortfolio.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContextPool<DeveloperPortfolioDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DeveloperPortfolioConnection"))
            );

            builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<ITechRepository, TechRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseSwagger();

            if (app.Environment.IsDevelopment())
            {                
                app.UseSwaggerUI();
            }

            app.UseCors(policy =>
                policy.WithOrigins("http://localhost:7295", "https://localhost:7295",
                "http://victorious-coast-047c61a10.3.azurestaticapps.net",
                "https://victorious-coast-047c61a10.3.azurestaticapps.net")
                .AllowAnyMethod()
                .WithHeaders(HeaderNames.ContentType)
            );

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}