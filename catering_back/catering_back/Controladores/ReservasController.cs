using catering_back.Dtos;
using catering_back.Modelos;
using catering_back.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : Controller
    {
        private IReservasRepository _reservaRepository;
        private IMenusRepository _menuRepository;

        public ReservasController(IReservasRepository reservaRepository, IMenusRepository menuRepository)
        {
            _reservaRepository = reservaRepository;
            _menuRepository = menuRepository;
        }

        //api/reservas
        [HttpGet]
        public ActionResult<List<ReservaDto>> GetReservas()
        //public IActionResult GetReservas()
        {
            var reservas = _reservaRepository.GetReservas().ToList();
            var reservasDto = new List<ReservaDto>();
            foreach (var reserva in reservas)
            {
                reservasDto.Add(new ReservaDto
                {

                    Id = reserva.Id,
                    Id_menu = int.Parse(reserva.Id_menu), //la ID del menú la configuré como STRING por error. He tenido que parsearla.
                    Direccion = reserva.Direccion,
                    Email = reserva.Email,
                    Estado = reserva.Estado

                });

            }

            return reservasDto;
           // return Ok(reservasDto);
        }

        //api/reservas/reservaId
        [HttpGet("reservas/{reservaId}", Name = "GetReserva")]
        public ActionResult<ReservaDto> GetReserva(int reservaId)
       // public IActionResult GetReserva(int reservaId)
        {
            var reserva = _reservaRepository.GetReserva(reservaId);
            var reservaDto = new ReservaDto()
            {
                Id = reserva.Id,
                Id_menu = int.Parse(reserva.Id_menu),
                Direccion = reserva.Direccion,
                Email = reserva.Email,
                Estado = reserva.Estado
            };


            return reservaDto;
           // return Ok(reservaDto);
        }
        

        //api/reservas
        [HttpPost]
        public IActionResult CreateReserva([FromBody] Reserva reservaParaCrear)
        {
            //Añadimos la ID de los menus seleccionado a la reserva creada:
           // reservaParaCrear.Menus = _menuRepository.GetMenu(reservaParaCrear.Id_menu);

            _reservaRepository.CreateReserva(reservaParaCrear);

            return CreatedAtRoute("GetReserva", reservaParaCrear);
        }

        //api/reservas/reservaId
        [HttpPost("{reservaId}")]
        public IActionResult UpdateReserva(int reservaId, [FromBody] Reserva reservaParaActualizar)
        {
            //reservaParaActualizar.Menus = _menuRepository.GetMenu(reservaParaActualizar.Id_menu);

            _reservaRepository.UpdateReserva(reservaParaActualizar);

            return NoContent();
        }

        //api/reservas/reservaId
        [HttpDelete("{reservaId}")]
        public IActionResult DeleteReserva(int reservaId)
        {
            var reservaParaBorrar = _reservaRepository.GetReserva(reservaId);
            _reservaRepository.DeleteReserva(reservaParaBorrar);

            return NoContent();
        }
    }
}

