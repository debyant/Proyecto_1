using System;
using Etapa2.Entidades;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId{get; private set;}
        public string Nombre {get; set;}
        public TiposJornada Jornada {get; set;}

     //   public Curso()
       // {
         //   UniqueId = Guid.NewGuid().ToString();
        //}
        
        //ID aleatorios
        public Curso()=> UniqueId = Guid.NewGuid().ToString();
    }
}