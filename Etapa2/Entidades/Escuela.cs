namespace CoreEscuela.Entidades
{
class Escuela
{
     string nombre;
        private string pais;

        public string Nombre
     {
         get{ return nombre;}
         set{nombre = value.ToUpper();}
     }

     public int AñodeCreación {get;set;}

     public string Ciudad { get; set; }

     public string Pais { get; set; }

     public TiposEscuela TiposEscuela {get; set;}
    
    //metodos //constructores

    public Escuela(string nombre,int año, TiposEscuela tipos, string pais="", string ciudad = "")
    {
        (Nombre, AñodeCreación) = (nombre, año);
        Pais = pais;
        Ciudad = ciudad;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Tipo: {TiposEscuela} \n Pais: {Pais}, Ciudad: {Ciudad}";
    }
}

}