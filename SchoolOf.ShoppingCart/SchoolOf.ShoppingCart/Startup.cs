using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SchoolOf.Common;
using SchoolOf.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolOf.ShoppingCart
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)//optionala
        {
            //mapare de diferite servicii
            //dep injection=componentele nu trebuie sa depinda de clasele concrete ci de abstr
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SchoolOf.ShoppingCart", Version = "v1" });
            });
            services.AddScoped<DatabaseContext>();
            services.AddScoped< UnitOfWork, UnitOfWork > ();
                
            services.Configure<DbSettings>(Configuration.GetSection(nameof(DbSettings)));//aduc informatiile din appsetings
            //scoped=va fi returnata aceeasi instanta de clasa 
            //transient=in acelasi scenariu, ai un req si 7 servicii, toate cele 7 serv vor primi o instanta noua
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SchoolOf.ShoppingCart v1"));
            }
            //conteaza ordinea 
            app.UseHttpsRedirection();

            app.UseRouting();

           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
