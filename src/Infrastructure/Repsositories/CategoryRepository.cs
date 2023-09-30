using GraphQlProject.Model;

namespace GraphQlProject.Infrastructure.Repsositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category(){ Id= 1, Name="Main course", ImageUrl ="main-course.jpg"},
            new Category(){ Id= 2, Name="Desserts", ImageUrl="desserts.jpg"},
            new Category(){ Id= 3, Name="Breakfast", ImageUrl="breakfast.jpg"},
        };


        public Category AddCategory(Category category)
        {
            _categories.Add(category);
            return category;
        }

        public void DeleteCategory(int id)
        {
            _categories.RemoveAt(id);
        }

        public List<Category> GetCategories()
        {
            return _categories;
        }

        public Category UpdateCategory(int id, Category category)
        {
            _categories[id] = category;
            return category;
        }
    }
}
