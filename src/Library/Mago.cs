using System;
using Elemento;
using System.Collections;

namespace Personaje
{
    public class Mago
    {
        public string Name{get;set;}
        private int vida;
        public BastonMagico Baston {get;set;}
        public LibroDeHechizos Libro{get;set;}

        public int Vida
        {
            get
            {
                return this.vida;
            }
            
        }
        

        public Mago(string name,BastonMagico baston,LibroDeHechizos libro )
        {
            ///this.Elementos=new ArrayList();
            this.vida=100;
            this.Name=name;
            this.Baston=baston;
            this.Libro=libro;

        }
        public void EliminarBaston ()
        {
            this.Baston=null;
        }
        public void EliminarLibroHechizo()
        {
            this.Libro=null;

        }
        public void CambiarBaston(BastonMagico nuevo)
        {
            this.Baston=nuevo;
        }
        public void CambiarLibroDeHechizos(LibroDeHechizos nuevo)
        {
            this.Libro=nuevo;

        }

        /* Pusimos los siguientes comportamientos en todas las clases dentro del namespace personaje, ya que por patron EXPERT 
        estas son expertas en los datos usados para cumplir con la responsabilidad. Como por ejemplo saber la defensa y el ataque 
        es algo propio del elemento o item, pero el personaje conoce sus items, por lo tanto el calculo de los totales,
        tiene sentido por patron EXPERT que se encuentre en la propia clase. Tanto recibir ataque como curar afectan directamente
        a la vida del personaje, por lo tanto tiene sentido que estos comportamientos esten en la clase propia del personaje, ya que 
        este es experto en datos de la vida. */

        public int AtaqueTotal()
        {
            int ataque = 0;
            ataque= Baston.Ataque() + Libro.Ataque();
            return ataque;

        }
        public int DefensaTotal()
        {
            int defensa = 0;
            
            defensa=Baston.Defensa() + Libro.Defensa();
            return defensa;
        }
        
        public void RecibirAtaque(int ataque)
        {
            int vida = this.vida + this.DefensaTotal() - ataque;

            if(vida <= 0)
            {
                this.vida = 0;
            }
            else if (vida<=100 && vida>0)
            {
                this.vida = vida;
            }
        }
        public void Curar()
        {
            this.vida=100;
        }

    }
}
