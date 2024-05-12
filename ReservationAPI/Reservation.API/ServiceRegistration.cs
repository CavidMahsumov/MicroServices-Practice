using Reservation.API.Infrastructure;
using Reservation.API.Services;

namespace Reservation.API
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection service)
        {
            service.AddScoped<IReservationService, ReservationService>();
        }
    }
}
