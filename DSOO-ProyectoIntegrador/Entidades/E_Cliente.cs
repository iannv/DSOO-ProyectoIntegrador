using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSOO_ProyectoIntegrador.Entidades
{
    public class E_Cliente
    {

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TDoc { get; set; }
        public int Dni { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public bool AptoFisico { get; set; }
        public int NumCarnet { get; set; }
        public bool Socio { get; set; }

    }
}