﻿using ProyectoFinal.Seguridad;
using PROYECTOFINAL._3erSemestre.Presentacion;
using Sistema_FarmaciaTotal;
using Sistema_FarmaciaTotal.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Presentacion
{
    public partial class FrmMenuPrincipal1 : Form
    {
        public FrmMenuPrincipal1()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelFormularioo.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panelBarraTitulo_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Metodo para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmHabitaciones>();
            btnHabitaciones.BackColor = Color.FromArgb(12, 61, 92);

        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmServicios>();
            btnServicios.BackColor = Color.FromArgb(12, 61, 92);

        }

        private void btnPagoPlanilla_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPagoPlanillas>();
            btnPagoPlanilla.BackColor = Color.FromArgb(12, 61, 92);
        }
        private void btnHuespedes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmHuespedes>();
            btnHuespedes.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPagos>();
            btnPagos.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere cerrar sesion?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        #endregion

        #region Funcionalidad para abrir formularios dentro del panel contenedor
        //Metodo para abrir formularios dentro del panel contenedor
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void FrmMenuPrincipal1_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void panelFormularios_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnConsumos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmConsumos>();
            btnPagoPlanilla.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmReservaciones>();
            btnPagoPlanilla.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEmpleados>();
            btnPagoPlanilla.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmHabitaciones"] == null)
                btnHabitaciones.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FrmServicios"] == null)
                btnServicios.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FrmPagoPlanillas"] == null)
                btnPagoPlanilla.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FrmHuespedes"] == null)
                btnHuespedes.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FrmPagos"] == null)
                btnPagos.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FrmConsumos"] == null)
                btnConsumos.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FrmReservaciones"] == null)
                btnReservaciones.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FrmAsignaciones"] == null)
                btnAsignaciones.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FrmUsuarios"] == null)
                btnUsuarios.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FrmEmleados"] == null)
                btnEmpleados.BackColor = Color.FromArgb(4, 41, 68);






        }
        #endregion

        private void LoadUserData()
        {
            lblUsuario.Text = UserCache.NombreUsuario;
            lblRol.Text = UserCache.Rol;
            lblEstado.Text = UserCache.Estado;
        }
    }

}
