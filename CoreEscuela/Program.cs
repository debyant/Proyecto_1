using System;

namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;  //atributos
        public string direccion;
        public int añoFundacion;

        //public string ceo = "Debany Moreno";
        public string ceo;
        public void Timbrar() //metodos
        {
            //todo
            Console.Beep(20000, 3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Platzi Academy";
            miEscuela.direccion = "Av Benito Juarez 800";
            miEscuela.añoFundacion = 2010;
            Console.WriteLine("Timbre");
            miEscuela.Timbrar();

            //Console.WriteLine("Hello World!");
        }
    }
}
