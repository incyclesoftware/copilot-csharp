
using IncycleAirways.Repositories;

namespace IncycleAirways
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IFlightManifestsRepository, InMemoryFlightManifestRepository>();
            builder.Services.AddSingleton<IPassengersRepository, InMemoryPassengersRepository>();
            builder.Services.AddSingleton<IFlightsRepository, InMemoryFlightsRepository>();


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
}
