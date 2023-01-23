using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallZ
{
    public abstract class Personaje
    {

        protected List<EHabilidades> ataques;

        protected int nivelDePoder;
        protected string nombre;

        protected abstract string Descripcion { get; }


        private Personaje()
        {
            List<EHabilidades> ataques = new List<EHabilidades>();
        }

        protected Personaje(int nivelDePoder, string nombre)
        {
            this.nivelDePoder = nivelDePoder;
            this.nombre = nombre;
        }

        protected Personaje(List<EHabilidades> ataques, int nivelDePoder, string nombre) : this(nivelDePoder, nombre)
        {
            this.ataques = ataques;
        }

        public override string ToString()
        {
            return nombre;
        }


        public abstract string Transformarse();


        public virtual string InfoPersonaje()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format($"Nombre: {ToString()}"));
            foreach (EHabilidades item in ataques)
            {
                sb.AppendLine(string.Format($"{item}"));
            }

            sb.AppendLine(string.Format($"Nivel de poder {nivelDePoder}"));
            sb.AppendLine(string.Format($"{Descripcion}"));

            return  sb.ToString();
        }


        public static bool operator ==(Personaje p1, List<Personaje> ListPersonajes)
        {

            if (p1 is not null && ListPersonajes is not null)
            {
                foreach (Personaje personajito in ListPersonajes)
                {
                    if (p1 == personajito)
                    {

                        return true;
                    }
                }
            }


            return false;
        }

        public static bool operator !=(Personaje p1, List<Personaje> ListPersonajes)
        {
            return !(p1 == ListPersonajes);
        }



        public static bool operator ==(Personaje p1, Personaje p2)
        {
            if (p1 is not null && p2 is not null)
            {
                if (p1.GetType() == p2.GetType() && p1.nombre == p2.nombre)
                {
                    return true;
                }
            }
            return false;

        }

        public static bool operator !=(Personaje p1, Personaje p2)
        {
            return !(p1 == p2);
        }





    }
}
