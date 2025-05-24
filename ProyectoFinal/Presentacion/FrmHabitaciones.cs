using ProyectoFinal.Datos;
using ProyectoFinal.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmHabitaciones : Form
    {

        CLhabitaciones cl_habitaciones = new CLhabitaciones();
        CDhabitaciones cd_habitaciones = new CDhabitaciones();
        public FrmHabitaciones()
        {
            InitializeComponent();

        }

        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {

        }

        private void MtdConsultarHabitaciones()
        {
            DataTable Dt = cd_habitaciones.MtdConsultarHabitaciones();
            dgvHabitaciones.DataSource = Dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(cboxTipo.Text)||
               string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    double Numero = double.Parse(txtNumero.Text);
                    string Ubicacion = txtUbicacion.Text;
                    string Tipo = cboxTipo.Text;
                    string Estado = cboxEstado.Text;
                    double Precio = cl_habitaciones.MtdPrecioHabitacion(Tipo);
                    DateTime FechaSistema = cl_habitaciones.MtdFechaHoy();
                    string UsuarioSistema = "Yulian";

                    cd_habitaciones.MtdAgregarhabitacion(Numero, Ubicacion, Tipo, Precio, FechaSistema, Estado, UsuarioSistema);
                    MessageBox.Show("Habitacion agregada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(cboxTipo.Text) ||
               string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoHabitacion = (int.Parse(txtCodigoHabitacion.Text));
                    double Numero = double.Parse(txtNumero.Text);
                    string Ubicacion = txtUbicacion.Text;
                    string Tipo = cboxTipo.Text;
                    string Estado = cboxEstado.Text;
                    double Precio = cl_habitaciones.MtdPrecioHabitacion(Tipo);
                    DateTime FechaSistema = cl_habitaciones.MtdFechaHoy();
                    string UsuarioSistema = "Yulian";

                    cd_habitaciones.MtdActualizarhabitacion(CodigoHabitacion, Numero, Ubicacion, Tipo, Precio, FechaSistema, Estado, UsuarioSistema);
                    MessageBox.Show("Habitacion actualizada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MtdLimpiarCampos()
        {
            txtCodigoHabitacion.Text = "";
            txtNumero.Text = "";
            txtUbicacion.Text = "";
            cboxTipo.Text = "";
            txtPrecio.Text = "";
            cboxEstado.Text = "";
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoHabitacion.Text))
            {
                MessageBox.Show("Favor seleccionar habitacion a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoHabitacion = (int.Parse(txtCodigoHabitacion.Text));

                    cd_habitaciones.MtdEliminarHabitacion(CodigoHabitacion);
                    MessageBox.Show("Habitacion eliminada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxTipo.Text))
            {
                MessageBox.Show("Seleccione un tipo de habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtPrecio.Text = cl_habitaciones.MtdPrecioHabitacion(cboxTipo.Text).ToString("c");
            }
        }

        private void FrmHabitaciones_Load_1(object sender, EventArgs e)
        {
            lblFecha.Text = cl_habitaciones.MtdFechaHoy().ToString("d");
            MtdConsultarHabitaciones();



        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvHabitaciones.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvHabitaciones.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoHabitacion.Text = dgvHabitaciones.SelectedCells[0].Value.ToString();
                txtNumero.Text = dgvHabitaciones.SelectedCells[1].Value.ToString();
                txtUbicacion.Text = dgvHabitaciones.SelectedCells[2].Value.ToString();
                cboxTipo.Text = dgvHabitaciones.SelectedCells[3].Value.ToString();
                txtPrecio.Text = dgvHabitaciones.SelectedCells[4].Value.ToString();
                cboxEstado.Text = dgvHabitaciones.SelectedCells[5].Value.ToString();
                
            }
        }
        private void txtUsuarioSistema_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaSistema_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
