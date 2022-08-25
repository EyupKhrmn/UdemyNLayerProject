using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using UdemyNLayerProject.API.Repository;
using UdemyNlayerProject.CORE.Repository;
using UdemyNlayerProject.CORE.Services;
using UdemyNlayerProject.CORE.UnitOfWorks;
using UdemyNLayerProject.DATA;
using UdemyNLayerProject.DATA.Repositorys;
using UdemyNLayerProject.DATA.UnitOfWorks;
using UdemyNLayerProject.SERVİCE.Services;

namespace UdemyNLayerProject.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
            

            services.AddScoped<IUnitOfWork, UnitOfwork>();
            
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:Mssql"].ToString(),
                    o => { o.MigrationsAssembly("UdemyNLayerProject.DATA"); });
            });
            
            services.AddControllers(o =>
            {
               
            });
            services.Configure<ApiBehaviorOptions>(options => { 
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddSwaggerDocument();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}