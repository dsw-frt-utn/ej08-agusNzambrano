using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    public class RetailSale : Sale
    {
        public override decimal CalculateTotal() // la clase hija redefine el metodo 
        {
            return GetImporte();
        }
    }
}
