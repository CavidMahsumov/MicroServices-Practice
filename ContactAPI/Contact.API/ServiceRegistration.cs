using Contact.API.Infrastructure;
using Contact.API.Services;

namespace Contact.API
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IContactService, ContactService>();
        }
    }
}
