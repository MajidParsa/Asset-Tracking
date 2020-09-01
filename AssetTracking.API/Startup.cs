using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace AssetTracking
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
			services.AddCors(options =>
			{
				options.AddPolicy("CorsPolicy",
					builder => builder
						.SetIsOriginAllowed((host) => true)
						.AllowAnyMethod()
						.AllowAnyHeader()
						.AllowCredentials());
			});

			services.AddControllers();
			services.AddSwaggerGen(c =>
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "Asset Tracking API",
					Description = "A simple example ASP.NET Core Web API",
					//TermsOfService = new Uri("https://example.com/terms"),
					//Contact = new OpenApiContact
					//{
					//	Name = "Shayne Boyer",
					//	Email = string.Empty,
					//	Url = new Uri("https://twitter.com/spboyer"),
					//},
					//License = new OpenApiLicense
					//{
					//	Name = "Use under LICX",
					//	Url = new Uri("https://example.com/license"),
					//}
				}));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseCors("CorsPolicy");

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});

			app.UseSwagger();
			app.UseSwaggerUI(
				c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Asset Tracking API V1")
			);
		}
	}
}
