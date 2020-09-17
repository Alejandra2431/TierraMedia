using System;
using Elemento;

namespace Personaje
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

        /* Pusimos los siguientes comportamientos en todas las clases dentro del namespace personaje, ya que por patron EXPERT 
        estas son expertas en los datos usados para cumplir con la responsabilidad. Como por ejemplo saber la defensa y el ataque 
        es algo propio del elemento o item, pero el personaje conoce sus items, por lo tanto el calculo de los totales,
        tiene sentido por patron EXPERT que se encuentre en la propia clase. Tanto recibir ataque como curar afectan directamente
        a la vida del personaje, por lo tanto tiene sentido que estos comportamientos esten en la clase propia del personaje, ya que 
        este es experto en datos de la vida. */

        public int AtaqueTotal()
        {
            return this.Espada.Ataque + this.Escudo.Ataque;
        }

        public int DefensaTotal()
        {
            return this.Espada.Defensa + this.Escudo.Defensa;
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
            
            if(vida <= 0)
            {
                this.Vida = 0;
            }
            else if(vida <= 100 && vida > 0)
            {
                this.Vida = vida;
            }
        }

        public void Curar()
        {
            this.Vida = 100;
        }
    }
}
