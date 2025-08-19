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
            this.SuspendLayout();
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(39, 35);
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
            this.LModificar.Location = new System.Drawing.Point(137, 35);
            this.LModificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(49, 13);
            this.LModificar.TabIndex = 1;
            this.LModificar.Text = "modificar";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(41, 70);
            this.LDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(41, 111);
            this.LApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(41, 154);
            this.LNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 4;
            this.LNombre.Text = "Nombre";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(113, 65);
            this.TDni.Margin = new System.Windows.Forms.Padding(2);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(150, 20);
            this.TDni.TabIndex = 5;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(113, 106);
            this.TApellido.Margin = new System.Windows.Forms.Padding(2);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(150, 20);
            this.TApellido.TabIndex = 6;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(113, 152);
            this.TNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(150, 20);
            this.TNombre.TabIndex = 7;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(113, 207);
            this.BGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(56, 19);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(206, 207);
            this.BEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(56, 19);
            this.BEliminar.TabIndex = 9;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 444);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LModificar);
            this.Controls.Add(this.LNya);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Pequeño Formulario";
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
    }
}

