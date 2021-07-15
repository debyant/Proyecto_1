using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2010, TiposEscuela.Primaria,
            Pais:"México", ciudad:"Nuevo León"
            );
            

            Console.WriteLine(escuela);
        }
    }
}
