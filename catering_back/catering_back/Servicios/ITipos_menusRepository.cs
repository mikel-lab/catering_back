using catering_back.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Servicios
{
    public interface ITipos_menusRepository
    {
        ICollection<Tipo_menu> GetTipos_menus();

        Tipo_menu GetTipo_menu(int tipoId);
    }
}
