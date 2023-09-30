using GraphQL.Types;
using GraphQlProject.Infrastructure.Repsositories;
using GraphQlProject.Model;

namespace GraphQlProject.Graphql.Type
{
    public class CategoryType : ObjectGraphType<Category>
    {
        //For nested query
        public CategoryType(IMenuRepository menuRepository)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            Field<ListGraphType<MenuType>>("Menus").Resolve(context =>
            {
                return menuRepository.GetAllMenu();
            });

        }
    }
}
