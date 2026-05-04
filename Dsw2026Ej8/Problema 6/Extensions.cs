using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_6
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            return code.Trim().ToUpper().Replace(" ", "-");
            //Trim () elimina los espacios al inicio y al final
            //ToUpper() convierte a mayusculas
            //Replace(" ", "-") reemplaza los espacios por guiones

        }
    }
}
