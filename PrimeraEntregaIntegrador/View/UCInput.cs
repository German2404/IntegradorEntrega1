using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            f = (Form1)this.FindForm();
         
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
            var b = textBoxMarkov.Text.ToString().Split(',');
            var set = new SortedSet<String>(b);

            var a = f.analyzer.giveMarkovRefinedSuggestion(Int32.Parse(markovDA.Value.ToString()), Int32.Parse(markovHA.Value.ToString()), Int32.Parse(markovDC.Value.ToString()), Int32.Parse(markovHC.Value.ToString()), Int32.Parse(markovNumber.Value.ToString()), set);

            MessageBox.Show(String.Join("-", a.ToArray()));
        }

        private void buttonAP_Click_1(object sender, EventArgs e)
        {
            var a = f.analyzer.giveAPrioriRefinedAssotiations(Int32.Parse(aprioriDA.Value.ToString()), Int32.Parse(aprioriHA.Value.ToString()), Int32.Parse(aprioriDC.Value.ToString()), Int32.Parse(aprioriHC.Value.ToString()));
        }

        private void buttonBF_Click(object sender, EventArgs e)
        {
            var a = f.analyzer.giveBruteForceRefinedAssotiations(Int32.Parse(desdeArticulos.Value.ToString()), Int32.Parse(hastaArticulos.Value.ToString()), Int32.Parse(desdeClientes.Value.ToString()), Int32.Parse(hastaClientes.Value.ToString()));
        }
    }
}
