namespace Formularios
{
    partial class FrmInicio
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
            this.PictureInicio = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetasDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMTarjetaDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTarjetaDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PictureInicio)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureInicio
            // 
            this.PictureInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureInicio.Image = global::Formularios.Properties.Resources.star_wars_lightsabers_darth_vader_luke_skywalker_wallpaperswa_com_66;
            this.PictureInicio.Location = new System.Drawing.Point(0, 28);
            this.PictureInicio.Name = "PictureInicio";
            this.PictureInicio.Size = new System.Drawing.Size(725, 358);
            this.PictureInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureInicio.TabIndex = 0;
            this.PictureInicio.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.tarjetasDeCreditoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMClienteToolStripMenuItem,
            this.listarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // aBMClienteToolStripMenuItem
            // 
            this.aBMClienteToolStripMenuItem.Name = "aBMClienteToolStripMenuItem";
            this.aBMClienteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.aBMClienteToolStripMenuItem.Text = "ABM Cliente";
            this.aBMClienteToolStripMenuItem.Click += new System.EventHandler(this.aBMClienteToolStripMenuItem_Click);
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.listarClientesToolStripMenuItem.Text = "Listar Clientes";
            // 
            // tarjetasDeCreditoToolStripMenuItem
            // 
            this.tarjetasDeCreditoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMTarjetaDeCreditoToolStripMenuItem,
            this.listarTarjetaDeCreditoToolStripMenuItem});
            this.tarjetasDeCreditoToolStripMenuItem.Name = "tarjetasDeCreditoToolStripMenuItem";
            this.tarjetasDeCreditoToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.tarjetasDeCreditoToolStripMenuItem.Text = "Tarjetas de credito";
            this.tarjetasDeCreditoToolStripMenuItem.Click += new System.EventHandler(this.tarjetasDeCreditoToolStripMenuItem_Click);
            // 
            // aBMTarjetaDeCreditoToolStripMenuItem
            // 
            this.aBMTarjetaDeCreditoToolStripMenuItem.Name = "aBMTarjetaDeCreditoToolStripMenuItem";
            this.aBMTarjetaDeCreditoToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.aBMTarjetaDeCreditoToolStripMenuItem.Text = "ABM Tarjeta de credito";
            this.aBMTarjetaDeCreditoToolStripMenuItem.Click += new System.EventHandler(this.aBMTarjetaDeCreditoToolStripMenuItem_Click);
            // 
            // listarTarjetaDeCreditoToolStripMenuItem
            // 
            this.listarTarjetaDeCreditoToolStripMenuItem.Name = "listarTarjetaDeCreditoToolStripMenuItem";
            this.listarTarjetaDeCreditoToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.listarTarjetaDeCreditoToolStripMenuItem.Text = "Listar Tarjeta de credito";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 386);
            this.Controls.Add(this.PictureInicio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.PictureInicio)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureInicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetasDeCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMTarjetaDeCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTarjetaDeCreditoToolStripMenuItem;
    }
}

