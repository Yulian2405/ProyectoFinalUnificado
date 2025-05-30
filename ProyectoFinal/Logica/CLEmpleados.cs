using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Logica
{
    public class CLEmpleados
    {
        /* Para la fecha en pantalla*/
        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }
        /* Para mostrar el salario del empleado*/

        public double MtdSalarioEmpleado(string Cargo)
        {
            if (Cargo == "Gerente") return 35000;
            else if (Cargo == "Recepcionista") return 7000;
            else if (Cargo == "Botones") return 5000;
            else if (Cargo == "Conserje") return 3000;
            else if (Cargo == "Chef") return 1000;
            else return 0;
        }
    }
}
