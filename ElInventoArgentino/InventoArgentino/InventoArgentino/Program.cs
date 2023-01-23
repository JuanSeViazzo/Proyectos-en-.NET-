/*En el método Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta de 100
 * y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
Utilizar todos los métodos y mostrar los resultados por consola.
Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.*/




using System;
using LogicaDeNegocio;

namespace InventoArgentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujoAzul;
            string dibujoRojo;
           
            Boligrafo BoligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);

            Boligrafo BoligrafoRojo = new Boligrafo(50, ConsoleColor.Red);


            Console.WriteLine("La tinta azul tiene:{0} unidades",BoligrafoAzul.GetTinta());
            Console.WriteLine("La tinta roja tiene:{0} unidades", BoligrafoRojo.GetTinta());

            dibujoAzul = BoligrafoAzul.Pintar(44, out dibujoAzul) == true ? dibujoAzul : null;

            if(dibujoAzul != null)
                Console.ForegroundColor = ConsoleColor.Blue;


            ConsoleColor dibujarEnAzul = Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(dibujoAzul);

            Console.WriteLine("La tinta actual es: {0} ",BoligrafoAzul.GetTinta());

            BoligrafoAzul.Recargar();

            Console.WriteLine("Se ha realizado la recarga, la tinta actual es: {0}",BoligrafoAzul.GetTinta());


            dibujoRojo = BoligrafoRojo.Pintar(40, out dibujoRojo) == true ? dibujoRojo : null;
            if(dibujoRojo != null)
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(dibujoRojo);

            Console.WriteLine("La tinta actual es: {0} ", BoligrafoRojo.GetTinta());

            BoligrafoRojo.Recargar();

            Console.WriteLine("Se ha realizado la recarga, la tinta actual es: {0}", BoligrafoRojo.GetTinta());


            Console.ReadKey();

        }
    }
}
