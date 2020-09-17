using NUnit.Framework;
using Personaje;
using Elemento;
namespace Test.Library
{


    public class MagoTest
    {
        private Mago mago; 

        [SetUp]
        public void Setup()
        {
            BastonMagico baston=new BastonMagico("Baston Hielo",40,0);
            Hechizo hechizo=new Hechizo("Escarcha",40,10);
            LibroDeHechizos libro = new LibroDeHechizos("Biblia",hechizo);
            this.mago= new Mago("Gandalf",baston,libro);
        }
        [Test]
        public void LibroDeHechizosAtaqueFunciona()
        {
            
            Equals(mago.Libro.Ataque(),40);
        }
        [Test]
        public void LibroDeHechizosDefensaFunciona()
        {
            
            Equals(mago.Libro.Defensa(),10);
        }
        
        [Test]
        public void LibroDeHechizosAgregarHechizoFunciona()
        {
            Hechizo hechizo1=new Hechizo("Fuego",200,10);
            mago.Libro.AgregarHechizo(hechizo1);
            Equals(240,mago.Libro.Ataque());
        }
        [Test]
        public void LibroDeHechizosEliminarHechizoFunciona()
        {
            Hechizo hechizo1=new Hechizo("Fuego",200,10);
            mago.Libro.AgregarHechizo(hechizo1);
            Equals(40,mago.Libro.Ataque());
        }

        

        [Test]
        public void DefensaTotalFunciona()
        {
            
            Equals(mago.DefensaTotal(),10);
        }
        [Test]
        public void AtaqueTotalFunciona()
        {
            Equals(mago.AtaqueTotal(),80);
        }
        
        
        [Test]
        public void CambiarBastonFunciona()
        {
            BastonMagico baston=new BastonMagico("Baston Fuego",70,0);
            mago.CambiarBaston(baston);
            Equals(mago.Baston,baston);
        }
        [Test]
        public void EliminarBastonFunciona()
        {
            mago.EliminarBaston();
            Equals(mago.Baston,null);
        }
        [Test]
        public void CambiarLibroHechizosFunciona()
        {
            LibroDeHechizos libro = new LibroDeHechizos("Fiore",null);
            mago.CambiarLibroDeHechizos(libro);
            Equals(mago.Libro,libro);
        }
        [Test]
        public void EliminarLibroHechizosFunciona()
        {
            mago.EliminarLibroHechizo();
            Equals(mago.Libro,null);
        }
        [Test]
        public void CurarFunciona()
        {
            mago.RecibirAtaque(1000);
            mago.Curar();
            Equals(mago.Vida,100);
        }
        [Test]
        public void RecibirAtaqueFunciona()
        {
            
            mago.RecibirAtaque(30);
            Equals(mago.Vida,80);
        }

        
        

    }


}