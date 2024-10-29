using MiPrimeraAPI_StefanJativa.Models;

namespace MiPrimeraAPI_StefanJativa.Repositories
{
    public class RestauranteRepository
    {

        //Metodo Devuelve el resutaurante
        //Llama a la clase del modelo Restaurante
        public List<Restaurante> DevuelveRestaurantes()
        {

            //Crea Lista tipo restaurante
            List<Restaurante> restaurantes = new List<Restaurante>();
            
            

            //Crea los objetos restaurate 1 y 2
            Restaurante restaurante = new Restaurante
            {
                Id = 1,
                Nombre = "McDonals",
                CostoComercial = 100000,
                Direccion = "Orellana",
                AceptaMascotas = false
            };

            Restaurante restaurante2 = new Restaurante
            {
                Id = 2,
                Nombre = "Burger King",
                CostoComercial = 50000,
                Direccion = "Orellana",
                AceptaMascotas = true
            };


            //Ambos objetos creados anteriormente se almacenan en la lista Restaurantes
            restaurantes.Add(restaurante);
            restaurantes.Add(restaurante2);

            //Retorna la lista restaurantes
            return restaurantes;

        }



        



    }
}
