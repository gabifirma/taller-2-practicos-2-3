namespace Practico2
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
            this.LNya = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBNaranja = new System.Windows.Forms.CheckBox();
            this.CBMastercard = new System.Windows.Forms.CheckBox();
            this.CBVisa = new System.Windows.Forms.CheckBox();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTarjeta = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.RBVaron = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.PImagen = new System.Windows.Forms.PictureBox();
            this.BSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(30, 39);
            this.LNya.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(98, 13);
            this.LNya.TabIndex = 0;
            this.LNya.Text = "Nombre y Apellido: ";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(128, 39);
            this.LModificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(49, 13);
            this.LModificar.TabIndex = 1;
            this.LModificar.Text = "modificar";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(32, 74);
            this.LDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(30, 13);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "*DNI";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(32, 115);
            this.LApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(48, 13);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "*Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(32, 158);
            this.LNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(48, 13);
            this.LNombre.TabIndex = 4;
            this.LNombre.Text = "*Nombre";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(104, 69);
            this.TDni.Margin = new System.Windows.Forms.Padding(2);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(150, 20);
            this.TDni.TabIndex = 5;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(104, 110);
            this.TApellido.Margin = new System.Windows.Forms.Padding(2);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(150, 20);
            this.TApellido.TabIndex = 6;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(104, 156);
            this.TNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(150, 20);
            this.TNombre.TabIndex = 7;
            // 
            // BGuardar
            // 
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(38, 426);
            this.BGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(130, 50);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(210, 426);
            this.BEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(130, 50);
            this.BEliminar.TabIndex = 9;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.CBNaranja);
            this.panel1.Controls.Add(this.CBMastercard);
            this.panel1.Controls.Add(this.CBVisa);
            this.panel1.Controls.Add(this.TTelefono);
            this.panel1.Controls.Add(this.LTarjeta);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.LNya);
            this.panel1.Controls.Add(this.LModificar);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Location = new System.Drawing.Point(38, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 327);
            this.panel1.TabIndex = 10;
            // 
            // CBNaranja
            // 
            this.CBNaranja.AutoSize = true;
            this.CBNaranja.Location = new System.Drawing.Point(104, 285);
            this.CBNaranja.Name = "CBNaranja";
            this.CBNaranja.Size = new System.Drawing.Size(63, 17);
            this.CBNaranja.TabIndex = 13;
            this.CBNaranja.Text = "Naranja";
            this.CBNaranja.UseVisualStyleBackColor = true;
            // 
            // CBMastercard
            // 
            this.CBMastercard.AutoSize = true;
            this.CBMastercard.Location = new System.Drawing.Point(104, 261);
            this.CBMastercard.Name = "CBMastercard";
            this.CBMastercard.Size = new System.Drawing.Size(79, 17);
            this.CBMastercard.TabIndex = 12;
            this.CBMastercard.Text = "Mastercard";
            this.CBMastercard.UseVisualStyleBackColor = true;
            // 
            // CBVisa
            // 
            this.CBVisa.AutoSize = true;
            this.CBVisa.Location = new System.Drawing.Point(104, 238);
            this.CBVisa.Name = "CBVisa";
            this.CBVisa.Size = new System.Drawing.Size(46, 17);
            this.CBVisa.TabIndex = 11;
            this.CBVisa.Text = "Visa";
            this.CBVisa.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(104, 196);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(150, 20);
            this.TTelefono.TabIndex = 10;
            // 
            // LTarjeta
            // 
            this.LTarjeta.AutoSize = true;
            this.LTarjeta.Location = new System.Drawing.Point(35, 238);
            this.LTarjeta.Name = "LTarjeta";
            this.LTarjeta.Size = new System.Drawing.Size(45, 13);
            this.LTarjeta.TabIndex = 9;
            this.LTarjeta.Text = "Tarjétas";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(33, 199);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 8;
            this.LTelefono.Text = "Teléfono";
            // 
            // RBVaron
            // 
            this.RBVaron.AutoSize = true;
            this.RBVaron.Checked = true;
            this.RBVaron.Location = new System.Drawing.Point(365, 184);
            this.RBVaron.Name = "RBVaron";
            this.RBVaron.Size = new System.Drawing.Size(53, 17);
            this.RBVaron.TabIndex = 11;
            this.RBVaron.TabStop = true;
            this.RBVaron.Text = "Varón";
            this.RBVaron.UseVisualStyleBackColor = true;
            this.RBVaron.CheckedChanged += new System.EventHandler(this.RBVaron_CheckedChanged);
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(453, 184);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(51, 17);
            this.RBMujer.TabIndex = 12;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            this.RBMujer.CheckedChanged += new System.EventHandler(this.RBMujer_CheckedChanged);
            // 
            // PImagen
            // 
            this.PImagen.Image = ((System.Drawing.Image)(resources.GetObject("PImagen.Image")));
            this.PImagen.Location = new System.Drawing.Point(381, 69);
            this.PImagen.Name = "PImagen";
            this.PImagen.Size = new System.Drawing.Size(100, 104);
            this.PImagen.TabIndex = 13;
            this.PImagen.TabStop = false;
            // 
            // BSalir
            // 
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(381, 426);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(130, 50);
            this.BSalir.TabIndex = 14;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(193, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nuevo Cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.PImagen);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBVaron);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Pequeño Formulario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CBNaranja;
        private System.Windows.Forms.CheckBox CBMastercard;
        private System.Windows.Forms.CheckBox CBVisa;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label LTarjeta;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.RadioButton RBVaron;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.PictureBox PImagen;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Label label1;
    }
}

