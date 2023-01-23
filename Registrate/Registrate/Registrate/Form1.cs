using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registrate
{
    public partial class VistaRegistro : Form
    {
        public VistaRegistro()
        {
            InitializeComponent();
            string pais = Properties.Resources.paises.ToString();
            string[]listaPaises = pais.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < listaPaises.Length; i++)
            {
                lstPaises.Items.Add(listaPaises[i]);
            }

            for (int i = 0; i < listaPaises.Length; i++)
            {
                cmbPaises.Items.Add(listaPaises[i]);
            }




        }







    }
}
