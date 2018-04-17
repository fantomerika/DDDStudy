using Autofac;
using Autofac.Configuration;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Undefine.Repository;
using Undefine.Repository.Models;

namespace Undefine.Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            //Configuration = configuration;
            var builder = new ConfigurationBuilder().SetBasePath(env.ContentRootPath)
                .AddJsonFile("autofac.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        public IConfiguration Configuration { get; }
        public IContainer Container { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            var connection = @"Server=.;Initial Catalog=UndefineDB;User ID= sa;Password =~!@#QWER`123qwer";
            //var connection = @"Server=(localdb)\mssqllocaldb;Database=UndefineDB;Trusted_Connection=True;";
            //services.AddDbContextPool<UndefineDBContext>(options => options.UseSqlServer(connection,b=>b.MigrationsAssembly("Undefine.Web")));
            services.AddDbContext<UndefineDBContext>(options => options.UseSqlServer(connection, b => b.MigrationsAssembly("Undefine.Web")));
            services.AddMvc();
            services.AddScoped<IEFUnitOfWork, EFUnitOfWork>();

            var builder = new ContainerBuilder();
            builder.Populate(services);
            var module = new ConfigurationModule(Configuration);
            builder.RegisterModule(module); 
            this.Container = builder.Build();

            return new AutofacServiceProvider(this.Container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Default",
                    template: "{controller=Default}/{action=Index}/{id?}"
                        );
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
