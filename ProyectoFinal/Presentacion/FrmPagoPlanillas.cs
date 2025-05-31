using Microsoft.VisualBasic.Devices;
using ProyectoFinal.Datos;
using ProyectoFinal.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Presentacion
{
    public partial class FrmPagoPlanillas : Form
    {
        CDpagoplanillas cd_pagoplanillas = new CDpagoplanillas();
        CLpagoplanillas cl_pagoplanillas = new CLpagoplanillas();
        public FrmPagoPlanillas()
        {
            InitializeComponent();
        }

        private void FrmPagoPlanillas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = cl_pagoplanillas.MtdFechaActual().ToString("dd/MM/yyyy");
            MtdMostrarListaEmpleados();
            MtdConsultarPagoPlanillas();
            
        }

        // Metodo que imprime la lista de empleados en el combobox
        private void MtdMostrarListaEmpleados()
        {
            var ListaEmpleados = cd_pagoplanillas.MtdListaEmpleado();
            cboxCodigoEmpleado.Items.Clear();

            foreach (var empleados in ListaEmpleados)
            {
                cboxCodigoEmpleado.Items.Add(empleados);
            }

            cboxCodigoEmpleado.DisplayMember = "Text";
            cboxCodigoEmpleado.ValueMember = "Value";
        }

        // Recupera el Salario del Empleado para el txtSalario.Text del Form

        private void cboxCodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEmpleado = (dynamic)cboxCodigoEmpleado.SelectedItem;
            int CodigoEmpleado = (int)selectedEmpleado.Value;

            double Salario = cl_pagoplanillas.MtdConsultaSalarioEmpleado(CodigoEmpleado);
            txtSalario.Text = Salario.ToString("c");
            double Bono = cl_pagoplanillas.MtdSalarioBono(Salario);
            txtBono.Text = Bono.ToString("c");
        }

        // Metodo para mostrar listado de PagoPlanillas en el DataGridView
        private void MtdConsultarPagoPlanillas()
        {
            DataTable Dt = cd_pagoplanillas.MtdConsultarPagoPlanillas();
            dgvPagoPlanillas.DataSource = Dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoEmpleado.Text) || string.IsNullOrEmpty(dtpFechaPago.Text) || string.IsNullOrEmpty(txtSalario.Text) ||
                string.IsNullOrEmpty(txtBono.Text) || string.IsNullOrEmpty(txtHorasExtras.Text) || string.IsNullOrEmpty(txtMontoTotal.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor completar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var SelectedEmpleado = (dynamic)cboxCodigoEmpleado.SelectedItem;
                    int CodigoEmpleado = (int)SelectedEmpleado.Value;

                    DateTime FechaPago = dtpFechaPago.Value;
                    double Salario = cl_pagoplanillas.MtdConsultaSalarioEmpleado(CodigoEmpleado);
                    double Bono = cl_pagoplanillas.MtdSalarioBono(Salario);
                    double HorasExtras = double.Parse(txtHorasExtras.Text);
                    double MontoTotal = cl_pagoplanillas.MtdMontoTotal(Salario, Bono,HorasExtras);
                    string Estado = cboxEstado.Text;
                    string UsuarioSistema = "Yulian";
                    DateTime FechaSistema = cl_pagoplanillas.MtdFechaActual();

                    cd_pagoplanillas.MtdAgregarPagoPlanillas(CodigoEmpleado, FechaPago, Salario, Bono, HorasExtras, MontoTotal, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Pago Planilla agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoPlanillas();
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
            txtCodigoPagoPlanilla.Text = "";
            cboxCodigoEmpleado.Text= " ";
            dtpFechaPago.Text = "";
            txtSalario.Text = "";
            txtBono.Text = "";
            txtHorasExtras.Text = "";
            txtMontoTotal.Text = " ";
            cboxEstado.Text = " ";

        }

        private void dgvPagoPlanillas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvPagoPlanillas.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvPagoPlanillas.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoPagoPlanilla.Text = dgvPagoPlanillas.SelectedCells[0].Value.ToString();

                //cboxCodigoEmpleado.Text = dgvPagoPlanillas.SelectedCells[1].Value.ToString();
                int CodigoEmpleado = (int)dgvPagoPlanillas.SelectedCells[1].Value;
                foreach (var codigoEmp in cboxCodigoEmpleado.Items)
                {
                    if (((dynamic)codigoEmp).Value == CodigoEmpleado)
                    {
                        cboxCodigoEmpleado.SelectedItem = codigoEmp;
                        //break;
                    }
                }

                dtpFechaPago.Text = dgvPagoPlanillas.SelectedCells[2].Value.ToString();
                txtSalario.Text = dgvPagoPlanillas.SelectedCells[3].Value.ToString();
                txtBono.Text = dgvPagoPlanillas.SelectedCells[4].Value.ToString();
                txtHorasExtras.Text = dgvPagoPlanillas.SelectedCells[5].Value.ToString();
                txtMontoTotal.Text = dgvPagoPlanillas.SelectedCells[6].Value.ToString();
                cboxEstado.Text = dgvPagoPlanillas.SelectedCells[7].Value.ToString();


            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoPagoPlanilla.Text))
            {
                MessageBox.Show("Favor seleccionar pago planilla a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoPagoPlanilla = (int.Parse(txtCodigoPagoPlanilla.Text));

                    cd_pagoplanillas.MtdEliminarPagoPlanilla(CodigoPagoPlanilla);
                    MessageBox.Show("Pago Planilla eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoPlanillas();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void txtBono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoTotal_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtHorasExtras_TextChanged(object sender, EventArgs e)
        {
            var selectedEmpleado = (dynamic)cboxCodigoEmpleado.SelectedItem;
            int CodigoEmpleado = (int)selectedEmpleado.Value;
            double Salario = cl_pagoplanillas.MtdConsultaSalarioEmpleado(CodigoEmpleado);
            
            double Bono =   cl_pagoplanillas.MtdSalarioBono(Salario);
            double Horas;


            if (double.TryParse(txtHorasExtras.Text, out Horas))
            {
                Horas = double.Parse(txtHorasExtras.Text);
                double MontoTotal = cl_pagoplanillas.MtdMontoTotal(Salario, Bono, int.Parse(txtHorasExtras.Text));
                txtMontoTotal.Text = MontoTotal.ToString("c");
            }
            else
            {
                Horas = 0;
                double MontoTotal = cl_pagoplanillas.MtdMontoTotal(Salario, Bono, Horas);
                txtMontoTotal.Text = MontoTotal.ToString("c");

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoEmpleado.Text) || string.IsNullOrEmpty(dtpFechaPago.Text) || string.IsNullOrEmpty(txtSalario.Text) ||
                string.IsNullOrEmpty(txtBono.Text) || string.IsNullOrEmpty(txtHorasExtras.Text) || string.IsNullOrEmpty(txtMontoTotal.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor completar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoPagoPlanilla = (int.Parse(txtCodigoPagoPlanilla.Text));
                    var SelectedEmpleado = (dynamic)cboxCodigoEmpleado.SelectedItem;
                    int CodigoEmpleado = (int)SelectedEmpleado.Value;

                    DateTime FechaPago = dtpFechaPago.Value;
                    double Salario = cl_pagoplanillas.MtdConsultaSalarioEmpleado(CodigoEmpleado);
                    double Bono = cl_pagoplanillas.MtdSalarioBono(Salario);
                    double HorasExtras = double.Parse(txtHorasExtras.Text);
                    double MontoTotal = cl_pagoplanillas.MtdMontoTotal(Salario, Bono, HorasExtras);
                    string Estado = cboxEstado.Text;
                    string UsuarioSistema = "Yulian";
                    DateTime FechaSistema = cl_pagoplanillas.MtdFechaActual();

                    cd_pagoplanillas.MtdActualizarPagoPlanillas(CodigoPagoPlanilla, CodigoEmpleado, FechaPago, Salario, Bono, HorasExtras, MontoTotal, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Pago Planilla actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoPlanillas();
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
