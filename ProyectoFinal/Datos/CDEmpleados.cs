using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    internal class CDEmpleados
    {

        CDconexion cd_conexion = new CDconexion();

        /* Para consultar tabla tbl_empleados*/

        public DataTable MtdConsultarEmpleados()
        {
            string QueryConsultarEmpleados = "Select * from tbl_empleados";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarEmpleados, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        /* Para agregar algo de la tabla */

        public void MtdAgregarempleado(string Nombre, string Cargo, double Salario, DateTime FechaContratacion, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarEmpleado = "Insert into tbl_empleados(Nombre,Cargo,Salario, FechaContratacion, Estado, UsuarioSistema, FechaSistema) values (@Nombre, @Cargo, @Salario, @FechaContratacion, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarEmpleado, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.Parameters.AddWithValue("@Salario", Salario);
            cmd.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        /* Para editar algo de la tabla */

        public void MtdActualizarempleado(int CodigoEmpleado, string Nombre, string Cargo, double Salario, DateTime FechaContratacion, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarEmpleado = "Update tbl_empleados set Nombre=@Nombre,Cargo=@Cargo,Salario=@Salario, FechaContratacion=@FechaContratacion, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryActualizarEmpleado, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.Parameters.AddWithValue("@Salario", Salario);
            cmd.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        /* Para eliminar algo de la tabla */

        public void MtdEliminarEmpleado(int CodigoEmpleado)
        {
            string QueryEliminarEmpleado = "Delete tbl_empleados where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryEliminarEmpleado, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
