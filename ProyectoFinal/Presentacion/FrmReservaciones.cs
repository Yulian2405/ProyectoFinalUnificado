using ProyectoFinal.Datos;
using Sistema_FarmaciaTotal.Datos;
using Sistema_FarmaciaTotal.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FarmaciaTotal.Presentacion
{
    public partial class FrmReservaciones : Form
    {
        CDconexion cd_conexion = new CDconexion();
        CDReservaciones cd_Reservaciones = new CDReservaciones();
        CLReservaciones cl_Reservaciones = new CLReservaciones();
        public FrmReservaciones()
        {
            InitializeComponent();
        }
        private void MtdConsultarReservaciones()
        {
            DataTable Dt = cd_Reservaciones.MtdConsultarReservaciones();
            dgvReservaciones.DataSource = Dt;


        }
        private void MtdMostrarListaHuespedes()
        {
            var ListaHuespedes = cd_Reservaciones.MtdListaHuespedes();

            foreach (var Huesped in ListaHuespedes)
            {
                cboxCodigoHuesped.Items.Add(Huesped);
            }

            cboxCodigoHuesped.DisplayMember = "Text";
            cboxCodigoHuesped.ValueMember = "Value";
        }

        private void MtdMostrarListaHabitaciones()
        {
            var ListaHabitaciones = cd_Reservaciones.MtdListaHabitaciones();

            foreach (var Habitaciones in ListaHabitaciones)
            {
                cboxCodigoHabitacion.Items.Add(Habitaciones);
            }

            cboxCodigoHabitacion.DisplayMember = "Text";
            cboxCodigoHabitacion.ValueMember = "Value";
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmReservaciones_Load(object sender, EventArgs e)
        {
            lblFecha.Text = cl_Reservaciones.MtdFechaActual().ToString("dd/MM/yyyy");
            MtdConsultarReservaciones();
            MtdMostrarListaHabitaciones();
            MtdMostrarListaHuespedes();
            
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if  (string.IsNullOrEmpty(cboxCodigoHuesped.Text) || string.IsNullOrEmpty(cboxCodigoHabitacion.Text) || string.IsNullOrEmpty(dtpFechaEntrada.Text) ||
                string.IsNullOrEmpty(dtpFechaSalida.Text) || string.IsNullOrEmpty(txtTotal.Text))
            {
                MessageBox.Show("Favor completar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var SelectedHuesped = (dynamic)cboxCodigoHuesped.SelectedItem;
                    int CodigoHuesped = (int)SelectedHuesped.Value;

                    var SelectedHabitacion = (dynamic)cboxCodigoHabitacion.SelectedItem;
                    int CodigoHabitacion = (int)SelectedHabitacion.Value;

                    DateTime FechaEntrada = dtpFechaEntrada.Value; 
                    DateTime FechaSalida = dtpFechaSalida.Value;
                    string Total = txtTotal.Text;
                    string UsuarioSistema = "LAPTOP-NCJENTML\\SQLEXPRESS";
                    DateTime FechaSistema = cl_Reservaciones.MtdFechaActual();

                    cd_Reservaciones.MtdAgregarReservaciones(CodigoHuesped, CodigoHabitacion, FechaEntrada, FechaSalida, Total, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Consumo agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarReservaciones();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoReserva.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoReserva = (int.Parse(txtCodigoReserva.Text));

                    cd_Reservaciones.MtdEliminarReservaciones(CodigoReserva);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarReservaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void MtdLimpiarCampos()
        {
            txtCodigoReserva.Text = "";
            cboxCodigoHuesped.Text = "";
            cboxCodigoHabitacion.Text = "";
            dtpFechaEntrada.Text = "";
            dtpFechaSalida.Text = "";
            txtTotal.Text = "";
        }

        private void dgvReservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SeleccionarCelda = dgvReservaciones.CurrentRow.Index;
            txtCodigoReserva.Text = dgvReservaciones[0, SeleccionarCelda].Value.ToString();
            cboxCodigoHuesped.Text = dgvReservaciones[1, SeleccionarCelda].Value.ToString();
            cboxCodigoHabitacion.Text = dgvReservaciones[2, SeleccionarCelda].Value.ToString();
            dtpFechaEntrada.Text = dgvReservaciones[3, SeleccionarCelda].Value.ToString();
            dtpFechaSalida.Text = dgvReservaciones[4, SeleccionarCelda].Value.ToString();
            txtTotal.Text = dgvReservaciones[5, SeleccionarCelda].Value.ToString();


            

        }

        private void cboxCodigoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTotal_TextChanged_1(object sender, EventArgs e)
        {
           
            
        }

        
    }
}
     

    

