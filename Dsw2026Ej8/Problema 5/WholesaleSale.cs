using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal() // la clase hija redefine el metodo 
        {
            return GetImporte() * 0.9m; // se aplica un descuento del 10% 
        }
    }
}
