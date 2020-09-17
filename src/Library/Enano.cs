using System;
using System.Collections;
using Elemento;

namespace Personaje
{
    public class Enano
    {
        public string Nombre{get; private set;}

        public int Vida{get; private set;}

        public Mazo Mazo {get; private set;}

        public Armadura Armadura {get; private set;}

        public Enano(string nombre, Mazo mazo, Armadura armadura)
        {
            this.Vida = 200;
            this.Nombre = nombre;
            this.Mazo = mazo;
            this.Armadura = armadura;
        }

        public int AtaqueTotal()
        {
            return this.Mazo.Ataque + this.Armadura.Ataque;
        }

        public int DefensaTotal()
        {
            return this.Mazo.Defensa + this.Armadura.Defensa;
        }

        public void RemoverArmadura()
        {
            this.Armadura = null;
        }

        public void RemoverMazo()
        {
            this.Mazo = null;
        }

        public void CambiarMazo(Mazo nuevo)
        {
            this.Mazo=nuevo;
        }
        public void CambiarArmadura(Armadura nuevo)
        {
            this.Armadura=nuevo;

        }
        public void RecibirAtaque(int ataque)
        {
            int vida = this.Vida + this.DefensaTotal() - ataque;

            if(vida <= 0)
            {
                this.Vida = 0;
            }
            else if(vida <= 200 && vida > 0)
            {
                this.Vida = vida;
            }
        }

        public void Curar()
        {
            this.Vida = 200;
        }
    }
}