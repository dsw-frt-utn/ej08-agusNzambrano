using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_6
{
    public class Problema6
    {
        public string NormalizarCodigoProducto(string code)
        {
            if (code == null)
            {
                return "SIN-CODIGO";

            }
            return code.ToProductCode();
        }
    }
}
