namespace ejercicio_20_cd
{
    public class Cd
    {
        private int contador;

        public Cancion[] canciones;

        public Cd()
        {
            canciones = new Cancion[15];
            contador = 0;
        }

        public int numeroDeCanciones()
        {
            return contador;
        }

        public void grabaCancion(int posicion, Cancion unaCancion)
        {
            if ((posicion >= 0) && (posicion < 15))
            {
                canciones[posicion] = unaCancion;
                contador++;
            }
            else
            {
                System.Console.WriteLine("La posicion excede la cantidad de elementos del vector.");
            }
        }

        public void agregarUna(Cancion nuevaCancion)
        {
            if (contador > 14)
            {
                System.Console.WriteLine("La posicion excede la cantidad de elementos del vector.2");
            }
            else
            {
                canciones[contador] = nuevaCancion;
                contador++;
            }
        }

        public void eliminarCancionEnPosicion(int posicion)
        {
            if ((posicion >= 0) && (posicion < 15))
            {
                canciones[posicion] = null;
                contador--;
            }
        }

        public void informarCanciones()
        {
            for (int i = 0; i < 15; i++)
            {
                if (canciones[i] != null)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Disco: {0}", nombre);
                    System.Console.WriteLine("Posicion: {0} Cancion: {1} Duracion: {2}", i, canciones[i].nombre, canciones[i].duracion);
                    System.Console.WriteLine("Contador = {0}", contador);
                }
            }
        }
    }
}