using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTeatro
{
    public class Espectador
    {
        private int dni;
        string nombre;
        private string numeroTelefonico;
        int cantidadDeEntradas;

        private Espectador()
        {
            cantidadDeEntradas = 1;
        }

        public Espectador(int dni, string nombre, string numeroTelefonico): this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.numeroTelefonico = numeroTelefonico;
        }

        public Espectador(string numTel, string nombre, int dni, int cantidadDeEntradas): this(dni,nombre,numTel)
        {
            this.cantidadDeEntradas = cantidadDeEntradas;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NumeroTelefonico { get => numeroTelefonico; set => numeroTelefonico = value; }
        public int CantidadDeEntradas { get => cantidadDeEntradas; set => cantidadDeEntradas = value; }
    }
}
