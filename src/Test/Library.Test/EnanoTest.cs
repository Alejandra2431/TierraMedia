using NUnit.Framework;
using Personaje;
using Elemento;

namespace Test.Library
{
    public class EnanoTest
    {
        private Enano enano1;
        private Mazo mazo1;
        private Armadura armadura1;
        private Mazo mazo2;
        private Armadura armadura2;

        [SetUp]
        public void SetUp()
        {
            this.mazo1 = new Mazo("Rompe Tormentas", 40, 0);
            this.armadura1 = new Armadura("Impenetrable", 0, 50);
            this.enano1 = new Enano("Gimly", mazo1, armadura1);
            this.mazo2 = new Mazo("Noqueador", 30, 0);
            this.armadura2 = new Armadura("Fortaleza", 0, 20);
        }

        [Test]
        public void AtaqueTotal()
        {
            Assert.AreEqual(40, enano1.AtaqueTotal());
        }

        [Test]
        public void DefensaTotal()
        {
            Assert.AreEqual(50, enano1.DefensaTotal());
        }

        [Test]
        public void SacarArmadura()
        {
            enano1.RemoverArmadura();
            Assert.AreEqual(null, enano1.Armadura);
        }

        [Test]
        public void SacarMazo()
        {
            enano1.RemoverMazo();
            Assert.AreEqual(null, enano1.Mazo);
        }

        [Test]
        public void CambiarMazo()
        {
            enano1.CambiarMazo(mazo2);
            Assert.AreEqual(30, enano1.AtaqueTotal());
        }

        [Test]
        public void CambiarArmadura()
        {
            enano1.CambiarArmadura(armadura2);
            Assert.AreEqual(20, enano1.DefensaTotal());
        }

        [Test]
        public void Curar()
        {
            enano1.RecibirAtaque(100);
            enano1.Curar();
            Assert.AreEqual(200, enano1.Vida);
        }

        [Test]
        public void RecibirAtaque()
        {
            enano1.RecibirAtaque(100);
            Assert.AreEqual(150, enano1.Vida);
        }
    }
}