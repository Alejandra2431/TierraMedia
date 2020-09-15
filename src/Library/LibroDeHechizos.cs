using System;
using System.Collections;

namespace Elemento
{
    public class LibroDeHechizos
    {
        public string Name{get;set;}
        public ArrayList Libro{get; set;}

        public LibroDeHechizos(string name,Hechizo hechizo)
        {
            this.Name=name;
            Libro.Add(hechizo);
        }
        public int Ataque()
        {
            int ataque = 0;
            
            foreach(Hechizo hechizo in Libro)
            {
                ataque=ataque + hechizo.Ataque;
            }
            return ataque;

        }
        public void EliminarHechizo(Hechizo hechizo)
        {
            Libro.Remove(hechizo);
        }
        public int Defensa()
        {
            int defensa = 0;
            
            foreach(Hechizo hechizo in Libro)
            {
                defensa=defensa + hechizo.Defensa;
            }
            return defensa;
        }

        
    }
}
