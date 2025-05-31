using ProyectoFinal.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FarmaciaTotal.Datos
{
    internal class CDReservaciones
    {
        CDconexion cd_conexion = new CDconexion();

        public DataTable MtdConsultarReservaciones()
        {
            string QueryConsultar = "Select * from tbl_reservaciones where CodigoReserva=@CodigoReserva";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable(); 
            SqlAdap.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public List<dynamic> MtdListaHuespedes()
        {
           
            List<dynamic> ListaHuespedes = new List<dynamic>();
            string QueryListaHuespedes = "Select re.CodigoHuesped CodigoHuesped, hu.Nombre NombreHuesped from tbl_huespedes re inner join tbl_huespedes hu on re.CodigoHuesped=hu.CodigoHuesped;\r\n";
            SqlCommand cmd = new SqlCommand(QueryListaHuespedes, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaHuespedes.Add(new
                {
                    Value = reader["CodigoHuesped"],
                    Text = $"{reader["CodigoHuesped"]} - {reader["NombreHuesped"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaHuespedes;
        }

        public List<dynamic> MtdListaHabitaciones()
        {
            List<dynamic> ListaHabitaciones = new List<dynamic>();
            string QueryListaHabitacion = "Select CodigoHabitacion, Precio from tbl_habitaciones";
            SqlCommand cmd = new SqlCommand(QueryListaHabitacion, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaHabitaciones.Add(new
                {
                    Value = reader["CodigoHabitacion"],
                    Text = $"{reader["CodigoHabitacion"]} - {reader["Precio"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaHabitaciones;
        }
        public void MtdAgregarReservaciones(int CodigoHuesped, int CodigoHabitacion, DateTime FechaEntrada, DateTime FechaSalida, string Total, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarReservaciones = "Insert into tbl_reservaciones (CodigoHuesped, CodigoHabitacion, FechaEntrada, FechaSalida, Total, UsuarioSistema, FechaSistema) values (@CodigoHuesped, @CodigoHabitacion, @FechaEntrada, @FechaSalida, @Total,  @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarReservaciones, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHuesped", CodigoHuesped);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@FechaEntrada", FechaEntrada);
            cmd.Parameters.AddWithValue("@FechaSalida", FechaSalida);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActulizarReservaciones(int CodigoReserva, int CodigoHuesped, int CodigoHabitacion, DateTime FechaEntrada, DateTime FechaSalida, string Total, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarReservaciones = "update tbl_reservaciones set CodigoHuesped=@CodigoHuesped, CodigoHabitacion=@CodigoHabitacion, FechaEntrada=@FechaEntrada,  Total=@Total, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema  where CodigoReserva=@CodigoReserva";
            SqlCommand cmd = new SqlCommand(QueryAgregarReservaciones, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHuesped", CodigoHuesped);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@FechaEntrada", FechaEntrada);
            cmd.Parameters.AddWithValue("@FechaSalida", FechaSalida);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarReservaciones(int CodigoReserva)
        {
            string QueryEliminarReservaciones = "Delete tbl_reservaciones where CodigoReservaciones=@CodigoReservaciones";
            SqlCommand cmd = new SqlCommand(QueryEliminarReservaciones, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoReservaciones", CodigoReserva);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

    }
}

