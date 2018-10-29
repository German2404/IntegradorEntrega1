namespace PrimeraEntregaIntegrador.View
{
    partial class UCGraphics
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.articlesTable = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clientsTable = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.articlesTable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clientsTable);
            this.splitContainer1.Size = new System.Drawing.Size(868, 523);
            this.splitContainer1.SplitterDistance = 432;
            this.splitContainer1.TabIndex = 16;
            // 
            // articlesTable
            // 
            chartArea1.Name = "ChartArea1";
            this.articlesTable.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.articlesTable.Legends.Add(legend1);
            this.articlesTable.Location = new System.Drawing.Point(3, 0);
            this.articlesTable.Name = "articlesTable";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.articlesTable.Series.Add(series1);
            this.articlesTable.Size = new System.Drawing.Size(426, 520);
            this.articlesTable.TabIndex = 2;
            this.articlesTable.Text = "articlesTable";
            // 
            // clientsTable
            // 
            chartArea2.Name = "ChartArea1";
            this.clientsTable.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.clientsTable.Legends.Add(legend2);
            this.clientsTable.Location = new System.Drawing.Point(-1, 0);
            this.clientsTable.Name = "clientsTable";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.clientsTable.Series.Add(series2);
            this.clientsTable.Size = new System.Drawing.Size(433, 523);
            this.clientsTable.TabIndex = 0;
            this.clientsTable.Text = "clientsTable";
            this.clientsTable.Click += new System.EventHandler(this.clientsTable_Click);
            // 
            // UCGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCGraphics";
            this.Size = new System.Drawing.Size(875, 527);
            this.Load += new System.EventHandler(this.UCGraphics_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articlesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart articlesTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart clientsTable;
    }
}
