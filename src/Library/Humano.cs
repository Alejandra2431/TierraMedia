using System;
using Elemento;

namespace Personajes
{
    public class Humano
    {
        public string Nombre { get; private set;}
        public int Vida {get; private set;}
        public Espada Espada {get; private set;}
        public Escudo Escudo {get; private set;}
        
        public Humano(string nombre, Espada espada, Escudo escudo)
        {
            this.Nombre         = nombre;
            this.Vida           = 100;
            this.Espada         = espada;
            this.Escudo         = escudo;
        }

        public int AtaqueTotal()
        {
            return this.Espada.Ataque + this.Escudo.Ataque;
        }

        public int DefensaTotal()
        {
            return this.Espada.Defensa + this.Escudo.Ataque;
        }

        public void CambiarEspada(Espada espada)
        {
            this.Espada = espada;
        }

        public void CambiarEscudo(Escudo escudo)
        {
            this.Escudo = escudo;
        }

        public void RemoverEspada()
        {
            this.Espada = null;
        }

        public void RemoverEscudo()
        {
            this.Escudo = null;
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
            this.Vida = 100;
        }
    }
}
