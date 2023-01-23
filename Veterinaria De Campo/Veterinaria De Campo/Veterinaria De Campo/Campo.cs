using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_De_Campo
{
    public class Campo
    {
        public enum Tipo
        {
            Pastoreo,
            Engorde
        }


        private int alimentoDisponible;
        private List<Animal> animales;
        private static Tipo servicio;

        public static Tipo TipoServicio {set => servicio = value; }

        static Campo()
        {
            servicio = Tipo.Engorde;
        }

        private Campo()
        {
            animales = new List<Animal>();
        }

        public Campo (int alimento) : this()
        {
            this.alimentoDisponible = alimento;
        }

        private int AlimentoComprometido()
        {

            int totalDeAlimento = 0;

            foreach (Animal item in animales)
            {

                totalDeAlimento += item.KiloAlimentos;

            }
            return totalDeAlimento;

        }

        private int AlimentoComprometido(Animal animal)
        {
            int totalDeAlimento = AlimentoComprometido();

            totalDeAlimento = totalDeAlimento + animal.KiloAlimentos;

            return totalDeAlimento;
            
        }

        public static bool operator +(Campo campo, Animal animal)
        {

            if (campo != null && animal != null)
            {

                if (campo.alimentoDisponible >= campo.AlimentoComprometido(animal))
                {
                    campo.animales.Add(animal);
                    return true;
                }
                else
                    return false;


            }
            else
                return false;


        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Servicio del Campo: {servicio}");
            sb.AppendLine($"Alimento comprometido {AlimentoComprometido()} de {alimentoDisponible} \n");
           
            foreach (Animal item in animales)
            {
                sb.AppendLine(item.Datos());
            }

            return sb.ToString();
        }




    }
}
