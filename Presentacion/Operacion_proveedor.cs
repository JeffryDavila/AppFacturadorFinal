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
    public partial class Operacion_proveedor : Form
    {
        ProveedorModel objproveedor = new ProveedorModel();
        public string Operacion = "Insertar";
        public string idprov;
        public Operacion_proveedor()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                if (!campos_vacios())
                {
                    objproveedor.Agregar_Proveedor(textCodigo.Text,textNombre.Text, textTelefono.Text,textDireccion.Text,textEmail.Text);
                    MessageBox.Show("Insertado correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    obtener_id_proveedor();
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
                    objproveedor.Editar_Proveedor(Convert.ToInt32(idprov),textCodigo.Text, textNombre.Text, textTelefono.Text, textDireccion.Text, textEmail.Text);
                    MessageBox.Show("Se edito correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Operacion_proveedor_Load(object sender, EventArgs e)
        {

        }

        private void brnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool campos_vacios()
        {
            if (textCodigo.Text == "" || textNombre.Text == "" || textTelefono.Text == "" || textDireccion.Text == "" || textEmail.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LimpiarFormulario()
        {
            textCodigo.Text = "";
            textNombre.Text = "";
            textTelefono.Text = "";
            textDireccion.Text = "";
            textEmail.Text = "";
        }

        public void obtener_id_proveedor()
        {
            string cadena = "PROV00";
            int sumador = objproveedor.obtenerIdProveedor();
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
