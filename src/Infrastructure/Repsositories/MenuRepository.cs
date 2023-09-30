using GraphQlProject.Model;

namespace GraphQlProject.Infrastructure.Repsositories
{
    public class MenuRepository : IMenuRepository
    {

        private static List<Menu> _menus = new List<Menu>()
        {
            new Menu(){ Id= 1, Name="Burger", Description ="burger", Price = 100},
            new Menu(){ Id= 2, Name="Salad", Description ="salad", Price = 100},
            new Menu(){ Id= 3, Name="Chocolate", Description ="chocolate", Price = 100},
            new Menu(){ Id= 4, Name="Pizza", Description ="pizza", Price = 100},
            new Menu(){ Id= 5, Name="Pasta", Description ="pasta", Price = 100},
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
