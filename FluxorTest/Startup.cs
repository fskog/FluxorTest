using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Blazor.Fluxor;

namespace FluxorTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddFluxor(options => options.UseDependencyInjection(typeof(Startup).Assembly));
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
