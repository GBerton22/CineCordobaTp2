using CineCordobaBack.Entidades;
using CineCordobaFront.Cliente;
using CineCordobaFront.Servicios.Implementacion;
using CineCordobaBack.Entidades.Dto;
using CineCordobaFront.Servicios.Interfaz;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineCordobaFront.Presentacion
{
    public partial class FrmComprobanteVenta : Form
    {

        DtoComprobantesR nuevo = null;
        int proxComprobante;


        public FrmComprobanteVenta()
        {
            InitializeComponent();

            nuevo = new DtoComprobantesR();


        }


        private void LimpiarCampos()
        {
            txtDocumento.Text = string.Empty;
            txtCodigoVendedor.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            txtTotal.Text = string.Empty;
            cboVendedor.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            cboFormasPago.SelectedIndex = -1;
            cbofuncion.SelectedIndex = -1;
            cboPeli.SelectedIndex = -1;
            cboPromo.SelectedIndex = -1;
            cboSucursal.SelectedIndex = -1;
            cboTipoSalas.SelectedIndex = -1;
            dgvComprobante.Rows.Clear();
            dtpFechaVenta.Value = DateTime.Now;
        }

        private async void FrmComprobanteVenta_Load(object sender, EventArgs e)
        {
            dtpFechaVenta.Value = DateTime.Now;
            dtpFechaVenta.Enabled = false;
            txtCodigoVendedor.Enabled = false;
            gboxPeli.Enabled = false;
            gboxPromo.Enabled = false;
            btnConfirmar.Enabled = false;

            await ProximoComprobante();
            LimpiarCampos();
            await CargarCombos();


        }
        private async Task RealizarOperacionAsincrona()
        {
            await Task.Delay(3000);
        }

        private async Task ProximoComprobante()
        {
            string url = "https://localhost:7055/proxComprobantess";
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            proxComprobante = JsonConvert.DeserializeObject<int>(dataJson);

            if (proxComprobante > 0)
            {

                txtNumComprobante.Text = "Comprobante N° : " + proxComprobante.ToString();
            }
            else
            {
                MessageBox.Show("Error en obtener el proximo N° Comprobante.", "ERROR");
            }


        }

        private async Task<int> ProximoDetalleComprobante()
        {
            string url = "https://localhost:7055/proxDetalleComprobantess";
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            int proxDetalle = JsonConvert.DeserializeObject<int>(dataJson);
            return proxDetalle;
        }


        private async Task CargarCombos()
        {

            await CargarFormasPagoAsync();
            await CargarClientesAsync();
            await CargarPeliculasAsync();
            await CargarPromocionesAsync();
            await CargarSucursalesAsync();
            await CargarVendedoresAsync();
        }

        private async Task CargarVendedoresAsync()
        {
            await RealizarOperacionAsincrona();
            string url = "https://localhost:7055/vendedoress";
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoVendedores> lVendedores = JsonConvert.DeserializeObject<List<DtoVendedores>>(dataJson);

            cboVendedor.DataSource = lVendedores;
            cboVendedor.ValueMember = "VendedorId";
            cboVendedor.DisplayMember = "NombreCompleto";
        }

        private async Task CargarSucursalesAsync()
        {
            await RealizarOperacionAsincrona();
            string url = "https://localhost:7055/sucursaless";
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoSucursales> lSucursales = JsonConvert.DeserializeObject<List<DtoSucursales>>(dataJson);

            cboSucursal.DataSource = lSucursales;
            cboSucursal.ValueMember = "SucursalId";
            cboSucursal.DisplayMember = "NombreSucursal";
        }


        private async Task CargarPromocionesAsync()
        {
            await RealizarOperacionAsincrona();
            string url = "https://localhost:7055/promoss";
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoPromociones> lPromos = JsonConvert.DeserializeObject<List<DtoPromociones>>(dataJson);

            cboPromo.DataSource = lPromos;
            cboPromo.ValueMember = "PromoId";
            cboPromo.DisplayMember = "NombrePromo";
        }

        private async void cboPeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idPeli = cboPeli.SelectedIndex + 1;

            await CargarFuncionesAsync(idPeli);

        }
        private async void cbofuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            await RealizarOperacionAsincrona();
            int idFuncion = Convert.ToInt32(cbofuncion.SelectedIndex + 1);
            await CargarTipoSalasAsync(idFuncion);
        }

        private void cboTipoSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idTipoSala = Convert.ToInt32(cboTipoSalas.SelectedIndex + 1);

        }

        private void cboVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoVendedor.Text = cboVendedor.SelectedValue.ToString();
        }



        private async Task CargarPeliculasAsync()
        {
            await RealizarOperacionAsincrona();
            string url = "https://localhost:7055/peliculass";
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoPelis> lPeliculas = JsonConvert.DeserializeObject<List<DtoPelis>>(dataJson);

            cboPeli.DataSource = lPeliculas;
            cboPeli.ValueMember = "PeliculaId";
            cboPeli.DisplayMember = "NombrePelicula";
        }

        private async Task CargarFuncionesAsync(int idPeli)
        {
            await RealizarOperacionAsincrona();
            string url = "https://localhost:7055/funcioness" + "?idPeli=" + idPeli;
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoFuncion> lFunciones = JsonConvert.DeserializeObject<List<DtoFuncion>>(dataJson);

            cbofuncion.DataSource = lFunciones;
            cbofuncion.ValueMember = "FuncionId";
            cbofuncion.DisplayMember = "FuncionCompleta";
        }

        private async Task CargarClientesAsync()
        {
            await RealizarOperacionAsincrona();
            string url = "https://localhost:7055/clientess";
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoClientes> lClientes = JsonConvert.DeserializeObject<List<DtoClientes>>(dataJson);

            cboCliente.DataSource = lClientes;
            cboCliente.ValueMember = "ClienteId";
            cboCliente.DisplayMember = "NombreCompleto";
        }

        private async Task CargarFormasPagoAsync()
        {
            await RealizarOperacionAsincrona();
            string url = "https://localhost:7055/formasDePagos";
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoFormasPago> lformasPago = JsonConvert.DeserializeObject<List<DtoFormasPago>>(dataJson);

            cboFormasPago.DataSource = lformasPago;
            cboFormasPago.ValueMember = "FormasPagoId";
            cboFormasPago.DisplayMember = "FormasDePago";


        }


        private async Task CargarTipoSalasAsync(int idFuncion)
        {
            await RealizarOperacionAsincrona();
            string url = "https://localhost:7055/tipoSalass" + "?idFuncion=" + idFuncion;
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoTipoSalas> lTipoSalas = JsonConvert.DeserializeObject<List<DtoTipoSalas>>(dataJson);

            cboTipoSalas.DataSource = lTipoSalas;
            cboTipoSalas.ValueMember = "Id_sala";
            cboTipoSalas.DisplayMember = "Tipo";
        }


        bool existe;    //VARIABLE GLOBAL
        //List<Clientes> lclientes;

        private async Task ExisteDocumento(int doc)
        {
            string url = "https://localhost:7055/existenciaDocumentos" + "?numDoc=" + doc;
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            existe = JsonConvert.DeserializeObject<bool>(dataJson);


        }

        private async Task ClienteEncontrado(int doc)
        {
            string url = "https://localhost:7055/clienteFiltrdoPorDocs" + "?numDoc=" + doc;
            var dataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoClientes> lclientes = JsonConvert.DeserializeObject<List<DtoClientes>>(dataJson);


            cboCliente.DataSource = lclientes;
            cboCliente.ValueMember = "ClienteId";
            cboCliente.DisplayMember = "NombreCompleto";

        }



        private async void btnBuscarCLiente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDocumento.Text))   //si el txt documento no esta vacio hace lo siguiente
            {


                int doc = int.Parse(txtDocumento.Text);

                await ExisteDocumento(doc);
                if (existe)
                {
                    await ClienteEncontrado(doc);

                }

            }
        }

        DtoTipoSalas ts;
        private void btnAgregarEntrada_Click(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;

            ts = (DtoTipoSalas)cboTipoSalas.SelectedItem;

            DtoFuncion f = (DtoFuncion)cbofuncion.SelectedItem;


            f.SalaId.TipoSala = ts;
            DtoPromociones p = (DtoPromociones)cboPromo.SelectedItem;
            string sub;

            if (f.Subtitulo == 0)
            {
                sub = "No";
            }
            else
            {
                sub = "Sí";
            }

            DtoDetalleComprobanteR detalle = new DtoDetalleComprobanteR(f, p);
            nuevo.AgregarDetalle(detalle);

            dgvComprobante.Rows.Add(new object[] { f.PeliculaID.NombrePelicula, f.FuncionCompleta, f.SalaId.SalaId
                                                 , f.SalaId.TipoSala.Tipo, sub, f.SalaId.TipoSala.Precio.ToString(), p.NombrePromo , "Quitar"});

            CalcularTotales();

        }

        private void CalcularTotales()
        {
            txtSubtotal.Text = nuevo.CalcularTotal().ToString();
            DtoPromociones p = (DtoPromociones)cboPromo.SelectedItem;


            double desc = nuevo.CalcularTotal() * (p.Descuento);
            txtTotal.Text = (nuevo.CalcularTotal() - desc).ToString();

        }


        private void dgvComprobante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvComprobante.CurrentCell.ColumnIndex == 7) //boton Quitar de la grilla
            {
                nuevo.EliminarDetalle(dgvComprobante.CurrentRow.Index);
                dgvComprobante.Rows.RemoveAt(dgvComprobante.CurrentRow.Index);
                CalcularTotales();
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            CrearComprobante();
        }


        private async void CrearComprobante()
        {

            DtoClientes cli = (DtoClientes)cboCliente.SelectedItem;
            DtoVendedores vendedor = (DtoVendedores)cboVendedor.SelectedItem;
            DtoSucursales suc = (DtoSucursales)cboSucursal.SelectedItem;
            DtoFormasPago fp = (DtoFormasPago)cboFormasPago.SelectedItem;
            //List<DetalleComprobante> dt = new List<DetalleComprobante>();

            foreach (DtoDetalleComprobanteR i in nuevo.lDetallesComprobantes)
            {
                i.Precio = ts.Precio;
                // i.Precio = Convert.ToDouble(txtTotal.Text);
                i.DetalleComprobanteId = await ProximoDetalleComprobante();



            }

            nuevo.ComprobanteId = proxComprobante;

            nuevo.Cliente = cli;
            nuevo.Vendedor = vendedor;
            nuevo.Sucursal = suc;
            nuevo.FechaComprobante = Convert.ToDateTime(dtpFechaVenta.Value);
            nuevo.FormaPagoId = fp;
            nuevo.Detalle = new DtoDetalleComprobanteR();
            //nuevo.lDetallesComprobantes = dt;


            if (await CrearComprobanteAsync(nuevo))
            {
                MessageBox.Show("Se registró con éxito el comprobante...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Se registró con éxito el comprobante...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LimpiarCampos();
                this.Dispose();
            }
        }


        private async Task<bool> CrearComprobanteAsync(DtoComprobantesR nuevo)
        {
            string url = "https://localhost:7055/insertComprobantes";

            // Llamar al método PostAsync con el objeto Comprobantes
            var dataJson = await ClienteSingleton.ObtenerInstancia().PostAsync(url, nuevo);

            return dataJson.Equals("true");
        }




        private void btnElegirPeli_Click(object sender, EventArgs e)
        {
            gboxMaestro.Enabled = false;
            gboxPeli.Enabled = true;
        }

        private void btnElegirPromo_Click(object sender, EventArgs e)
        {
            gboxPromo.Enabled = true;
            gboxPeli.Enabled = false;

        }

        private void btnEditarEntrada_Click(object sender, EventArgs e)
        {
            gboxMaestro.Enabled = true;
            gboxPeli.Enabled = false;
            gboxPromo.Enabled = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
           DialogResult result=  MessageBox.Show("Seguro desea SALIR?", "IMPORTANTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result == DialogResult.OK)
            {
                this.Dispose();

            }

        }









        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
