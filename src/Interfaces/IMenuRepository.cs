using GraphQlProject.Model;

namespace GraphQlProject.Interfaces
{
    public interface IMenuRepository
    {
        List<Menu> GetAllMenus();
        Menu GetMenuById(int id);
        Menu AddMenu(Menu menu);
        Menu UpdateMenu(int id, Menu menu);
        void DeleteMenu(int id);
    }
}
