using ProyectoFinal.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOFINAL._3erSemestre.Datos
{
    internal class CDHuespedes
    {
        CDconexion cd_conexion = new CDconexion();
        public DataTable MtdConsultarHuespedes()
        {
            string QueryConsultarPagos = "Select * from tbl_Huespedes";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarPagos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarHuesped(string Nombre, string Nit, string Telefono, string Tipo, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarHuesped = "Insert into tbl_Huespedes(Nombre, Nit, Telefono, Tipo, Estado, UsuarioSistema, FechaSistema) values (@Nombre, @Nit, @Telefono, @Tipo, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarHuesped, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Nit", Nit);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }


        public void MtdEditarHuesped(int CodigoHuesped,string Nombre, string Nit, string Telefono, string Tipo, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarHuesped = "update tbl_Huespedes set Nombre=@Nombre, Nit=@Nit, Telefono=@Telefono, Tipo=@Tipo, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoHuesped=@CodigoHuesped";
            SqlCommand cmd = new SqlCommand(QueryAgregarHuesped, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHuesped", CodigoHuesped);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Nit", Nit);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarHuesped(int CodigoHuesped)
        {
            string QueryEliminarHuesped = "Delete tbl_Huespedes where CodigoHuesped=@CodigoHuesped";
            SqlCommand cmd = new SqlCommand(QueryEliminarHuesped, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHuesped", CodigoHuesped);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

    }
}
