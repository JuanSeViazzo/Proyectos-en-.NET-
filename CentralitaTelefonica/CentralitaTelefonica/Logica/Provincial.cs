
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logica
{



    public class Provincial : Llamada
    {
        public enum EFranja
        {
            Franja_1, Franja_2, Franja_3
        }

        protected EFranja franjaHoraria;


        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        public Provincial(string origen,EFranja miFranja,float duracion,string destino) : base (duracion,destino,origen)
        {
            franjaHoraria = miFranja;

        }

        public Provincial(EFranja franja, Llamada llamada) : this(llamada.NrOrigen, franja, llamada.Duracion, llamada.NrDestino)
        {
        }


        private float CalcularCosto()
        {
            float costo;

            switch (franjaHoraria)
            {
                case EFranja.Franja_1:
                    costo = Duracion * 0.99f;
                    break;

                case EFranja.Franja_2:
                    costo = Duracion * 1.25f;
                    break;

                default:
                    costo = Duracion * 0.66f;
                    break;
            }

            return costo;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de llamada: {CostoLlamada}");
            sb.AppendLine($"Duracion de la llamada: {duracion}");
            return sb.ToString();
        }


        public override string ToString()
        {
            return Mostrar();
        }


        public override bool Equals(Object llamada)
        {

            if (llamada != null && llamada is Provincial)
            {
                return true;
            }
            else
                return false;
        }







    }
}
