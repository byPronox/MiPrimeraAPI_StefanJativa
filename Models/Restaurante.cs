﻿namespace MiPrimeraAPI_StefanJativa.Models
{
    public class Restaurante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public float CostoComercial { get; set; }
        public Boolean AceptaMascotas { get; set; }
    }
}
