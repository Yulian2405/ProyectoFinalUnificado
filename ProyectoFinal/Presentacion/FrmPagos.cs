using ProyectoFinal.Datos;
using PROYECTOFINAL._3erSemestre.Datos;
using PROYECTOFINAL._3erSemestre.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINAL._3erSemestre.Presentacion
{
    public partial class FrmPagos : Form
    {
        CDconexion cd_conexion = new CDconexion();
        CDPagos cd_pagos = new CDPagos();
        CLPagos cl_pagos = new CLPagos();
        public FrmPagos()
        {
            InitializeComponent();

        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
           
            lblFecha.Text = cl_pagos.MtdFechaActual().ToString("dd/MM/yyyy");
            MtdConsultarPagos();
            MtdListaReservaciones();


        }

        private void MtdConsultarPagos()
        {
            DataTable Dt = cd_pagos.MtdConsultarPagos();
            dgvPagos.DataSource = Dt;

        }
        private void MtdListaReservaciones()
        {
            var ListaReservaciones = cd_pagos.MtdListaReservaciones();
            cboxCodigoReserva.Items.Clear();

            foreach (var reservaciones in ListaReservaciones)
            {
                cboxCodigoReserva.Items.Add(reservaciones);
            }

            cboxCodigoReserva.DisplayMember = "Text";
            cboxCodigoReserva.ValueMember = "Value";
        }

        private void MtdMostrarReservaciones()
        {
            var ListaReservaciones = cd_pagos.MtdListaReservaciones();
            cboxCodigoReserva.Items.Clear();

            foreach (var reservaciones in ListaReservaciones)
            {
                cboxCodigoReserva.Items.Add(reservaciones);
            }

            cboxCodigoReserva.DisplayMember = "Text";
            cboxCodigoReserva.ValueMember = "Value";
        }



        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cboxCodigoReserva.Text) || string.IsNullOrEmpty(cboxMetodoPago.Text) || string.IsNullOrEmpty(txtMonto.Text) || string.IsNullOrEmpty(txtTPago.Text) ||
                string.IsNullOrEmpty(DtpFechaPago.Text) || string.IsNullOrEmpty(txtDescuento.Text) || string.IsNullOrEmpty(txtPropina.Text) || string.IsNullOrEmpty(txtImpuesto.Text))
            {
                MessageBox.Show("Favor completar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var SelectedReserva = (dynamic)cboxCodigoReserva.SelectedItem;
                    int CodigoReserva = (int)SelectedReserva.Value;




                    string MetodoPago = cboxMetodoPago.Text;
                    decimal Monto = decimal.Parse(txtMonto.Text);
                    decimal Propina = decimal.Parse(txtPropina.Text);
                    decimal Impuesto = decimal.Parse(txtImpuesto.Text);
                    decimal Descuento = decimal.Parse(txtDescuento.Text);
                    decimal TotalPago = decimal.Parse(txtTPago.Text);
                    DateTime FechaSistema = cl_pagos.MtdFechaActual();
                    string UsuarioSistema = "Nombre";
                    DateTime FechaPago = DtpFechaPago.Value;

                    cd_pagos.MtdAgregarPago(CodigoReserva, Monto, Propina, Impuesto, Descuento, TotalPago, FechaPago, MetodoPago, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Pago Agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        public void MtdLimpiarCampos()
        {
            cboxCodigoReserva.Text = "";
            txtCodigoPago.Clear();
            cboxMetodoPago.Text = "";
            txtMonto.Clear();
            txtPropina.Clear();
            txtImpuesto.Clear();
            txtDescuento.Clear();
            txtTPago.Clear();
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
            if (dgvPagos.SelectedRows.Count > 0)
            {
                int codigoPago = Convert.ToInt32(dgvPagos.SelectedRows[0].Cells["CodigoPago"].Value);
                try
                {
                    cd_pagos.MtdEliminarPago(codigoPago); 
                    MessageBox.Show("Pago eliminado correctamente.");
                    MtdConsultarPagos(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el pago: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }

        }

        private void dgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string FechaSistema = lblFecha.Text;
                int SeleccionarCelda = dgvPagos.CurrentRow.Index;

                txtCodigoPago.Text = dgvPagos[0, SeleccionarCelda].Value.ToString();
                cboxCodigoReserva.Text = dgvPagos[1, SeleccionarCelda].Value.ToString();
                txtMonto.Text = dgvPagos[2, SeleccionarCelda].Value.ToString();
                txtPropina.Text = dgvPagos[3, SeleccionarCelda].Value.ToString();
                txtImpuesto.Text = dgvPagos[4, SeleccionarCelda].Value.ToString();
                txtDescuento.Text = dgvPagos[5, SeleccionarCelda].Value.ToString();
                txtTPago.Text = dgvPagos[6, SeleccionarCelda].Value.ToString();
                DtpFechaPago.Text = dgvPagos[7, SeleccionarCelda].Value.ToString();
                cboxMetodoPago.Text = dgvPagos[8, SeleccionarCelda].Value.ToString();



            }
            catch
            {
                MessageBox.Show("SELECCIONE CELDAS CON VALORES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoReserva.Text) || string.IsNullOrEmpty(cboxMetodoPago.Text) || string.IsNullOrEmpty(txtMonto.Text) || string.IsNullOrEmpty(txtTPago.Text) ||
                string.IsNullOrEmpty(DtpFechaPago.Text) || string.IsNullOrEmpty(txtDescuento.Text) || string.IsNullOrEmpty(txtPropina.Text) || string.IsNullOrEmpty(txtImpuesto.Text))
            {
                MessageBox.Show("Favor completar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var SelectedReserva = (dynamic)cboxCodigoReserva.SelectedItem;
                    int CodigoReserva = (int)SelectedReserva.Value;



                    int CodigoPago = int.Parse(txtCodigoPago.Text);
                    string MetodoPago = cboxMetodoPago.Text;
                    decimal Monto = decimal.Parse(txtMonto.Text);
                    decimal Propina = decimal.Parse(txtPropina.Text);
                    decimal Impuesto = decimal.Parse(txtImpuesto.Text);
                    decimal Descuento = decimal.Parse(txtDescuento.Text);
                    decimal TotalPago = decimal.Parse(txtTPago.Text);
                    DateTime FechaSistema = cl_pagos.MtdFechaActual();
                    string UsuarioSistema = "Nombre";
                    DateTime FechaPago = DtpFechaPago.Value;

                    cd_pagos.MtdEditarPago(CodigoPago, CodigoReserva, Monto, Propina, Impuesto, Descuento, TotalPago, FechaPago, MetodoPago, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Pago Editado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void txtPropina_TextChanged(object sender, EventArgs e)
        {
            
        }
        // Recupera el Total de la reserva para el txtMonto.Text del Form
        private void cboxCodigoReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Muestra el Monto Total de la reservacion
            var selectedReserva= (dynamic)cboxCodigoReserva.SelectedItem;
            int codigoServicio = (int)selectedReserva.Value;
            txtMonto.Text =  cl_pagos.MtdConsultaMontoServicio(codigoServicio).ToString();

            // Calcula la propina en el txtPropina
            txtPropina.Text =  cl_pagos.MtdMtdPropinaPago( double.Parse(txtMonto.Text)).ToString();

            // Calcula el impuesto  en el txtImpuesto
            txtImpuesto.Text = cl_pagos.MtdImpuestoPago(double.Parse(txtMonto.Text)).ToString();

            // Calcula el descuento en base a txtMonto
            txtDescuento.Text = cl_pagos.MtdDescuentoPago(double.Parse(txtMonto.Text)).ToString();

            // Calcula el monto pago
            txtTPago.Text = cl_pagos.MtdTotalPago(double.Parse(txtMonto.Text),double.Parse(txtPropina.Text),double.Parse(txtImpuesto.Text),double.Parse(txtDescuento.Text)).ToString();

        }

    }

} 
