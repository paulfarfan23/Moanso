namespace Restaurante_Proyect
{
    partial class FormRegistroProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroProducto));
            this.botCancelar = new System.Windows.Forms.Button();
            this.botGuardar = new System.Windows.Forms.Button();
            this.texCorreo = new System.Windows.Forms.TextBox();
            this.texDireccion = new System.Windows.Forms.TextBox();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // botCancelar
            // 
            this.botCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botCancelar.Image")));
            this.botCancelar.Location = new System.Drawing.Point(292, 217);
            this.botCancelar.Name = "botCancelar";
            this.botCancelar.Size = new System.Drawing.Size(75, 26);
            this.botCancelar.TabIndex = 19;
            this.botCancelar.Text = "Cancelar";
            this.botCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botCancelar.UseVisualStyleBackColor = true;
            // 
            // botGuardar
            // 
            this.botGuardar.Image = ((System.Drawing.Image)(resources.GetObject("botGuardar.Image")));
            this.botGuardar.Location = new System.Drawing.Point(193, 217);
            this.botGuardar.Name = "botGuardar";
            this.botGuardar.Size = new System.Drawing.Size(75, 26);
            this.botGuardar.TabIndex = 18;
            this.botGuardar.Text = "Guardar";
            this.botGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botGuardar.UseVisualStyleBackColor = true;
            // 
            // texCorreo
            // 
            this.texCorreo.Location = new System.Drawing.Point(127, 151);
            this.texCorreo.MaxLength = 40;
            this.texCorreo.Name = "texCorreo";
            this.texCorreo.Size = new System.Drawing.Size(229, 20);
            this.texCorreo.TabIndex = 17;
            // 
            // texDireccion
            // 
            this.texDireccion.Location = new System.Drawing.Point(127, 115);
            this.texDireccion.MaxLength = 50;
            this.texDireccion.Name = "texDireccion";
            this.texDireccion.Size = new System.Drawing.Size(229, 20);
            this.texDireccion.TabIndex = 16;
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(127, 39);
            this.texNombre.MaxLength = 40;
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(229, 20);
            this.texNombre.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descripciòn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // FormRegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botCancelar);
            this.Controls.Add(this.botGuardar);
            this.Controls.Add(this.texCorreo);
            this.Controls.Add(this.texDireccion);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistroProducto";
            this.Text = "Datos de Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botCancelar;
        private System.Windows.Forms.Button botGuardar;
        private System.Windows.Forms.TextBox texCorreo;
        private System.Windows.Forms.TextBox texDireccion;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}