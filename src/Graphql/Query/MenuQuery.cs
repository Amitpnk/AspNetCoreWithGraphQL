using GraphQL;
using GraphQL.Types;
using GraphQlProject.Graphql.Type;
using GraphQlProject.Interfaces;

namespace GraphQlProject.Graphql.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuRepository menuRepository)
        {
            Field<ListGraphType<MenuType>>("Menus").Resolve(context =>
            {
                return menuRepository.GetAllMenus();
            });

            Field<MenuType>("Menu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" })).Resolve(context =>
            {
                return menuRepository.GetMenuById(context.GetArgument<int>("menuId"));
            });
        }
    }
}
