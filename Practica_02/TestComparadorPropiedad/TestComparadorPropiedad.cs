namespace PSS.rih419.Practica_02
{
    [TestClass]
    public class TestComparadorPropiedad
    {
        UsuarioView usuario1 = new UsuarioView(0, "Rodrigo", "Comer", "Comida", true);
        UsuarioView usuario2 = new UsuarioView(1, "Rodrigo", "Comer", "Comida", false);
        UsuarioView usuario3 = null;

        [TestMethod]
        public void TestMethod1()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");

            Assert.AreEqual(1,propiedad.Compare(usuario1, usuario3));

        }

        [TestMethod]
        public void TestMethod2()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");

            Assert.AreEqual(-1, propiedad.Compare(usuario3, usuario1));

        }

        [TestMethod]
        public void TestMethod3()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");

            Assert.AreEqual(0, propiedad.Compare(usuario3, usuario3));

        }

        [TestMethod]
        public void TestMethod4()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("EsValido");

            Assert.AreEqual(-1, propiedad.Compare(usuario2, usuario1));

        }

        [TestMethod]
        public void TestMethod5()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");

            Assert.AreEqual(0, propiedad.Compare(usuario3, usuario3));

        }
        [TestMethod]
        public void TestMethod6()
        {

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>("Id");

            Assert.AreEqual(0, propiedad.Compare(usuario3, usuario3));

        }

    }
}