using System;

namespace modelo
{
    public class PuntoTuristico
    {
        private String nombre;
        private String ciudad;
        private String depto;
        private double latitud;
        private double longitud;
        //LA_LO
        public PuntoTuristico(String nombre, String ciudad, String depto, double latitud, double longitud)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Depto = depto;
            this.Latitud = latitud;
            this.Longitud = longitud;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Depto { get => depto; set => depto = value; }
        public double Latitud { get => latitud; set => latitud = value; }
        public double Longitud { get => longitud; set => longitud = value; }
    }
}
