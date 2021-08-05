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

namespace Presentacion
{
    public partial class Tasa_cambio : Form
    {
        public Tasa_cambio()
        {
            InitializeComponent();
        }

        private void Tasa_cambio_Load(object sender, EventArgs e)
        {
            if(FacturaCache.tasa_de_cambio_dolar>0)
            {
                textdolar_cordoba.Text = Convert.ToString(FacturaCache.tasa_de_cambio_dolar);
            }
        }

        private void btnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                FacturaCache.tasa_de_cambio_dolar = Convert.ToDecimal(textdolar_cordoba.Text);
                MessageBox.Show("La tasa de cambio es: " + FacturaCache.tasa_de_cambio_dolar, "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Generic Exception Handler: {ex}");
                MessageBox.Show("Error al guardar tasa de cambio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
