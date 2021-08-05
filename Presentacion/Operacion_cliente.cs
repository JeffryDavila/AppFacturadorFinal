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
    public partial class Operacion_cliente : Form
    {
        ClienteModel objcliente = new ClienteModel();
        public string Operacion = "Insertar";
        public string idclient;
        public Operacion_cliente()
        {
            InitializeComponent();
        }

        private void textcodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void textEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void btnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Operacion_cliente_Load(object sender, EventArgs e)
        {

        }

        public void LimpiarFormulario()
        {
            textCedula.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            textEdad.Text = "";
        }

        private bool campos_vacios()
        {
            if (textNombre.Text == "" || textApellido.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void verificar_campos_opcionales()
        {
            if(textEdad.Text == "")
            {
                textEdad.Text= "0";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                if (!campos_vacios())
                {
                    verificar_campos_opcionales();
                    objcliente.Agregar_cliente(textCodigo.Text, textNombre.Text, textApellido.Text, textCedula.Text, Convert.ToInt32(textEdad.Text));
                    MessageBox.Show("Insertado correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    obtener_id_cliente();
                }
                else
                {
                    MessageBox.Show("Campos Nombre o Apellido vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(Operacion == "Editar")
            {
                if (!campos_vacios())
                {
                    objcliente.Editar_Cliente(Convert.ToInt32(idclient), textCedula.Text, textNombre.Text, textApellido.Text, Convert.ToInt32(textEdad.Text));
                    MessageBox.Show("Se edito correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }

        public void obtener_id_cliente()
        {
            string cadena = "CLI00";
            int sumador = objcliente.obtenerIdCliente();
            sumador += 1;
            textCodigo.Text = cadena + "" + Convert.ToString(sumador);
        }

    }
}
