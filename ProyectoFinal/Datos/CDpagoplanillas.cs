using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    public class CDpagoplanillas
    {
        CDconexion cd_conexion = new CDconexion();

        // Metodo que llena el combobox de empleados    
        public List<dynamic> MtdListaEmpleado()
        {
            List<dynamic> ListaEmpleado = new List<dynamic>();
            string QueryListaEmpleado = "Select CodigoEmpleado, Nombre from tbl_empleados";
            SqlCommand cmd = new SqlCommand(QueryListaEmpleado, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaEmpleado.Add(new
                {
                    Value = reader["CodigoEmpleado"],
                    Text = $"{reader["CodigoEmpleado"]} - {reader["Nombre"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaEmpleado;
        }

        // Consulta PagoPlanillas en la base de datos para cargar en el DataGridView
        public DataTable MtdConsultarPagoPlanillas()
        {
            string QueryConsultarPagoPlanillas = "Select * from tbl_pago_planillas";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarPagoPlanillas, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        // Agrega PagoPlanillas en la base de datos
        public void MtdAgregarPagoPlanillas(int CodigoEmpleado, DateTime FechaPago, double Salario, double Bono, double HorasExtras, double MontoTotal, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarPagoPlanillas = "Insert into tbl_pago_planillas (CodigoEmpleado, FechaPago, Salario, Bono, HorasExtras, MontoTotal, Estado, UsuarioSistema, FechaSistema) values (@CodigoEmpleado, @FechaPago, @Salario, @Bono, @HorasExtras, @MontoTotal, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarPagoPlanillas, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@Salario", Salario);
            cmd.Parameters.AddWithValue("@Bono", Bono);
            cmd.Parameters.AddWithValue("@HorasExtras", HorasExtras);
            cmd.Parameters.AddWithValue("@MontoTotal", MontoTotal);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);

            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarPagoPlanilla(int CodigoPagoPlanilla)
        {
            string QueryEliminarPagoPlanilla = "Delete tbl_pago_planillas where CodigoPagoPlanilla=@CodigoPagoPlanilla";
            SqlCommand cmd = new SqlCommand(QueryEliminarPagoPlanilla, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPagoPlanilla", CodigoPagoPlanilla);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
