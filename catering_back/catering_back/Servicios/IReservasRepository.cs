using catering_back.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Servicios
{
     public interface IReservasRepository
    {
        ICollection<Reserva> GetReservas();

        //ICollection<Menu> GetMenusReserva(int reservaId);

        Reserva GetReserva(int tipoId);



        bool CreateReserva(Reserva reserva);
        bool UpdateReserva(Reserva reserva);
        bool DeleteReserva(Reserva reserva);
        bool Save();
    }
}

