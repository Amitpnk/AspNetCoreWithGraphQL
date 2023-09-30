using GraphQlProject.Graphql.Query;

namespace GraphQlProject.Graphql.Schema
{
    public class RootSchema: GraphQL.Types.Schema
    {
        public RootSchema(IServiceProvider serviceProvider): base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
        }
    }
}
