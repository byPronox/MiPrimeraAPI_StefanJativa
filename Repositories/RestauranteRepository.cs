using MiPrimeraAPI_StefanJativa.Models;

namespace MiPrimeraAPI_StefanJativa.Repositories
{
    public class RestauranteRepository
    {

        //Llama a la clase del modelo Restaurante
        public List<Restaurante> DevuelveRestaurantes()
        {
            List<Restaurante> restaurantes = new List<Restaurante>();
            
            

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

            restaurantes.Add(restaurante);
            restaurantes.Add(restaurante2);
            return restaurantes;

        }



        //Llama a la clase del modelo Restaurante
        public Restaurante DevuelveRestaurante()
        {
            Restaurante restaurante2 = new Restaurante();
            restaurante2.Nombre = "McDonals";

            Restaurante restaurante = new Restaurante
            {
                Id = 1,
                Nombre = "McDonals",
                CostoComercial = 100000,
                Direccion = "Orellana",
                AceptaMascotas = false
            };
            return restaurante;
        }



    }
}
