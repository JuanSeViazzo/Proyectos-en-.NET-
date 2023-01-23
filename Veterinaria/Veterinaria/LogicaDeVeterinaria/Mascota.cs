using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeVeterinaria
{
    public class Mascota
    {
        private string nombreMascota;
        private string especie;
        private string vacunas;
        private DateTime fechaDeNacimiento;


        public Mascota(string nombreMascota, string especie, string vacunas, DateTime fechaDeNacimiento)
        {
            this.nombreMascota = nombreMascota;
            this.especie = especie;
            this.vacunas = vacunas;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }


        public string GetNombreMascota()
        {
            return this.nombreMascota;
        }
        public string GetEspecie()
        {
            return this.especie;
        }
        public string GetVacuna()
        {
            return this.vacunas;
        }
        public DateTime GetFechaNacimiento()
        {
            return this.fechaDeNacimiento;
        }


        public void SetVacuna(string nuevaVacuna)
        {
            if (string.IsNullOrWhiteSpace(nuevaVacuna))
            {

            }
           vacunas = nuevaVacuna;

        }



}
}
