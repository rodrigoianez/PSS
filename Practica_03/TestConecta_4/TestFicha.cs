using PSS.rih419.Practica_03;

namespace PSS.rih419.Practica_03
{
    [TestClass]
    public class TestFicha
    {
        [TestMethod]
        public void Crear_Ficha()
        {
            Ficha ficha = new Ficha();
            Assert.IsNotNull(ficha);
        }

        [TestMethod]
        public void Constructor_ParametroColor_EsIgual() 
        {
            Ficha ficha = new Ficha(ColorFicha.Rojo);
            Assert.AreEqual(ColorFicha.Rojo, ficha.Color);
        }

    }

}