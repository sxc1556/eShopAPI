using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Interfaces.Services;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace eShopAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddDbContext<EShopDbContext>(option =>
        {
            option.UseSqlServer(builder.Configuration.GetConnectionString("EShopDBConnection"), 
                b => b.MigrationsAssembly("Infrastructure")); // Specify the migrations assembly
        });
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddAutoMapper(typeof(Program));
        #region service injection

        builder.Services.AddScoped<ICustomerServiceAsync, CustomerServiceAsync>();
        builder.Services.AddScoped<IProductServiceAsync, ProductServiceAsync>();
        #endregion

        #region repository injection

        builder.Services.AddScoped<ICustomerRepositoryAsync, CustomerRepositoryAsync>();
        builder.Services.AddScoped<IProductRepositoryAsync, ProductRepositoryAsync>();

        #endregion
        var app = builder.Build();
        
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}