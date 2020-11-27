namespace Formularios
{
    partial class FrmPlazoFijo
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPlazoFijo = new System.Windows.Forms.ListBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInteres = new Formularios.TextBoxNumeros();
            this.txtTasa = new Formularios.TextBoxNumeros();
            this.txtCapitalInicial = new Formularios.TextBoxNumeros();
            this.txtDias = new Formularios.TextBoxNumeros();
            this.txtTipo = new Formularios.TextBoxNumeros();
            this.txtIDCliente = new Formularios.TextBoxNumeros();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(870, 431);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(222, 37);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(681, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nuevo Plazo Fijo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Listado de Plazo fijo";
            // 
            // lstPlazoFijo
            // 
            this.lstPlazoFijo.FormattingEnabled = true;
            this.lstPlazoFijo.ItemHeight = 16;
            this.lstPlazoFijo.Location = new System.Drawing.Point(18, 63);
            this.lstPlazoFijo.Name = "lstPlazoFijo";
            this.lstPlazoFijo.Size = new System.Drawing.Size(623, 388);
            this.lstPlazoFijo.TabIndex = 11;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(1047, 71);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 23;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(692, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Dias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(692, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Capital Inicial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tasa TNA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Interes";
            // 
            // txtInteres
            // 
            this.txtInteres.Enabled = false;
            this.txtInteres.Location = new System.Drawing.Point(846, 316);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(162, 22);
            this.txtInteres.TabIndex = 31;
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(846, 273);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(162, 22);
            this.txtTasa.TabIndex = 29;
            this.txtTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasa_KeyPress);
            // 
            // txtCapitalInicial
            // 
            this.txtCapitalInicial.Location = new System.Drawing.Point(846, 228);
            this.txtCapitalInicial.Name = "txtCapitalInicial";
            this.txtCapitalInicial.Size = new System.Drawing.Size(162, 22);
            this.txtCapitalInicial.TabIndex = 27;
            this.txtCapitalInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapitalInicial_KeyPress);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(846, 182);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(162, 22);
            this.txtDias.TabIndex = 25;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(844, 129);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(162, 22);
            this.txtTipo.TabIndex = 24;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(844, 71);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(162, 22);
            this.txtIDCliente.TabIndex = 12;
            // 
            // FrmPlazoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 514);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCapitalInicial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPlazoFijo);
            this.Name = "FrmPlazoFijo";
            this.Text = "FrmPlazoFijo";
            this.Load += new System.EventHandler(this.FrmPlazoFijo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private TextBoxNumeros txtIDCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPlazoFijo;
        private System.Windows.Forms.Button btnBuscarCliente;
        private TextBoxNumeros txtTipo;
        private TextBoxNumeros txtDias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private TextBoxNumeros txtCapitalInicial;
        private System.Windows.Forms.Label label9;
        private TextBoxNumeros txtTasa;
        private System.Windows.Forms.Label label5;
        private TextBoxNumeros txtInteres;
    }
}