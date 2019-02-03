using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using TKDTheoryApi.Data;
using TKDTheoryApi.Models;

namespace TKDTheoryApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var dbConnection = Configuration.GetConnectionString("db");

            services.AddDbContext<DbLokisaurTKDTheoryAppContext>(options => options.UseSqlServer(dbConnection));
            services.AddScoped<IDbContext, DbLokisaurTKDTheoryAppContext>();
            services.AddScoped<ITKDTheoryAppContext, TKDTheoryAppContext>();
            services.AddScoped<IMapper, Mapper>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Taekwondo Theory App", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Taekwondo Theory API");
                c.RoutePrefix = string.Empty;
            });


            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
