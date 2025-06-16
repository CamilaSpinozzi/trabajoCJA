using System;

public static class Extensiones
{
    public static IEnumerable<string> SoloMayusculas(this IEnumerable<string> coleccion)
//El método debe ser estático para poder ser un método de extensión.
// 2. IEnumerable<string> SoloMayusculas(...): Esto indica que el método devuelve una colección de strings.
//3. this IEnumerable<string> coleccion:¡Este es el corazón de la extensión! Al
//anteponer this, estás diciendo: “Este método extiende a cualquier objeto que sea IEnumerable<string>”.
    {
        if (coleccion == null)
            throw new ArgumentNullException(nameof(coleccion));

        var resultado = coleccion.Where(s =>
       !string.IsNullOrEmpty(s) &&
        s.All(c => char.IsUpper(c) && char.IsLetter(c))
          );

        //char.IsLetter(c)
        //Devuelve true si el carácter c es una letra(A - Z o a - z, incluyendo letras de otros alfabetos Unicode).
        //!char.IsLetter(c) Es la negación lógica: devuelve true si NO es una letra.
        //s.All(char.IsUpper)	Evalúa que todos los caracteres del string estén en mayúscula.
        //!string.IsNullOrEmpty(s)	Evita que strings vacíos o null den error al llamar .All()

        // Devuelve una colección (puede estar vacía, pero nunca null)
        return resultado;

    }

}
