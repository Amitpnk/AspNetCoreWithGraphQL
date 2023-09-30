using GraphQlProject.Model;

namespace GraphQlProject.Infrastructure.Repsositories
{
    public class ReservationRepository : IReservationRepository
    {
        private static List<Reservation> _reservations = new List<Reservation>()
        {
            new Reservation(){ Id= 1, CustomerName="cust1", CustomerEmail ="cust1@example.com", CustomerPhone ="123", PartySize=2, SpecialRequest="req1", ReservatinDate=DateTime.Now.AddDays(7)},
            new Reservation(){ Id= 2, CustomerName="cust2", CustomerEmail ="cust2@example.com", CustomerPhone ="365", PartySize=5, SpecialRequest="req2", ReservatinDate=DateTime.Now.AddDays(10)},
            new Reservation(){ Id= 3, CustomerName="cust3", CustomerEmail ="cust3@example.com", CustomerPhone ="986", PartySize=4, SpecialRequest="req3", ReservatinDate=DateTime.Now.AddDays(14)},
        };
        public Reservation AddReservation(Reservation reservation)
        {
            _reservations.Add(reservation);
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return _reservations;
        }
    }
}
