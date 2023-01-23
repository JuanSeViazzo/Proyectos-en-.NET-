using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDispositivo
{
    public class AppMusical : Aplicacion
    {


        List<string> listaCanciones;



        protected override int Tamanio { get => base.tamanioMB; }


        public AppMusical(string nombre,Dispositivo.SistemaOperativo sistemaOperativo, int tamanioInicial) : base(nombre, sistemaOperativo, tamanioInicial) 
        {

        }


        public AppMusical(string nombre, Dispositivo.SistemaOperativo sistemaOperativo, int tamanioInicial,List<String> listaCanciones) : this(nombre, sistemaOperativo, tamanioInicial)
        {
            this.listaCanciones = listaCanciones;
        }





    }
}
