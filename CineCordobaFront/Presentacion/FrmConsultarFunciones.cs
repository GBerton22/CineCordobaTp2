using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineCordobaApi.Services.Interfaz;
using CineCordobaBack.Datos.Context;
using CineCordobaApi.Services.Implementacion;
using CineCordobaBack.Entidades;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using CineCordobaBack.Fachada.Concretas;
using System.Drawing.Text;
using System.Net.Http.Json;
using System.Text;
using CineCordobaBack.Fachada.Interfaces;

namespace CineCordobaFront
{
    public partial class FrmConsultarFunciones : Form
    {
        private IFuncionesServices _funcionesServices;
        private readonly IFuncionesDao funcionesDao;

        public FrmConsultarFunciones(IFuncionesDao funcionesDao)
        {

            InitializeComponent();

            Load += (sender, e) => CargarComboBoxPeliculasConsulta();
            Load += (sender, e) => CargarComboBoxHorarios();
            Load += (sender, e) => CargarComboBoxNroFuncion();
            Load += (sender, e) => CargarComboBoxSalaAsync();
            Load += (sender, e) => CargarComboBoxPeliculasModificacion();

            this.funcionesDao = funcionesDao;

            _funcionesServices = new FuncionesServices(funcionesDao);

            dgvFunciones.CellContentClick += DgvFunciones_CellContentClick;
        }
        private async void DgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var modificarColumnIndex = 5;

                if (e.ColumnIndex == modificarColumnIndex)
                {
                    await CargarDatosFuncionSeleccionadaAsync(e.RowIndex);
                }
                HabilitarGroupBox();
            }
            ConsultarFunciones();
        }
        private void HabilitarGroupBox()
        {
            gbDatosFunciones.Enabled = true;

            cboNroFuncion.Enabled = false;
        }

        private async Task CargarDatosFuncionSeleccionadaAsync(int rowIndex)
        {
            int idFuncion = Convert.ToInt32(dgvFunciones.Rows[rowIndex].Cells[0].Value);

            var detallesFuncion = await _funcionesServices.ObtenerDetallesFuncion(idFuncion);

            if (detallesFuncion != null)
            {
                cboNroFuncion.Text = detallesFuncion.id_funcion.ToString();
                dtpFecha.Value = detallesFuncion.Fecha;
                comboPeliculas.SelectedValue = detallesFuncion.id_pelicula;
                cboHorario.SelectedValue = detallesFuncion.id_horario;
                cboSala.SelectedValue = detallesFuncion.id_sala;
                rbtSi.Checked = detallesFuncion.Subtitulo;
                rbtNo.Checked = !detallesFuncion.Subtitulo;

                btnConfirmar.Enabled = true;
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            gbDatosFunciones.Enabled = false;


        }
        private async void CargarComboBoxPeliculasConsulta()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync("https://localhost:7055/api/peliculas/consulta");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        List<Peliculas> peliculas = JsonConvert.DeserializeObject<List<Peliculas>>(jsonContent);

                        cboPeliculas.DataSource = peliculas;
                        cboPeliculas.DisplayMember = "nombre_pelicula";
                        cboPeliculas.ValueMember = "id_pelicula";
                    }
                    else
                    {
                        Console.WriteLine("Error al obtener datos de la API");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        private async void CargarComboBoxPeliculasModificacion()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync("https://localhost:7055/api/peliculas/modificacion");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        List<Peliculas> peliculas = JsonConvert.DeserializeObject<List<Peliculas>>(jsonContent);

                        comboPeliculas.DataSource = peliculas;
                        comboPeliculas.DisplayMember = "nombre_pelicula";
                        comboPeliculas.ValueMember = "id_pelicula";
                    }
                    else
                    {
                        Console.WriteLine("Error al obtener datos de la API");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private async void CargarComboBoxNroFuncion()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync("https://localhost:7055/api/funciones/ObtenerIds");

                    if (response.IsSuccessStatusCode)
                    {
                        List<int> ids = JsonConvert.DeserializeObject<List<int>>(await response.Content.ReadAsStringAsync());

                        cboNroFuncion.Items.Clear();

                        foreach (int id in ids)
                        {
                            cboNroFuncion.Items.Add(id);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error al obtener los IDs de función de la API");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        private async Task CargarComboBoxSalaAsync()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync("https://localhost:7055/api/salas");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        List<Salas> salas = JsonConvert.DeserializeObject<List<Salas>>(jsonContent);

                        cboSala.DataSource = salas;
                        cboSala.DisplayMember = "id_sala";
                        cboSala.ValueMember = "id_sala";
                    }
                    else
                    {
                        Console.WriteLine("Error al obtener datos de la API de salas");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        private async void CargarComboBoxHorarios()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync("https://localhost:7055/api/horarios");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        List<Horarios> horarios = JsonConvert.DeserializeObject<List<Horarios>>(jsonContent);

                        cboHorario.DataSource = horarios;
                        cboHorario.DisplayMember = "id_horario";
                        cboHorario.ValueMember = "id_horario";
                    }
                    else
                    {
                        Console.WriteLine("Error al obtener datos de la API");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpFecDesde.Value;
            DateTime fechaHasta = dtpFecHasta.Value;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _funcionesServices = new FuncionesServices(funcionesDao);
            ConsultarFunciones();
        }
        private int ObtenerIdPeliculaSeleccionada()
        {
            if (cboPeliculas.SelectedItem != null)
            {
                var peliculaSeleccionada = (Peliculas)cboPeliculas.SelectedItem;

                return peliculaSeleccionada.id_pelicula;
            }
            MessageBox.Show("Por favor, selecciona una película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return -1;
        }
        private void ConsultarFunciones()
        {
            DateTime fechaDesde = dtpFecDesde.Value;
            DateTime fechaHasta = dtpFecHasta.Value;
            int idPelicula = ObtenerIdPeliculaSeleccionada();

            using (var dbContext = new DbContexto())
            {
                var funcionesServices = new FuncionesServices(funcionesDao);

                var funcionesConFormato = funcionesServices.ObtenerFuncionesPorPelicula(fechaDesde, fechaHasta, idPelicula);

                dgvFunciones.Rows.Clear();

                foreach (var funcion in funcionesConFormato)
                {
                    dgvFunciones.Rows.Add(
                        funcion.NroFuncion,
                        funcion.NombrePelicula,
                        funcion.HorarioString,
                        funcion.SalaId,
                        funcion.SubtituloString
                    );
                }
            }
        }

        private void LimpiarDatos()
        {
            MessageBox.Show("Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            dgvFunciones.Rows.Clear();

            gbDatosFunciones.Enabled = false;
            btnConfirmar.Enabled = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private async void dgvFunciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var eliminarColumnIndex = dgvFunciones.Columns["colEliminar"].Index;

                if (e.ColumnIndex == eliminarColumnIndex)
                {
                    await EliminarFuncionAsync(e.RowIndex);
                }
            }
        }
        private async Task EliminarFuncionAsync(int rowIndex)
        {
            gbDatosFunciones.Enabled = false;
            try
            {
                int idFuncion = Convert.ToInt32(dgvFunciones.Rows[rowIndex].Cells["ColFuncionId"].Value);

                var confirmacion = MessageBox.Show("¿Desea eliminar la función?", "Eliminar Función", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool eliminado = await _funcionesServices.EliminarFuncion(idFuncion);

                    if (eliminado)
                    {
                        MessageBox.Show("Función eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ConsultarFunciones();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la función.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gbDatosFunciones.Enabled = false;
        }
        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int idFuncion = Convert.ToInt32(cboNroFuncion.Text);
                var funcionSeleccionada = await _funcionesServices.ObtenerDetallesFuncion(idFuncion);

                if (funcionSeleccionada != null)
                {
                    funcionSeleccionada.Fecha = dtpFecha.Value;
                    funcionSeleccionada.id_pelicula = (int)comboPeliculas.SelectedValue;
                    funcionSeleccionada.id_horario = (int)cboHorario.SelectedValue;
                    funcionSeleccionada.id_sala = (int)cboSala.SelectedValue;
                    funcionSeleccionada.Subtitulo = rbtSi.Checked;

                    _funcionesServices.Update(funcionSeleccionada);

                    MessageBox.Show("Función actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbDatosFunciones.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ConsultarFunciones();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            if (gbDatosFunciones.Enabled)
            {
                MessageBox.Show("Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                gbDatosFunciones.Enabled = false;
                btnConfirmar.Enabled = false;
            }
        }
    }
}