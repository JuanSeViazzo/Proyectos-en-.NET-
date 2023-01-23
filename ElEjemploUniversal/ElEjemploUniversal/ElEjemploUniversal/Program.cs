using System;
using LogicaDelUniverso;


namespace ElEjemploUniversal
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Estudiante PrimerEstudiante = new Estudiante("Maradona", "Diego Armando","12171");
            Estudiante SegundoEstudiante = new Estudiante("Messi", "Lionel", "12172");
            Estudiante TercerEstudiante = new Estudiante("Daniel", "Pasarella", "12173");

            Console.WriteLine(PrimerEstudiante.Mostrar());
            Console.WriteLine(SegundoEstudiante.Mostrar());
            Console.WriteLine(TercerEstudiante.Mostrar());

            PrimerEstudiante.SetNotaPrimerParcial(10);
            PrimerEstudiante.SetNotaSegundoParcial(10);
            SegundoEstudiante.SetNotaPrimerParcial(10);
            SegundoEstudiante.SetNotaSegundoParcial(10);
            TercerEstudiante.SetNotaPrimerParcial(2);
            TercerEstudiante.SetNotaSegundoParcial(6);


            Console.WriteLine(PrimerEstudiante.Mostrar());
            Console.WriteLine(SegundoEstudiante.Mostrar());
            Console.WriteLine(TercerEstudiante.Mostrar());




            Console.ReadKey();





        }
    }
}
