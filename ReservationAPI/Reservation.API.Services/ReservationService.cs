using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservation(int id)
        {
            return new()
            {
                Id = id,
                Amount = 100,
                BkgDate = DateTime.Now,
                CheckinDate = DateTime.Now,
                CheckoutDate = DateTime.Now,
                BkgNumber = 101
            };
        }
    }
}
