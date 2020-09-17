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
        public void EliminarLibroHechizo(LibroDeHechizos libro)
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

            if(vida < 0)
            {
                this.vida = 0;
            }
            else
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
