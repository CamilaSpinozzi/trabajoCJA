using System;

public static class Estadisticas
{
    public static (int min, int max, double promedio) CalcularEstadisticas(IEnumerable<int> elementos)

    {

        if (elementos == null || !elementos.Any())
        {
            throw new DatosInvalidosException("La lista está vacía o es null");

        }

        int min = elementos.Min();
        int max = elementos.Max();
        double promedio = elementos.Average();

        return (min, max, promedio);
 

    }
}
