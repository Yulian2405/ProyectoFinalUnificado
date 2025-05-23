using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    internal class CDhabitaciones
    {
        CDconexion cd_conexion = new CDconexion();


        public DataTable MtdConsultarHabitaciones()
        {
            string QueryConsultarHabitacion = "Select * from tbl_habitaciones";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarHabitacion, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarhabitacion(double Numero, string Ubicacion, string Tipo, double Precio, DateTime FechaSistema, string Estado, string UsuarioSistema)
        {
            string QueryAgregarHabitacion = "Insert into tbl_habitaciones(Numero,Ubicacion,Tipo, Precio, FechaSistema, Estado, UsuarioSistema) values (@Numero, @Ubicacion, @Tipo, @Precio, @FechaSistema, @Estado, @UsuarioSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarHabitacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarhabitacion(int CodigoHabitacion, double Numero, string Ubicacion, string Tipo, double Precio, DateTime FechaSistema, string Estado, string UsuarioSistema)
        {
            string QueryActualizarHabitacion = "Update tbl_habitaciones set Numero=@Numero,Ubicacion=@Ubicacion,Tipo=@Tipo, Precio=@Precio, FechaSistema=@FechaSistema, Estado=@Estado, UsuarioSistema=@UsuarioSistema where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryActualizarHabitacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarHabitacion(int CodigoHabitacion)
        {
            string QueryEliminarHabitacion = "Delete tbl_habitaciones where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryEliminarHabitacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}