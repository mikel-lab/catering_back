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
    public class Tipos_menusController : Controller
    {

        private ITipos_menusRepository _tipos_menusRepository;

        public Tipos_menusController(ITipos_menusRepository tipos_menusRepository)
        {
            _tipos_menusRepository = tipos_menusRepository;
        }

        //api/tipos_menus
        [HttpGet]

        public ActionResult<List<Tipo_menuDto>> GetTipos_menus()
        // public IActionResult GetTipos_menus()
        {
            var tipos_menus = _tipos_menusRepository.GetTipos_menus().ToList();
            var tipos_menusDto = new List<Tipo_menuDto>();
            foreach (var tipo_menu in tipos_menus)
            {
                tipos_menusDto.Add(new Tipo_menuDto
                {

                    Id = tipo_menu.Id,
                    Tipo = tipo_menu.Tipo

                });

            }

            return tipos_menusDto;
            //return Ok(tipos_menusDto);
        }

        //api/tipos_menus/tipo_menuId
        [HttpGet("{tipo_menuId}")]
        public ActionResult<Tipo_menuDto> GetTipo_menu(int tipo_menuId)
        //public IActionResult GetTipo_menu(int tipo_menuId)
        {
            var tipo_menu = _tipos_menusRepository.GetTipo_menu(tipo_menuId);
            var tipo_menuDto = new Tipo_menuDto()
            {
                Id = tipo_menu.Id,
                Tipo = tipo_menu.Tipo
            };


            return tipo_menuDto;
            //return Ok(tipo_menuDto);
        }
    }
}
