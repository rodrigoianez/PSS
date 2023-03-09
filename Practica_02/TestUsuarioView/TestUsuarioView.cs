using System.Data.Common;

namespace PSS.rih419.Practica_02
{

    public class TestUsuarioView
    {
        
            UsuarioView usuario1 = new UsuarioView(0, "Rodrigo", "cocinar", "avanzado", false);
            UsuarioView usuario2 = new UsuarioView(1, "Jesus", "comer", "experto", true);
            UsuarioView usuario3 = new UsuarioView();
            UsuarioView? usuario4 = null;
            UsuarioView usuario5 = new UsuarioView(0, "Rodrigo", "cocinar", "experto", true);
        
        [Test]
        public void IsNull()
        {

            Assert.IsNull(usuario4);
            

        }

        [Test]
        public void IsNotNull()
        {
            Assert.IsNotNull(usuario1);
            

        }

        [Test]
        public void AreEqual()
        {

            Assert.AreEqual(usuario1, usuario1);

        }

        [Test]
        public void AreNotEqual()
        {

            Assert.AreNotEqual(usuario1, usuario2);

        }

        [Test]
        public void EqualGetHashCode()
        {

            Assert.AreEqual(usuario1.GetHashCode(), usuario1.GetHashCode());

        }

        [Test]
        public void NotEqualGetHashCode()
        {

            Assert.AreNotEqual(usuario1.GetHashCode(), usuario2.GetHashCode());

        }

        [Test]
        public void VoidGetHashCode()
        {

            Assert.AreEqual(usuario3.GetHashCode(), usuario3.GetHashCode());

        }

        [Test]
        public void AreSame()
        {

            Assert.AreSame(usuario1, usuario1);

        }

    }
}