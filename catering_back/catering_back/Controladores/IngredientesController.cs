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
    public class IngredientesController
    {
        private IIngredientesRepository _ingredienteRepository;

        public IngredientesController(IIngredientesRepository ingredienteRepository)
        {
            _ingredienteRepository = ingredienteRepository;
        }

        //api/ingredientes
        [HttpGet]
        //public IActionResult GetIngredientes()
        public ActionResult<List<IngredienteDto>> GetIngredientes()
        {
            var ingredientes = _ingredienteRepository.GetIngredientes().ToList();
            var ingredientesDto = new List<IngredienteDto>();
            foreach (var ingrediente in ingredientes)
            {
                ingredientesDto.Add(new IngredienteDto
                {

                   Id=ingrediente.Id,
                   nombre_ingrediente=ingrediente.nombre_ingrediente

                });

            }

            return ingredientesDto;
            //return Ok(ingredientesDto);
        }

        // private IActionResult Ok(List<IngredienteDto> ingredientesDto)
        //{
        //   throw new NotImplementedException();
        //}



        //api/ingredientes/ingredienteId
        [HttpGet("{ingredienteId}")]
        // public IActionResult GetIngrediente(int ingredienteId)
        public ActionResult<IngredienteDto> GetIngrediente(int ingredienteId)
        {

            var ingrediente = _ingredienteRepository.GetIngrediente(ingredienteId);
            var ingredienteDto = new IngredienteDto()
            {
                Id = ingrediente.Id,
                nombre_ingrediente = ingrediente.nombre_ingrediente

            };

            return ingredienteDto;
            //return Ok(ingredienteDto);
        }

        // private IActionResult Ok(IngredienteDto ingredienteDto)
        //{
        //   throw new NotImplementedException();
        //}


        //api/ingredientes/menus/menuId
        [HttpGet("ingredientes/menus{menuId}")]
        public ActionResult<List<IngredienteDto>> GetIngredientesDeUnMenu(int menuId)
        //public IActionResult GetIngredientesDeUnMenu(int menuId)
        {
            var ingredientes = _ingredienteRepository.GetIngredientes_Menus(menuId);


            var ingredientesDto = new List<IngredienteDto>();
            foreach (var ingrediente in ingredientes)
            {
                ingredientesDto.Add(new IngredienteDto()
                {
                    Id = ingrediente.Id,
                    nombre_ingrediente = ingrediente.nombre_ingrediente
                });
            }

            return ingredientesDto;
            //return Ok(ingredientesDto);
        }
    }
}
