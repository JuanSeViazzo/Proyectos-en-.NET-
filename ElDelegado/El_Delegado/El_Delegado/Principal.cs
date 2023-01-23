using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Delegado
{

    /*Se asignará una instancia de FrmMostrar a un atributo de la clase. El MdiParent de dicha instancia será FrmPrincipal.
Se asignará una instancia de FrmTestDelegados a un atributo de la clase. El MdiParent de dicha instancia será FrmPrincipal.
Cuando el usuario pulse el submenú "Test Delegados", mostrar el FrmTestDelegados de forma no-modal.*/



    public partial class Principal : Form
    {
        FrmMostrar mostrar;
        FrmTestDelegados delegados;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            mostrar = new FrmMostrar();
            mostrar.MdiParent = this;

            delegados = new FrmTestDelegados();
            delegados.MdiParent = this;

            mostrarToolStripMenuItem.Enabled = false;


        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarToolStripMenuItem.Enabled = true;

            delegados.Show();





        }
    }
}
