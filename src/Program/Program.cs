using System;
using Elemento;
using Personaje;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Enano enano1 = new Enano("gimly");
            Console.WriteLine(enano1);
            Console.WriteLine(enano1.AtaqueTotal());
            Console.WriteLine(enano1.DefensaTotal());
            enano1.RecibirAtaque(10);
            enano1.Curar(5);
        }
    }
}
