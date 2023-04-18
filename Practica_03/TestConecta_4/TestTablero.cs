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
        public void Dimension_InstanciarTableroSinParametros_DimensionEsIgual()
        {
            Tablero tablero = new Tablero();
            bool booleano = tablero.Dimension == 9;
            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void Dimension_InstanciarTableroConParametros_DimensionEsIgual()
        {
            Tablero tablero = new Tablero(15);
            bool booleano = tablero.Dimension == 15;
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

        [TestMethod]
        public void Casillas_PongoFicha_FichaEsIgual()
        {
            Tablero tablero = new Tablero();
            var ficha = new Ficha(ColorFicha.Negro);
            tablero[5, 5] = ficha;
            bool booleano = tablero[5, 5].Color == ficha.Color;
            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void EsFinJuego_TableroSinFichas_EsFalse()
        {

            Tablero tablero = new Tablero();
            Assert.IsFalse(tablero.EsFinJuego());
        }

        [TestMethod]
        public void EsFinJuego_TableroLleno_EsTrue()
        {
            Tablero tablero = new Tablero(1);
            var ficha = new Ficha(ColorFicha.Rojo);
            int columna = 0;
            Tablero.PonerFichaPosicion(ficha, columna);
            Assert.IsTrue(tablero.EsFinJuego());
        }

        [TestMethod]
        public void AsignarFicha_AsignoFichas_EsIgual()
        {

            Jugador j1 = new Jugador();
            Jugador j2 = new Jugador();

            Tablero.AsignarFicha(j1, j2);

            Ficha ficha1 = new Ficha(ColorFicha.Rojo);
            Assert.AreEqual(j1.Ficha.Color, ficha1.Color);

            Ficha ficha2 = new Ficha(ColorFicha.Negro);
            Assert.AreEqual(j2.Ficha.Color, ficha2.Color);

        }

        [TestMethod]
        public void PonerfichaPosicion_PongoFicha_EsIgual()
        {

            Ficha ficha = new Ficha(ColorFicha.Rojo);
            int columna = 0;
            Tablero.PonerFichaPosicion(ficha, columna);

            Assert.AreNotEqual(Tablero.casilla[8, 0], null);


        }
    }
}