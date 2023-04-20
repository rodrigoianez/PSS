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
        public void Casillas_PongoFicha_FichaEsIgual()
        {
            Tablero tablero = new Tablero();
            var ficha = new Ficha(ColorFicha.Verde);
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
            Tablero tablero = new Tablero();
            int numeroCasillasOcupadas;
            tablero.numeroCasillasOcupadas = 81;
            bool booleano = tablero.EsFinJuego();
            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void AsignarFicha_AsignoFichas_EsIgual()
        {

            Jugador j1 = new Jugador();
            Jugador j2 = new Jugador();
            Tablero tablero = new Tablero();

            tablero.AsignarFicha(j1, j2);

            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Assert.AreEqual(j1.Ficha.Color, ficha1.Color);

            Ficha ficha2 = new Ficha(ColorFicha.Verde);
            Assert.AreEqual(j2.Ficha.Color, ficha2.Color);

        }

        [TestMethod]
        public void PonerfichaPosicion_PongoFicha_EsIgual()
        {
            Ficha ficha = new Ficha(ColorFicha.Morado);
            int columna = 0;
            Tablero tablero = new Tablero();
            tablero.PonerFichaPosicion(ficha, columna);

            Assert.AreNotEqual(tablero.casilla[8, 0], null);
        }

        [TestMethod]
        public void HayGanador_HayUnGanador_EsTrue()
        {
            
            Ficha ficha = new Ficha(ColorFicha.Morado);
            int columna = 0;
            Tablero tablero = new Tablero();
            Jugador jugador = new Jugador();
            bool booleano = tablero.HayGanador(tablero);

            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void iaFacil_PoneFicha_EsIgual()
        {
            Tablero tablero = new Tablero();
            Ficha ficha = new Ficha(ColorFicha.Morado);
            int columna = tablero.iaFacil();
            tablero.PonerFichaPosicion(ficha, columna);

            Assert.AreNotEqual(tablero.casilla[8, columna], null);

        }
    }
}