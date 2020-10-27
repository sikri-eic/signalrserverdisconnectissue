using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SignalRConnectionTest.Hubs;
using SignalRConnectionTest.Services;

namespace SignalRConnectionTest
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Service1>();
            services.AddSingleton<Service2>();
            services.AddSingleton<Service3>();
            services.AddControllers();
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<Hub1>("/signalr/hubs/hub1");
                endpoints.MapHub<Hub2>("/signalr/hubs/hub2");
                endpoints.MapHub<Hub3>("/signalr/hubs/hub3");
                endpoints.MapHub<Hub4>("/signalr/hubs/hub4");
                endpoints.MapHub<Hub5>("/signalr/hubs/hub5");
            });
        }
    }
}
