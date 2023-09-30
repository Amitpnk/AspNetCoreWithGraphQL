using GraphQL;
using GraphQL.Types;
using GraphQlProject.Graphql.Type;
using GraphQlProject.Infrastructure.Repsositories;

namespace GraphQlProject.Graphql.Query
{
    public class CategoryQuery : ObjectGraphType
    {
        public CategoryQuery(ICategoryRepository  categoryRepository)
        {
            Field<ListGraphType<CategoryType>>("Categories").Resolve(context =>
            {
                return categoryRepository.GetCategories();
            });
        }
    }
}
