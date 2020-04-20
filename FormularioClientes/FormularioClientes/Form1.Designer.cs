namespace FormularioClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textboxNombre = new System.Windows.Forms.TextBox();
            this.textboxApellido = new System.Windows.Forms.TextBox();
            this.textboxDireccion = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.fecNac = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.linkblog = new System.Windows.Forms.LinkLabel();
            this.linkyoutube = new System.Windows.Forms.LinkLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botonGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.botonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.botonCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.botonBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxNombre
            // 
            this.textboxNombre.Location = new System.Drawing.Point(220, 62);
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.Size = new System.Drawing.Size(243, 20);
            this.textboxNombre.TabIndex = 0;
            // 
            // textboxApellido
            // 
            this.textboxApellido.Location = new System.Drawing.Point(220, 110);
            this.textboxApellido.Name = "textboxApellido";
            this.textboxApellido.Size = new System.Drawing.Size(243, 20);
            this.textboxApellido.TabIndex = 1;
            // 
            // textboxDireccion
            // 
            this.textboxDireccion.Location = new System.Drawing.Point(220, 192);
            this.textboxDireccion.Multiline = true;
            this.textboxDireccion.Name = "textboxDireccion";
            this.textboxDireccion.Size = new System.Drawing.Size(243, 42);
            this.textboxDireccion.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.SteelBlue;
            this.nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.nombre.Location = new System.Drawing.Point(43, 69);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(47, 13);
            this.nombre.TabIndex = 4;
            this.nombre.Text = "Nombre:";
            // 
            // fecNac
            // 
            this.fecNac.AutoSize = true;
            this.fecNac.BackColor = System.Drawing.Color.SteelBlue;
            this.fecNac.ForeColor = System.Drawing.SystemColors.Control;
            this.fecNac.Location = new System.Drawing.Point(40, 159);
            this.fecNac.Name = "fecNac";
            this.fecNac.Size = new System.Drawing.Size(111, 13);
            this.fecNac.TabIndex = 5;
            this.fecNac.Text = "Fecha de Nacimiento:";
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.BackColor = System.Drawing.Color.SteelBlue;
            this.direccion.ForeColor = System.Drawing.SystemColors.Control;
            this.direccion.Location = new System.Drawing.Point(40, 199);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(55, 13);
            this.direccion.TabIndex = 6;
            this.direccion.Text = "Dirección:";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.BackColor = System.Drawing.Color.SteelBlue;
            this.apellido.ForeColor = System.Drawing.SystemColors.Control;
            this.apellido.Location = new System.Drawing.Point(43, 116);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(47, 13);
            this.apellido.TabIndex = 7;
            this.apellido.Text = "Apellido:";
            // 
            // linkblog
            // 
            this.linkblog.AutoSize = true;
            this.linkblog.LinkColor = System.Drawing.Color.Black;
            this.linkblog.Location = new System.Drawing.Point(12, 9);
            this.linkblog.Name = "linkblog";
            this.linkblog.Size = new System.Drawing.Size(48, 13);
            this.linkblog.TabIndex = 8;
            this.linkblog.TabStop = true;
            this.linkblog.Text = "Ir al Blog";
            // 
            // linkyoutube
            // 
            this.linkyoutube.AutoSize = true;
            this.linkyoutube.LinkColor = System.Drawing.Color.Black;
            this.linkyoutube.Location = new System.Drawing.Point(432, 9);
            this.linkyoutube.Name = "linkyoutube";
            this.linkyoutube.Size = new System.Drawing.Size(77, 13);
            this.linkyoutube.TabIndex = 9;
            this.linkyoutube.TabStop = true;
            this.linkyoutube.Text = "Canal Youtube";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botonGuardar,
            this.toolStripSeparator2,
            this.botonEliminar,
            this.toolStripSeparator4,
            this.botonCancelar,
            this.toolStripSeparator5,
            this.botonBuscar,
            this.toolStripSeparator6});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 498);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(513, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // botonGuardar
            // 
            this.botonGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.botonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("botonGuardar.Image")));
            this.botonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(69, 22);
            this.botonGuardar.Text = "&Guardar";
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // botonEliminar
            // 
            this.botonEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.botonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("botonEliminar.Image")));
            this.botonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(70, 22);
            this.botonEliminar.Text = "&Eliminar";
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // botonCancelar
            // 
            this.botonCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.botonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botonCancelar.Image")));
            this.botonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(73, 22);
            this.botonCancelar.Text = "&Cancelar";
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Enabled = false;
            this.botonBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.botonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("botonBuscar.Image")));
            this.botonBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(62, 22);
            this.botonBuscar.Text = "&Buscar";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(220, 151);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(243, 20);
            this.datePicker.TabIndex = 11;
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBoxDatosPersonales.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(29, 45);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(461, 209);
            this.groupBoxDatosPersonales.TabIndex = 12;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Datos Personales";
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(29, 276);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(461, 189);
            this.dgvBuscar.TabIndex = 13;
            this.dgvBuscar.Click += new System.EventHandler(this.dgvBuscar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(513, 523);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.linkyoutube);
            this.Controls.Add(this.linkblog);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.fecNac);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.textboxDireccion);
            this.Controls.Add(this.textboxApellido);
            this.Controls.Add(this.textboxNombre);
            this.Controls.Add(this.groupBoxDatosPersonales);
            this.Name = "Form1";
            this.Text = "Administración de Clientes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxNombre;
        private System.Windows.Forms.TextBox textboxApellido;
        private System.Windows.Forms.TextBox textboxDireccion;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label fecNac;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.LinkLabel linkblog;
        private System.Windows.Forms.LinkLabel linkyoutube;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ToolStripButton botonGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton botonEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton botonBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton botonCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.GroupBox groupBoxDatosPersonales;
        private System.Windows.Forms.DataGridView dgvBuscar;
    }
}

