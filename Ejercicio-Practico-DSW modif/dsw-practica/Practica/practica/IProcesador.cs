using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.practica
{
    internal interface IProcesador<T>
    {
        T Procesar(IEnumerable<T> elementos, Func<T, bool> criterio);
        //la Funcion: Procesar
        // IEnumerable es una lista de elementos
        // Func<T, bool> es un delegado predefinido y despues se le pone el criterio
    }
}
