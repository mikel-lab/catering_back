using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Modelos
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "El nombre del menu no puede tener más de 100 caracteres")]
        public string Id_menu { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Direccion { get; set; }

        [ForeignKey("Id_reserva")]
        public virtual ICollection<Menu> Menus { get; set; }
    }
}
