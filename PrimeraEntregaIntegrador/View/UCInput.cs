using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PrimeraEntregaIntegrador.View
{
    public partial class UCInput : UserControl
    {
        private Form1 f;
        public UCInput()
        {

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                f = (Form1)this.FindForm();
            }
            catch(Exception s)
            {

            }
            

        }


        private void btnLimitar_Click(object sender, EventArgs e)
        {

        }

        private void buttonAP_Click(object sender, EventArgs e)
        {

        }

        private void buttonM_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void desdeClientes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonM_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Boton presionado");
            var b2 = textBoxMarkov.Text.ToString().Split(',');
            var set = new SortedSet<String>(b2);
            
          
            Button b = sender as Button;
            b.Enabled = false;
            Console.WriteLine("AP clicked");
            Thread t = new Thread(new ThreadStart(() => f.analyzer.reportMarkov(Int32.Parse(markovDA.Value.ToString()), Int32.Parse(markovHA.Value.ToString()), Int32.Parse(markovDC.Value.ToString()), Int32.Parse(markovHC.Value.ToString()), Int32.Parse(markovNumber.Value.ToString()), set)));
            Thread buttonEnabler = new Thread(new ThreadStart(() => {
                t.Join();
                if (b.InvokeRequired)
                {
                    b.Invoke(new Action(() =>
                    {
                        b.Enabled = true;
                    }));

                }
                else
                {

                    b.Enabled = true;
                }
            }));


            t.Start();
            buttonEnabler.Start();
          
        }

       

        private void buttonAP_Click_1(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.Enabled = false;

            f.analyzer.confidenceThreshold = (Double)numConfianza.Value;
            f.analyzer.supportThreshold = (Double)numSoporte.Value;
            Thread t = new Thread(new ThreadStart(() => f.analyzer.reportAP(Int32.Parse(aprioriDA.Value.ToString()), Int32.Parse(aprioriHA.Value.ToString()), Int32.Parse(aprioriDC.Value.ToString()), Int32.Parse(aprioriHC.Value.ToString()))));
            Thread buttonEnabler=new Thread(new ThreadStart(() =>{
                t.Join();
                if (b.InvokeRequired)
                {
                    b.Invoke(new Action(() =>
                    {
                        b.Enabled = true;
                    }));

                }
                else
                {

                b.Enabled = true;
                }
            }));


            t.Start();
            buttonEnabler.Start();


        }

        private void buttonBF_Click(object sender, EventArgs e)
        {
            var a = f.analyzer.giveBruteForceRefinedAssotiations(Int32.Parse(desdeArticulos.Value.ToString()), Int32.Parse(hastaArticulos.Value.ToString()), Int32.Parse(desdeClientes.Value.ToString()), Int32.Parse(hastaClientes.Value.ToString()));
        }
    }
}
