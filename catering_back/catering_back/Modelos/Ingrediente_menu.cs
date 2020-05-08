using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Modelos
{
    public class Ingrediente_menu
    {
        public int Id_menu { get; set; }

        public int Id_ingrediente { get; set; }

        public virtual Ingrediente Ingrediente { get; set; }

        public virtual Menu Menu { get; set; }

    }
}
