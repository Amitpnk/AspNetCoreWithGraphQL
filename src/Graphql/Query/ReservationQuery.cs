using GraphQL;
using GraphQL.Types;
using GraphQlProject.Graphql.Type;
using GraphQlProject.Infrastructure.Repsositories;

namespace GraphQlProject.Graphql.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservationRepository reservationRepository)
        {
            Field<ListGraphType<ReservationType>>("Reservations").Resolve(context =>
            {
                return reservationRepository.GetReservations();
            });
        }
    }
}
