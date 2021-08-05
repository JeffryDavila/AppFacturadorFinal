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
    public partial class Anulacion_compra : Form
    {
        public int idpedido;
        public string estado;

        ComprasModel objcompra = new ComprasModel();
        public Anulacion_compra()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!Campos_vacios())
            {
                if (MessageBox.Show("¿Estas seguro de Anular la compra?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        estado = "Anulada";
                        objcompra.Anular_Pedido(idpedido, estado, textMotivo.Text);
                        MessageBox.Show("La compra ha sido Anulada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch(Exception exception)
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
            if(textMotivo.Text=="")
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
