using GraphQL.Types;
using GraphQlProject.Model;

namespace GraphQlProject.Graphql.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(m => m.Id);
            Field(m => m.CustomerName);
            Field(m => m.CustomerEmail);
            Field(m => m.CustomerPhone);
            Field(m => m.PartySize);
            Field(m => m.SpecialRequest);
            Field(m => m.ReservatinDate);
        }
    }
}
