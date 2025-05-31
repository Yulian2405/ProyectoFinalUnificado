using ProyectoFinal.Datos;
using Sistema_FarmaciaTotal.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FarmaciaTotal.Logica
{
    internal class CLConsumos
    {
        CDconexion cd_conexion = new CDconexion();

        public DateTime MtdFechaActual()
        {
            return DateTime.Now;
        }
    }

    /*public double MtdConsultaMontoServicio(int CodigoReserva)
    {
        double Monto = 0;

        string QueryConsultarMontoReserva = "Select Total from tbl_reservaciones where CodigoReserva=@CodigoReserva";
        SqlCommand CommandMontoReserva = new SqlCommand(QueryConsultarMontoReserva, cd_conexion.MtdAbrirConexion());
        CommandMontoReserva.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
        SqlDataReader reader = CommandMontoReserva.ExecuteReader();

        if (reader.Read())
        {
            Monto = double.Parse(reader["Total"].ToString());
        }
        else
        {
            Monto = 0;
        }

        cd_conexion.MtdCerrarConexion();
        return MontoServicio;
    }*/


}
