using System;
using System.Collections.Generic;
using System.Text;
namespace Pero_Que_Ensalada
{
    public class Receta
    {

        public enum Tipo
        {
            Clasica,
            Especial
        }

        
        private int capacidadDelContenedor;
        private List<Ingrediente> ingredientes;
        private static Tipo preparacion;

        public static Tipo TipoDePreparacion { set { preparacion = value; } }


        static Receta ()
        {
            TipoDePreparacion = Tipo.Clasica;
        }

        private Receta()
        {
            ingredientes = new ();
        }

        public Receta (int cantidad) : this()
        {
            capacidadDelContenedor = cantidad;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Receta {Receta.preparacion}"));
            sb.AppendLine(string.Format($"Capacidad Libre: {CapacidadLibre()} "));
            sb.AppendLine(string.Format($"Capacidad Total: {capacidadDelContenedor}"));
            foreach (Ingrediente item in ingredientes)
            {
                sb.AppendLine(item.Informacion());
            }

            return sb.ToString();

        }

        public int CapacidadLibre()
        {
            int cantidadOcupada = 0;
            int espacioLibre = 0;

            foreach (Ingrediente item in ingredientes)
            {
                cantidadOcupada += item.Cantidad;


            }

            espacioLibre = capacidadDelContenedor - cantidadOcupada;
            return espacioLibre;
        }

        public int CapacidadLibre(Ingrediente planta)
        {
            int espacioActualLibre = 0;

            espacioActualLibre = CapacidadLibre() - planta.Cantidad;



            return espacioActualLibre;

        }

        public static bool operator +(Receta receta, Ingrediente ingrediente)
        {
            if (receta is not null && ingrediente is not null)
            {
                if (receta.CapacidadLibre(ingrediente) >=0)
                {
                    receta.ingredientes.Add(ingrediente);

                    return true;
                }
                else return false;
            } else
                return false;


        }


    }
}
