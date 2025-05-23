using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Analizador
    {
        static string enteros = "[0-9]+";
        static string decimales = "[0-9]+[.,][0-9]+";
        static string letras = "[a-zA-ZñÑáéíóúÁÉÍÓÚüÜ]+";
        static string cadenas = "[a-zA-ZñÑáéíóúÁÉÍÓÚüÜ0-9]+";
        static string numeros = "[0-9]+[.,]?[0-9]*";
        static string numerosPositivos = "[0-9]+[.,]?[0-9]*";
        static string decimalPositivo = "[0-9]+[.,]?[0-9]*";

        public static bool EsEntero(string palabra)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(palabra, enteros);
        }

        public static bool EsDecimal(string palabra)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(palabra, decimales);
        }

        public static bool EsLetra(string palabra)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(palabra, letras);
        }

        public static bool EsCadena(string palabra)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(palabra, cadenas);
        }
        public static bool EsNumero(string palabra)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(palabra, numeros);
        }

        public static bool EsNumeroPositivo(string palabra)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(palabra, numerosPositivos);
        }

        public static bool EsDecimalPositivo(string palabra)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(palabra, decimalPositivo);
        }
    }
}
