using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace pTopicos02
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/api/calculator/sumar", async context =>
                {
                    var numero1 = int.Parse(context.Request.Query["numero1"]);
                    var numero2 = int.Parse(context.Request.Query["numero2"]);
                    var resultado = numero1 + numero2;

                    await context.Response.WriteAsJsonAsync(new { resultado });
                });
            });
        }
    }
}
