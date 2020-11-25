namespace Formularios
{
    partial class FrmCuentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumeros1 = new Formularios.TextBoxNumeros();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoloCaracteres1 = new Formularios.TextBoxSoloCaracteres();
            this.btnAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de cuentas";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(717, 436);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ABM cuentas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(796, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "IdCliente";
            // 
            // textBoxNumeros1
            // 
            this.textBoxNumeros1.Location = new System.Drawing.Point(940, 62);
            this.textBoxNumeros1.Name = "textBoxNumeros1";
            this.textBoxNumeros1.Size = new System.Drawing.Size(178, 22);
            this.textBoxNumeros1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(796, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripcion";
            // 
            // textBoxSoloCaracteres1
            // 
            this.textBoxSoloCaracteres1.Location = new System.Drawing.Point(940, 119);
            this.textBoxSoloCaracteres1.Name = "textBoxSoloCaracteres1";
            this.textBoxSoloCaracteres1.Size = new System.Drawing.Size(265, 22);
            this.textBoxSoloCaracteres1.TabIndex = 6;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(1017, 180);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(188, 52);
            this.btnAlta.TabIndex = 7;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // FrmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 531);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.textBoxSoloCaracteres1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNumeros1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmCuentas";
            this.Text = "FrmCuentas";
            this.Load += new System.EventHandler(this.FrmCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TextBoxNumeros textBoxNumeros1;
        private System.Windows.Forms.Label label4;
        private TextBoxSoloCaracteres textBoxSoloCaracteres1;
        private System.Windows.Forms.Button btnAlta;
    }
}