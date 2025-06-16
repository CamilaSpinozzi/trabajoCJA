
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica.practica
{
    internal class ProcesadorDeEnteros : IProcesador<int>

    {
        public int Procesar(IEnumerable<int> elementos, Func<int, bool> criterio)
        {
            if (elementos == null || !elementos.Any())
            {
                throw new ArgumentException("La lista está vacía o es null");
            }

            int suma = 0;

            foreach (var e in elementos)
            {
                if (criterio(e))
                {
                    suma += e;
                }
               else 
                {
                    return 0;
                }
            }

            return suma;
        }

    }
}