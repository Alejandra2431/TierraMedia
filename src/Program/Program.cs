using System;
using Elemento;
using Personaje;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Arco arco1= new Arco("Arco Fuego",20,0);
            Anillo anillo1 =new Anillo("Anillo Brillante",10,20);
            Elfo elfo1= new Elfo("Legolas",arco1,anillo1);

            Mazo mazo1= new Mazo("Martillo",40,0);
            Armadura armadura1=new Armadura("Armadura Hierro",0,50);
            Enano enano1=new Enano("Gimbli",mazo1,armadura1);

            Espada espada1=new Espada("Espada Acero",50,5);
            Escudo escudo1= new Escudo("Escudo Madera",0,40);
            Humano humano1=new Humano("Charlie",espada1,escudo1);

            BastonMagico baston1=new BastonMagico("Baston Hielo",40,0);
            Hechizo hechizo1=new Hechizo("Escarcha",40,10);
            LibroDeHechizos libro1 = new LibroDeHechizos("Biblia",hechizo1);
            Mago mago1=new Mago("Gandalf",baston1,libro1);

            // Mago Ataca Enano
            enano1.RecibirAtaque(mago1.AtaqueTotal());
            Console.WriteLine(enano1.Vida.ToString());

            // Enano se Cura 
            enano1.Curar();
            Console.WriteLine(enano1.Vida.ToString());


        }
    }
}
