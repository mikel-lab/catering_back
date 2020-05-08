using catering_back.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Servicios
{
     public interface IIngredientesRepository
    {
        ICollection<Ingrediente> GetIngredientes();

        Ingrediente GetIngrediente(int ingredienteId);

        ICollection<Ingrediente> GetIngredientes_Menus(int menuId); //Arreglo
    }
}
