using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class Anulacion_factura : Form
    {
        public int idfactura;
        public string estado;

        FacturaModel objfactura = new FacturaModel();
        public Anulacion_factura()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Campos_vacios())
            {
                if (MessageBox.Show("¿Estas seguro de Anular la factura?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        estado = "Anulada";
                        objfactura.obtener_articulo_cantidad(idfactura);
                        objfactura.sumar_articulo_stock();
                        objfactura.Anular_Factura(idfactura, estado, textMotivo.Text);
                        MessageBox.Show("La Factura ha sido Anulada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Al Parecer ha ocurrido un error Inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Campo Motivo Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Campos_vacios()
        {
            if (textMotivo.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
