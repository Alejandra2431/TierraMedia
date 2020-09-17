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
        public int AtaqueTotal(){
            return this.Arco.Ataque + this.Anillo.Ataque;
        }
        public int DefensaTotal(){
            return this.Arco.Defensa + this.Anillo.Defensa;
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
