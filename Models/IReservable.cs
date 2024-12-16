using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMaster.Models
{
    // Interface representing an entity that can be reserved
    public interface IReservable
    {
        // Creates a reservation.
        void CreateReservation();

        // Cancels a reservation.
        void CancelReservation();
    }
}
