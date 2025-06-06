﻿namespace ProyectoFinal.Presentacion
{
    partial class FrmMenuPrincipal1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal1));
            this.panelFormularioo = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.lblMensajeBienvenida = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnAsignaciones = new FontAwesome.Sharp.IconButton();
            this.btnReservaciones = new FontAwesome.Sharp.IconButton();
            this.btnPagos = new FontAwesome.Sharp.IconButton();
            this.btnHuespedes = new FontAwesome.Sharp.IconButton();
            this.btnConsumos = new FontAwesome.Sharp.IconButton();
            this.btnPagoPlanilla = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnServicios = new FontAwesome.Sharp.IconButton();
            this.btnHabitaciones = new FontAwesome.Sharp.IconButton();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelFormularioo.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormularioo
            // 
            this.panelFormularioo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFormularioo.Controls.Add(this.panelFormularios);
            this.panelFormularioo.Controls.Add(this.panelMenu);
            this.panelFormularioo.Controls.Add(this.panelBarraTitulo);
            this.panelFormularioo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelFormularioo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularioo.Location = new System.Drawing.Point(0, 0);
            this.panelFormularioo.Name = "panelFormularioo";
            this.panelFormularioo.Size = new System.Drawing.Size(1363, 661);
            this.panelFormularioo.TabIndex = 0;
            this.panelFormularioo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularios_Paint);
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelFormularios.Controls.Add(this.lblMensajeBienvenida);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(250, 40);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1113, 621);
            this.panelFormularios.TabIndex = 2;
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularios_Paint_1);
            // 
            // lblMensajeBienvenida
            // 
            this.lblMensajeBienvenida.AutoSize = true;
            this.lblMensajeBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeBienvenida.Location = new System.Drawing.Point(424, 228);
            this.lblMensajeBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensajeBienvenida.Name = "lblMensajeBienvenida";
            this.lblMensajeBienvenida.Size = new System.Drawing.Size(231, 29);
            this.lblMensajeBienvenida.TabIndex = 1;
            this.lblMensajeBienvenida.Text = "PAGINA PRINCIPAL";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnEmpleados);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnAsignaciones);
            this.panelMenu.Controls.Add(this.btnReservaciones);
            this.panelMenu.Controls.Add(this.btnPagos);
            this.panelMenu.Controls.Add(this.btnHuespedes);
            this.panelMenu.Controls.Add(this.btnConsumos);
            this.panelMenu.Controls.Add(this.btnPagoPlanilla);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.PanelLogin);
            this.panelMenu.Controls.Add(this.btnServicios);
            this.panelMenu.Controls.Add(this.btnHabitaciones);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 621);
            this.panelMenu.TabIndex = 1;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnEmpleados.IconColor = System.Drawing.Color.White;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.IconSize = 25;
            this.btnEmpleados.Location = new System.Drawing.Point(4, 494);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(247, 36);
            this.btnEmpleados.TabIndex = 31;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 25;
            this.btnUsuarios.Location = new System.Drawing.Point(5, 454);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(247, 36);
            this.btnUsuarios.TabIndex = 30;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnAsignaciones
            // 
            this.btnAsignaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnAsignaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignaciones.FlatAppearance.BorderSize = 0;
            this.btnAsignaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnAsignaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAsignaciones.IconChar = FontAwesome.Sharp.IconChar.FaceSmileBeam;
            this.btnAsignaciones.IconColor = System.Drawing.Color.White;
            this.btnAsignaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsignaciones.IconSize = 25;
            this.btnAsignaciones.Location = new System.Drawing.Point(5, 407);
            this.btnAsignaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignaciones.Name = "btnAsignaciones";
            this.btnAsignaciones.Size = new System.Drawing.Size(247, 36);
            this.btnAsignaciones.TabIndex = 29;
            this.btnAsignaciones.Text = "Asignaciones";
            this.btnAsignaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsignaciones.UseVisualStyleBackColor = false;
            this.btnAsignaciones.Click += new System.EventHandler(this.btnAsignaciones_Click);
            // 
            // btnReservaciones
            // 
            this.btnReservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnReservaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservaciones.FlatAppearance.BorderSize = 0;
            this.btnReservaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnReservaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservaciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReservaciones.IconChar = FontAwesome.Sharp.IconChar.TowerObservation;
            this.btnReservaciones.IconColor = System.Drawing.Color.White;
            this.btnReservaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReservaciones.IconSize = 25;
            this.btnReservaciones.Location = new System.Drawing.Point(5, 362);
            this.btnReservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservaciones.Name = "btnReservaciones";
            this.btnReservaciones.Size = new System.Drawing.Size(247, 36);
            this.btnReservaciones.TabIndex = 28;
            this.btnReservaciones.Text = "Reservaciones";
            this.btnReservaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservaciones.UseVisualStyleBackColor = false;
            this.btnReservaciones.Click += new System.EventHandler(this.btnReservaciones_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btnPagos.IconColor = System.Drawing.Color.White;
            this.btnPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagos.IconSize = 25;
            this.btnPagos.Location = new System.Drawing.Point(5, 320);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(247, 36);
            this.btnPagos.TabIndex = 27;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnHuespedes
            // 
            this.btnHuespedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnHuespedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuespedes.FlatAppearance.BorderSize = 0;
            this.btnHuespedes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnHuespedes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnHuespedes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuespedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuespedes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHuespedes.IconChar = FontAwesome.Sharp.IconChar.BedPulse;
            this.btnHuespedes.IconColor = System.Drawing.Color.White;
            this.btnHuespedes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuespedes.IconSize = 25;
            this.btnHuespedes.Location = new System.Drawing.Point(4, 278);
            this.btnHuespedes.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuespedes.Name = "btnHuespedes";
            this.btnHuespedes.Size = new System.Drawing.Size(247, 36);
            this.btnHuespedes.TabIndex = 26;
            this.btnHuespedes.Text = "Huespedes";
            this.btnHuespedes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuespedes.UseVisualStyleBackColor = false;
            this.btnHuespedes.Click += new System.EventHandler(this.btnHuespedes_Click);
            // 
            // btnConsumos
            // 
            this.btnConsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnConsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsumos.FlatAppearance.BorderSize = 0;
            this.btnConsumos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnConsumos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnConsumos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsumos.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnConsumos.IconColor = System.Drawing.Color.White;
            this.btnConsumos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsumos.IconSize = 25;
            this.btnConsumos.Location = new System.Drawing.Point(5, 234);
            this.btnConsumos.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsumos.Name = "btnConsumos";
            this.btnConsumos.Size = new System.Drawing.Size(247, 36);
            this.btnConsumos.TabIndex = 25;
            this.btnConsumos.Text = "Consumos";
            this.btnConsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsumos.UseVisualStyleBackColor = false;
            this.btnConsumos.Click += new System.EventHandler(this.btnConsumos_Click);
            // 
            // btnPagoPlanilla
            // 
            this.btnPagoPlanilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnPagoPlanilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagoPlanilla.FlatAppearance.BorderSize = 0;
            this.btnPagoPlanilla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnPagoPlanilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnPagoPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagoPlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoPlanilla.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPagoPlanilla.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnPagoPlanilla.IconColor = System.Drawing.Color.White;
            this.btnPagoPlanilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagoPlanilla.IconSize = 25;
            this.btnPagoPlanilla.Location = new System.Drawing.Point(4, 190);
            this.btnPagoPlanilla.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagoPlanilla.Name = "btnPagoPlanilla";
            this.btnPagoPlanilla.Size = new System.Drawing.Size(247, 36);
            this.btnPagoPlanilla.TabIndex = 24;
            this.btnPagoPlanilla.Text = "Pago Planilla";
            this.btnPagoPlanilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagoPlanilla.UseVisualStyleBackColor = false;
            this.btnPagoPlanilla.Click += new System.EventHandler(this.btnPagoPlanilla_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnCerrarSesion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 88);
            this.panel2.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(89, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cerrar sesion:";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(32, 19);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(51, 51);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // PanelLogin
            // 
            this.PanelLogin.Controls.Add(this.lblEstado);
            this.PanelLogin.Controls.Add(this.label3);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Controls.Add(this.lblRol);
            this.PanelLogin.Controls.Add(this.pictureBox1);
            this.PanelLogin.Controls.Add(this.label2);
            this.PanelLogin.Controls.Add(this.lblUsuario);
            this.PanelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogin.Location = new System.Drawing.Point(0, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(250, 90);
            this.PanelLogin.TabIndex = 22;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Teal;
            this.lblEstado.Location = new System.Drawing.Point(172, 58);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(11, 16);
            this.lblEstado.TabIndex = 28;
            this.lblEstado.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(87, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(87, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Usuario:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.Teal;
            this.lblRol.Location = new System.Drawing.Point(172, 36);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(11, 16);
            this.lblRol.TabIndex = 27;
            this.lblRol.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(87, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Rol:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Teal;
            this.lblUsuario.Location = new System.Drawing.Point(172, 17);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(11, 16);
            this.lblUsuario.TabIndex = 26;
            this.lblUsuario.Text = ".";
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnServicios.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnServicios.IconColor = System.Drawing.Color.White;
            this.btnServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicios.IconSize = 25;
            this.btnServicios.Location = new System.Drawing.Point(4, 146);
            this.btnServicios.Margin = new System.Windows.Forms.Padding(4);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(247, 36);
            this.btnServicios.TabIndex = 21;
            this.btnServicios.Text = "Sercicios";
            this.btnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnHabitaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitaciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHabitaciones.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.btnHabitaciones.IconColor = System.Drawing.Color.White;
            this.btnHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHabitaciones.IconSize = 25;
            this.btnHabitaciones.Location = new System.Drawing.Point(4, 97);
            this.btnHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(247, 43);
            this.btnHabitaciones.TabIndex = 20;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHabitaciones.UseVisualStyleBackColor = false;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1363, 40);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTitulo_Paint);
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove_1);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1299, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1267, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1299, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1331, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // FrmMenuPrincipal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 661);
            this.Controls.Add(this.panelFormularioo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FrmMenuPrincipal1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal1";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal1_Load);
            this.panelFormularioo.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormularioo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private FontAwesome.Sharp.IconButton btnServicios;
        private FontAwesome.Sharp.IconButton btnHabitaciones;
        private System.Windows.Forms.Label lblMensajeBienvenida;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnPagoPlanilla;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnAsignaciones;
        private FontAwesome.Sharp.IconButton btnReservaciones;
        private FontAwesome.Sharp.IconButton btnPagos;
        private FontAwesome.Sharp.IconButton btnHuespedes;
        private FontAwesome.Sharp.IconButton btnConsumos;
    }
}