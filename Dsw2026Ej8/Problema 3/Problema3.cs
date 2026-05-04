using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_3
{
    internal class Problema3
    {
        public string CompararCopias (int originalValue, Product product)
        {
            //punto 1 (copio originalValue en una variable local)
            int copiaValue = originalValue;

            copiaValue++; 

            Product copiaProducto = product; //copia la referencia del producto en otra variable local copiaProducto

            if (copiaProducto != null)
            {
                //modifico la descripcion del producto a través de la referencia copiaProducto
                copiaProducto.SetDescripcion("Descripcion modificada"); 
            }

            return $"{originalValue} - {copiaValue}- {product.GetDescripcion()}";


        }
    }
}
