using System;
namespace Elemento
{
    public class Espada
    {
        public string Nombre { get; private set;}
        public int Ataque {get; private set;}
        public int Defensa {get; private set;}
        
        public Espada(string nombre, int ataque, int defensa)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
        }
    }
}