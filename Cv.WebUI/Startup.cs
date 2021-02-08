using Cv.Business.Abstract;
using Cv.Business.Concrete;
using Cv.DataAccess.Abstract;
using Cv.DataAccess.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cv.WebUI
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
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(opt=>
    {
        opt.Cookie.HttpOnly = true;
        opt.Cookie.Name = "CvCookie";
        opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
        opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;


        opt.ExpireTimeSpan = TimeSpan.FromMinutes(90);
        opt.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Auth/Login");
    });
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IAppUserDal, EfAppUserDal>(); 
            
            services.AddScoped<ICertificationService, CertificationService>();
            services.AddScoped<ICertificationDal, EfCertificationDal>(); 
            
            services.AddScoped<IEducationService, EducationService>();
            services.AddScoped<IEducationDal, EfEducationDal>();

            services.AddScoped<IExperienceService, ExperienceService>();
            services.AddScoped<IExperienceDal, EfExperienceDal>();

            services.AddScoped<IInterestService, InterestService>();
            services.AddScoped<IInterestDal, EfInterestDal>(); 
            
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<ISkillDal, EfSkillDal>();
            
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectDal, EfProjectDal>();
            
            services.AddScoped<IReferenceService, ReferenceService>();
            services.AddScoped<IReferenceDal, EfReferenceDal>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Default}/{action=Index}/{id?}");
            });
        }
    }
}
