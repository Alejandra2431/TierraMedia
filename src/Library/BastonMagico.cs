using System;

namespace Elemento
{
    public class BastonMagico
    {
        public string Name{get;set;}
        private int ataque;
        private int defensa;

        public BastonMagico(string name,int ataque,int defensa)
        {
            this.Name=name;
            this.ataque=ataque;
            this.defensa=defensa;
        }
        public int Ataque()
        {
            return this.ataque;
        }
        public int Defensa()
        {
            return this.defensa;
        }

        
    }
}
