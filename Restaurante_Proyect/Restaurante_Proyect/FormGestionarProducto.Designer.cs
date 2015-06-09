namespace FormGestionarProducto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barOpciones = new System.Windows.Forms.ToolStrip();
            this.botCrear = new System.Windows.Forms.ToolStripButton();
            this.botModificar = new System.Windows.Forms.ToolStripButton();
            this.botEliminar = new System.Windows.Forms.ToolStripButton();
            this.botCerrar = new System.Windows.Forms.ToolStripButton();
            this.dataAlumnos = new System.Windows.Forms.DataGridView();
            this.botBuscar = new System.Windows.Forms.Button();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.etiNombre = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // barOpciones
            // 
            this.barOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botCrear,
            this.botModificar,
            this.botEliminar,
            this.botCerrar});
            this.barOpciones.Location = new System.Drawing.Point(0, 0);
            this.barOpciones.Name = "barOpciones";
            this.barOpciones.Size = new System.Drawing.Size(613, 25);
            this.barOpciones.TabIndex = 1;
            this.barOpciones.Text = "toolStrip1";
            // 
            // botCrear
            // 
            this.botCrear.Image = ((System.Drawing.Image)(resources.GetObject("botCrear.Image")));
            this.botCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCrear.Name = "botCrear";
            this.botCrear.Size = new System.Drawing.Size(55, 22);
            this.botCrear.Text = "Crear";
            // 
            // botModificar
            // 
            this.botModificar.Image = ((System.Drawing.Image)(resources.GetObject("botModificar.Image")));
            this.botModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botModificar.Name = "botModificar";
            this.botModificar.Size = new System.Drawing.Size(78, 22);
            this.botModificar.Text = "Modificar";
            // 
            // botEliminar
            // 
            this.botEliminar.Image = ((System.Drawing.Image)(resources.GetObject("botEliminar.Image")));
            this.botEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botEliminar.Name = "botEliminar";
            this.botEliminar.Size = new System.Drawing.Size(70, 22);
            this.botEliminar.Text = "Eliminar";
            // 
            // botCerrar
            // 
            this.botCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botCerrar.Image")));
            this.botCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCerrar.Name = "botCerrar";
            this.botCerrar.Size = new System.Drawing.Size(59, 22);
            this.botCerrar.Text = "Cerrar";
            // 
            // dataAlumnos
            // 
            this.dataAlumnos.AllowUserToAddRows = false;
            this.dataAlumnos.AllowUserToDeleteRows = false;
            this.dataAlumnos.AllowUserToResizeRows = false;
            this.dataAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.Tipo,
            this.Descripcion,
            this.correo});
            this.dataAlumnos.Location = new System.Drawing.Point(12, 102);
            this.dataAlumnos.MultiSelect = false;
            this.dataAlumnos.Name = "dataAlumnos";
            this.dataAlumnos.ReadOnly = true;
            this.dataAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAlumnos.Size = new System.Drawing.Size(596, 333);
            this.dataAlumnos.TabIndex = 8;
            // 
            // botBuscar
            // 
            this.botBuscar.Image = ((System.Drawing.Image)(resources.GetObject("botBuscar.Image")));
            this.botBuscar.Location = new System.Drawing.Point(466, 57);
            this.botBuscar.Name = "botBuscar";
            this.botBuscar.Size = new System.Drawing.Size(75, 23);
            this.botBuscar.TabIndex = 7;
            this.botBuscar.Text = "Buscar";
            this.botBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botBuscar.UseVisualStyleBackColor = true;
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(70, 59);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(390, 20);
            this.texNombre.TabIndex = 6;
            // 
            // etiNombre
            // 
            this.etiNombre.AutoSize = true;
            this.etiNombre.Location = new System.Drawing.Point(12, 62);
            this.etiNombre.Name = "etiNombre";
            this.etiNombre.Size = new System.Drawing.Size(47, 13);
            this.etiNombre.TabIndex = 5;
            this.etiNombre.Text = "Nombre:";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // correo
            // 
            this.correo.HeaderText = "Stock";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 501);
            this.Controls.Add(this.dataAlumnos);
            this.Controls.Add(this.botBuscar);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.etiNombre);
            this.Controls.Add(this.barOpciones);
            this.Name = "Form1";
            this.Text = "GestionarProducto";
            this.barOpciones.ResumeLayout(false);
            this.barOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barOpciones;
        private System.Windows.Forms.ToolStripButton botCrear;
        private System.Windows.Forms.ToolStripButton botModificar;
        private System.Windows.Forms.ToolStripButton botEliminar;
        private System.Windows.Forms.ToolStripButton botCerrar;
        private System.Windows.Forms.DataGridView dataAlumnos;
        private System.Windows.Forms.Button botBuscar;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.Label etiNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
    }
}

