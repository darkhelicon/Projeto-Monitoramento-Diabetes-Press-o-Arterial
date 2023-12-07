using APIHM.Services;
using APIHM.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Repository;
using Repository.Context;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using System;
using System.IO;
using System.Reflection;

namespace APIHM
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
            services.AddAutoMapper(typeof(Startup));
            services.AddCors();

            addScope(services);

            services.AddCors(options =>
                        options.AddPolicy("MyPolicy",
                        builder =>
                        {
                            builder
                                .AllowAnyMethod()
                                .AllowAnyHeader()
                                .AllowAnyOrigin();
                        }));

            services.AddControllers();

            services.AddSwaggerGen();
        }

        private void addScope(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddDbContext<EFContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"],
                b => b.MigrationsAssembly("APIHM")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IHiperRepository, HiperRepository>();
            services.AddScoped<IHiperService, HiperService>();
            services.AddScoped<IGlicoRepository, GlicoRepository>();
            services.AddScoped<IGlicoService, GlicoService>();
            services.AddScoped<IExtraRepository, ExtraRepository>();
            services.AddScoped<IExtraService, ExtraService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder
                                .AllowAnyMethod()
                                .AllowAnyHeader()
                                .AllowAnyOrigin());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}