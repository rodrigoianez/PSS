using PSS.rih419.Practica_03;
using System.Diagnostics.SymbolStore;

namespace PSS.rih419.Practica_03
{
    [TestClass]
    public class TestTablero
    {
        [TestMethod]
        public void Constructor_SinParametros_EsNoNulo()
        {
            Tablero tablero = new Tablero();
            Assert.IsNotNull(tablero);
        }

        [TestMethod]
        public void Constructor_ParametroDimension_DimensionEsIgual()
        {
            Tablero tablero = new Tablero(9);
            bool booleano = tablero.Dimension == 9;
            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void Indexador_FilaColumna_EsIgual()
        {

            Tablero tablero = new Tablero(9);
            tablero[1, 1] = new Ficha(ColorFicha.Negro);
            bool booleano = tablero[1, 1].Color == ColorFicha.Negro;
            Assert.IsTrue(booleano);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexador_FueraDimension_Excepcion()
        {

            Tablero tablero = new Tablero(9);
            tablero[10, 10] = new Ficha(ColorFicha.Negro);
            
            Assert.Fail("Se esperaba una IndexOutOfRangeException");

        }


    }

}