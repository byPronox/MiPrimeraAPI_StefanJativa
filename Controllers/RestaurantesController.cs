using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimeraAPI_StefanJativa.Models;
using MiPrimeraAPI_StefanJativa.Repositories;

namespace MiPrimeraAPI_StefanJativa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantesController : ControllerBase
    {
        [HttpGet]
        [Route("InformacionRestaurante")]
        public ActionResult DevuelveRestaurante(int id)
        {
            try
            {
                RestauranteRepository repo = new RestauranteRepository();
                var restaurantes = repo.DevuelveRestaurantes();


                if (restaurantes.Any(x=>x.Id == id ))
                {
                    var info_restaurante = restaurantes.Find(x => x.Id == id);

                    return Ok(info_restaurante);
                }
                else
                {
                    return NotFound();
                }

                
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            
        }

        [HttpGet]
        [Route("InformacionRestaurantes")]
        public List<Restaurante> DevuelveListadoRestaurante()
        {
            RestauranteRepository repo = new RestauranteRepository();
            return repo.DevuelveRestaurantes();
        }

    }
}
