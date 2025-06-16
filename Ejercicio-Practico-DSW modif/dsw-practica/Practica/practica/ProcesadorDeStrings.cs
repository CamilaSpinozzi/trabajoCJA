using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.practica
{
    internal class ProcesadorDeStrings : IProcesador<string>
    {
        public string Procesar(IEnumerable<string> elementos, Func<string, bool> criterio)
        {
            if (elementos == null || !elementos.Any())
            {
                throw new ArgumentException("La lista está vacía o es null");
              
            }

            //filtra la condicion
           var filtrados = elementos.Where(criterio);
            //Where() es un método de LINQ que devuelve solo
            //los elementos que cumplen con la condición del delegado.  

            // Guardamos el resultado
            var resultado = filtrados.MaxBy(s => s.Length);
            //(s => s.Length) lambda

            // Retornamos el resultado o "" si es null (por seguridad)
            return resultado ?? "";

            



        }
    }
}
