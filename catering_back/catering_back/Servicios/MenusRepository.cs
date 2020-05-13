using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catering_back.Modelos;

namespace catering_back.Servicios
{
    public class MenusRepository : IMenusRepository
    {

        private CateringDbContext _menusDbContext;

        public MenusRepository(CateringDbContext menusDbContext)
        {
            _menusDbContext = menusDbContext;
        }

        //GETS

      

        public Menu GetMenu(int menuId)
        {
            return _menusDbContext.Menus.Where(m => m.Id == menuId).FirstOrDefault();
        }

        public Reserva GetMenuReservado(int menuId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Menu> GetMenus()
        {
            return _menusDbContext.Menus.OrderBy(m => m.Nombre).ToList();
        }

        public Tipo_menu GetTipo_Menu(int menuId)
        {
            //Returns the type (meat or fish) of a menu
            // return _menusDbContext.Tipos_menus.Where(m => m.Id == menuId).Select(tm => tm.Tipo).FirstOrDefault();
            throw new NotImplementedException();
        }

        public ICollection<Menu> GetMenusReserva(int reservaId)
        {
            return _menusDbContext.Menus.Where(m => m.Id == reservaId).ToList();
        }

        public ICollection<Menu> GetMenusCarne(int Tipo_menu)
        {
            return _menusDbContext.Menus.Where(m => m.Id_tipo_menu == Tipo_menu).ToList();
        }

        public ICollection<Menu> GetMenusPescado(int Tipo_menu)
        {
            return _menusDbContext.Menus.Where(m => m.Id_tipo_menu == Tipo_menu).ToList();
        }
    }
}
