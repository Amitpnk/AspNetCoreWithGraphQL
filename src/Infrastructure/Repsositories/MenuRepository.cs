using GraphQlProject.Model;

namespace GraphQlProject.Infrastructure.Repsositories
{
    public class MenuRepository : IMenuRepository
    {

        private static List<Menu> _menus = new List<Menu>()
        {
            new Menu(){ Id= 1, Name="Burger", Description ="burger", Price = 105, CategoryId =1, ImageUrl="burger.jpg"},
            new Menu(){ Id= 2, Name="Salad", Description ="salad", Price = 206, CategoryId =3, ImageUrl="salad.jpg"},
            new Menu(){ Id= 3, Name="Chocolate", Description ="chocolate", Price = 354, CategoryId =2, ImageUrl="chocolate.jpg"},
            new Menu(){ Id= 4, Name="Pizza", Description ="pizza", Price = 150, CategoryId =1, ImageUrl="pizza.jpg"},
            new Menu(){ Id= 5, Name="Pasta", Description ="pasta", Price = 250, CategoryId =3, ImageUrl="pasta.jpg"},
        };


        public Menu AddMenu(Menu menu)
        {
            _menus.Add(menu);
            return menu;
        }

        public void DeleteMenu(int id)
        {
            _menus.RemoveAt(id);
        }

        public List<Menu> GetAllMenus()
        {
            return _menus;
        }

        public Menu GetMenuById(int id)
        {
            return _menus.Find(x => x.Id == id);
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            _menus[id] = menu;
            return menu;
        }
    }
}
