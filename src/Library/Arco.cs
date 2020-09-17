using System;

namespace Elemento
{
    public class Arco
    {
        public string Nombre{get;set;}
        public int Ataque{get;private set;}
        public int Defensa{get;private set;}

        public Arco(string nombre,int ataque, int defensa)
        {
            this.Nombre=nombre;
            this.Ataque=ataque;
            this.Defensa=defensa;
        }
    }
}