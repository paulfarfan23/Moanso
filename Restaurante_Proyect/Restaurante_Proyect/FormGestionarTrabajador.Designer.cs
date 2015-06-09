namespace Restaurante_Proyect
{
    partial class FormGestionarTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarTrabajador));
            this.barOpciones = new System.Windows.Forms.ToolStrip();
            this.botCrear = new System.Windows.Forms.ToolStripButton();
            this.botModificar = new System.Windows.Forms.ToolStripButton();
            this.botEliminar = new System.Windows.Forms.ToolStripButton();
            this.botCerrar = new System.Windows.Forms.ToolStripButton();
            this.dataAlumnos = new System.Windows.Forms.DataGridView();
            this.botBuscar = new System.Windows.Forms.Button();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.etiNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.barOpciones.Size = new System.Drawing.Size(597, 25);
            this.barOpciones.TabIndex = 2;
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
            this.usuario,
            this.nombre,
            this.dni,
            this.direccion,
            this.telefono,
            this.tipoTrabajador,
            this.correo,
            this.Password});
            this.dataAlumnos.Location = new System.Drawing.Point(1, 93);
            this.dataAlumnos.MultiSelect = false;
            this.dataAlumnos.Name = "dataAlumnos";
            this.dataAlumnos.ReadOnly = true;
            this.dataAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAlumnos.Size = new System.Drawing.Size(596, 333);
            this.dataAlumnos.TabIndex = 12;
            // 
            // botBuscar
            // 
            this.botBuscar.Image = ((System.Drawing.Image)(resources.GetObject("botBuscar.Image")));
            this.botBuscar.Location = new System.Drawing.Point(487, 44);
            this.botBuscar.Name = "botBuscar";
            this.botBuscar.Size = new System.Drawing.Size(75, 23);
            this.botBuscar.TabIndex = 11;
            this.botBuscar.Text = "Buscar";
            this.botBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botBuscar.UseVisualStyleBackColor = true;
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(74, 46);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(390, 20);
            this.texNombre.TabIndex = 10;
            // 
            // etiNombre
            // 
            this.etiNombre.AutoSize = true;
            this.etiNombre.Location = new System.Drawing.Point(-58, 47);
            this.etiNombre.Name = "etiNombre";
            this.etiNombre.Size = new System.Drawing.Size(47, 13);
            this.etiNombre.TabIndex = 9;
            this.etiNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Nombre";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "DNI";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // dni
            // 
            this.dni.HeaderText = "Dirección";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 80;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Correo-e";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 200;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // tipoTrabajador
            // 
            this.tipoTrabajador.HeaderText = "Tipo de Trabajador";
            this.tipoTrabajador.Name = "tipoTrabajador";
            this.tipoTrabajador.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.HeaderText = "Usuario";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 200;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // FormGestionarTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataAlumnos);
            this.Controls.Add(this.botBuscar);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.etiNombre);
            this.Controls.Add(this.barOpciones);
            this.Name = "FormGestionarTrabajador";
            this.Text = "Gestionar Trabajador";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}