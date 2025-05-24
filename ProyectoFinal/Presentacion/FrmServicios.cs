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

namespace ProyectoFinal
{
    public partial class FrmServicios : Form
    {
        CLservicios cl_servicios = new CLservicios();
        CDservicios cd_servicios = new CDservicios();
        public FrmServicios()
        {
            InitializeComponent();
        }
        private void MtdConsultarServicios()
        {
            DataTable DtServicios = cd_servicios.MtdConsultarServicios();
            dgvServicios.DataSource = DtServicios;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxTipo.Text) || string.IsNullOrEmpty(txtPrecio.Text) ||
               string.IsNullOrEmpty(dtpFechaVigencia.Text) || string.IsNullOrEmpty(dtpFechaVencimiento.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Nombre = txtNombre.Text;
                    string Tipo = cboxTipo.Text;
                    double Precio = cl_servicios.MtdPrecioServicio(Tipo);
                    DateTime FechaVigencia = dtpFechaVigencia.Value;
                    DateTime FechaVencimiento = dtpFechaVencimiento.Value;
                    string Estado = cboxEstado.Text;
                    string UsuarioSistema = "Yulian";
                    DateTime FechaSistema = cl_servicios.MtdFechaHoy();

                    cd_servicios.MtdAgregarServicios(Nombre, Tipo, Precio, FechaVigencia, FechaVencimiento, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Servicio agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarServicios();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            lblFecha.Text = cl_servicios.MtdFechaHoy().ToString("d");
            MtdConsultarServicios();
        }

        public void MtdLimpiarCampos()
        {
            txtCodigoServicio.Text = "";
            cboxTipo.Text = " ";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            dtpFechaVigencia.Text = "";
            dtpFechaVencimiento.Text = "";
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
            if (string.IsNullOrEmpty(txtCodigoServicio.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoServicio = int.Parse(txtCodigoServicio.Text);

                try
                {
                    cd_servicios.MtdEliminarServicios(CodigoServicio);
                    MessageBox.Show("Servicio eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarServicios();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvServicios.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvServicios.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoServicio.Text = dgvServicios.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvServicios.SelectedCells[1].Value.ToString();
                cboxTipo.Text = dgvServicios.SelectedCells[2].Value.ToString();
                txtPrecio.Text = dgvServicios.SelectedCells[3].Value.ToString();
                dtpFechaVigencia.Text = dgvServicios.SelectedCells[4].Value.ToString();
                dtpFechaVencimiento.Text = dgvServicios.SelectedCells[5].Value.ToString();
                cboxEstado.Text=dgvServicios.SelectedCells[6].Value.ToString();
              

            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxTipo.Text))
            {
                MessageBox.Show("Seleccione un tipo de servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtPrecio.Text = cl_servicios.MtdPrecioServicio(cboxTipo.Text).ToString("c");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodigoServicio.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxTipo.Text) || string.IsNullOrEmpty(txtPrecio.Text) ||
               string.IsNullOrEmpty(dtpFechaVigencia.Text) || string.IsNullOrEmpty(dtpFechaVencimiento.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoServicio = int.Parse(txtCodigoServicio.Text);
                    string Nombre = txtNombre.Text;
                    string Tipo = cboxTipo.Text;
                    double Precio = cl_servicios.MtdPrecioServicio(Tipo);
                    DateTime FechaVigencia = dtpFechaVigencia.Value;
                    DateTime FechaVencimiento = dtpFechaVencimiento.Value;
                    string Estado = cboxEstado.Text;
                    string UsuarioSistema = "Yulian";
                    DateTime FechaSistema = cl_servicios.MtdFechaHoy();

                    cd_servicios.MtdActualizarServicios(CodigoServicio, Nombre, Tipo, Precio, FechaVigencia, FechaVencimiento, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Servicio editado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarServicios();
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
