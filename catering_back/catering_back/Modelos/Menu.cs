using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Modelos
{
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Foto { get; set; }

        public int Id_tipo_menu { get; set; }

        public string Ingredientes_menu { get; set; }

        public int Id_reserva { get; set; }

        public virtual Reserva Reserva { get; set; }

        public virtual ICollection<Ingrediente_menu> Ingredientes_Menus { get; set; }

        public virtual Tipo_menu Tipo_menu { get; set; }
    }
}
