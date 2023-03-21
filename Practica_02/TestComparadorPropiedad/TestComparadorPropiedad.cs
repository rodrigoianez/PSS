namespace PSS.rih419.Practica_02
{
    [TestClass]
    public class TestComparadorPropiedad
    {


        [TestMethod]
        public void TestMethod1()
        {

            UsuarioView usuario1 = new UsuarioView(0, "Rodrigo", "Comer", "Comida", true);
            UsuarioView usuario2 = new UsuarioView(0, "Rodrigo", "Comer", "Comida", true);

            ComparadorPropiedad<UsuarioView> propiedad = new ComparadorPropiedad<UsuarioView>();

            Assert.AreEqual(0,propiedad.Compare(usuario1, usuario2));

        }
    }
}