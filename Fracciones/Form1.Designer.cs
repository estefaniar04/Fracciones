namespace Fracciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numNumerador1 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador1 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador2 = new System.Windows.Forms.NumericUpDown();
            this.numNumerador2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCalcularResultado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultadoDenominador = new System.Windows.Forms.Label();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.Numentero2 = new System.Windows.Forms.NumericUpDown();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblResultadoNumerador = new System.Windows.Forms.Label();
            this.Numentero1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numentero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numentero1)).BeginInit();
            this.SuspendLayout();
            // 
            // numNumerador1
            // 
            this.numNumerador1.Location = new System.Drawing.Point(86, 72);
            this.numNumerador1.Name = "numNumerador1";
            this.numNumerador1.Size = new System.Drawing.Size(77, 20);
            this.numNumerador1.TabIndex = 0;
            // 
            // numDenominador1
            // 
            this.numDenominador1.Location = new System.Drawing.Point(86, 117);
            this.numDenominador1.Name = "numDenominador1";
            this.numDenominador1.Size = new System.Drawing.Size(77, 20);
            this.numDenominador1.TabIndex = 1;
            // 
            // numDenominador2
            // 
            this.numDenominador2.Location = new System.Drawing.Point(304, 112);
            this.numDenominador2.Name = "numDenominador2";
            this.numDenominador2.Size = new System.Drawing.Size(78, 20);
            this.numDenominador2.TabIndex = 3;
            // 
            // numNumerador2
            // 
            this.numNumerador2.Location = new System.Drawing.Point(304, 72);
            this.numNumerador2.Name = "numNumerador2";
            this.numNumerador2.Size = new System.Drawing.Size(78, 20);
            this.numNumerador2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "_________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "_________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "+";
            // 
            // lblCalcularResultado
            // 
            this.lblCalcularResultado.AutoSize = true;
            this.lblCalcularResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcularResultado.Location = new System.Drawing.Point(400, 88);
            this.lblCalcularResultado.Name = "lblCalcularResultado";
            this.lblCalcularResultado.Size = new System.Drawing.Size(24, 25);
            this.lblCalcularResultado.TabIndex = 7;
            this.lblCalcularResultado.Text = "=";
            this.lblCalcularResultado.Click += new System.EventHandler(this.lblCalcularResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(443, 88);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(23, 25);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "x";
            // 
            // lblResultadoDenominador
            // 
            this.lblResultadoDenominador.AutoSize = true;
            this.lblResultadoDenominador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDenominador.Location = new System.Drawing.Point(513, 112);
            this.lblResultadoDenominador.Name = "lblResultadoDenominador";
            this.lblResultadoDenominador.Size = new System.Drawing.Size(23, 25);
            this.lblResultadoDenominador.TabIndex = 9;
            this.lblResultadoDenominador.Text = "x";
            // 
            // cboOperacion
            // 
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.cboOperacion.Location = new System.Drawing.Point(177, 95);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(44, 21);
            this.cboOperacion.TabIndex = 10;
            // 
            // Numentero2
            // 
            this.Numentero2.Location = new System.Drawing.Point(238, 95);
            this.Numentero2.Name = "Numentero2";
            this.Numentero2.Size = new System.Drawing.Size(41, 20);
            this.Numentero2.TabIndex = 11;
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(487, 88);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(109, 13);
            this.lblLinea.TabIndex = 12;
            this.lblLinea.Text = "_________________";
            // 
            // lblResultadoNumerador
            // 
            this.lblResultadoNumerador.AutoSize = true;
            this.lblResultadoNumerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoNumerador.Location = new System.Drawing.Point(513, 63);
            this.lblResultadoNumerador.Name = "lblResultadoNumerador";
            this.lblResultadoNumerador.Size = new System.Drawing.Size(23, 25);
            this.lblResultadoNumerador.TabIndex = 13;
            this.lblResultadoNumerador.Text = "x";
            // 
            // Numentero1
            // 
            this.Numentero1.Location = new System.Drawing.Point(12, 96);
            this.Numentero1.Name = "Numentero1";
            this.Numentero1.Size = new System.Drawing.Size(41, 20);
            this.Numentero1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numentero1);
            this.Controls.Add(this.lblResultadoNumerador);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.Numentero2);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.lblResultadoDenominador);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblCalcularResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDenominador2);
            this.Controls.Add(this.numNumerador2);
            this.Controls.Add(this.numDenominador1);
            this.Controls.Add(this.numNumerador1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numentero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numentero1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNumerador1;
        private System.Windows.Forms.NumericUpDown numDenominador1;
        private System.Windows.Forms.NumericUpDown numDenominador2;
        private System.Windows.Forms.NumericUpDown numNumerador2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCalcularResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultadoDenominador;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.NumericUpDown Numentero2;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblResultadoNumerador;
        private System.Windows.Forms.NumericUpDown Numentero1;
    }
}

