using System.Reflection.Metadata.Ecma335;

namespace Clases
{
    public class Persona
    {
        protected string ID { get; set; }
        protected string ApellidoM { get; set; }
        protected string ApellidoP { get; set; }
        protected string Direccion { get; set; }
        protected string DNI { get; set; }
        protected string Email { get; set; }
        protected string Nombre { get; set; }
        protected string TelefonoFijo { get; set; }
        protected string TelefonoMovil { get; set; }

        public Persona( string id, string apM, string apP, string dir, string dni, string email, string nombre, string telfijo, string telmovil )
        {
            ID = id;
            ApellidoM = apM;
            ApellidoP = apP;
            Direccion = dir;
            DNI = dni;
            Email = email;
            Nombre = nombre;
            TelefonoFijo = telfijo;
            TelefonoMovil = telmovil;
        }
    }
}
