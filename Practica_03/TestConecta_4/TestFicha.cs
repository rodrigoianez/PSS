using PSS.rih419.Practica_03;

namespace PSS.rih419.Practica_03
{
    [TestClass]
    public class TestFicha
    {
        [TestMethod]
        public void Constructor_SinParametros_EsNoNulo()
        {
            Ficha ficha = new Ficha();
            Assert.IsNotNull(ficha);
        }

        [TestMethod]
        public void Constructor_ParametroColor_EsIgual() 
        {
            Ficha ficha = new Ficha(ColorFicha.Rojo);
            bool booleano = ficha.Color == ColorFicha.Rojo;
            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void Constructor_SinParametroColor_EsSinColor()
        {
            Ficha ficha = new Ficha(ColorFicha.SinColor);
            bool booleano = ficha.Color == ColorFicha.SinColor;
            Assert.IsTrue(booleano);
        }

    }

}