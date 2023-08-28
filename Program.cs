
using E_Commerce.Repository.Abstract;
using E_Commerce.Repository.Concrete.EfCore;

namespace E_Commerce
{
    public class Program
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductRepository,EfCoreProductRepository>();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app)
        {

        }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddScoped<IProductRepository,EfCoreProductRepository>();
            //builder.Services.AddControllers();
            //Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();
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