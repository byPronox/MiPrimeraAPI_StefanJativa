using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimeraAPI_StefanJativa.Models;
using MiPrimeraAPI_StefanJativa.Repositories;

namespace MiPrimeraAPI_StefanJativa.Controllers
{
    [Route("api/[controller]")]//Asigna la ruta base
    [ApiController]//Abilita el controladro a la Api
    public class RestaurantesController : ControllerBase //Hereda de control base lo que esta pro deffecto en visual code
    {
        [HttpGet]//Responde a las solicitudes de get
        [Route("InformacionRestaurante")]




        //Metodo DevuelveRestaurante
        //Devuelve solamente por el id buscado
        public ActionResult DevuelveRestaurante(int id)
        {
            try
            {

                //Instancia de repositoryrestaurante 
                RestauranteRepository repo = new RestauranteRepository();
                var restaurantes = repo.DevuelveRestaurantes();


                if (restaurantes.Any(x => x.Id == id))
                {
                    var info_restaurante = restaurantes.Find(x => x.Id == id);

                    return Ok(info_restaurante);
                }
                else
                {
                    return NotFound();
                }


            }

            //Manejo de errores
            //Regresa un http 400 bad request
            catch (Exception e)
            {
                return BadRequest();
            }
            
        }


        //Metodo DevuelveListado
        //Devuelve la lista completa del repositorio

        [HttpGet]
        [Route("InformacionRestaurantes")]
        public List<Restaurante> DevuelveListadoRestaurante()
        {

            
            RestauranteRepository repo = new RestauranteRepository();
            return repo.DevuelveRestaurantes();
        }

    }
}
