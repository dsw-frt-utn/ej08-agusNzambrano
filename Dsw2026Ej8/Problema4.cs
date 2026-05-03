using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            int cantidadNotas = 0;

            int?[] notas = { nota1, nota2, nota3 };

            for (int i = 0; i < notas.Length; i++)
            {
                // Verificar si el tipo anulable tiene un valor antes de sumarla (devuelve true o false)
                if (notas[i].HasValue)
                {
                    int valorNota = notas[i].Value; // Obtener el valor de la nota anulable

                    if (valorNota >= 0 && valorNota <= 100)// Validar que la nota esté en el rango permitido
                    {
                        suma += notas[i].Value;
                        cantidadNotas++;
                    }
                }


            }
            if (cantidadNotas == 0)
            {
                return 0; // segunda condicion, 3 notas null retorna 0

            }
            else
            {
                return suma / cantidadNotas; // Calcular el promedio
            }
        }
    }
}

