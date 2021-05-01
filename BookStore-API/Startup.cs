using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using BookStore_API.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using System.IO;
using BookStore_API.Contracts;
using BookStore_API.Services;

namespace BookStore_API
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddCors(o => o.AddPolicy("CORSPolicy",
                builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()));

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title="Book Store API", 
                    Version="V1",  
                    Description="This is a Book Store API project"
                });

                // this is to include all the xml comments in swagger document
                // it should include: c.RoutePrefix = ""; in app.UseSwaggerUI
                // get the project xml file
                var xmlfile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                // get the project folder where the xml file is
                var xmlpath = Path.Combine(AppContext.BaseDirectory, xmlfile);
                c.IncludeXmlComments(xmlpath);
            });

            // To include the logger
            services.AddSingleton<ILoggerService, LoggerService>();

            services.AddControllers();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Book Store API");
                // this is to set the default webapp route to swagger/index.html
                c.RoutePrefix = "";
            });

            app.UseHttpsRedirection();

            app.UseCors("CORSPolicy");

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
