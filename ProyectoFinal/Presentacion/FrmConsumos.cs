using ProyectoFinal.Datos;
using Sistema_FarmaciaTotal.Datos;
using Sistema_FarmaciaTotal.Logica;
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

namespace Sistema_FarmaciaTotal
{
    public partial class FrmConsumos : Form
    {
        CDconexion cd_conexion = new CDconexion();
        CLConsumos cl_consumos = new CLConsumos();
        CDConsumos cd_consumos = new CDConsumos();
        public FrmConsumos()
        {
            InitializeComponent();
        }
        private void MtdMostrarListareservaciones()
        {
            var Listareservaciones = cd_consumos.MtdListareservaciones();
            

            foreach (var reservaciones in Listareservaciones)
            {
                cboxCodigoReserva.Items.Add(reservaciones);
            }

            cboxCodigoReserva.DisplayMember = "Text";
            cboxCodigoReserva.ValueMember = "Value";
        }
         
        private void MtdMostrarListaServicios()
        {
            var ListaServicios = cd_consumos.MtdListaServicios();
            

            foreach (var servicios in ListaServicios)
            {
                cboxCodigoServicio.Items.Add(servicios);
            }

            cboxCodigoServicio.DisplayMember = "Text";
            cboxCodigoServicio.ValueMember = "Value";
        }

       
        private void MtdConsultarConsumos()
        {
            DataTable Dt = cd_consumos.MtdConsultarConsumos();
            dgvConsumos.DataSource = Dt;
        }

        private void FrmConsumos_Load(object sender, EventArgs e)
        {
            lblFecha.Text = cl_consumos.MtdFechaActual().ToString("dd/MM/yyyy");
            MtdMostrarListareservaciones();
            MtdMostrarListaServicios();
            MtdConsultarConsumos();


        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(cboxCodigoReserva.Text) || string.IsNullOrEmpty(cboxCodigoServicio.Text) || string.IsNullOrEmpty(txtMonto.Text) ||
                string.IsNullOrEmpty(dtpFechaConsumo.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor completar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {


                    int CodigoReserva = (int)((dynamic)cboxCodigoReserva.SelectedItem).value;
                    int CodigoServicio = (int)((dynamic)cboxCodigoServicio.SelectedItem).value;
                    double Monto = double.Parse(txtMonto.Text);
                    DateTime FechaConsumo = dtpFechaConsumo.Value;
                    string Estado = cboxEstado.Text;                 
                    string UsuarioSistema = "LAPTOP-NCJENTML\\SQLEXPRESS";
                    DateTime FechaSistema = cl_consumos.MtdFechaActual();

                    cd_consumos.MtdAgregarConsumos(CodigoReserva, CodigoServicio, Monto, FechaConsumo, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Consumo agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarConsumos();
                    MtdLimpiarCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodigoServicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvConsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    
        
        public void MtdLimpiarCampos()
        {
            txtCodigoConsumo.Text = "";
            cboxCodigoReserva.Text = "";
            cboxCodigoServicio.Text = "";
            txtMonto.Text = "";
            dtpFechaConsumo.Text = "";
            cboxEstado.Text = "";
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
            if (string.IsNullOrEmpty(txtCodigoConsumo.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoConsumo = int.Parse(txtCodigoConsumo.Text);

                try
                {
                    cd_consumos.MtdEliminarConsumos(CodigoConsumo);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarConsumos();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboxCodigoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedServicio = (dynamic)cboxCodigoServicio.SelectedItem;
            int CodigoServicio = (int)selectedServicio;
            txtCodigoConsumo.Text = (CodigoServicio).ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboxCodigoReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* var selectedReserva = (dynamic)cboxCodigoReserva.SelectedItem;
            int codigoServicio = (int)selectedReserva.Value;
            txtMonto.Text = cl_consumos.MtdConsultaMontoServicio(codigoServicio).ToString();*/
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoConsumo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoReserva.Text) || string.IsNullOrEmpty(cboxCodigoServicio.Text) || string.IsNullOrEmpty(txtMonto.Text) ||
               string.IsNullOrEmpty(dtpFechaConsumo.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor completar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    int CodigoReserva = (int)((dynamic)cboxCodigoReserva.SelectedItem).value;
                    int CodigoServicio = (int)((dynamic)cboxCodigoServicio.SelectedItem).value;
                    double Monto = double.Parse(txtMonto.Text);
                    DateTime FechaConsumo = dtpFechaConsumo.Value;
                    string Estado = cboxEstado.Text;
                    string UsuarioSistema = "LAPTOP-NCJENTML\\SQLEXPRESS";
                    DateTime FechaSistema = cl_consumos.MtdFechaActual();

                    cd_consumos.MtdAgregarConsumos(CodigoReserva, CodigoServicio, Monto, FechaConsumo, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Consumo editado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarConsumos();
                    MtdLimpiarCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}







