using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catering_back.Modelos;

namespace catering_back.Servicios
{
    public class Tipos_menusRepository : ITipos_menusRepository
    {

        private CateringDbContext _tipos_menusDbContext;

        public Tipos_menusRepository(CateringDbContext tipos_menusDbContext)
        {
            _tipos_menusDbContext = tipos_menusDbContext;
        }

   
        public ICollection<Tipo_menu> GetTipos_menus()
        {
            return _tipos_menusDbContext.Tipos_menus.OrderBy(tm => tm.Tipo).ToList();
        }

        public Tipo_menu GetTipo_menu(int tipoId)
        {
            return _tipos_menusDbContext.Tipos_menus.Where(tm => tm.Id == tipoId).FirstOrDefault();
        }
    }
}
