using CineCordobaBack.Datos.Implementacion;
using CineCordobaBack.Entidades;
using CineCordobaBack.Servicios.Fabrica;
using CineCordobaFront.Cliente;
using CineCordobaFront.Presentacion;
using CineCordobaBack.Datos.Interfaces;
using CineCordobaBack.Datos.Interfaz;
using CineCordobaBack.Fachada.Interfaces;
using CineCordobaBack.Fachada.Implementaciones;
using CineCordobaBack.Datos;
using CordobaCineApp.Presentacion;
using Newtonsoft.Json;
using System.Reflection.Metadata;
using CineCordobaBack.Datos.Concretas;
using Microsoft.EntityFrameworkCore;
using CineCordobaBack.Datos.Context;
using CineCordobaBack.Fachada.Concretas;

namespace CineCordobaFront
{
    public partial class frmMenu : Form
    {
        public Usuarios oUsuario;
        public frmMenu()
        {
            InitializeComponent();
        }

        private async Task RealizarOperacionAsincrona()
        {
            await Task.Delay(3000);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void frmMenu_Load_1(object sender, EventArgs e)
        {
            OcultarElementos();

        }

        private void OcultarElementos()
        {
            menuStrip1.Enabled = false;
            pbImgFondo.Visible = false;
            menuStrip1.Visible = false;
            img_usuario_anim.Visible = false;




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string usuario = txtUsuario.Text;
                string contra = txtContraseña.Text;

                oUsuario = new Usuarios(usuario, contra);
                if (Convert.ToInt32(await ConsultarUsuario(oUsuario)) == 1)
                {
                    menuStrip1.Enabled = true;
                    Ocultar();
                    lblCompletar.Text = "Cargo: Vendedor.";
                    lblUsuar.Text = "Usuario: " + usuario + ".";

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async Task<int> ConsultarUsuario(Usuarios oUsuario)
        {
            string usuario = JsonConvert.SerializeObject(oUsuario);
            string url = "https://localhost:7055/usuario";
            var data = await ClienteSingleton.ObtenerInstancia().PostAsync(url, usuario);
            int v = JsonConvert.DeserializeObject<int>(data);

            return v;
        }

        private void Ocultar()
        {
            txtContraseña.Visible = false;
            txtUsuario.Visible = false;
            btnCancelar.Visible = false;
            btnIngresar.Visible = false;
            pbImgFondo.Visible = true;
            lblContraseña.Visible = false;
            lblUsuario.Visible = false;
            lblInicioSesion.Visible = false;
            menuStrip1.Visible = true;
            img_usuario.Visible = false;
            img_usuario_anim.Visible = false;
        }

        private bool validar()
        {
            bool v = true;
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                v = false;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                v = false;
            }
            return v;
        }

        private async void crearFuncionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RealizarOperacionAsincrona();

            AltaFunciones altaCliente = new AltaFunciones();
            altaCliente.ShowDialog();
        }

        private async void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RealizarOperacionAsincrona();
            FrmAltaClientes altaCliente = new FrmAltaClientes();
            altaCliente.ShowDialog();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            img_usuario.Visible = false;
            img_usuario_anim.Visible = true;
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreditos creditos = new frmCreditos();
            creditos.ShowDialog();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaGeneroTipoSala repor = new FrmConsultaGeneroTipoSala();
            repor.ShowDialog();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FabricaServicio fabricaServicio = new FabricaServicioImp();  // Reemplaza ImplementacionDeFabricaServicio con la implementación real
            FrmConsultarCliente frmConsultarCliente = new FrmConsultarCliente(fabricaServicio);
            frmConsultarCliente.ShowDialog();
        }

        private void consultarFuncionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new DbContexto())
                {
                    IFuncionesDao FuncionesDao = new FuncionesDao(dbContext);
                    FrmConsultarFunciones frmConsultarFunciones = new FrmConsultarFunciones(FuncionesDao);
                    frmConsultarFunciones.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear DbContext: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComprobanteVenta comprobanteVentas = new FrmComprobanteVenta();
            comprobanteVentas.ShowDialog();
        }
    }
}