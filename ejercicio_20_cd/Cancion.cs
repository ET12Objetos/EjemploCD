namespace ejercicio_20_cd
{
    public class Cancion
    {
        public string nombre { get; set; }

        public double duracion { get; set; }

        public Cancion(string unNombre, double unaDuracion)
        {
            this.nombre = unNombre;
            
            this.duracion = unaDuracion;
        }
    }
}