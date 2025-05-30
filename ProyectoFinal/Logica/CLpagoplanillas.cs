using ProyectoFinal.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Logica
{
    public class CLpagoplanillas
    {
        CDconexion cd_conexion = new CDconexion();

        // Metodo para recuperar la fecha del dia
        public DateTime MtdFechaActual()
        {
            return DateTime.Now;
        }

        // Metodo que recupera el Salario del Empleado para el txtSalario del Form
        public double MtdConsultaSalarioEmpleado(int CodigoEmpleado)
        {
            double SalarioEmpleado = 0;

            string QueryConsultarSalarioEmpleado = "Select Salario from tbl_empleados where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand CommandSalarioEmpleado = new SqlCommand(QueryConsultarSalarioEmpleado, cd_conexion.MtdAbrirConexion());
            CommandSalarioEmpleado.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            SqlDataReader reader = CommandSalarioEmpleado.ExecuteReader();

            if (reader.Read())
            {
                SalarioEmpleado = double.Parse(reader["Salario"].ToString());
            }
            else
            {
                SalarioEmpleado = 0;
            }

            cd_conexion.MtdCerrarConexion();
            return SalarioEmpleado;
        }

        public double MtdSalarioBono(double Salario)
        {
            double Bono = Salario * 0.15;
            return Bono;
           
        }

        public double MtdMontoTotal(double Salario, double Bono, double HorasExtras)
        {
            double MontoTotal = Salario + Bono + (HorasExtras * 12);
            return MontoTotal;
        }
    }
}
