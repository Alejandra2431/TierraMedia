using NUnit.Framework;
using Test.Library;
using Personaje;
using Elemento;

namespace Test.Library
{
    public class ElfoTest
    {
        private Elfo elfo1;
        private Enano enano1;
        [SetUp]
        public void SetUp()
        {
            Arco arco1= new Arco("Arco Fuego", 20, 0);
            Anillo anillo1 =new Anillo("Anillo Brillante", 10, 20);
            this.elfo1= new Elfo("Legolas", arco1, anillo1);

            Mazo mazo1= new Mazo("Martillo", 40, 0);
            Armadura armadura1=new Armadura("Armadura Hierro", 0, 50);
            Enano enano1=new Enano("Gimbli", mazo1, armadura1);
        }
        [Test]
        public void AtaqueTotalTest()
        {
            Assert.AreEqual(this.elfo1.AtaqueTotal(), 30);
        }
        [Test]
        public void DefensaTotalTest()
        {
            Assert.AreEqual(this.elfo1.DefensaTotal(), 20);
        }
        [Test]
        public void RemoverArcoTest()
        {
            this.elfo1.RemoverArco();
            Assert.AreEqual(this.elfo1.Arco, null);
        }
        [Test]
        public void RemoverAnilloTest()
        {
            this.elfo1.RemoverAnillo();
            Assert.AreEqual(this.elfo1.Anillo, null);
        }
        [Test]
        public void CambiarArcoTest()
        {
            Arco arco= new Arco("Fuego2", 15, 0);
            this.elfo1.CambiarArco(arco);
            Assert.AreEqual(this.elfo1.AtaqueTotal, 25);
        }
        [Test]
        public void CambiarAnilloTest()
        {
            Anillo anillo= new anillo("Brillante2", 0, 30);
            this.elfo1.CambiarAnillo(anillo);
            Assert.AreEqual(this.elfo1.DefensaTotal, 30);
        }  
        [Test]
        public void CurarTest()
        {
            this.elfo1.Curar();
            Asser.AreEqual(this.elfo1.Vida, 70);
        }
        [This]
        public void RecibirAtaqueTest()
        {
            this.elfo1.RecibirAtaque(this.enano1.AtaqueTotal);
            Assert.AreEqual(this.elfo1.Vida,50)
        }
    }
}