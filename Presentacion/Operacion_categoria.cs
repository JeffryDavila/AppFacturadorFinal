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
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class Operacion_categoria : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsq, int wparam, int lparam);

        CategoriaModel objcategoria = new CategoriaModel();
        public string Operacion = "Insertar";
        public string idCategoria;
        public Operacion_categoria()
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
                    objcategoria.Agregar_categoria(textCodigo.Text, textNombre.Text);
                    MessageBox.Show("Insertado correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    obtener_id_categoria();
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
                    objcategoria.Editar_categoria(Convert.ToInt32(idCategoria), textCodigo.Text, textNombre.Text);
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
        }

        private bool campos_vacios()
        {
            if (textCodigo.Text == "" || textNombre.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void obtener_id_categoria()
        {
            string cadena = "CAT00";
            int sumador = objcategoria.obtenerIdCategoria();
            sumador += 1;
            textCodigo.Text = cadena + "" + Convert.ToString(sumador);
        }

        private void btnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Operacion_categoria_Load(object sender, EventArgs e)
        {

        }

        private void Operacion_categoria_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
