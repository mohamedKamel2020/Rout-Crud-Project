using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.BLL.Interface;
using Demo.BLL.Interfaces;
using Demo.BLL.Repositories;
using Demo.BLL.Repository;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using Demo.PL.Mappers;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demo.PL
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
			services.AddControllersWithViews();
			services.AddDbContext<MVCAppDBContext>(options => {options.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));});
			services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddAutoMapper(M => M.AddProfile(new EmployeeProfile()));
			services.AddAutoMapper(D => D.AddProfile(new DepartmentProfile()));
			services.AddIdentity<ApplicationUser, IdentityRole>(option=>
			{
				option.Password.RequiredLength = 6;
			}).AddEntityFrameworkStores<MVCAppDBContext>()
			.AddTokenProvider<DataProtectorTokenProvider<ApplicationUser>>(TokenOptions.DefaultProvider);
			//services.AddScoped<UserManager<ApplicationUser>, UserManager<ApplicationUser>>();
			//services.AddScoped<SignInManager<ApplicationUser>,SignInManager<ApplicationUser>>();
			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(options =>
				{
					options.LoginPath = "Account/Login";
					options.AccessDeniedPath = "Home/Error";
				});
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
					pattern: "{controller=Account}/{action=Login}/{id?}");
			});
		}
	}
}
