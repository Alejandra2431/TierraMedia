using System;
using Elemento;
using System.Collections;

namespace Personaje
{
    public class Elfo
    {
        public string Nombre {get; set;}
        public int Vida {get;set;}
        public Arco Arco {get;set;}
        public Anillo Anillo {get;set;}
        public Elfo (string nombre, Arco arco, Anillo anillo){
            this.Nombre= nombre;
            this.Vida= 70;
            this.Arco= arco;
            this.Anillo= anillo;
        }
        /* Pusimos los siguientes comportamientos en todas las clases dentro del namespace personaje, ya que por patron EXPERT 
        estas son expertas en los datos usados para cumplir con la responsabilidad. Como por ejemplo saber la defensa y el ataque 
        es algo propio del elemento o item, pero el personaje conoce sus items, por lo tanto el calculo de los totales,
        tiene sentido por patron EXPERT que se encuentre en la propia clase. Tanto recibir ataque como curar afectan directamente
        a la vida del personaje, por lo tanto tiene sentido que estos comportamientos esten en la clase propia del personaje, ya que 
        este es experto en datos de la vida. */
        public int AtaqueTotal(){
            return this.Arco.Ataque + this.Anillo.Ataque;
        }
        public int DefensaTotal(){
            return this.Arco.Defensa + this.Anillo.Defensa;
        }
        public void RecibirAtaque(int ataque)
        {
            int vida = this.Vida + this.DefensaTotal() - ataque;
            if(vida <= 0)
            {
                this.Vida = 0;
            }
            else if (vida <= 70 && vida > 0)
            {
                this.Vida = vida;
            }
        }
        public void RemoverArco()
        {
            this.Arco= null;
        }
        public void RemoverAnillo()
        {
            this.Anillo= null;
        }
        public void CambiarArco(Arco arco)
        {
            this.Arco= arco;
        }
        public void CambiarAnillo(Anillo anillo)
        {
            this.Anillo= anillo;
        }
        public void Curar()
        {
            this.Vida= 70;
        }
    }
}
