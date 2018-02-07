using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Panel.Models;
using Panel.ViewModels;

namespace Panel
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
   services.AddDbContext<PizzaContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
   services.AddSingleton(Configuration);
   services.AddScoped<IMyRepository, MyRepository>();
   services.AddMvc();
  }

  // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
  public void Configure(IApplicationBuilder app, IHostingEnvironment env)
  {
   if (env.IsDevelopment())
   {
    app.UseDeveloperExceptionPage();
    app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
    {
     HotModuleReplacement = true
    });
   }
   else
   {
    app.UseExceptionHandler("/Home/Error");
   }
   AutoMapper.Mapper.Initialize(config =>
   {
    config.CreateMap<OrderViewModel, Order>().ReverseMap();
    config.CreateMap<DishViewModel, Dish>().ReverseMap();
   });

   app.UseStaticFiles();

   app.UseMvc(routes =>
   {
    routes.MapRoute(
                 name: "default",
                 template: "{controller=Home}/{action=Index}/{id?}");

    routes.MapSpaFallbackRoute(
                 name: "spa-fallback",
                 defaults: new { controller = "Home", action = "Index" });
   });
  }
 }
}
