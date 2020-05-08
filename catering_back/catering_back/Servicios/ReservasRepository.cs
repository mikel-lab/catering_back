using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catering_back.Modelos;

namespace catering_back.Servicios
{
    public class ReservasRepository : IReservasRepository
    {
        private CateringDbContext _reservasDbContext;

        public ReservasRepository(CateringDbContext reservasDbContext)
        {
            _reservasDbContext = reservasDbContext;
        }

        public bool CreateReserva(Reserva reserva)
        {
            _reservasDbContext.Add(reserva);
            return Save();
        }

        public bool DeleteReserva(Reserva reserva)
        {
            _reservasDbContext.Remove(reserva);
            return Save();
        }

        

        public Reserva GetReserva(int reservaId)
        {
            return _reservasDbContext.Reservas.Where(r => r.Id == reservaId).FirstOrDefault();
        }

        public ICollection<Reserva> GetReservas()
        {
            return _reservasDbContext.Reservas.OrderBy(r => r.Id).ToList();
        }

        public bool Save()
        {
            var guardado = _reservasDbContext.SaveChanges();
            return guardado >= 0 ? true : false;
        }

        public bool UpdateReserva(Reserva reserva)
        {
            _reservasDbContext.Update(reserva);
            return Save();
        }
    }
}
