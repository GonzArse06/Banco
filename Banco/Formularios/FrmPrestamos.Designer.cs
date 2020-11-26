namespace Formularios
{
    partial class FrmPrestamos
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
            this.gbTipoPrestamos = new System.Windows.Forms.GroupBox();
            this.gbPrestamosAltas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTipoPrestamos = new System.Windows.Forms.ListBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtTna = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonto = new Formularios.TextBoxNumeros();
            this.txtPlazo = new Formularios.TextBoxNumeros();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtCuotaInteres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCuotaCapital = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCuotaTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtIdCliente = new Formularios.TextBoxNumeros();
            this.label11 = new System.Windows.Forms.Label();
            this.gbTipoPrestamos.SuspendLayout();
            this.gbPrestamosAltas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTipoPrestamos
            // 
            this.gbTipoPrestamos.Controls.Add(this.txtIdCliente);
            this.gbTipoPrestamos.Controls.Add(this.label11);
            this.gbTipoPrestamos.Controls.Add(this.btnAlta);
            this.gbTipoPrestamos.Controls.Add(this.txtCuotaTotal);
            this.gbTipoPrestamos.Controls.Add(this.label10);
            this.gbTipoPrestamos.Controls.Add(this.txtCuotaInteres);
            this.gbTipoPrestamos.Controls.Add(this.label8);
            this.gbTipoPrestamos.Controls.Add(this.txtCuotaCapital);
            this.gbTipoPrestamos.Controls.Add(this.label9);
            this.gbTipoPrestamos.Controls.Add(this.btnSimular);
            this.gbTipoPrestamos.Controls.Add(this.txtPlazo);
            this.gbTipoPrestamos.Controls.Add(this.label7);
            this.gbTipoPrestamos.Controls.Add(this.txtMonto);
            this.gbTipoPrestamos.Controls.Add(this.label6);
            this.gbTipoPrestamos.Controls.Add(this.txtTna);
            this.gbTipoPrestamos.Controls.Add(this.label5);
            this.gbTipoPrestamos.Controls.Add(this.txtLinea);
            this.gbTipoPrestamos.Controls.Add(this.label4);
            this.gbTipoPrestamos.Controls.Add(this.lstTipoPrestamos);
            this.gbTipoPrestamos.Controls.Add(this.label1);
            this.gbTipoPrestamos.Location = new System.Drawing.Point(12, 12);
            this.gbTipoPrestamos.Name = "gbTipoPrestamos";
            this.gbTipoPrestamos.Size = new System.Drawing.Size(649, 553);
            this.gbTipoPrestamos.TabIndex = 0;
            this.gbTipoPrestamos.TabStop = false;
            // 
            // gbPrestamosAltas
            // 
            this.gbPrestamosAltas.Controls.Add(this.textBox1);
            this.gbPrestamosAltas.Controls.Add(this.label3);
            this.gbPrestamosAltas.Controls.Add(this.lstPrestamos);
            this.gbPrestamosAltas.Controls.Add(this.label2);
            this.gbPrestamosAltas.Location = new System.Drawing.Point(697, 12);
            this.gbPrestamosAltas.Name = "gbPrestamosAltas";
            this.gbPrestamosAltas.Size = new System.Drawing.Size(525, 553);
            this.gbPrestamosAltas.TabIndex = 1;
            this.gbPrestamosAltas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO PRESTAMOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRESTAMOS DADOS DE ALTA";
            // 
            // lstTipoPrestamos
            // 
            this.lstTipoPrestamos.FormattingEnabled = true;
            this.lstTipoPrestamos.ItemHeight = 16;
            this.lstTipoPrestamos.Location = new System.Drawing.Point(6, 61);
            this.lstTipoPrestamos.Name = "lstTipoPrestamos";
            this.lstTipoPrestamos.Size = new System.Drawing.Size(301, 452);
            this.lstTipoPrestamos.TabIndex = 1;
            this.lstTipoPrestamos.SelectedIndexChanged += new System.EventHandler(this.lstTipoPrestamos_SelectedIndexChanged);
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.ItemHeight = 16;
            this.lstPrestamos.Location = new System.Drawing.Point(18, 61);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(487, 356);
            this.lstPrestamos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comision total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 449);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(252, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Linea";
            // 
            // txtLinea
            // 
            this.txtLinea.Enabled = false;
            this.txtLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea.Location = new System.Drawing.Point(457, 68);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.ReadOnly = true;
            this.txtLinea.Size = new System.Drawing.Size(171, 27);
            this.txtLinea.TabIndex = 3;
            // 
            // txtTna
            // 
            this.txtTna.Enabled = false;
            this.txtTna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTna.Location = new System.Drawing.Point(457, 110);
            this.txtTna.Name = "txtTna";
            this.txtTna.ReadOnly = true;
            this.txtTna.Size = new System.Drawing.Size(171, 27);
            this.txtTna.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "TNA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(457, 165);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(171, 27);
            this.txtMonto.TabIndex = 7;
            // 
            // txtPlazo
            // 
            this.txtPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlazo.Location = new System.Drawing.Point(457, 219);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(171, 27);
            this.txtPlazo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Plazo";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(369, 283);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(259, 44);
            this.btnSimular.TabIndex = 10;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtCuotaInteres
            // 
            this.txtCuotaInteres.Enabled = false;
            this.txtCuotaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotaInteres.Location = new System.Drawing.Point(457, 394);
            this.txtCuotaInteres.Name = "txtCuotaInteres";
            this.txtCuotaInteres.ReadOnly = true;
            this.txtCuotaInteres.Size = new System.Drawing.Size(171, 27);
            this.txtCuotaInteres.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cuota (Interes)";
            // 
            // txtCuotaCapital
            // 
            this.txtCuotaCapital.Enabled = false;
            this.txtCuotaCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotaCapital.Location = new System.Drawing.Point(457, 346);
            this.txtCuotaCapital.Name = "txtCuotaCapital";
            this.txtCuotaCapital.ReadOnly = true;
            this.txtCuotaCapital.Size = new System.Drawing.Size(171, 27);
            this.txtCuotaCapital.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cuota (capital)";
            // 
            // txtCuotaTotal
            // 
            this.txtCuotaTotal.Enabled = false;
            this.txtCuotaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotaTotal.Location = new System.Drawing.Point(457, 447);
            this.txtCuotaTotal.Name = "txtCuotaTotal";
            this.txtCuotaTotal.ReadOnly = true;
            this.txtCuotaTotal.Size = new System.Drawing.Size(171, 27);
            this.txtCuotaTotal.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "CUOTA TOTAL";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(369, 491);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(259, 44);
            this.btnAlta.TabIndex = 17;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(457, 18);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(104, 27);
            this.txtIdCliente.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "IdCliente";
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 611);
            this.Controls.Add(this.gbPrestamosAltas);
            this.Controls.Add(this.gbTipoPrestamos);
            this.Name = "FrmPrestamos";
            this.Text = "FrmPrestamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            this.gbTipoPrestamos.ResumeLayout(false);
            this.gbTipoPrestamos.PerformLayout();
            this.gbPrestamosAltas.ResumeLayout(false);
            this.gbPrestamosAltas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipoPrestamos;
        private TextBoxNumeros txtMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstTipoPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPrestamosAltas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtCuotaTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCuotaInteres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCuotaCapital;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSimular;
        private TextBoxNumeros txtPlazo;
        private System.Windows.Forms.Label label7;
        private TextBoxNumeros txtIdCliente;
        private System.Windows.Forms.Label label11;
    }
}