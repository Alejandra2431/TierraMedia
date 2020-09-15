using System;
using Elemento;

namespace Personajes
{
    public class Humano
    {
        public string Nombre { get; private set;}
        public int Vida {get; private set;}
        public Espada ItemAtaque {get; private set;}
        public Escudo ItemDefensa {get; private set;}
        
        public Humano(string nombre)
        {
            this.Nombre         = nombre;
            this.Vida           = 100;
            this.ItemAtaque     = new Espada("Sable", 20, 0);
            this.ItemDefensa    = new Escudo("Escudo de madera", 0, 15);
        }

        public int AtaqueTotal()
        {
            return this.ItemAtaque.Ataque + this.ItemDefensa.Ataque;
        }

        public int DefensaTotal()
        {
            return this.ItemAtaque.Defensa + this.ItemDefensa.Ataque;
        }

        public void CambiarItemAtaque(Espada espada)
        {
            this.ItemAtaque = espada;
        }

        public void CambiarItemDefensa(Escudo escudo)
        {
            this.ItemDefensa = escudo;
        }

        public void RemoverItemAtaque()
        {
            this.ItemAtaque = null;
        }

        public void RemoverItemDefensa()
        {
            this.ItemDefensa = null;
        }

        public void RecibirAtaque(int ataque)
        {
            int vida = this.Vida + this.DefensaTotal() - ataque;
            
            if(vida < 0)
            {
                this.Vida = 0;
            }else
            {
                this.Vida = vida;
            }
        }

        public void Curar(int curacion)
        {
            if(curacion > 0)
            {
                int vidaNueva = this.Vida + curacion;
                if(vidaNueva > 100)
                {
                    this.Vida = 100;
                }
                else
                {
                    this.Vida = vidaNueva;   
                }
            }
        }
    }
}
