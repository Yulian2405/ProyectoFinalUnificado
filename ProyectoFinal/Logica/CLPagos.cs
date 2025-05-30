using ProyectoFinal.Datos;
using PROYECTOFINAL._3erSemestre.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOFINAL._3erSemestre.Logica
{
    internal class CLPagos
    {
        CDconexion cd_Conexion = new CDconexion();

        public DateTime MtdFechaActual()
        {
            return DateTime.Now;
        }

        public double MtdConsultaMontoServicio(int CodigoReserva)
        {
            double MontoServicio = 0;

            string QueryConsultarMontoReserva = "Select Total from tbl_reservaciones where CodigoReserva=@CodigoReserva";
            SqlCommand CommandMontoReserva = new SqlCommand(QueryConsultarMontoReserva, cd_Conexion.MtdAbrirConexion());
            CommandMontoReserva.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            SqlDataReader reader = CommandMontoReserva.ExecuteReader();

            if (reader.Read())
            {
                MontoServicio = double.Parse(reader["Total"].ToString());
            }
            else
            {
                MontoServicio = 0;
            }

            cd_Conexion.MtdCerrarConexion();
            return MontoServicio;
        }

        public double MtdMtdPropinaPago(double MontoPago)
        {
            return MontoPago * 0.10; // 10% de propina
        }

        public double MtdImpuestoPago(double MontoPago)
        {
            return MontoPago * 0.12; // 12% de Impuesto
        }

        public double MtdDescuentoPago(double MontoPago)
        {
            if (MontoPago > 0 && MontoPago <= 500) return MontoPago * 0.03; // 3% 
            else if (MontoPago > 500 && MontoPago <= 5000) return MontoPago * 0.05; // 5% 
            else if (MontoPago > 5000) return MontoPago * 0.07; // 7% 
            else return 0; // Sin descuento
        }

        public double MtdTotalPago(double Monto, double Propina, double Impuesto, double Descuento)
        {
            return Monto + Propina + Impuesto - Descuento; // Total del pago
        }
    }


}
