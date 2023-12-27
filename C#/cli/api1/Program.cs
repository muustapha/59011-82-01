using API1.Models.data.Services;
using API1.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace API1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<MyFootballDbContext>(options =>
            options.UseMySQL(builder.Configuration.GetConnectionString("Default")));
            builder.Services.AddControllersWithViews();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<JoueursServices>(); 
            builder.Services.AddTransient<ArbitresServices>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddControllers().AddNewtonsoftJson();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}