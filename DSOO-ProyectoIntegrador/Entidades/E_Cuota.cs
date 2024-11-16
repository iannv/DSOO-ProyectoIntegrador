using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_ProyectoIntegrador.Entidades
{
    internal class E_Cuota
    {
        public int IdCuota {  get; set; }
        public int IdCliente { get; set; }
        public float Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public E_Cliente Cliente { get; set; }
    }
}
