using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{

    public class Venta
    {
        public int IDx { set; get; }
        public int Cantidad { set; get; }
        public string NombreProducto { set; get; }
        public float Precio { set; get; }
        public int IDPaciente { set; get; }
        public int IDCajaRegistradora { set; get; }
        public float subtotal { get; set; }
        public Venta(int idx, int cantidad, string nombreProducto, float precio, int idPaciente, int idCajaRegistradora)
        {
            IDx = idx;
            Cantidad = cantidad;
            NombreProducto = nombreProducto;
            Precio = precio;
            IDPaciente = idPaciente;
            IDCajaRegistradora = idCajaRegistradora;
            subtotal = precio * cantidad;
        }

        public Venta(int cantidad, string nombreProducto, float precio, int idPaciente, int idCajaRegistradora)
        {
            Cantidad = cantidad;
            NombreProducto = nombreProducto;
            Precio = precio;
            IDPaciente = idPaciente;
            IDCajaRegistradora = idCajaRegistradora;
            subtotal = precio * cantidad;
        }
    }
}
