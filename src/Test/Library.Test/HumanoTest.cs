using NUnit.Framework;
using Personaje;
using Elemento;
namespace Test.Library
{


    public class HumanoTest
    {
        private Humano  humano;
        private Elfo    elfo;
        [SetUp]
        public void Setup()
        {
            Espada espada   = new Espada("Espada Acero",50,5);
            Escudo escudo   = new Escudo("Escudo Madera",0,40);
            this.humano     = new Humano("Charlie",espada,escudo);

            Arco arco      = new Arco("Arco Fuego",20,0);
            Anillo anillo  = new Anillo("Anillo Brillante",10,20);
            this.elfo      = new Elfo("Legolas",arco,anillo);


        }
        [Test]
        public void TestAtaqueTotal()
        {
            Assert.AreEqual(50, this.humano.AtaqueTotal());
        }

        [Test]
        public void TestDefensaTotal()
        {
            Assert.AreEqual(45, this.humano.DefensaTotal());
        }

        [Test]
        public void TestRecibirAtaque()
        {
            this.humano.RecibirAtaque(this.elfo.AtaqueTotal());
            Assert.AreEqual(100, this.humano.Vida);
        }

        [Test]
        public void TestCurar()
        {
            this.elfo.RecibirAtaque(this.humano.AtaqueTotal());
            Assert.AreEqual(40, this.elfo.Vida);

            this.elfo.Curar();

            Assert.AreEqual(70, this.elfo.Vida);
        }

        [Test]
        public void TestRemoverEscudo()
        {
            humano.RemoverEscudo();
            Assert.AreEqual(null, humano.Escudo);
        }

        [Test]
        public void TestRemoverEspada()
        {
            humano.RemoverEspada();
            Assert.AreEqual(null, humano.Espada);
        }

        [Test]
        public void TestCambiarEspada()
        {
            humano.CambiarEspada(new Espada("Sable", 30,0));
            Assert.AreEqual(30, humano.AtaqueTotal());
        }

        [Test]
        public void TestCambiarEscudo()
        {
            humano.CambiarEscudo(new Escudo("Escudo de plata", 14,68));
            // Defensa = 68 del escudo + 5 de la espada inicial
            Assert.AreEqual(73, humano.DefensaTotal());
        }
    }


}