﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    internal class CDPagos
    {
        CDconexion cd_conexion = new CDconexion();

        public DataTable MtdConsultarPagos()
        {
            string QueryConsultarPagos = "Select * from tbl_Pagos";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarPagos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarPago(int CodigoReserva, decimal Monto, decimal Propina, decimal Impuesto, decimal Descuento, decimal TotalPago, DateTime FechaPago, string MetodoPago, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarPago = "Insert into tbl_Pagos(CodigoReserva, Monto, Propina, Impuesto, Descuento, TotalPago, FechaPago, MetodoPago, UsuarioSistema, FechaSistema) values (@CodigoReserva, @Monto, @Propina, @Impuesto, @Descuento, @TotalPago, @FechaPago, @MetodoPago, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarPago, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            cmd.Parameters.AddWithValue("@Monto", Monto);
            cmd.Parameters.AddWithValue("@Propina", Propina);
            cmd.Parameters.AddWithValue("@Impuesto", Impuesto);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@TotalPago", TotalPago);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@MetodoPago", MetodoPago);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEditarPago(int CodigoPago, int CodigoReserva, decimal Monto, decimal Propina, decimal Impuesto, decimal Descuento, decimal TotalPago, DateTime FechaPago, string MetodoPago, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarPago = "Update tbl_Pagos set CodigoReserva=@CodigoReserva, Monto=@Monto, Propina=@Propina, Impuesto=@Impuesto, Descuento=@Descuento, TotalPago=@TotalPago, FechaPago=@FechaPago, MetodoPago=@MetodoPago, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema   where CodigoPago=@CodigoPago";
            SqlCommand cmd = new SqlCommand(QueryActualizarPago, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPago", CodigoPago);
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            cmd.Parameters.AddWithValue("@Monto", Monto);
            cmd.Parameters.AddWithValue("@Propina", Propina);
            cmd.Parameters.AddWithValue("@Impuesto", Impuesto);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@TotalPago", TotalPago);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@MetodoPago", MetodoPago);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

       public void MtdEliminarPago(int CodigoPago)
        {
            string QueryEliminarPago = "Delete tbl_Pagos where CodigoPago=@CodigoPago";
            SqlCommand cmd = new SqlCommand(QueryEliminarPago, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPago", CodigoPago);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }


        public double MtdMonto(int CodigoReserva)
        {
            double Monto = 0;
            string QueryConsultarMonto = "Select Total from tbl_Reservaciones where CodigoReserva=@CodigoReserva";
            SqlCommand CommandMonto = new SqlCommand(QueryConsultarMonto, cd_conexion.MtdAbrirConexion());
            CommandMonto.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            SqlDataReader reader = CommandMonto.ExecuteReader();
            if (reader.Read())
            {
                Monto = double.Parse(reader["Total"].ToString());
            }
            else
            {
                Monto = 0;
            }
            cd_conexion.MtdCerrarConexion();
            return Monto;
        }

        public int MtdVerificarReserva(int CodigoReserva)
        {
            int Reserva = 0;
            string QueryVerificarReserva = "Select * from tbl_Reservaciones where CodigoReserva=@CodigoReserva";
            SqlCommand cmd = new SqlCommand(QueryVerificarReserva, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Reserva = 1702;
            }
            else
            {
                Reserva = 0;
            }
            cd_conexion.MtdCerrarConexion();
            return Reserva;
        }

        public List<dynamic> MtdListaReservaciones()
        {
            List<dynamic> ListaReservaciones = new List<dynamic>();
            string QueryListaReservaciones = "Select  re.CodigoReserva CodigoReserva, hu.Nombre NombreHuesped from tbl_Reservaciones re inner join tbl_Huespedes hu on re.CodigoHuesped=hu.CodigoHuesped;\r\n";
            SqlCommand cmd = new SqlCommand(QueryListaReservaciones, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaReservaciones.Add(new
                {
                    Value = reader["CodigoReserva"],
                    Text = $"{reader["CodigoReserva"]} - {reader["NombreHuesped"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaReservaciones;
        }
    }
}
