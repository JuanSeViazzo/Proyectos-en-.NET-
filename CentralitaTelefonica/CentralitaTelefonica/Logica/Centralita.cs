using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Centralita
    {

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
           listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) :this()
        {
            this.razonSocial = nombreEmpresa;
        }


        public List<Llamada> Llamadas { get => listaDeLlamadas;}


        public float GananciasPorLocal
        {
            get { return CalcularGanancia(Llamada.ETipoLlamada.Local); }
        }
        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(Llamada.ETipoLlamada.Provincial); }
        }
        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.ETipoLlamada.Todas); }
        }


        private float CalcularGanancia(Llamada.ETipoLlamada tipoLlamada)
        {
            float total=0;

            
            foreach (Llamada item in listaDeLlamadas)
            {

                switch (tipoLlamada)
                {
                    case Llamada.ETipoLlamada.Local:
                        if(item is Local )
                            total = total + item.CostoLlamada;
                        break;
                    case Llamada.ETipoLlamada.Provincial:
                        if (item is Provincial)
                            total = total + item.CostoLlamada;
                        break;
                    default:
                        total = total + item.CostoLlamada;
                        break;
                }

            }


            return total;

        }


        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion); 
        }
        public override string ToString()
        {
            return Mostrar();
        }



        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"El nombre de la razon social es: {razonSocial}");
            sb.AppendLine($"El costo de llamdas Locales es: {GananciasPorLocal}");
            sb.AppendLine($"El costo de llamadas Provinciales es:{GananciasPorProvincial}");
            sb.AppendLine($"El costo total de llamadas Totales es: {GananciasPorTotal}");

            foreach (Llamada item in listaDeLlamadas)
            {
                if (item is Local)
                {
                    sb.AppendLine("Llamada Local");
                    sb.AppendLine("---------");
                    sb.AppendLine(item.ToString());
                    sb.AppendLine("---------");

                }else
                {
                    sb.AppendLine("Llamada Provincial");
                    sb.AppendLine("---------");
                    sb.AppendLine(item.ToString());
                    sb.AppendLine("---------");
                }


            }
            return sb.ToString();   

        }


        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            Llamadas.Add(nuevaLlamada);  
        }








        public static bool operator ==(Centralita central, Llamada llamada)
        {

            if(central is not null && llamada is not null)
            {
                foreach (Llamada item in central.listaDeLlamadas)
                {

                    if(llamada == item)
                    {
                        return true;
                    }

                }

            }

            return false;
        }

        public static bool operator !=(Centralita central,Llamada llamada)
        {
            return !(central == llamada);
        }

        //El operador + invocará al método AgregarLlamada sólo si la llamada no está registrada en la Centralita. Utilizar la sobrecarga del operador == de Centralita.

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {

            if(central is not null && nuevaLlamada is not null)
            {
                    if(!(central == nuevaLlamada ))
                    {
                       central.AgregarLlamada(nuevaLlamada);
                    }
            }

            return central;
        }



    }
}
