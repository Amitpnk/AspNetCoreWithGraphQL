using GraphQL.Types;
using GraphQlProject.Model;

namespace GraphQlProject.Graphql.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Price);
            Field(m => m.Description);
        }
    }
}
