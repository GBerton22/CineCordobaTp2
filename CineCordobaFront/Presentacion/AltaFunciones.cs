using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using CineCordobaBack.Servicios;
using CineCordobaBack.Servicios.Implementacion;
using CineCordobaBack.Servicios.Interfaz;
using CineCordobaFront.Cliente;
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
    public partial class AltaFunciones : Form
    {


        public AltaFunciones()
        {
            InitializeComponent();


        }

        private async void AltaFunciones_Load(object sender, EventArgs e)
        {

            LimpiarCampos();
            int proximaFuncion = await ProximaFuncionAsync();
            lblFuncion.Text = lblFuncion.Text + " " + proximaFuncion;
            await CargarHorariosAsync();
            await CargarPeliculasAsync();
            await CargarSucursalAsync();


        }

        private async Task<int> ProximaFuncionAsync()
        {
            string url = "https://localhost:7055/proxFuncion";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            int v = JsonConvert.DeserializeObject<int>(data);

            return v;
        }

        private async Task CargarSucursalAsync()
        {
            string url = "https://localhost:7055/traerSucursales";
            var DataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Sucursales> lsucursales = JsonConvert.DeserializeObject<List<Sucursales>>(DataJson);

            cboSucursal.DataSource = lsucursales;
            cboSucursal.ValueMember = "id_sucursal";
            cboSucursal.DisplayMember = "NombreSucursal";
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarHorariosAsync()
        {
            string url = "https://localhost:7055/horarios";
            var DataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<CineCordobaBack.Entidades.Dto.DtoHorario> lhorarios = JsonConvert.DeserializeObject<List<CineCordobaBack.Entidades.Dto.DtoHorario>>(DataJson);

            cboHorario.DataSource = lhorarios;
            cboHorario.ValueMember = "id_horario";
            cboHorario.DisplayMember = "HorarioCompleto";
            cboHorario.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private async Task CargarPeliculasAsync()
        {
            string url = "https://localhost:7055/peliculas";
            var DataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoPeliculas> lpeliculas = JsonConvert.DeserializeObject<List<DtoPeliculas>>(DataJson);

            cboPelicula.DataSource = lpeliculas;
            cboPelicula.ValueMember = "id_pelicula";
            cboPelicula.DisplayMember = "nombre_pelicula";
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void LimpiarCampos()
        {
            dtpFecha.Value = DateTime.Now;
            cboSucursal.SelectedIndex = -1;
            cboPelicula.SelectedIndex = -1;
            rbtSubNo.Checked = false; rbtSubSi.Checked = false;
        }



        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                //MessageBox.Show("Las validaciones son correctas...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //this.Dispose();
                CineCordobaBack.Entidades.Dto.DtoFunciones Funcion = new CineCordobaBack.Entidades.Dto.DtoFunciones();

                Funcion.FuncionId = await ProximaFuncionAsync();
                Funcion.Fecha = Convert.ToDateTime(dtpFecha.Value);
                bool sub = false;
                if (rbtSubSi.Checked) { sub = true; }
                if (rbtSubNo.Checked) { sub = false; }
                Funcion.Subtitulo = sub;
                //Peliculas pelicula = new Peliculas();
                //pelicula.Id_pelicula = Convert.ToInt32(cboPelicula.SelectedValue);
                if (cboPelicula.SelectedItem is DtoPeliculas peliculaSeleccionada)
                {
                    //Console.WriteLine($"Pelicula seleccionada: {peliculaSeleccionada.Id_pelicula} - {peliculaSeleccionada.Nombre_pelicula}");

                    // Asignación directa al objeto Funcion
                    Funcion.PeliculaId = peliculaSeleccionada;
                }

                if (cboSala.SelectedItem is DtoTipoSalas tipoSalaSeleccionada)
                {
                    DtoSalas salaSeleccionada = new DtoSalas
                    {
                        SalaId = tipoSalaSeleccionada.Id_sala,
                        TipoSala = tipoSalaSeleccionada
                    };

                    // Asignación directa al objeto Funcion
                    Funcion.SalasId = salaSeleccionada;
                }
                Funcion.HorarioID = cboHorario.SelectedItem as CineCordobaBack.Entidades.Dto.DtoHorario;

                //Funcion.PeliculaId = cboPelicula.SelectedItem as Peliculas;
                //Funcion.SalasId = cboSala.SelectedItem as Salas;
                //Funcion.PeliculaId = pelicula;
                //Salas sala = new Salas();
                //sala.SalaId = Convert.ToInt32(cboSala.SelectedValue);
                //Funcion.SalasId = sala;
                //Horarios horario = new Horarios();
                //horario.Id_horario = Convert.ToInt32(cboHorario.SelectedValue);
                //Funcion.HorarioID = horario;
                //Funcion.SalasId= (Salas)cboSala.SelectedItem;
                //Funcion.HorarioID = (Horarios)cboHorario.SelectedItem;
                ////Funcion.PeliculaId = (Peliculas)cboPelicula.SelectedItem;



                if (await crearFuncionAsync(Funcion))
                {
                    MessageBox.Show("Se registró con éxito la funcion...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("NO se pudo registrar la funcion...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        private async Task<bool> crearFuncionAsync(CineCordobaBack.Entidades.Dto.DtoFunciones funcion)
        {
            string url = "https://localhost:7055/AltaFuncion";
            string FuncionJson = JsonConvert.SerializeObject(funcion);
            var DataJson = await ClienteSingleton.ObtenerInstancia().PostAsync(url, FuncionJson);
            return DataJson.Equals("true");
        }


        private bool validar()
        {
            bool v = true;
            if (dtpFecha.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("No se pueden cargar funciones en el pasado", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFecha.Focus();
                v = false;
            }


            if (cboPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una pelicula", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPelicula.Focus();
                v = false;
            }

            if (cboSala.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una sala", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSala.Focus();
                v = false;
            }
            if (cboSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una sucursal", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSucursal.Focus();
                v = false;
            }
            if (!rbtSubNo.Checked && !rbtSubSi.Checked)
            {
                MessageBox.Show("Debe seleccionar una opcion", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtSubNo.Focus();
                v = false;
            }

            if (v == false)
            {
                MessageBox.Show("Debe completar los datos para la funcion", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return v;
        }

        private async void cboSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idSucursalSeleccionada = Convert.ToInt32(cboSucursal.SelectedIndex + 1);

            await CargarSalasAsync(idSucursalSeleccionada);


        }

        private async Task CargarSalasAsync(int idSucursal)
        {
            string url = "https://localhost:7055/traerSalas" + "?id=" + idSucursal;
            var DataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DtoTipoSalas> lsalas = JsonConvert.DeserializeObject<List<DtoTipoSalas>>(DataJson);

            cboSala.DataSource = lsalas;
            cboSala.ValueMember = "id_sala";
            cboSala.DisplayMember = "tipo";
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
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
