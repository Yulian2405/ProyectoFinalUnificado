using ProyectoFinal.Datos;
using PROYECTOFINAL._3erSemestre.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOFINAL._3erSemestre.Logica
{
    internal class CLPagos
    {
        CDconexion cd_Conexion = new CDconexion();

        public DateTime MtdFechaActual()
        {
            return DateTime.Now;
        }
}
}
