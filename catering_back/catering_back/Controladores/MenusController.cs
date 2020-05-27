using catering_back.Dtos;
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
    public class MenusController : Controller
    {

        private IMenusRepository _menuRepository;

        public MenusController(IMenusRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        //api/menus 
        [HttpGet]
        public ActionResult<List<MenuDto>> GetMenus()
        // public IActionResult GetMenus()
        {
            var menus = _menuRepository.GetMenus().ToList();
    
            var menusDto = new List<MenuDto>();
            foreach (var menu in menus)
            {
                menusDto.Add(new MenuDto
                {

                    Id = menu.Id,
                    Nombre = menu.Nombre,
                    Foto = menu.Foto,
                    Id_reserva = menu.Id_reserva,
                    Id_tipo_menu = menu.Id_tipo_menu,
                    Ingredientes_menu = menu.Ingredientes_menu

                });

            }
            return menusDto;
            //return Ok(menusDto);
        }

        //api/menus/tipos_menus/Tipo_menu 
        [HttpGet("tipos_menus/{Tipo_menu}")]
        public ActionResult<List<MenuDto>> GetMenusCarneOPescado(int Tipo_menu)
        
        {
            var menus = _menuRepository.GetMenusCarneOPescado(Tipo_menu).ToList();

            var menusDto = new List<MenuDto>();
            foreach (var menu in menus)
            {
                menusDto.Add(new MenuDto
                {

                    Id = menu.Id,
                    Nombre = menu.Nombre,
                    Foto = menu.Foto,
                    Id_reserva = menu.Id_reserva,
                    Ingredientes_menu = menu.Ingredientes_menu

                });

            }
            return menusDto;
            ;
        }

        //api/menus/tipos_menus/Tipo_menu 
        //[HttpGet("tipos_menus/{Tipo_menu}")]
        // public ActionResult<List<MenuDto>> GetMenusPescado(int Tipo_menu)

        // {
        // var menus = _menuRepository.GetMenusPescado(Tipo_menu).ToList();

        // var menusDto = new List<MenuDto>();
        // foreach (var menu in menus)
        // {
        // menusDto.Add(new MenuDto
        // {

        // Id = menu.Id,
        // Nombre = menu.Nombre,
        //Foto = menu.Foto,
        // Id_reserva = menu.Id_reserva,
        // Ingredientes_menu = menu.Ingredientes_menu

        // });

        // }
        // return menusDto;
        // ;
        //}

        //api/menus/menuId
        [HttpGet("{menuId}")]
        public ActionResult<MenuDto> GetMenu(int menuId)
        //public IActionResult GetMenu(int menuId)
        {
            var menu = _menuRepository.GetMenu(menuId);
            var menuDto = new MenuDto()
            {
                Id = menu.Id,
                Nombre = menu.Nombre,
                Foto = menu.Foto,
                Id_reserva = menu.Id_reserva,
                Id_tipo_menu = menu.Id_tipo_menu,
                Ingredientes_menu = menu.Ingredientes_menu
            };


            return menuDto;
            //return Ok(menuDto);
        }

        //api/menus/reservas/reservaId
        [HttpGet("reservas/{reservaId}")]
        public ActionResult<List<MenuDto>> GetMenusReserva(int reservaId)
        // public IActionResult GetMenusReserva(int reservaId)
        {
            var menus = _menuRepository.GetMenusReserva(reservaId);


            var menusDto = new List<MenuDto>();
            foreach (var menu in menus)
            {
                menusDto.Add(new MenuDto()
                {
                    Nombre = menu.Nombre,
                    Ingredientes_menu = menu.Ingredientes_menu
                });
            }

            return menusDto;
            //return Ok(menusDto);
        }

    }
}


