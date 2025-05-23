using ProyectoFinal.Datos;
using PROYECTOFINAL._3erSemestre.Datos;
using PROYECTOFINAL._3erSemestre.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            MtdConsultarConsumos();
        }

        private void MtdConsultarConsumos()
        {
            DataTable Dt = cd_pagos.MtdConsultarPagos();
            dgvPagos.DataSource = Dt;
        }


        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxMetodoPago.Text) || string.IsNullOrEmpty(txtCodigoPago.Text) || string.IsNullOrEmpty(cboxCodigoReserva.Text) || string.IsNullOrEmpty(txtMonto.Text) ||
                string.IsNullOrEmpty(DtpFechaPago.Text) || string.IsNullOrEmpty(txtPropina.Text) || string.IsNullOrEmpty(txtDescuento.Text) || string.IsNullOrEmpty(txtImpuesto.Text))
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
                    int CodigoPago = int.Parse(txtCodigoPago.Text);
                    decimal Monto = decimal.Parse(txtMonto.Text);
                    decimal Propina = decimal.Parse(txtPropina.Text);
                    decimal Impuesto = decimal.Parse(txtImpuesto.Text);
                    decimal Descuento = decimal.Parse(txtDescuento.Text);
                    DateTime FechaPago = DtpFechaPago.Value;
                    decimal TotalPago = decimal.Parse(txtTPago.Text);
                    string UsuarioSistema = "Darien";
                    DateTime FechaSistema = cl_pagos.MtdFechaActual();

                    cd_pagos.MtdAgregarPagos(CodigoPago, CodigoReserva, Monto, Propina, Impuesto, Descuento, TotalPago, FechaPago, MetodoPago, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Consumo agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarConsumos();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int VerFila = dgvPagos.CurrentRow.Index;

            dgvPagos.Rows.RemoveAt(VerFila);
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
    }
}
