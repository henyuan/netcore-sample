using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace sample
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        // 运行时调用此方法。使用此方法向容器添加服务。
        public void ConfigureServices(IServiceCollection services) => services.AddMvc();
        // 运行时调用此方法。使用此方法配置HTTP请求管道。
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseStatusCodePagesWithReExecute("/errors/{0}");
            app.UseExceptionHandler("/errors/{0}");
            app.UseMvc();
        }
    }
}