using System;

namespace Elemento
{
    public class Hechizo
    {
        public string Name{get;set;}
        public int Ataque{get;private set;}
        public int Defensa{get;private set;}

        public Hechizo(string name,int ataque, int defensa)
        {
            this.Name=name;
            this.Ataque=ataque;
            this.Defensa=defensa;
        }


    }
}
