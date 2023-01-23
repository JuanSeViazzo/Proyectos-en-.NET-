using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo) : this(llamada.NrOrigen, llamada.Duracion, llamada.NrDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        private float CalcularCosto()
        {
            float final;

            final = costo * Duracion;

            return final;
        }        
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de Llamada {CostoLlamada}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }
        public override bool Equals(Object llamada)
        {
           
            if (llamada != null && llamada is Local)
            {
                return true;
            }else
                return false;
        }
    }
}
