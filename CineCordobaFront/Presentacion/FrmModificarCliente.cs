using CineCordobaBack.Entidades;
using CineCordobaBack.Servicios.Implementacion;
using CineCordobaBack.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineCordobaFront.Presentacion;
using CineCordobaBack.Fachada.Concretas;
using CineCordobaBack.Fachada.Interfaces;
using CineCordobaBack.Servicios.Fabrica;
using CineCordobaFront.Cliente;
using Newtonsoft.Json;


namespace CineCordobaFront.Presentacion
{
    public partial class FrmModificarCliente : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;

        private Clientes oCliente;
        private int idCliente;
        public FrmModificarCliente(int id_cliente, FabricaServicio oFabrica)
        {
            InitializeComponent();

            oServicio = oFabrica.CrearServicio();
            oCliente = new Clientes();
            this.oFabrica = oFabrica;
            this.idCliente = id_cliente;
        }

        private async void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            await CargarCampos();
            await cargarCombos();
            cargarNumeroCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        private async Task<Clientes> ConsultarClientesId(int idCliente)
        {
            string url = "https://localhost:7055/clienteSegunId?id_cliente=" + "?idCliente=" + idCliente.ToString();
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            Clientes oCliente = JsonConvert.DeserializeObject<Clientes>(data);

            return oCliente;
        }
        public async Task CargarCampos()
        {
            Clientes oCliente = await ConsultarClientesId(this.idCliente);

            if (oCliente != null)
            {

                txtNombre.Text = oCliente.Nombre.ToString();
                txtApellido.Text = oCliente.Apellido.ToString();

                txtTelefono.Text = oCliente.Telefono.ToString();
                txtEmail.Text = oCliente.Email.ToString();
                txtCalle.Text = oCliente.Calle.ToString();
                txtAltura.Text = oCliente.Altura.ToString();
                txtDocumento.Text = oCliente.NroDoc.ToString();
                cboBarrio.SelectedIndex = Convert.ToInt32(oCliente.id_barrio.ToString()) - 1;
                cboTipoDocumento.SelectedIndex = Convert.ToInt32(oCliente.id_tipo_doc.ToString()) - 1;
            }
            else
            {
                MessageBox.Show("No se encontró el cliente");
            }
        }
        private async Task cargarCombos()
        {
            await cargarBarrios();
            await cargarTipoDocumento();
        }
        private async Task cargarBarrios()
        {
            string url = "https://localhost:7055/barrios";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Barrios> lst = JsonConvert.DeserializeObject<List<Barrios>>(data);
            cboBarrio.DataSource = lst;
            cboBarrio.ValueMember = "id_barrio";
            cboBarrio.DisplayMember = "barrio";
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task cargarTipoDocumento()
        {
            string url = "https://localhost:7055/tipo_documentos";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<TipoDoc> lst = JsonConvert.DeserializeObject<List<TipoDoc>>(data);
            cboTipoDocumento.DataSource = lst;
            cboTipoDocumento.ValueMember = "id_tipo_documento";
            cboTipoDocumento.DisplayMember = "TipoDocumento";
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private async void BtnModificar_Click(object sender, EventArgs e)
        {
            await ModificarCliente();
        }
        private async Task ModificarCliente()
        {
            if (validar())
            {
                if (MessageBox.Show("Confirme la modificacion del cliente", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        {
                            Clientes c = await ConsultarClientesId(idCliente);
                            int id_cliente = idCliente;


                            oCliente.id_cliente = Convert.ToInt32(id_cliente);
                            oCliente.Nombre = txtNombre.Text;
                            oCliente.Apellido = txtApellido.Text;
                            oCliente.Telefono = Convert.ToInt32(txtTelefono.Text);
                            oCliente.Email = txtEmail.Text;
                            oCliente.FechaNac = dtpFechaNacimiento.Value;
                            oCliente.id_barrio = Convert.ToInt32(cboBarrio.SelectedValue);
                            oCliente.Calle = txtCalle.Text;
                            oCliente.Altura = Convert.ToInt32(txtAltura.Text);
                            oCliente.id_tipo_doc = Convert.ToInt32(cboTipoDocumento.SelectedValue);
                            oCliente.NroDoc = Convert.ToInt32(txtDocumento.Text);

                            if (oServicio.ModificarClientes(oCliente))
                            {
                                MessageBox.Show("Se actualizó el cliente con éxito");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar el cliente");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al modificar el cliente: {ex.Message}");
                    }
                }
            }
            Dispose();

        }
        public bool validar()
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de documento");
                return false;
            }

            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un barrio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escriba un nombre");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Escriba un apellido");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCalle.Text))
            {
                MessageBox.Show("Escriba una calle");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Escriba un Email");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Escriba un documento");
                return false;
            }

            if (!int.TryParse(txtDocumento.Text, out int documento) || documento <= 0)
            {
                MessageBox.Show("Ingrese un valor numérico mayor que cero para el documento");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Escriba un telefono");
                return false;
            }

            if (!int.TryParse(txtTelefono.Text, out int telefono) || telefono <= 0)
            {
                MessageBox.Show("Ingrese un valor numérico mayor que cero para el teléfono");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                MessageBox.Show("Escriba una altura de calle");
                return false;
            }

            if (!int.TryParse(txtAltura.Text, out int altura) || altura <= 0)
            {
                MessageBox.Show("Ingrese un valor numérico mayor que cero para la altura");
                return false;
            }

            return true;
        }


        private void cargarNumeroCliente()
        {
            lblClienteNro.Text = "Cliente Nro:" + " " + idCliente.ToString();
        }
    }
}
