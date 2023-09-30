using GraphQL.Types;
using GraphQlProject.Model;

namespace GraphQlProject.Graphql.Type
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
        }
    }
}
