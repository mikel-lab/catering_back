using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catering_back.Modelos;

namespace catering_back.Servicios
{
    public class IngredientesRepository : IIngredientesRepository
    {
        private CateringDbContext _ingredientesDbContext;

        public IngredientesRepository(CateringDbContext ingredientesDbContext)
        {
            _ingredientesDbContext = ingredientesDbContext;
        }

        public Ingrediente GetIngrediente(int ingredienteId)
        {
            return _ingredientesDbContext.Ingredientes.Where(i => i.Id == ingredienteId).FirstOrDefault();
        }

        public ICollection<Ingrediente> GetIngredientes()
        {
            return _ingredientesDbContext.Ingredientes.OrderBy(i => i.nombre_ingrediente).ToList();
        }

        public ICollection<Ingrediente> GetIngredientes_Menus(int menuId)
        {
            //returns the ingredients in a specific menu
            return _ingredientesDbContext.Ingredientes_menus.Where(m => m.Id_menu == menuId).Select(i => i.Ingrediente).ToList();

            //Cuidado. Para extraer estos datos hacía falta usar la tabla intermedia, no la original de ingredientes. (V.40)
        }
    }
}
