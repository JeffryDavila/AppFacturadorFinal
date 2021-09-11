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
    public partial class Compras : Form
    {
        public string idpedido;//obtener idpedido de la lista Data table
        public string estado;//obtener estado de la lista Data table

        ComprasModel compras = new ComprasModel();
        public Compras()
        {
            InitializeComponent();
        }

        public void ListarPedido()
        {
            ComprasModel objcompras = new ComprasModel();
            Lista_de_compras.DataSource = objcompras.Listar_pedidos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarInferior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Formulario_Principal principal = Owner as Formulario_Principal;
            Operacion_nueva_Compra frm = new Operacion_nueva_Compra();
            
            principal.AddOwnedForm(frm);
            frm.lblSubMenu.Text = "Nueva Compra";
            frm.ListarProveedor();
            frm.obtener_id_compra();
            principal.AbrirFormPanel(frm);


        }

        private void Lista_de_compras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.Lista_de_compras.Columns[e.ColumnIndex].Name == "Estado")
            {
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {

                        switch (e.Value.ToString())
                        {
                            case "Pendiente":
                                e.CellStyle.BackColor = Color.DarkGray;
                                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                                break;
                            case "Confirmada":
                                e.CellStyle.BackColor = Color.Green;
                                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                                break;
                            case "Anulada":
                                e.CellStyle.BackColor = Color.Red;
                                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                                break;
                        }
                    }
                }
                catch (NullReferenceException oException)
                {

                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Lista_de_compras.SelectedRows.Count > 0)
            {
                estado= Lista_de_compras.CurrentRow.Cells["Estado"].Value.ToString();

                if(estado=="Pendiente")
                {
                    if (MessageBox.Show("¿Estas seguro de confirmar la compra seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        idpedido = Lista_de_compras.CurrentRow.Cells["ID"].Value.ToString();
                        compras.obtener_articulo_cantidad(Convert.ToInt32(idpedido));
                        compras.sumar_articulo_stock();
                        compras.Confirmar_pedido(Convert.ToInt32(idpedido));
                        MessageBox.Show("La compra ha sido confirmada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Formulario_Principal ventana = Owner as Formulario_Principal;
                        Compra_Factura hoja = new Compra_Factura();
                        DataTable dt = compras.Listar_Compra_completa(Convert.ToInt32(idpedido));
                        DataSet ds = new DataSet();
                        ds.Tables.Add(dt);
                        hoja.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                        hoja.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;//todo el ancho de pagina
                        ventana.AbrirFormPanel(hoja);

                        //hoja.ShowDialog();

                        /*
                        if(cmb_Opcion.SelectedIndex == 0)
                        {
                            ListarPedido();
                        }
                        else if (cmb_Opcion.SelectedIndex == 1)
                        {
                            ListarPedido_Fecha(Convert.ToString(Fecha_select2.Value.ToString("dd/MM/yyyy")));
                        }
                        else if (cmb_Opcion.SelectedIndex == 2)
                        {
                            ListarPedido_Rangos(Convert.ToString(Fecha_select1.Value.ToString("dd/MM/yyyy")), Fecha_select2.Value.ToString("dd/MM/yyyy"));
                        }
                        */
                    }
                }
                else if(estado== "Confirmada")
                {
                    MessageBox.Show("Esta compra ya fue confirmada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Esta compra esta anulada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (Lista_de_compras.SelectedRows.Count > 0)
            {
                estado = Lista_de_compras.CurrentRow.Cells["Estado"].Value.ToString();
                if(estado== "Pendiente")
                {
                    Anulacion_compra ventana_anular = new Anulacion_compra();
                    ventana_anular.idpedido = Convert.ToInt32(Lista_de_compras.CurrentRow.Cells["ID"].Value.ToString());
                    ventana_anular.ShowDialog();

                    if (cmb_Opcion.SelectedIndex == 0)
                    {
                        ListarPedido();
                    }
                    else if (cmb_Opcion.SelectedIndex == 1)
                    {
                        ListarPedido_Fecha(Convert.ToString(Fecha_select2.Value.ToString("dd/MM/yyyy")));
                    }
                    else if (cmb_Opcion.SelectedIndex == 2)
                    {
                        ListarPedido_Rangos(Convert.ToString(Fecha_select1.Value.ToString("dd/MM/yyyy")), Fecha_select2.Value.ToString("dd/MM/yyyy"));
                    }

                }
                else if(estado== "Confirmada")
                {
                    MessageBox.Show("No se puede anular una compra que ya esta confirmada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Esta compra ya esta anulada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (Lista_de_compras.SelectedRows.Count > 0)
            {
                idpedido = Lista_de_compras.CurrentRow.Cells["ID"].Value.ToString();
                Ver_detalle_compra ver = new Ver_detalle_compra();
                ver.text_ID.Text = idpedido;
                compras.Consultar_Compra(Convert.ToInt32(idpedido));
                ver.Listar_Mini_consultaCompra(Convert.ToInt32(idpedido));
                ver.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Opcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_Opcion.SelectedIndex == 0)
            {
                lbl_fecha1.Visible = false;
                Fecha_select1.Visible = false;
                lbl_fecha2.Visible = false;
                Fecha_select2.Visible = false;
                btn_buscar.Visible = false;
     
                ListarPedido();
            }
            else if (cmb_Opcion.SelectedIndex == 1)
            {
                lbl_fecha1.Visible = false;
                Fecha_select1.Visible = false;

                lbl_fecha2.Visible = true;
                lbl_fecha2.Text = "Fecha";
                Fecha_select2.Visible = true;
                btn_buscar.Visible = true;
            }
            else if (cmb_Opcion.SelectedIndex == 2)
            {
                lbl_fecha1.Visible = true;
                Fecha_select1.Visible = true;
                lbl_fecha2.Visible = true;
                lbl_fecha2.Text = "Hasta";
                Fecha_select2.Visible = true;
                btn_buscar.Visible = true;
            }
        }

        public void ListarPedido_Fecha(string fecha)
        {
            ComprasModel objcompras = new ComprasModel();
            Lista_de_compras.DataSource = objcompras.Listar_pedidos_Fecha(fecha);
        }

        public void ListarPedido_Rangos(string fechaInicio,string fechaFin)
        {
            ComprasModel objcompras = new ComprasModel();
            Lista_de_compras.DataSource = objcompras.Listar_pedidos_Rango(fechaInicio,fechaFin);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cmb_Opcion.SelectedIndex == 1)
            {
                Console.WriteLine(Fecha_select2.Value);
                ListarPedido_Fecha(Convert.ToString(Fecha_select2.Value.ToString("dd/MM/yyyy")));
            }
            else if (cmb_Opcion.SelectedIndex == 2)
            {
                Console.WriteLine("Inicio:" + Fecha_select1.Value + "\n");
                Console.WriteLine("Inicio:" + Fecha_select2.Value + "\n");
                ListarPedido_Rangos(Convert.ToString(Fecha_select1.Value.ToString("dd/MM/yyyy")) , Fecha_select2.Value.ToString("dd/MM/yyyy"));
            }
        }

        private void btn_vista_imprimir_Click(object sender, EventArgs e)
        {
            if (Lista_de_compras.SelectedRows.Count > 0)
            {
                estado = Lista_de_compras.CurrentRow.Cells["Estado"].Value.ToString();
                if (estado == "Confirmada")
                {
                    idpedido = Lista_de_compras.CurrentRow.Cells["ID"].Value.ToString();
                    Compra_Factura hoja = new Compra_Factura();
                    DataTable dt = compras.Listar_Compra_completa(Convert.ToInt32(idpedido));
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt);
                    hoja.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    hoja.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;//todo el ancho de pagina
                    hoja.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Solo se pueden mostrar la vista de Impresion de las compras confirmadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
