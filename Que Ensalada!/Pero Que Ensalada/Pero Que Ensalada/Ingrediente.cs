using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pero_Que_Ensalada
{
    public abstract class Ingrediente
    {
        private int cantidad;
        private string descripcion;
        

        public int Cantidad { get => cantidad; }

        public abstract string Proceso { get; }
        public abstract string UnidadDeMedida { get; }


        public Ingrediente(string descripcion, int cantidad)
        {
            this.descripcion = descripcion;
            this.cantidad = cantidad;
        }

        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{descripcion.ToUpper()}, en una cantidad de {this.Cantidad} {this.UnidadDeMedida.ToUpper()} "));
            sb.AppendLine(string.Format($"Proceso: {Proceso.ToUpper()}"));

            return sb.ToString();
        }




    }
}
