using td_api.NetCore6.Connection;

namespace td_api.NetCore6
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

            builder.Services.AddTransient(_ => new ConexionBDContext(builder.Configuration.GetConnectionString("RutaWebSQL")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //swagger as default and Cors ----------------------------------------------------------
            app.UseCors(x => x
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .SetIsOriginAllowed(origin => true) // allow any origin
                        .AllowCredentials());

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("./swagger/v1/swagger.json", "v1");
                options.RoutePrefix = string.Empty;
            });

            app.UseSwagger(options =>
            {
                options.SerializeAsV2 = true;
            });
            //--------------------------------------------------------------------------------------

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}