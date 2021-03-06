﻿using catering_back.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Servicios
{
   public interface IMenusRepository
    {
        ICollection<Menu> GetMenus();

        ICollection<Menu> GetMenusCarneOPescado(int Tipo_menu);

        //ICollection<Menu> GetMenusPescado(int Tipo_menu);

        Menu GetMenu(int menuId);


        ICollection<Menu> GetMenusReserva(int reservaId);

        Reserva GetMenuReservado(int menuId);

         //ICollection<Ingrediente> GetIngredientes_Menus(int menuId);

        Tipo_menu GetTipo_Menu(int menuId);


    }
}
