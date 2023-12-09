using PaymentSystem.Dal.Repositories;
using PaymentSystem.Domain.Abstractions;

namespace PaymentSystem.Api.Registrars
{
    public class MvcRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddScoped<IMerchantRepository, MerchantRepository>();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
           

        }



    }
}
