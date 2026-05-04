using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    public class Sale
    {
        private decimal _importe;

        public decimal GetImporte () {return _importe;}
        public void SetImporte (decimal value) {_importe = value; }

        public virtual decimal CalculateTotal()
        {
            return _importe;
        }

    }
}
