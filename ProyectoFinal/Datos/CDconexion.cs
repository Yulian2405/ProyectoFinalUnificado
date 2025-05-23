using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    public class CDconexion
    {
                                                                                                   //Base de datos nuestra//
            private SqlConnection db_conexion = new SqlConnection("Data Source=YULIAN\\SQLEXPRESS;Initial Catalog=db_HotelFinal;Integrated Security=True;Encrypt=False");

            public SqlConnection MtdAbrirConexion()
            {
                if (db_conexion.State == ConnectionState.Closed)
                {
                    db_conexion.Open();
                }
                return db_conexion;
            }

            public SqlConnection MtdCerrarConexion()
            {
                if (db_conexion.State == ConnectionState.Open)
                {
                    db_conexion.Close();
                }
                return db_conexion;
            }
        
    }
}
