
using System.IO.Pipes;

namespace ProjectFlowPro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var environment = builder.Configuration.GetValue<string>("ENV_FILE");
            DotNetEnv.Env.Load(environment!);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            ServiceInjections(builder);
            RepositoryInjections(builder);
            UtilityInjections(builder);

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

        private static void ServiceInjections(WebApplicationBuilder builder)
        {

        }

        private static void RepositoryInjections(WebApplicationBuilder builder)
        {

        }

        private static void UtilityInjections(WebApplicationBuilder builder)
        {

        }
    }
}