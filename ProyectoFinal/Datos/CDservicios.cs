using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    public class CDservicios
    {
        CDconexion cd_conexion = new CDconexion();

        public DataTable MtdConsultarServicios()
        {
            string QueryConsultar = "Select * from tbl_servicios";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarServicios(string Nombre, string Tipo, double Precio, DateTime FechaVigencia, DateTime FechaVencimiento, string Estado, string UsuarioSistema, string FechaSistema)
        {
            string QueryAgregar = "Insert into tbl_servicios (Nombre, Tipo, Precio, FechaVigencia, FechaVencimiento, Estado, UsuarioSistema, FechaSistema) values (@Nombre, @Tipo, @Precio, @FechaVigencia, @FechaVencimiento, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@FechaVigencia", FechaVigencia);
            cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarServicios(int CodigoServicio, string Nombre, string Tipo, double Precio, DateTime FechaVigencia, DateTime FechaVencimiento, string Estado, string UsuarioSistema, string FechaSistema)
        {
            string QueryAgregar = "Update tbl_servicios set Nombre=@Nombre, Tipo=@Tipo, Precio=@Precio, FechaVigencia=@FechaVigencia, FechaVencimiento=@FechaVencimiento, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoServicio=@CodigoServicio";
            SqlCommand cmd = new SqlCommand(QueryAgregar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoServicio", CodigoServicio);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@FechaVigencia", FechaVigencia);
            cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarServicios(int CodigoServicio)
        {
            string QueryEliminar = "Delete from tbl_servicios where CodigoServicio=@CodigoServicio";
            SqlCommand cmd = new SqlCommand(QueryEliminar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoServicio", CodigoServicio);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
