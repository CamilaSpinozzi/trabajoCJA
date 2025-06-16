using System;

public class DatosInvalidosException : Exception
{
    public DatosInvalidosException() { }

    public DatosInvalidosException(string mensaje) : base(mensaje) { }

    public DatosInvalidosException(string mensaje, Exception inner) : base(mensaje, inner) { }
}
