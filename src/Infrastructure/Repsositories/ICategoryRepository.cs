using GraphQlProject.Model;

namespace GraphQlProject.Infrastructure.Repsositories
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
        Category AddCategory(Category category);
        Category UpdateCategory(int id,Category category);
        void DeleteCategory(int id);

    }
}
