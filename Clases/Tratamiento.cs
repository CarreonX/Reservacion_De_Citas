using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Tratamiento
    {
        public int IdReceta { get; set; }
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
        public float PrecioUnitario { get; set; }
        public float SubTotal { get; set; }

        public Tratamiento(int idReceta, int cantidad, string nombre, float precioUnitario)
        {
            IdReceta = idReceta;
            Cantidad = cantidad;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            SubTotal = PrecioUnitario * Cantidad;
        }
    }
}
