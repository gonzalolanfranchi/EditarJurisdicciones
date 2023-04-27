namespace WindowsFormsApp1
{
    partial class Principal
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
            this.lblPrimeraFactura = new System.Windows.Forms.Label();
            this.nudPrimerFactura = new System.Windows.Forms.NumericUpDown();
            this.btnEjecutar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimerFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimeraFactura
            // 
            this.lblPrimeraFactura.AutoSize = true;
            this.lblPrimeraFactura.Location = new System.Drawing.Point(13, 13);
            this.lblPrimeraFactura.Name = "lblPrimeraFactura";
            this.lblPrimeraFactura.Size = new System.Drawing.Size(120, 13);
            this.lblPrimeraFactura.TabIndex = 0;
            this.lblPrimeraFactura.Text = "Primera factura del mes:";
            // 
            // nudPrimerFactura
            // 
            this.nudPrimerFactura.Location = new System.Drawing.Point(140, 11);
            this.nudPrimerFactura.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrimerFactura.Name = "nudPrimerFactura";
            this.nudPrimerFactura.Size = new System.Drawing.Size(83, 20);
            this.nudPrimerFactura.TabIndex = 1;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(148, 46);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 3;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 89);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.nudPrimerFactura);
            this.Controls.Add(this.lblPrimeraFactura);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimerFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeraFactura;
        private System.Windows.Forms.NumericUpDown nudPrimerFactura;
        private System.Windows.Forms.Button btnEjecutar;
    }
}