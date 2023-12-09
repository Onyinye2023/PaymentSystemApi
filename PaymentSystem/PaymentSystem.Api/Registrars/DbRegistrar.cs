using Microsoft.EntityFrameworkCore;
using PaymentSystem.Dal;

namespace PaymentSystem.Api.Registrars
{
    public class DbRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var cs = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(cs));
        }
    }
}
