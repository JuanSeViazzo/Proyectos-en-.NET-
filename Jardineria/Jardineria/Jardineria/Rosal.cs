using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria
{
    public class Rosal : Planta
    {
        public enum Color
        {
            Roja, Blanca, Amarilla, Rosa, Azul
        }

        private Color florColor;

        public Rosal(string nombre, int tamanio) : base(nombre, tamanio)
        {

        }
        public Rosal(string nombre, int tamanio, Color florColor) : this(nombre, tamanio)
        {
            this.florColor = florColor;
        }

        public override bool TieneFlores { get => true; }
        public override bool TieneFruto { get => false; }


        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.Append(base.ResumenDeDatos());
            sb.AppendLine(String.Format($"Flores de color {this.florColor}"));

            return sb.ToString();
        }




    }
}
