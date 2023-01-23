using Logica;
using System;
using System.Windows.Forms;
namespace Visual
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        public Centralita Centralita { get => centralita; }

        int txtOrigenODestino;
        int provincialOLocal;

        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {


            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.EFranja));

            Provincial.EFranja franjas;
            Enum.TryParse<Provincial.EFranja>(cmbFranja.SelectedValue.ToString(), out franjas);


        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(12);
            Llamada llamada;
            int duracion = rnd.Next(1, 50);
            float costo = 0;
            float dividendo = 0;
            float divisor = 0;

            while (costo < 0.5 || costo > 5.6) 
            {
                dividendo = rnd.Next(2, 11);
                divisor = rnd.Next(2, 11);
                costo = dividendo / divisor;
            }
            



            if (provincialOLocal ==0)
            {

                llamada = new Provincial(txtOrigen.Text, (Provincial.EFranja)cmbFranja.SelectedItem, duracion, txtDestino.Text);
                centralita.Llamadas.Add(llamada);
                MessageBox.Show("La llamada ha sido realizada");

            }
            else
            {
                llamada = new Local(txtOrigen.Text, duracion, txtDestino.Text, costo);
                centralita.Llamadas.Add(llamada);
                MessageBox.Show("La llamada ha sido realizada");

            }



        }

        private void txtDestino_Leave(object sender, EventArgs e)
        {


            if (txtDestino.Text.StartsWith('#'))
            {
                cmbFranja.Enabled = false;
                provincialOLocal = 1;
            }
            else
            {
                cmbFranja.Enabled = true;
                provincialOLocal = 0;
            }
        


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += button1.Text;
            }
            else
                txtOrigen.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += button2.Text;
            }
            else
                txtOrigen.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += button3.Text;
            }
            else
                txtOrigen.Text += button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += button6.Text;
            }
            else
                txtOrigen.Text += button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += button5.Text;
            }
            else
                txtOrigen.Text += button5.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += button4.Text;
            }
            else
                txtOrigen.Text += button4.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += button9.Text;
            }
            else
                txtOrigen.Text += button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {


            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += button8.Text;
            }
            else
                txtOrigen.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += button7.Text;
            }
            else
                txtOrigen.Text += button7.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += '*';
            }
            else
                txtOrigen.Text += '*';
        }

        private void button10_Click(object sender, EventArgs e)
        {


            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += "#";
            }
            else
                txtOrigen.Text += '#';
            cmbFranja.Enabled = false;

        }

        private void button0_Click(object sender, EventArgs e)
        {


            if (txtOrigenODestino == 1)
            {
                txtDestino.Text += button0.Text;
            }
            else
                txtOrigen.Text += button0.Text;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult opcion = MessageBox.Show("Seguro Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (opcion == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDestino.Clear();
            txtOrigen.Clear();
        }

        private void txtDestino_Click(object sender, EventArgs e)
        {
            txtOrigenODestino = 1;
        }

        private void txtOrigen_Click(object sender, EventArgs e)
        {
            txtOrigenODestino = 2;
        }
    }
}
