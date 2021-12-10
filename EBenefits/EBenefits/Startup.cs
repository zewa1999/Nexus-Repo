using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBenefits
{
    public class Startup
    {
        public void Configure(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/nexusbenefits", async context =>
            {
                await context.Response.WriteAsync("nexusbenefits");
            });
        }
    }
}
