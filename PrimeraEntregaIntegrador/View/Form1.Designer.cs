namespace PrimeraEntregaIntegrador
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ucGraphics1 = new PrimeraEntregaIntegrador.View.UCGraphics();
            this.ucInput1 = new PrimeraEntregaIntegrador.View.UCInput();
            this.SuspendLayout();
            // 
            // ucGraphics1
            // 
            this.ucGraphics1.Location = new System.Drawing.Point(12, 8);
            this.ucGraphics1.Name = "ucGraphics1";
            this.ucGraphics1.Size = new System.Drawing.Size(875, 527);
            this.ucGraphics1.TabIndex = 0;
            // 
            // ucInput1
            // 
            this.ucInput1.Location = new System.Drawing.Point(903, 12);
            this.ucInput1.Name = "ucInput1";
            this.ucInput1.Size = new System.Drawing.Size(274, 321);
            this.ucInput1.TabIndex = 1;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 543);
            this.Controls.Add(this.ucInput1);
            this.Controls.Add(this.ucGraphics1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private View.UCGraphics ucGraphics1;
        private View.UCInput ucInput1;
    }
}