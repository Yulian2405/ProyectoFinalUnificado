using ProyectoFinal.Datos;
using ProyectoFinal.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Presentacion
{
    public partial class FrmEmpleados : Form
    {

        CLEmpleados cl_empleados = new CLEmpleados();
        CDEmpleados cd_empleados = new CDEmpleados();
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            lblFecha.Text = cl_empleados.MtdFechaHoy().ToString("d");
            MtdConsultarEmpleados();
        }

        private void MtdConsultarEmpleados()
        {
            DataTable Dt = cd_empleados.MtdConsultarEmpleados();
            dgvEmpleados.DataSource = Dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxCargo.Text) || string.IsNullOrEmpty(txtSalario.Text) ||
               string.IsNullOrEmpty(dtpFechaContratacion.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Nombre = txtNombre.Text;
                    string Cargo = cboxCargo.Text;
                    double Salario = cl_empleados.MtdSalarioEmpleado(Cargo);
                    DateTime FechaContratacion = dtpFechaContratacion.Value;
                    string Estado = cboxEstado.Text;
                    string UsuarioSistema = "Said";
                    DateTime FechaSistema = cl_empleados.MtdFechaHoy();

                    cd_empleados.MtdAgregarempleado(Nombre, Cargo, Salario, FechaContratacion, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Empleado agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
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
            txtCodigoEmpleado.Text = " ";
            txtNombre.Text = "";
            cboxCargo.Text = "";
            txtSalario.Text = "";
            dtpFechaContratacion.Text = "";
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
            if (string.IsNullOrEmpty(txtCodigoEmpleado.Text))
            {
                MessageBox.Show("Favor seleccionar empleado a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoEmpleado = (int.Parse(txtCodigoEmpleado.Text));

                    cd_empleados.MtdEliminarEmpleado(CodigoEmpleado);
                    MessageBox.Show("Empleado eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCargo.Text))
            {
                MessageBox.Show("Seleccione el cargo del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtSalario.Text = cl_empleados.MtdSalarioEmpleado(cboxCargo.Text).ToString("c");
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvEmpleados.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvEmpleados.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoEmpleado.Text =dgvEmpleados.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvEmpleados.SelectedCells[1].Value.ToString();
                cboxCargo.Text = dgvEmpleados.SelectedCells[2].Value.ToString();
                txtSalario.Text = dgvEmpleados.SelectedCells[3].Value.ToString();
                dtpFechaContratacion.Text = dgvEmpleados.SelectedCells[4].Value.ToString();
                cboxEstado.Text = dgvEmpleados.SelectedCells[5].Value.ToString();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxCargo.Text) || string.IsNullOrEmpty(txtSalario.Text) ||
              string.IsNullOrEmpty(dtpFechaContratacion.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {   
                    int CodigoEmpleado = (int.Parse(txtCodigoEmpleado.Text));
                    string Nombre = txtNombre.Text;
                    string Cargo = cboxCargo.Text;
                    double Salario = cl_empleados.MtdSalarioEmpleado(Cargo);
                    DateTime FechaContratacion = cl_empleados.MtdFechaHoy();
                    string Estado = cboxEstado.Text;
                    string UsuarioSistema = "Said";
                    DateTime FechaSistema = cl_empleados.MtdFechaHoy();

                    cd_empleados.MtdActualizarempleado(CodigoEmpleado, Nombre, Cargo, Salario, FechaContratacion, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Empleado actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpFechaContratacion_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
