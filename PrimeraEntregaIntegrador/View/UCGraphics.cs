using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrimeraEntregaIntegrador.View
{
    public partial class UCGraphics : UserControl
    {

        Form1 f;

        public UCGraphics()
        {
            
           InitializeComponent();
           
           
        }

        public void modificarGraficas()
        {
            articlesTable.MouseEnter += grafica1_MouseEnter;
            articlesTable.MouseLeave += grafica1_MouseLeave;
            articlesTable.MouseWheel += grafica1_MouseWheel;
            clientsTable.MouseEnter += grafica2_MouseEnter;
            clientsTable.MouseLeave += grafica2_MouseLeave;
            clientsTable.MouseWheel += grafica2_MouseWheel;
        }

        private void grafica1_MouseEnter(object sender, EventArgs e)
        {

            this.articlesTable.Focus();
        }

        private void grafica1_MouseLeave(object sender, EventArgs e)
        {
            this.articlesTable.Parent.Focus();
        }


        private void grafica2_MouseEnter(object sender, EventArgs e)
        {

            this.clientsTable.Focus();
        }

        private void grafica2_MouseLeave(object sender, EventArgs e)
        {
            this.clientsTable.Parent.Focus();
        }


        private void grafica1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            //var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    //yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    //var yMin = yAxis.ScaleView.ViewMinimum;
                    //var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    //var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    //var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    //yAxis.ScaleView.Zoom(posYStart, posYFinish);


                }
            }
            catch { }
        }


        private void grafica2_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            //var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    //yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    //var yMin = yAxis.ScaleView.ViewMinimum;
                    //var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    //var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    //var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    //yAxis.ScaleView.Zoom(posYStart, posYFinish);


                }
            }
            catch { }
        }


        private void cargarHistogramas()
        {
           
            var articulos = f.analyzer.generateArticlesTable();
            //this.desdeArticulos.Minimum = articulos.Min(a => a.Key);
            //this.desdeArticulos.Maximum = articulos.Max(a => a.Key);
            //this.hastaArticulos.Minimum = articulos.Min(a => a.Key);
            //this.hastaArticulos.Maximum = articulos.Max(a => a.Key);


            var clientes = f.analyzer.generateClientsTable();
            //this.desdeClientes.Minimum = clientes.Min(a => a.Key);
            //this.desdeClientes.Maximum = clientes.Max(a => a.Key);
            //this.hastaClientes.Minimum = clientes.Min(a => a.Key);
            //this.hastaClientes.Maximum = clientes.Max(a => a.Key);
            this.articlesTable.Series[0].Points.Clear();

            this.articlesTable.ChartAreas[0].AxisY.Maximum = articulos.Max(a => a.Value) + 20;
            this.articlesTable.ChartAreas[0].AxisX.Title = "Numero de articulos por transaccion";
            this.articlesTable.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            this.articlesTable.ChartAreas[0].AxisY.ScaleView.Zoomable = false;
            this.clientsTable.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            this.clientsTable.ChartAreas[0].AxisY.ScaleView.Zoomable = false;
            this.articlesTable.ChartAreas[0].AxisY.Title = "Frecuencia absoluta";
            this.articlesTable.Series[0].XValueType = ChartValueType.Int32;
            this.clientsTable.Series[0].XValueType = ChartValueType.Int32;
            clientsTable.Series[0]["PointWidth"] = "1";
            articlesTable.Series[0]["PointWidth"] = "1";
            foreach (var cosa in articulos)
            {
                articlesTable.Series[0].Points.AddXY(cosa.Key, cosa.Value);
            }

            this.clientsTable.Series[0].Points.Clear();
            this.articlesTable.Titles.Add("Articulos comprados");
            this.clientsTable.Titles.Add("Frecuencia de compras");
            this.clientsTable.ChartAreas[0].AxisY.Maximum = clientes.Max(a => a.Value) + 20;
            this.clientsTable.ChartAreas[0].AxisX.Title = "Frecuencia de compra de cliente";
            this.clientsTable.ChartAreas[0].AxisY.Title = "Frecuencia absoluta";
            this.clientsTable.Series[0].ToolTip = "(#VALX,#VALY)";
            this.articlesTable.Series[0].ToolTip = "(#VALX,#VALY)";
            foreach (var cosa in clientes)
            {
                clientsTable.Series[0].Points.AddXY(cosa.Key, cosa.Value);
            }
        }

        private void UCGraphics_Load(object sender, EventArgs e)
        {

        }

        private void articlesTable_Click(object sender, EventArgs e)
        {

        }

        private void clientsTable_Click(object sender, EventArgs e)
        {
            
        }

        protected override  void OnLoad(EventArgs e)
        {
            try
            {
                f = (Form1)this.FindForm();
                cargarHistogramas();
                modificarGraficas();
            }
            catch(Exception s)
            {
               String error= s.StackTrace;
            }
            
        }
    }
}
