using System;

namespace ejercicio_20_cd
{
    class Program
    {
        static void Main(string[] args)
        {
            Cd disco = new Cd();
            disco.agregarUna(new Cancion("track 1", 4.3));
            disco.agregarUna(new Cancion("track 2", 4.3));
            disco.agregarUna(new Cancion("track 3", 4.3));
            disco.agregarUna(new Cancion("track 4", 4.3));
            Console.WriteLine("El disco: {0} tiene {1} canciones.", disco.nombre, disco.numeroDeCanciones());
            Console.WriteLine("La cancion de la posicion 2 es: {0}", disco.canciones[2].nombre);
            disco.grabaCancion(7, new Cancion("track 15", 2.4));
            Console.WriteLine("El disco: {0} tiene {1} canciones.", disco.nombre, disco.numeroDeCanciones());
            disco.eliminarCancionEnPosicion(3);
            //disco.informarCanciones();
            Console.WriteLine("El disco: {0} tiene {1} canciones.", disco.nombre, disco.numeroDeCanciones());
        }
    }
}
