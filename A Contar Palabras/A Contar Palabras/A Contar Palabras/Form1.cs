using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logicaDeNegocio;

namespace A_Contar_Palabras
{
    public partial class ContadorDePalabras : Form
    {
        public ContadorDePalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Palabras.AgregarPalabra(richTextBox1.Text);



        }
    }
}
