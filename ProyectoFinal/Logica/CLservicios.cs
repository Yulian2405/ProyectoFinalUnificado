using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Logica
{
    public class CLservicios
    {
        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }

        public double MtdPrecioServicio(string Tipo)
        {
            if (Tipo == "Comida") return 250;
            else if (Tipo == "Bebida") return 100;
            else if (Tipo == "Transporte") return 125;
            else if (Tipo == "Lavanderia") return 75;
            else if (Tipo == "Medicina") return 150;
            else return 0;
        }
    }
}




