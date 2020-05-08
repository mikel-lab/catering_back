using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Modelos
{
    public class Tipo_menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Tipo { get; set; }

        [ForeignKey("Id_tipo_menu")]
        public virtual ICollection<Menu> Menus { get; set; }
    }
}
