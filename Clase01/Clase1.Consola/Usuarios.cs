using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Consola
{
    class Usuarios
    {
        public Usuarios()
        {
        }

        public Usuarios(int codigo, string nombre, int horasTrabajo, int pagoTotal)
        {
            Codigo = codigo;
            Nombre = nombre;
            HorasTrabajo = horasTrabajo;
            PagoTotal = pagoTotal;
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int HorasTrabajo { get; set; }

        public int PagoTotal { get; set; }
    }
}
