using System;

namespace Reservations
{
    public interface IVacationPartFactory
    {
        IVacationPart CreateHotelReservation(string town, string hotelName, DateTime arrivalDate, DateTime leaveDate);
        IVacationPart CreateFlight(string companyName, string source, string destination, DateTime date);
        IVacationPart CreateFerryBooking(string lineName, bool fromMainland, DateTime date);
        IVacationPart CreateDailyTrip(string tripName, DateTime date);
        IVacationPart CreateMessage(string salon, DateTime date);
    }
}