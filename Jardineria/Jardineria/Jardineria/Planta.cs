using System;
using System.Text;

namespace Jardineria
{
    public abstract class Planta

    {
        private string nombre;
        private int tamanio;
        public int Tamanio { get => tamanio; }

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public abstract bool TieneFlores {get;}

        public abstract bool TieneFruto { get;}

        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format($"{this.nombre} tiene un tamaño {this.Tamanio}"));
            sb.AppendLine(string.Format($"Tiene Flores? {(TieneFlores is true ? "SI" : "NO")}"));
            sb.AppendLine(string.Format($"Tiene Frutos? {(TieneFruto is true ? "SI" : "NO")}"));

            return sb.ToString();   
        }





    }
}
