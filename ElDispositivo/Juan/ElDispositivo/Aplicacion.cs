using System;
using System.Text;
using System.Collections.Generic;

namespace ElDispositivo
{
    public abstract class Aplicacion
    {

        protected string nombre;
        protected int tamanioMB;
        protected Dispositivo.SistemaOperativo sistemaOperativo;

        protected Aplicacion(string nombre, Dispositivo.SistemaOperativo sistemaOperativo, int tamanioMB)
        {
            this.nombre = nombre;
            this.tamanioMB = tamanioMB;
            this.sistemaOperativo = sistemaOperativo;
        }

        public Dispositivo.SistemaOperativo SistemaOperativo { get => sistemaOperativo;}
        protected abstract int Tamanio { get;}


        public implicit operator Aplicacion(List<Aplicacion> appsInstaladas)
        {

        }


        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder(); 

            return sb.ToString();
        }


        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            return sb.ToString();

        }



        public static bool operator +(List<Aplicacion> appsInstaladas, Aplicacion app)
        {
   
        }


        public static bool operator ==(List<Aplicacion> appsInstaladas, Aplicacion app)
        {


        }

        public static bool operator !=(List<Aplicacion> appsInstaladas, Aplicacion app)
        {
            return !(appsInstaladas == app);

        }








    }
}
