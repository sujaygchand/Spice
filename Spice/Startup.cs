using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Spice.Service;
using Spice.Utilities;
using Stripe;

namespace Spice
{
	public class Startup
	{
		public double SessionTimeLimit { get; private set; } = 45;

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("DefaultConnection")));
			services.AddIdentity<IdentityUser, IdentityRole>()
				.AddDefaultTokenProviders()
				.AddDefaultUI()
				.AddEntityFrameworkStores<ApplicationDbContext>();

			services.AddControllersWithViews();
			services.AddRazorPages().AddRazorRuntimeCompilation();
			services.AddScoped<IDbInitialiser, DbInitialiser>();
			services.AddSingleton<IEmailSender, EmailSender>();

			services.AddAuthentication().AddFacebook(facebookOptions => 
			{
				facebookOptions.AppId = SessionDetails.FacebookAppId;
				facebookOptions.AppSecret = SessionDetails.FacebookSecretKey;

			});

			services.AddAuthentication().AddGoogle(googleOptions =>
			{
				googleOptions.ClientId = SessionDetails.GoogleClientId;
				googleOptions.ClientSecret = SessionDetails.GoogleSecretKey;			
			});

			services.ConfigureApplicationCookie(options =>
			{
				options.LoginPath = $"/Identity/Account/Login";
				options.LogoutPath = $"/Identity/Account/Logout";
				options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
			});

			services.AddSession(options =>
			{
				options.Cookie.IsEssential = true;
				options.IdleTimeout = TimeSpan.FromMinutes(45);
				options.Cookie.HttpOnly = true;

			});

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDbInitialiser dbInitialiser)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			dbInitialiser.Initialise();
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			app.UseSession();
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");
				endpoints.MapRazorPages();
			});
		}
	}
}
