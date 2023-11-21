using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using CineCordobaBack.Fachada.Implementaciones;
using CineCordobaBack.Fachada.Interfaces;
using CineCordobaBack.Servicios;
using CineCordobaBack.Servicios.Interfaz;
using CineCordobaFront.Cliente;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineCordobaFront.Presentacion
{
    public partial class FrmAltaClientes : Form
    {
        IAplicacion aplicacion = null;
        DtoCliente oCliente = null;
        public FrmAltaClientes()
        {
            InitializeComponent();
            oCliente = new DtoCliente();
            aplicacion = new Aplicacion();

        }

        private async void FrmAltaClientes_Load(object sender, EventArgs e)
        {
            await CargarCiudadesAsync();
            await CargarDocumentosAsync();
            await ProximoCliente();
            LimpiarCampos();
        }

        private async Task<int> ProximoCliente()
        {
            string url = "https://localhost:7055/proxCliente";
            var DataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            int v = JsonConvert.DeserializeObject<int>(DataJson);
            return v;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtCorreoElec.Text = "";
            txtCalle.Text = "";
            txtAltura.Text = "";
            dtpFechaNac.Value = DateTime.Now;
            cboBarrio.SelectedIndex = -1;
            cboCiudad.SelectedIndex = -1;
            cboTipoDoc.SelectedIndex = -1;

        }

        private async Task CargarDocumentosAsync()
        {
            string url = "https://localhost:7055/traerTipoDocumentos";
            var DataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoTipoDoc> ldoc = JsonConvert.DeserializeObject<List<DtoTipoDoc>>(DataJson);

            cboTipoDoc.DataSource = ldoc;
            cboTipoDoc.ValueMember = "TipoDocId";
            cboTipoDoc.DisplayMember = "TipoDocumento";
        }

        private async Task CargarCiudadesAsync()
        {
            string url = "https://localhost:7055/traerCiudades";
            var DataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Ciudades> lciudad = JsonConvert.DeserializeObject<List<Ciudades>>(DataJson);

            cboCiudad.DataSource = lciudad;
            cboCiudad.ValueMember = "id_ciudad";
            cboCiudad.DisplayMember = "ciudad";
        }

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdCiudadSeleccionada = Convert.ToInt32(cboCiudad.SelectedIndex + 1);
            CargarBarriosAsync(IdCiudadSeleccionada);
        }

        private async Task CargarBarriosAsync(int id)
        {
            string url = "https://localhost:7055/traerBarrios" + "?id=" + id;
            var DataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoBarrio> lbarrios = JsonConvert.DeserializeObject<List<DtoBarrio>>(DataJson);

            cboBarrio.DataSource = lbarrios;
            cboBarrio.ValueMember = "id_barrio";
            cboBarrio.DisplayMember = "NombreBarrio";
        }


        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                DtoCliente cliente = new DtoCliente();

                cliente.ClienteId = await ProximoCliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.NroDoc = int.Parse(txtDocumento.Text);
                cliente.Email = txtCorreoElec.Text;
                cliente.Calle = txtCalle.Text;
                cliente.Altura = int.Parse(txtAltura.Text);
                cliente.FechaNac = Convert.ToDateTime(dtpFechaNac.Value);
                cliente.Telefono = int.Parse(txtTelefono.Text);
                cliente.Barrio = (DtoBarrio)cboBarrio.SelectedItem;
                cliente.TipoDocId = (DtoTipoDoc)cboTipoDoc.SelectedItem;


                if (await crearClienteAsync(cliente))
                {
                    MessageBox.Show("Se registró con éxito el cliente...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("NO se pudo registrar el cliente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private async Task<bool> crearClienteAsync(DtoCliente cliente)
        {

            string url = "https://localhost:7055/AltaCliente";
            string FuncionJson = JsonConvert.SerializeObject(cliente);
            var DataJson = await ClienteSingleton.ObtenerInstancia().PostAsync(url, FuncionJson);
            return DataJson.Equals("true");
        }

        private bool validar()
        {
            bool v = true;

            if (dtpFechaNac.Value >= DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("el cliente debe ser mayor de edad", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNac.Focus();
                v = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text) || int.TryParse(txtNombre.Text, out _))
            {
                MessageBox.Show("Debe ingresar un nombre, que no incluya numeros", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                v = false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text) || int.TryParse(txtApellido.Text, out _))
            {
                MessageBox.Show("Debe ingresar un apellido, que no incluya numeros", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                v = false;
            }
            if (string.IsNullOrEmpty(txtCorreoElec.Text))
            {
                MessageBox.Show("Debe ingresar el correo electronico", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreoElec.Focus();
                v = false;
            }
            if (string.IsNullOrEmpty(txtDocumento.Text) || !int.TryParse(txtDocumento.Text, out _))
            {
                MessageBox.Show("El NRO de documento solo permite numeros", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDocumento.Focus();
                v = false;
            }
            if (!int.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("El telefono solo permite numeros", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                v = false;
            }
            if (string.IsNullOrEmpty(txtAltura.Text) || !int.TryParse(txtAltura.Text, out _))
            {
                MessageBox.Show("La altura solo permite numeros", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Focus();
                v = false;
            }



            return v;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cancelar la carga de la funcion?", "Cancelar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
