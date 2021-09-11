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
    public partial class Operacion_producto : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsq, int wparam, int lparam);

        ProductosModel objproducto = new ProductosModel();
        public string Operacion = "Insertar";
        public string idprod;

        int cont_precioU = 0;
        public Operacion_producto()
        {
            InitializeComponent();
        }

        public void ListarCategoria()
        {
            ProductosModel objpro = new ProductosModel();
            cmbCategoria.DataSource = objpro.Lista_de_categoria();
            cmbCategoria.DisplayMember = "descripcion";
            cmbCategoria.ValueMember = "idcategoria";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operacion_producto_Load(object sender, EventArgs e)
        {
            
        }

        private void rectangleShape1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                if(!campos_vacios())
                {
                    try
                    {
                        objproducto.Agregar_Producto(Convert.ToInt32(cmbCategoria.SelectedValue), textcodigoProducto.Text, textdescripcion.Text, Convert.ToDecimal(textPrecioU.Text), Convert.ToDecimal(textPrecioPromocion.Text));
                        MessageBox.Show("Insertado correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        obtener_id_producto();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Generic Exception Handler: {ex}");
                        MessageBox.Show("Error en el Formato de los precios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {       
                    MessageBox.Show("Campos Vacios", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Operacion == "Editar")
            {
                if (!campos_vacios())
                {
                    objproducto.Editar_Producto(Convert.ToInt32(idprod), Convert.ToInt32(cmbCategoria.SelectedValue), textcodigoProducto.Text, textdescripcion.Text, Convert.ToDecimal(textPrecioU.Text), Convert.ToDecimal(textPrecioPromocion.Text));
                    MessageBox.Show("Se edito correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void brnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void textcodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private bool campos_vacios()
        {
            if(cmbCategoria.Text=="" || textcodigoProducto.Text=="" || textdescripcion.Text=="" || textPrecioU.Text=="" || textPrecioPromocion.Text=="")
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
            textcodigoProducto.Text = "";
            textdescripcion.Text = "";
            cmbCategoria.SelectedIndex = 0;
            textPrecioU.Text = "";
            textPrecioPromocion.Text = "";
        }

        private void textPrecioU_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }



        private void textDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        public void obtener_id_producto()
        {
            string cadena = "PROC00";
            int sumador = objproducto.obtenerIdproducto();
            sumador += 1;
            textcodigoProducto.Text = cadena + "" + Convert.ToString(sumador);
        }

        private void textPrecioU_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operacion_producto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
