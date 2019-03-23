using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RING.Compras.Data;
using RING.Generales.Data;
using RING.Inventarios.Data;
using RING.Ventas.Data;

namespace RING.API
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
            services.AddDbContext<ComprasContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<GeneralesContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<VentasContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<InventariosContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(opt =>
                {
                    opt.SerializerSettings.ReferenceLoopHandling =
                        Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                })
            .AddJsonOptions(options => {
                options.SerializerSettings.ContractResolver =
                new Newtonsoft.Json.Serialization.DefaultContractResolver();
            });
            services.AddAutoMapper();
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

            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
