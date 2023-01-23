using System;
using System.Text;
namespace Logica
{
    public abstract class Llamada
    {
        public enum ETipoLlamada
        {
            Local, Provincial, Todas
        }

        protected float duracion;
        protected string nrDestino;
        protected string nrOrigen;

        public float Duracion {get => duracion;}
        public string NrDestino { get => nrDestino; set => nrDestino = value; }
        public string NrOrigen { get => nrOrigen; set => nrOrigen = value; }

        public Llamada(float duracion, string nrDestino, string nrOrigen)
        {
            this.duracion = duracion;
            this.nrDestino = nrDestino;
            this.nrOrigen = nrOrigen;
        }

        public abstract float CostoLlamada { get;}

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {

            return  (int) (llamada1.duracion - llamada2.duracion);
        }


        protected virtual string Mostrar()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" Numero de origen: {NrOrigen}");
            sb.AppendLine($" Numero de destino: {NrDestino}");
            sb.AppendLine($" Duracion de llamada: {duracion}");

            return sb.ToString();

        }


            

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (l2.Equals(l1) is true)
            {
                if (l1.nrDestino == l2.nrDestino && l1.nrOrigen == l2.nrOrigen)
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public static bool operator !=(Llamada l1, Llamada l2)
            => !(l1 == l2);


      















    }

}
