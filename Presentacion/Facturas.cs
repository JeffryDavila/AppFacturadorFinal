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
    public partial class Facturas : Form
    {
        public int idfactura;
        public string estado;
        public string motivo;
        public DateTime Fecha_selecionada;

        FacturaModel facturas = new FacturaModel();

        //variable para almacenar el nombre cliente
        string aux_nombre_cliente;

        //variable para almacenar estados de factura
        string aux_estado;

        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            Fecha_select.Format = DateTimePickerFormat.Custom;
            Fecha_select.CustomFormat = "dd-MMMM-yyyy";
            PermisosUsuario();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarInferior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lista_de_Facturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PermisosUsuario()
        {
            if (UserLoginCache.UserPrivilegios == Cargos.Vendedor)
            {
                btnAnular.Enabled = false;
            }
        }

        //Lista fecha de hoy
        public void ListarDetalleFactura_hoy()
        {
            FacturaModel objfactura = new FacturaModel();
            Lista_de_Facturas.DataSource = objfactura.Lista_Factura_Hoy();
        }

        //Lista fecha selecionada
        public void ListarDetalleFactura_Fecha(string fecha)
        {
            FacturaModel objfactura = new FacturaModel();
            Lista_de_Facturas.DataSource = objfactura.Listar_FacturaFecha(fecha);
        }

        private void btnNuevoFactura_Click(object sender, EventArgs e)
        {
            Formulario_Principal principal = Owner as Formulario_Principal;
            Operacion_nueva_factura frm = new Operacion_nueva_factura();
            principal.AddOwnedForm(frm);       
            frm.lblSubMenu.Text = "Nueva Factura";
            frm.Listarcliente();
            frm.ListarEmpleado();
            frm.obtener_id_factura();
            principal.AbrirFormPanel(frm);
        }

        private void Lista_de_Facturas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
         
           if(this.Lista_de_Facturas.Columns[e.ColumnIndex].Name == "Estado")
           {
               try
               {
                       if (e.Value.GetType() != typeof(System.DBNull))
                       {

                          switch (e.Value.ToString())
                          {
                            case "Anulada":
                                e.CellStyle.BackColor = Color.Red;
                                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                            break;
                            case "Facturada":
                                e.CellStyle.BackColor = Color.Green;
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

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (Lista_de_Facturas.SelectedRows.Count > 0)
            {
                idfactura= Convert.ToInt32(Lista_de_Facturas.CurrentRow.Cells["ID"].Value.ToString());
                estado = Lista_de_Facturas.CurrentRow.Cells["Estado"].Value.ToString();

                if(estado == "Facturada")
                {
                    Anulacion_factura ventana_anular = new Anulacion_factura();
                    ventana_anular.idfactura = idfactura;
                    ventana_anular.ShowDialog();

                    if(cmb_Opcion.SelectedIndex == 0)
                    {
                        ListarDetalleFactura_hoy();
                    }
                    else if (cmb_Opcion.SelectedIndex == 1)
                    {
                        ListarDetalleFactura_Fecha(Convert.ToString(Fecha_selecionada.ToString("dd/MM/yyyy")));
                    }
                }
                else
                {
                    MessageBox.Show("La factura ya fue anulada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Lista_de_Facturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Le diste doble click", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (Lista_de_Facturas.SelectedRows.Count > 0)
            {
                idfactura = Convert.ToInt32(Lista_de_Facturas.CurrentRow.Cells["ID"].Value.ToString());
                Ver_detalle_factura ver = new Ver_detalle_factura();
                ver.text_ID.Text = Convert.ToString(idfactura);
                facturas.Consultar_Factura(idfactura);
                ver.Listar_Mini_consultaFactura(idfactura);
                ver.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_Opcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cmb_Opcion.SelectedIndex==0)
            {
                Fecha_select.Visible = false;
                btn_buscar.Visible = false;
                ListarDetalleFactura_hoy();
            }
            else if(cmb_Opcion.SelectedIndex==1)
            {
                Fecha_select.Visible = true;
                btn_buscar.Visible = true;
            }
            
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Fecha_selecionada = Fecha_select.Value;
            Console.WriteLine(Fecha_selecionada); 
            ListarDetalleFactura_Fecha(Convert.ToString(Fecha_selecionada.ToString("dd/MM/yyyy")));
        }

        private void btn_vista_imprimir_Click(object sender, EventArgs e)
        {
            if (Lista_de_Facturas.SelectedRows.Count > 0)
            {
                idfactura = Convert.ToInt32(Lista_de_Facturas.CurrentRow.Cells["ID"].Value.ToString());
                aux_estado = Lista_de_Facturas.CurrentRow.Cells["Estado"].Value.ToString();
                if (aux_estado == "Facturada")
                {
                    aux_nombre_cliente = Lista_de_Facturas.CurrentRow.Cells["Cliente"].Value.ToString();
                    if (aux_nombre_cliente == "CLIENTES VARIOS")
                    {
                        facturas.Limpiar_nombre_temporal();
                    }
                    //Formulario_Principal ventana = Owner as Formulario_Principal;
                    Factura_Reporte hoja = new Factura_Reporte();

                    DataTable dt = facturas.Listar_Factura_completa(idfactura);
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt);
                    hoja.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    hoja.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;//todo el ancho de pagina
                    hoja.ShowDialog();
                    //ventana.AbrirFormPanel(hoja);
                }
                else
                {
                    MessageBox.Show("Solo se puede mostrar la vista impresion de las facturadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


    }
}
