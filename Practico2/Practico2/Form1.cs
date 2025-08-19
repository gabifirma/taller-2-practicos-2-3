using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string apellido = TApellido.Text;
            string nombre = TNombre.Text;
            Boolean valorDni = int.TryParse(TDni.Text, out int dni);
            Boolean valorNombre = !string.IsNullOrWhiteSpace(nombre) && nombre.All(char.IsLetter);
            Boolean valorApellido = !string.IsNullOrWhiteSpace(apellido) && apellido.All(char.IsLetter);

            if (valorDni && valorNombre && valorApellido)
            {
                LModificar.Text = apellido + " " + nombre;

                DialogResult ask = MessageBox.Show(
                    "¿Seguro que desea insertar un nuevo cliente?",
                    "Confirmar inserción",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El cliente: "+apellido+" "+nombre+" se insertó correctamente.",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            if (!valorDni)
            {
                MessageBox.Show("El DNI debe ser un número.");
            }

            if (!nombre.All(char.IsLetter) || !apellido.All(char.IsLetter))
            {
                MessageBox.Show("Solo se permiten letras para nombre y apellido");
            }
           
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Campos sin completar!",
                    "Error",
                    MessageBoxButtons.OK,  // Tipo de botones: OK, OKCancel, YesNo, etc.
                    MessageBoxIcon.Error);
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            string apellido = TApellido.Text;
            string nombre = TNombre.Text;

            DialogResult ask = MessageBox.Show(
                "Esta a punto de eliminar al cliente: " + apellido + " " + nombre,
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );
            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El cliente: " + apellido + " " + nombre + " se eliminó correctamente.",
                    "Eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();
                LModificar.Text = "modificar";
                
            }                        
        }
    }
}
