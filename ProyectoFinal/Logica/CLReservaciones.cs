using ProyectoFinal.Datos;
using Sistema_FarmaciaTotal.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FarmaciaTotal.Logica
{
    internal class CLReservaciones
    {
        CDconexion cd_conexion = new CDconexion();

        public DateTime MtdFechaActual()
        {
            return DateTime.Now;
        }
    }
    

}
