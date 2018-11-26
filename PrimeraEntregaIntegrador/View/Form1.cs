using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
                var assembly = Assembly.GetExecutingAssembly();
                
                String resourceName = "PrimeraEntregaIntegrador.datosFormatoFinal.txt";
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    analyzer.readTransactions(result.Split(new String[] { "\r\n" }, StringSplitOptions.None));
                
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show(this, e.Message);
                System.Environment.Exit(1);
            }

            this.formatearTabAPriori();
            this.formatearTabMarkov();
            this.formatDemandTab();
        }

        public void refreshDemandTab()
        {
            var data = this.analyzer.getSalesData(this.comboBox2.SelectedItem.ToString());
            this.chart1.Series[0].Points.Clear();
            this.chart1.ChartAreas[0].AxisY.Maximum = data.Max(a => a.Value) + 5;
            this.chart1.ChartAreas[0].AxisX.Title = "Fecha";

            this.chart1.ChartAreas[0].AxisY.Title = "Ventas (Ocurrencias en transacciones)";
            this.chart1.Series[0].XValueType = ChartValueType.String;

            foreach(var dato in data)
            {
                chart1.Series[0].Points.AddXY(dato.Key, dato.Value);
            }
  
        }


        public void formatearTabAPriori()
        {
            this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.numericUpDown1.Value = (decimal)analyzer.supportThreshold;
            this.numericUpDown2.Value = (decimal)analyzer.confidenceThreshold;
            var dic1 = analyzer.generateArticlesTable();
            var dic2 = analyzer.generateClientsTable();
            int minArt = dic1.Select(i => i.Key).Min();
            int maxArt = dic1.Select(i => i.Key).Max();
            int minClient = dic2.Select(i => i.Key).Min();
            int maxClient = dic2.Select(i => i.Key).Max();
            this.numericUpDown3.Value = minArt;
            this.numericUpDown4.Value = maxArt;
            this.numericUpDown3.Minimum = minArt;
            this.numericUpDown3.Maximum = this.numericUpDown4.Value-1;
            this.numericUpDown4.Minimum = this.numericUpDown3.Value+1;
            this.numericUpDown4.Maximum = maxArt;

            this.numericUpDown5.Value = minClient;
            this.numericUpDown6.Value = maxClient;
            this.numericUpDown5.Minimum = minClient;
            this.numericUpDown5.Maximum = this.numericUpDown6.Value - 1;
            this.numericUpDown6.Minimum = this.numericUpDown5.Value + 1;
            this.numericUpDown6.Maximum = maxClient;

        }


        public void formatearTabMarkov()
        {
            this.comboBox1.Items.Clear();
            var items = this.analyzer.transactions.Select(i => i.Value).SelectMany(i => i.items).Distinct().ToList();
            foreach(String item in items)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
            this.listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            var dic1 = analyzer.generateArticlesTable();
            var dic2 = analyzer.generateClientsTable();
            int minArt = dic1.Select(i => i.Key).Min();
            int maxArt = dic1.Select(i => i.Key).Max();
            int minClient = dic2.Select(i => i.Key).Min();
            int maxClient = dic2.Select(i => i.Key).Max();
            this.numericUpDown10.Value = minArt;
            this.numericUpDown9.Value = maxArt;
            this.numericUpDown10.Minimum = minArt;
            this.numericUpDown10.Maximum = this.numericUpDown9.Value - 1;
            this.numericUpDown9.Minimum = this.numericUpDown10.Value + 1;
            this.numericUpDown9.Maximum = maxArt;

            this.numericUpDown8.Value = minClient;
            this.numericUpDown7.Value = maxClient;
            this.numericUpDown8.Minimum = minClient;
            this.numericUpDown8.Maximum = this.numericUpDown7.Value - 1;
            this.numericUpDown7.Minimum = this.numericUpDown8.Value + 1;
            this.numericUpDown7.Maximum = maxClient;
        }


        public void formatDemandTab()
        {
            this.comboBox2.Items.Clear();
            var items = this.analyzer.transactions.Select(i => i.Value).SelectMany(i => i.items).Distinct().ToList();
            foreach (String item in items)
            {
                comboBox2.Items.Add(item);
            }
            comboBox2.SelectedIndex = 0;
            this.refreshDemandTab();
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

        private void ucInput1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucGraphics1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown4.Minimum = numericUpDown3.Value + 1;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown3.Maximum = this.numericUpDown4.Value - 1;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown6.Minimum = numericUpDown5.Value + 1;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown5.Maximum = this.numericUpDown6.Value - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();

            String resourceName1 = "PrimeraEntregaIntegrador.recursos.cargando.gif";
            String resourceName2 = "PrimeraEntregaIntegrador.recursos.check.gif";
            label11.Image = new Bitmap(assembly.GetManifestResourceStream(resourceName1));
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.listView1.Items.Clear();
            analyzer.supportThreshold = (double)this.numericUpDown1.Value;
            analyzer.confidenceThreshold = (double)this.numericUpDown2.Value;
            Thread t = new Thread(new ThreadStart(() =>
              {
                  this.analyzer.APassociations = this.analyzer.giveAPrioriRefinedAssotiations((int)this.numericUpDown3.Value, (int)this.numericUpDown4.Value, (int)this.numericUpDown5.Value, (int)this.numericUpDown6.Value);
                  this.Invoke(new Action(() =>
                  {
                      button1.Enabled = true;
                      button2.Enabled = true;
                      label11.Image = new Bitmap(assembly.GetManifestResourceStream(resourceName2));
                      foreach (var ass in this.analyzer.APassociations)
                      {
                          this.listView1.Items.Add(new ListViewItem(new String[] { ass.ToString(),String.Format("{0:P2}", ass.support), String.Format("{0:P2}", ass.confidence) }));
                      }
                      this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                      this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                  }));
              }));
            t.IsBackground = true;
            t.Start();
        
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.analyzer.reportAP(this.analyzer.APassociations);
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown9.Minimum = this.numericUpDown10.Value+1;
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown10.Maximum = this.numericUpDown9.Value - 1;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown7.Minimum = this.numericUpDown8.Value + 1;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown8.Maximum = this.numericUpDown7.Value - 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var lvi = new ListViewItem(new String[] { this.comboBox1.SelectedItem.ToString(),this.analyzer.articles[this.comboBox1.SelectedItem.ToString()] });
            lvi.Name = this.comboBox1.SelectedItem.ToString();
            
            if (!this.listView3.Items.ContainsKey(lvi.Text))
            {
            this.listView3.Items.Add(lvi);
            this.listView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.listView2.Items.Clear();
                  SortedSet<String> ss = new SortedSet<string>();
                  foreach(ListViewItem lvi in this.listView3.Items)
                  {
                      ss.Add(lvi.Name);
                  }
            Thread t = new Thread(new ThreadStart(() =>
              {
                  this.analyzer.MarkovSuggestions = this.analyzer.giveMarkovRefinedSuggestion((int)this.numericUpDown10.Value, (int)this.numericUpDown9.Value, (int)this.numericUpDown8.Value, (int)this.numericUpDown7.Value, (int)this.numericUpDown12.Value, ss);
                  this.Invoke(new Action(() =>
                  {
                      this.button3.Enabled = true;
                      this.button4.Enabled = true;
                      var refs = this.analyzer.MarkovSuggestions.Select(i=>new {Key=i.Key,Value=i.Value }).OrderByDescending(i => i.Value).Take((int)this.numericUpDown12.Value);
                      foreach(var s in refs)
                      {
                          this.listView2.Items.Add(new ListViewItem(new String[] {s.Key,this.analyzer.articles[s.Key],s.Value+"" }));
                      }
                      this.listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                      this.listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                  }));
              }));
            t.IsBackground = true;
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.analyzer.reportMarkov(this.analyzer.MarkovSuggestions, (int)this.numericUpDown12.Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.listView3.Items.Count>0)
            this.listView3.Items.RemoveAt(listView3.Items.Count - 1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refreshDemandTab();
        }
    }
}
