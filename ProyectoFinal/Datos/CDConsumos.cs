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
    internal class CDConsumos
    {
        CDconexion cd_conexion = new CDconexion();

        public List<dynamic> MtdListareservaciones()
        {
            List<dynamic> Listareservaciones = new List<dynamic>();
            string QueryListaReservaciones = "Select  re.CodigoReserva CodigoReserva, hu.Nombre NombreHuesped from tbl_reservaciones re inner join tbl_huespedes hu on re.CodigoHuesped=hu.CodigoHuesped;\r\n";
            SqlCommand cmd = new SqlCommand(QueryListaReservaciones, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Listareservaciones.Add(new
                {
                    Value = reader["CodigoReserva"],
                    Text = $"{reader["CodigoReserva"]} - {reader["NombreHuesped"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return Listareservaciones;
        }

        public List<dynamic> MtdListaServicios()
        {
            List<dynamic> ListaServicios = new List<dynamic>();
            string QueryListaServicios = "Select CodigoServicio, Nombre from tbl_servicios";
            SqlCommand cmd = new SqlCommand(QueryListaServicios, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaServicios.Add(new
                {
                    Value = reader["CodigoServicio"],
                    Text = $"{reader["CodigoServicio"]} - {reader["Nombre"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaServicios;
        }

        public double MtdMonto(int CodigoReserva)
        {
            double Monto = 0;
            string QueryConsultarMonto = "Select Total from tbl_reservaciones where CodigoReserva=@CodigoReserva";
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

        public DataTable MtdConsultarConsumos()
        {
            string QueryConsultar = "Select * from tbl_consumos";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;

        }
        public void MtdAgregarConsumos(int CodigoReserva, int CodigoServicio, double Monto, DateTime FechaConsumo, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarConsumos = "Insert into tbl_consumos (CodigoReserva, CodigoServicio, Monto, FechaConsumo, Estado, UsuarioSistema, FechaSistema) values (@CodigoReserva, @CodigoServicio, @Monto, @FechaConsumo, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarConsumos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            cmd.Parameters.AddWithValue("@CodigoServicio", CodigoServicio);
            cmd.Parameters.AddWithValue("@Monto", Monto);
            cmd.Parameters.AddWithValue("@FechaConsumo", FechaConsumo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }


        public void MtdActualizarConsumos(int CodigoConsumos, int CodigoReserva, int CodigoServicio, double Monto, DateTime FechaConsumo, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarConsumos = "update into tbl_consumos (CodigoReserva, CodigoServicio, Monto, FechaConsumo, Estado, UsuarioSistema, FechaSistema) values (@CodigoReserva, @CodigoServicio, @Monto, @FechaConsumo, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarConsumos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoConsumos", CodigoConsumos);
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            cmd.Parameters.AddWithValue("@CodigoServicio", CodigoServicio);
            cmd.Parameters.AddWithValue("@Monto", Monto);
            cmd.Parameters.AddWithValue("@FechaConsumo", FechaConsumo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarConsumos(int CodigoConsumo)
        {
            string QueryEliminar = "Delete from tbl_consumos where CodigoConsumo=@CodigoConsumo";
            SqlCommand cmd = new SqlCommand(QueryEliminar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoConsumo", CodigoConsumo);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }


    }
}
    
