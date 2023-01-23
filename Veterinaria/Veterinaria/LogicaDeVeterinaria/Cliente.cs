using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeVeterinaria
{
    public class Cliente
    {

        private string nombre;
        private string apellido;
        private string domicilio;
        private int telefono;
        private Mascota[] mascotas;            


        public Cliente(string nombre, string apellido, string domicilio, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            mascotas = new Mascota[20];
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public string Getdomicilio()
        {
            return this.domicilio;
        }
        public int GetTelefono()
        {
            return this.telefono;
        }

        public void SetDomicilio(string nuevoDomicilio)
        {
            domicilio = nuevoDomicilio;
        }

        public void SetTelefono(int telefono)
        {
            this.telefono=telefono;
        }


        public void CargarMascota(string nombreMascota, string especie, string vacunas, DateTime fechaDeNacimiento)
        {
            Mascota Mascota = new Mascota(nombreMascota, especie, vacunas, fechaDeNacimiento);

            if (mascotas!=null)
            {
                for (int i = 0; i < mascotas.Length; i++)
                {

                    if (mascotas[i]==null)
                    {
                        this.mascotas[i] = Mascota;
                    }


                }
            }
            
        }


    }
}
