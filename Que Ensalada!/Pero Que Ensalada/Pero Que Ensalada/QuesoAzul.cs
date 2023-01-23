using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pero_Que_Ensalada
{
    public class QuesoAzul : Ingrediente
    {

        public enum Procedencia
        {
            Francia,
            Argentina,
            Italia
        }

        private Procedencia procedencia;

        public override string Proceso { get => "desgranar"; }
        public override string UnidadDeMedida { get => "gramos"; }

        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Informacion());
            sb.AppendLine(String.Format($"Procede de: {this.procedencia}"));
            return sb.ToString();
        }

        public QuesoAzul(string descripcion, int cantidad) : base(descripcion,cantidad)
        {

        }

        public QuesoAzul(string descripcion, int cantidad,Procedencia procedencia) : this(descripcion,cantidad)
        {
            this.procedencia = procedencia;
        }










    }
}
