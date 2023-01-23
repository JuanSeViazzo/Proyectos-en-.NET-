using System.Collections.Generic;
using System;
using System.Text;

namespace Jardineria
{
    public class Jardin
    {
        public enum TipoSuelo
        {
            Terrozo, Arenozo
        }
        private int espacioTotal;
        private List<Planta> plantas;
        private static TipoSuelo suelo;
        static Jardin()
        {
            Jardin.suelo = TipoSuelo.Terrozo;

        }
        public static TipoSuelo Suelo { get => suelo; }
        private Jardin()
        {
            plantas = new List<Planta>();
        }
        public Jardin(int espacioTotal) : this()
        {
            this.espacioTotal = espacioTotal;
        }
        public int EspacioOcupado()
        {
            int espacioOcupado = 0;


            if (this.plantas != null)
            {
                foreach (Planta item in this.plantas)
                {
                    espacioOcupado += item.Tamanio;
                }
            }
            return espacioOcupado;

        }

        public int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;

        }


        public static bool operator +(Jardin jardin, Planta planta)
        {
            if (jardin.EspacioOcupado(planta) <= jardin.espacioTotal)
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine($"Composicion del Jardin {Jardin.Suelo}\n Espacio Ocupado: {EspacioOcupado()} de {espacioTotal}");
            
                foreach (Planta item in this.plantas)
                {
                    sb.AppendLine(item.ResumenDeDatos());
                }
            


            return sb.ToString();
        }

        

    }
}
