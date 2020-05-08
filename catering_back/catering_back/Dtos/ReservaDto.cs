using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Dtos
{
    public class ReservaDto
    {
        public int Id { get; set; }

      
        public int Id_menu { get; set; }

        
        public string Estado { get; set; }

       
        public string Email { get; set; }

        
        public string Direccion { get; set; }
    }
}
