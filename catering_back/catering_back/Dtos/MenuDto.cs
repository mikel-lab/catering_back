using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Dtos
{
    public class MenuDto
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Foto { get; set; }

        public int Id_tipo_menu { get; set; }

        public string Ingredientes_menu { get; set; }

        public int Id_reserva { get; set; }

    }
}
