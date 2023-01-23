using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace El_Relojero
{
    public partial class Form1 : Form
    {
       Task task;
       CancellationTokenSource source;
       CancellationToken token;

        public Form1()
        {
            InitializeComponent();
            this.source = new CancellationTokenSource();
            token = source.Token();
        }


        public void AsignarHora()
        {
            if(this.InvokeRequired)
            {
                Action delegado = AsignarHora;
                this.Invoke(delegado);  

            }



            lblHora.Text = DateTime.Now.ToString();



        }






        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                do
                {
                    AsignarHora();
                    Thread.Sleep(1000);

                } while (true);



            });
        }
    }
}
