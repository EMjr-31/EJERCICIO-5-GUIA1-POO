using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electrodomesticos
{
    class Clientes
    {
        string codigo;
        string nombre;
        string apellido;
        string fechaNaci;
        string correo;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string FechaNaci { get => fechaNaci; set => fechaNaci = value; }
       
    }
}
