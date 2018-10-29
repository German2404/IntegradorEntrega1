namespace PrimeraEntregaIntegrador.View
{
    partial class UCInput
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaClientes = new System.Windows.Forms.NumericUpDown();
            this.desdeArticulos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desdeClientes = new System.Windows.Forms.NumericUpDown();
            this.hastaArticulos = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.aprioriHC = new System.Windows.Forms.NumericUpDown();
            this.aprioriDA = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.aprioriDC = new System.Windows.Forms.NumericUpDown();
            this.aprioriHA = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxMarkov = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.markovHC = new System.Windows.Forms.NumericUpDown();
            this.markovDA = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.markovDC = new System.Windows.Forms.NumericUpDown();
            this.markovHA = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.markovNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonM = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desdeArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desdeClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaArticulos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aprioriHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprioriDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprioriDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprioriHA)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markovHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markovDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markovDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markovHA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markovNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(269, 316);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonBF);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.hastaClientes);
            this.tabPage1.Controls.Add(this.desdeArticulos);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.desdeClientes);
            this.tabPage1.Controls.Add(this.hastaArticulos);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(261, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabFuerzaBruta";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Limitar analisis por numero de articulos comprados:";
            // 
            // buttonBF
            // 
            this.buttonBF.Location = new System.Drawing.Point(46, 196);
            this.buttonBF.Name = "buttonBF";
            this.buttonBF.Size = new System.Drawing.Size(161, 23);
            this.buttonBF.TabIndex = 11;
            this.buttonBF.Text = "Mostrar Asociaciones FB";
            this.buttonBF.UseVisualStyleBackColor = true;
            this.buttonBF.Click += new System.EventHandler(this.buttonBF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde:";
            // 
            // hastaClientes
            // 
            this.hastaClientes.Location = new System.Drawing.Point(50, 146);
            this.hastaClientes.Name = "hastaClientes";
            this.hastaClientes.Size = new System.Drawing.Size(120, 20);
            this.hastaClientes.TabIndex = 10;
            // 
            // desdeArticulos
            // 
            this.desdeArticulos.Location = new System.Drawing.Point(50, 29);
            this.desdeArticulos.Name = "desdeArticulos";
            this.desdeArticulos.Size = new System.Drawing.Size(120, 20);
            this.desdeArticulos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta:";
            // 
            // desdeClientes
            // 
            this.desdeClientes.Location = new System.Drawing.Point(50, 120);
            this.desdeClientes.Name = "desdeClientes";
            this.desdeClientes.Size = new System.Drawing.Size(120, 20);
            this.desdeClientes.TabIndex = 8;
            this.desdeClientes.ValueChanged += new System.EventHandler(this.desdeClientes_ValueChanged);
            // 
            // hastaArticulos
            // 
            this.hastaArticulos.Location = new System.Drawing.Point(50, 55);
            this.hastaArticulos.Name = "hastaArticulos";
            this.hastaArticulos.Size = new System.Drawing.Size(120, 20);
            this.hastaArticulos.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Limitar analisis por frecuencia de compra:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.buttonAP);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.aprioriHC);
            this.tabPage2.Controls.Add(this.aprioriDA);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.aprioriDC);
            this.tabPage2.Controls.Add(this.aprioriHA);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(261, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabAPriori";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Limitar analisis por numero de articulos comprados:";
            // 
            // buttonAP
            // 
            this.buttonAP.Location = new System.Drawing.Point(52, 252);
            this.buttonAP.Name = "buttonAP";
            this.buttonAP.Size = new System.Drawing.Size(138, 23);
            this.buttonAP.TabIndex = 22;
            this.buttonAP.Text = "Generar Reporte";
            this.buttonAP.UseVisualStyleBackColor = true;
            this.buttonAP.Click += new System.EventHandler(this.buttonAP_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Desde:";
            // 
            // aprioriHC
            // 
            this.aprioriHC.Location = new System.Drawing.Point(52, 149);
            this.aprioriHC.Name = "aprioriHC";
            this.aprioriHC.Size = new System.Drawing.Size(120, 20);
            this.aprioriHC.TabIndex = 21;
            // 
            // aprioriDA
            // 
            this.aprioriDA.Location = new System.Drawing.Point(52, 32);
            this.aprioriDA.Name = "aprioriDA";
            this.aprioriDA.Size = new System.Drawing.Size(120, 20);
            this.aprioriDA.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Hasta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Hasta:";
            // 
            // aprioriDC
            // 
            this.aprioriDC.Location = new System.Drawing.Point(52, 123);
            this.aprioriDC.Name = "aprioriDC";
            this.aprioriDC.Size = new System.Drawing.Size(120, 20);
            this.aprioriDC.TabIndex = 19;
            // 
            // aprioriHA
            // 
            this.aprioriHA.Location = new System.Drawing.Point(52, 58);
            this.aprioriHA.Name = "aprioriHA";
            this.aprioriHA.Size = new System.Drawing.Size(120, 20);
            this.aprioriHA.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Desde:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Limitar analisis por frecuencia de compra:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxMarkov);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.markovHC);
            this.tabPage3.Controls.Add(this.markovDA);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.markovDC);
            this.tabPage3.Controls.Add(this.markovHA);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.markovNumber);
            this.tabPage3.Controls.Add(this.buttonM);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(261, 290);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Markov";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxMarkov
            // 
            this.textBoxMarkov.Location = new System.Drawing.Point(52, 229);
            this.textBoxMarkov.Name = "textBoxMarkov";
            this.textBoxMarkov.Size = new System.Drawing.Size(152, 20);
            this.textBoxMarkov.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 213);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(211, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Base de recomendación(Separado comas):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(245, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Limitar analisis por numero de articulos comprados:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Desde:";
            // 
            // markovHC
            // 
            this.markovHC.Location = new System.Drawing.Point(58, 143);
            this.markovHC.Name = "markovHC";
            this.markovHC.Size = new System.Drawing.Size(120, 20);
            this.markovHC.TabIndex = 31;
            // 
            // markovDA
            // 
            this.markovDA.Location = new System.Drawing.Point(58, 26);
            this.markovDA.Name = "markovDA";
            this.markovDA.Size = new System.Drawing.Size(120, 20);
            this.markovDA.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Hasta:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Hasta:";
            // 
            // markovDC
            // 
            this.markovDC.Location = new System.Drawing.Point(58, 117);
            this.markovDC.Name = "markovDC";
            this.markovDC.Size = new System.Drawing.Size(120, 20);
            this.markovDC.TabIndex = 29;
            // 
            // markovHA
            // 
            this.markovHA.Location = new System.Drawing.Point(58, 52);
            this.markovHA.Name = "markovHA";
            this.markovHA.Size = new System.Drawing.Size(120, 20);
            this.markovHA.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Desde:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(201, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Limitar analisis por frecuencia de compra:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Numero de recomendaciones:";
            // 
            // markovNumber
            // 
            this.markovNumber.Location = new System.Drawing.Point(66, 185);
            this.markovNumber.Name = "markovNumber";
            this.markovNumber.Size = new System.Drawing.Size(120, 20);
            this.markovNumber.TabIndex = 18;
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(35, 254);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(180, 23);
            this.buttonM.TabIndex = 0;
            this.buttonM.Text = "Generar Reporte";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click_1);
            // 
            // UCInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UCInput";
            this.Size = new System.Drawing.Size(274, 321);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desdeArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desdeClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaArticulos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aprioriHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprioriDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprioriDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprioriHA)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markovHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markovDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markovDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markovHA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markovNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown hastaClientes;
        private System.Windows.Forms.NumericUpDown desdeArticulos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown desdeClientes;
        private System.Windows.Forms.NumericUpDown hastaArticulos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown aprioriHC;
        private System.Windows.Forms.NumericUpDown aprioriDA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown aprioriDC;
        private System.Windows.Forms.NumericUpDown aprioriHA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxMarkov;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown markovHC;
        private System.Windows.Forms.NumericUpDown markovDA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown markovDC;
        private System.Windows.Forms.NumericUpDown markovHA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown markovNumber;
        private System.Windows.Forms.Button buttonM;
    }
}
