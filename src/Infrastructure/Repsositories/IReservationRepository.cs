using GraphQlProject.Model;

namespace GraphQlProject.Infrastructure.Repsositories
{
    public interface IReservationRepository
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);

    }
}
