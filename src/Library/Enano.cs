using System;
using System.Collections;
using Elemento;

namespace Personaje
{
    public class Enano
    {
        private string nombre;

        private int vida;

        public string Nombre{get; private set;}

        public int Vida{get; private set;}

        public Mazo itemAtaque {get; private set;}

        public Armadura itemDefensa {get; private set;}

        public Enano(string nombre)
        {
            this.Vida = 200;
            this.Nombre = nombre;
            this.itemAtaque = new Mazo ("rompe tormentas",35,0);
            this.itemDefensa = new Armadura("salva vidas",0,30);
        }

        public int AtaqueTotal()
        {
            return this.itemAtaque.Ataque + this.itemDefensa.Ataque;
        }

        public int DefensaTotal()
        {
            return this.itemAtaque.Defensa + this.itemDefensa.Defensa;
        }

        public void RemoverItemDefensa()
        {
            this.itemDefensa = null;
        }

        public void RemoverItemAtaque()
        {
            this.itemAtaque = null;
        }

        public void RecibirAtaque(int ataque)
        {
            int vida = this.Vida + this.DefensaTotal() - ataque;

            if(vida < 0)
            {
                this.Vida = 0;
            }
            else
            {
                this.Vida = vida;
            }
        }

        public void Curar(int curacion)
        {
            int vidaNueva = this.vida + curacion;

            if(vidaNueva > 200)
            {
                this.vida = 200;
            }
            else
            {
                this.vida=vidaNueva;
            }
        }
    }
}