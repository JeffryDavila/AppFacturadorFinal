using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentacion
{
    public partial class Operacion_empleado : Form
    {
        EmpleadoModel objEmpleado = new EmpleadoModel();
        public string Operacion = "Insertar";
        public string idempleado;
        public Operacion_empleado()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Operacion_empleado_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                if (!campos_vacios())
                {
                    objEmpleado.Agregar_empleado(textCodigo.Text, textNombre.Text, textApellido.Text, textCedula.Text,textTelefono.Text,textDireccion.Text);
                    MessageBox.Show("Insertado correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    obtener_id_empleado();
                }
                else
                {
                    MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Operacion == "Editar")
            {
                if (!campos_vacios())
                {
                    objEmpleado.Editar_categoria(Convert.ToInt32(idempleado), textCodigo.Text, textNombre.Text, textApellido.Text, textCedula.Text, textTelefono.Text, textDireccion.Text);
                    MessageBox.Show("Se edito correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LimpiarFormulario()
        {
            textCodigo.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            textCedula.Text = "";
            textTelefono.Text = "";
            textDireccion.Text = "";
        }

        private bool campos_vacios()
        {
            if (textCodigo.Text == "" || textNombre.Text == "" || textApellido.Text == "" || textCedula.Text == "" || textTelefono.Text=="" || textDireccion.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void obtener_id_empleado()
        {
            string cadena = "EMP000";
            int sumador = objEmpleado.obtenerIdCategoria();
            sumador += 1;
            textCodigo.Text = cadena + "" + Convert.ToString(sumador);
        }


        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}
