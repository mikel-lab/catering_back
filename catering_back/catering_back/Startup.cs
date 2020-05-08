using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catering_back.Servicios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace catering_back
{
    public class Startup
    {

        

        public static IConfiguration Configuration { get; set;}

        //constructor de la clase Startup
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {



            services.AddMvc();
            services.AddCors();
            var connectionString = Configuration["connectionStrings:cateringDbConnectionString"];
            services.AddDbContext<CateringDbContext>(c => c.UseSqlServer(connectionString));

            services.AddScoped<IMenusRepository,MenusRepository>();
            services.AddScoped<IIngredientesRepository, IngredientesRepository>();
            services.AddScoped<ITipos_menusRepository, Tipos_menusRepository>();
            services.AddScoped<IReservasRepository, ReservasRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.Run(async (context) =>
            // {
            //  await context.Response.WriteAsync("Hello World!");
            // });

            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseMvc();

            app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .WithExposedHeaders("Content-Disposition")
            );
        }
    }
}
