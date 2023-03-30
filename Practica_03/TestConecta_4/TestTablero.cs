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
        public void PonerFichaPosicion_PongoFicha_FichaEsIgualColor()
        {
            Tablero tablero = new Tablero();
            var ficha = new Ficha(ColorFicha.Negro);
            var posicion = new Posicion(5, 5);
            tablero.PonerFichaPosicion(ficha, posicion);
            bool booleano = tablero[5, 5].Color == ficha.Color;
            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void PonerFichaPosicion_PongoFichaCasillaLibre_EsTrue()
        {
            Tablero tablero = new Tablero();
            var ficha = new Ficha(ColorFicha.Negro);
            var posicion = new Posicion(5, 5);
            bool booleano = tablero.PonerFichaPosicion(ficha, posicion);
            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void PonerFichaPosicion_PongoFichaCasillaOcupada_EsFalse()
        {
            Tablero tablero = new Tablero();
            var ficha = new Ficha(ColorFicha.Negro);
            var posicion = new Posicion(5, 5);
            bool booleano = tablero.PonerFichaPosicion(ficha, posicion);
            bool booleano2 = tablero.PonerFichaPosicion(ficha, posicion);
            Assert.IsFalse(booleano2);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void PonerFichaPosicion_FueraDelTablero_EsFalse()
        {

            Tablero tablero = new Tablero(1);
            var ficha = new Ficha(ColorFicha.Negro);
            var posicion = new Posicion(5, 5);
            bool booleano = tablero.PonerFichaPosicion(ficha, posicion);

            Assert.Fail("Se esperaba una IndexOutOfRangeException");

        }
        [TestMethod]
        public void NumeroCasillasOcupadas_TableroConUnaFichaOcupada_EsUno()
        {

            Tablero tablero = new Tablero();
            var ficha = new Ficha(ColorFicha.Negro);
            var posicion = new Posicion(1, 1);
            tablero.PonerFichaPosicion(ficha, posicion);
            bool booleano = tablero.numeroCasillasOcupadas == 1;
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
            var posicion = new Posicion(0, 0);
            tablero.PonerFichaPosicion(ficha, posicion);
            Assert.IsTrue(tablero.EsFinJuego());
        }


    }
}