using System;
using Logica;

namespace CentralitaTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.EFranja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.EFranja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.ListaDeLlamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            c.ListaDeLlamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            c.ListaDeLlamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            c.ListaDeLlamadas.Add(l4);
            Console.WriteLine(c.Mostrar());

            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();






        }
    }
}
