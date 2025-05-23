using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.RightsManagement;
using ProyectoFinal.Datos;

namespace PROYECTOFINAL._3erSemestre.Datos
{
    public class CDPagos
    {
        CDconexion cd_conexion = new CDconexion();
        public DataTable MtdConsultarPagos()
        {
            string QueryConsultarPagos = "Select * from tbl_pagos";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarPagos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarPagos(int CodigoPago, int CodigoReserva, decimal Monto, decimal Propina, decimal Impuesto, decimal Descuento,decimal TotalPago, DateTime FechaPago, string MetodoPago, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarPagos = "Insert into tbl_pagos (CodigoPago, CodigoReserva, Monto, Propina, Impuesto, Descuento, TotalPago, FechaPago, MetodoPago, UsuarioSistema, FechaSistema) values (@CodigoPago, @CodigoReserva, @Monto, @Propina, @Impuesto, @Descuento, @TotalPago, @FechaPago, @MetodoPago, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarPagos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPago", CodigoPago);
            cmd.Parameters.AddWithValue("@CodigoMedicamento", CodigoReserva);
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

        public double MtdPropina(double Monto)
        {
            return Monto * 0.10;
        }


   


       
    }
}
