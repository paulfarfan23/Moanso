namespace Restaurante_Proyect
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.planificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.planificacionToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // planificacionToolStripMenuItem
            // 
            this.planificacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarProductoToolStripMenuItem,
            this.gestionarPagoToolStripMenuItem});
            this.planificacionToolStripMenuItem.Name = "planificacionToolStripMenuItem";
            this.planificacionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.planificacionToolStripMenuItem.Text = "Planificacion";
            this.planificacionToolStripMenuItem.Click += new System.EventHandler(this.planificacionToolStripMenuItem_Click);
            // 
            // gestionarProductoToolStripMenuItem
            // 
            this.gestionarProductoToolStripMenuItem.Name = "gestionarProductoToolStripMenuItem";
            this.gestionarProductoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gestionarProductoToolStripMenuItem.Text = "Gestionar Producto";
            // 
            // gestionarPagoToolStripMenuItem
            // 
            this.gestionarPagoToolStripMenuItem.Name = "gestionarPagoToolStripMenuItem";
            this.gestionarPagoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gestionarPagoToolStripMenuItem.Text = "Gestionar Trabajador";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDiarioToolStripMenuItem,
            this.reporteMensualToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.controlToolStripMenuItem.Text = "Reporte";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // reporteDiarioToolStripMenuItem
            // 
            this.reporteDiarioToolStripMenuItem.Name = "reporteDiarioToolStripMenuItem";
            this.reporteDiarioToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.reporteDiarioToolStripMenuItem.Text = "Reporte Diario";
            // 
            // reporteMensualToolStripMenuItem
            // 
            this.reporteMensualToolStripMenuItem.Name = "reporteMensualToolStripMenuItem";
            this.reporteMensualToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.reporteMensualToolStripMenuItem.Text = "Reporte Mensual";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 386);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem planificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteMensualToolStripMenuItem;

    }
}

