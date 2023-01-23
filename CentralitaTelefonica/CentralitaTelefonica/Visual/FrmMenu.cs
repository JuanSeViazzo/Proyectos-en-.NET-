using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Visual
{
    public partial class FrmMenu : Form
    {
        Centralita centralita;
        
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            centralita = new Centralita();  



        }

        private void btn_llamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(centralita);
            frmLlamador.ShowDialog();
            Centralita central = frmLlamador.Centralita;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcion;

            opcion = MessageBox.Show("Desea salir?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);    

            if (opcion == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_FacturacionTotal_Click(object sender, EventArgs e)
        {

            float ganancia = centralita.GananciasPorLocal;


            MessageBox.Show($"{ganancia.ToString()}", "La ganancia es"); 






        }
    }
}
