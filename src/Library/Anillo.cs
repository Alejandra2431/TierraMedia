using System;

namespace Elemento
{
    public class Anillo
    {
        public string Nombre{get;set;}
        public int Ataque{get;private set;}
        public int Defensa{get;private set;}

        public Anillo(string nombre,int ataque, int defensa)
        {
            this.Nombre=nombre;
            this.Ataque=ataque;
            this.Defensa=defensa;
        }
    }
}