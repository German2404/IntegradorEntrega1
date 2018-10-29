using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrimeraEntregaIntegrador
{
    public partial class Form1 : Form
    {
        internal Analyzer analyzer;
    

        public Form1()
        {
            InitializeComponent();
           
            analyzer = new Analyzer(0.03,0.20);
            try
            {
                analyzer.readTransactions("./"+"datosFormatoFinal.txt");
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message);
                System.Environment.Exit(1);
            }

            
        }

        
        public int Property
        {
            get => default(int);
            set
            {
            }
        }

       

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void clientsTable_Click(object sender, EventArgs e)
        {

        }

        

        private void textBoxMarkov_TextChanged(object sender, EventArgs e)
        {

        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

        private void articlesTable_Click(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }


    }
}
