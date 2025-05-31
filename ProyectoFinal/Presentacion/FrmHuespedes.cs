using ProyectoFinal.Datos;
using PROYECTOFINAL._3erSemestre.Datos;
using PROYECTOFINAL._3erSemestre.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINAL._3erSemestre.Presentacion
{
    public partial class FrmHuespedes : Form
    {
        CDconexion cd_conexion = new CDconexion();
        CLHuespedes cl_huespedes = new CLHuespedes();
        CDHuespedes cd_huespedes = new CDHuespedes();
        public FrmHuespedes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Cambios de GITHUB
        private void FrmHuespedes_Load(object sender, EventArgs e)
        {
            lblFecha.Text = cl_huespedes.MtdFechaActual().ToString("dd/MM/yyyy");
            MtdConsultarHuespedes();
        }

        public void MtdConsultarHuespedes()
        {
            DataTable dt = cd_huespedes.MtdConsultarHuespedes();

            dgvHuespedes.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNit.Text) ||
                string.IsNullOrEmpty(DtpFechaSistema.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor completar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                  

                    string UsuarioSistema = txtUsuario.Text;
                    string Nombre = txtNombre.Text;
                    string Tipo = cboxTipo.Text;
                    DateTime FechaSistema = DtpFechaSistema.Value;
                    string Nit = txtNit.Text;
                    string Telefono = txtTelefono.Text;
                    string Estado = cboxEstado.Text;

                    cd_huespedes.MtdAgregarHuesped(Nombre, Nit, Telefono, Tipo, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Huesped Agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHuespedes();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNit.Text) ||
               string.IsNullOrEmpty(DtpFechaSistema.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor completar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    int CodigoHuesped = int.Parse(txtCodigoHuesped.Text);
                    string UsuarioSistema = txtUsuario.Text;
                    string Nombre = txtNombre.Text;
                    string Tipo = cboxTipo.Text;
                    DateTime FechaSistema = DtpFechaSistema.Value;
                    string Nit = txtNit.Text;
                    string Telefono = txtTelefono.Text;
                    string Estado = cboxEstado.Text;

                    cd_huespedes.MtdEditarHuesped(CodigoHuesped, Nombre, Nit, Telefono, Tipo, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Huesped Editado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHuespedes();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void dgvHuespedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string FechaSistema = lblFecha.Text;
                int SeleccionarCelda = dgvHuespedes.CurrentRow.Index;

                txtCodigoHuesped.Text = dgvHuespedes[0, SeleccionarCelda].Value.ToString();
                txtNombre.Text = dgvHuespedes[1, SeleccionarCelda].Value.ToString();
                txtNit.Text = dgvHuespedes[2, SeleccionarCelda].Value.ToString();
                txtTelefono.Text = dgvHuespedes[3, SeleccionarCelda].Value.ToString();
                cboxTipo.Text = dgvHuespedes[4, SeleccionarCelda].Value.ToString();
                cboxEstado.Text = dgvHuespedes[5, SeleccionarCelda].Value.ToString();
                txtUsuario.Text = dgvHuespedes[6, SeleccionarCelda].Value.ToString();
                DtpFechaSistema.Text = dgvHuespedes[7, SeleccionarCelda].Value.ToString();
               



            }
            catch
            {
                MessageBox.Show("SELECCIONE CELDAS CON VALORES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        public void MtdLimpiarCampos()
        {
            txtCodigoHuesped.Clear();
            txtNombre.Clear();
            txtNit.Clear();
            txtTelefono.Clear();
            cboxTipo.Text = "";
            cboxEstado.Text = "";
            txtUsuario.Clear();
            DtpFechaSistema.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHuespedes.SelectedRows.Count > 0)
            {
                int CodigoHuesped = Convert.ToInt32(dgvHuespedes.SelectedRows[0].Cells["CodigoHuesped"].Value);
                try
                {
                    cd_huespedes.MtdEliminarHuesped(CodigoHuesped);
                    MessageBox.Show("Huesped eliminado correctamente.");
                    MtdConsultarHuespedes();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
