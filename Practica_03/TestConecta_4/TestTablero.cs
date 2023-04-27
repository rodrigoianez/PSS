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
            Tablero tablero = new Tablero();
            Ficha ficha = new Ficha(ColorFicha.Morado);
            int columna = 0;
            
            tablero.PonerFichaPosicion(ficha, columna, tablero);

            Assert.AreNotEqual(tablero.casilla[8, 0], null);
        }

        [TestMethod]
        public void HayGanador_NoHayUnGanador_EsFalse()
        {
            Juego juego = new Juego();
            Ficha ficha = new Ficha(ColorFicha.Morado);
            int columna = 0;
            Tablero tablero = new Tablero();
            Jugador jugador = new Jugador(ficha);
            bool booleano = juego.HayGanador(tablero, ficha, 4);

            Assert.IsFalse(booleano);
        }

        [TestMethod]
        public void HayGanador_HayUnGanadorHorizontal_EsTrue()
        {
            Juego juego = new Juego();
            Ficha ficha = new Ficha(ColorFicha.Morado);
            int columna = 0;
            Tablero tablero = new Tablero();
            Jugador jugador = new Jugador(ficha);
            tablero.PonerFichaPosicion(jugador.Ficha, 0, tablero);
            tablero.PonerFichaPosicion(jugador.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugador.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugador.Ficha, 3, tablero);
            bool booleano = juego.HayGanador(tablero, ficha, 4);

            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void HayGanador_HayUnGanadorVertical_EsTrue()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha ficha2 = new Ficha(ColorFicha.Verde);
            int columna = 0;
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador(ficha1);
            Jugador jugador2 = new Jugador(ficha2);
            tablero.PonerFichaPosicion(jugador1.Ficha, 0, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 0, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 0, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 3, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 0, tablero);
            bool booleano = juego.HayGanador(tablero, ficha1, 4);

            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void HayGanador_HayUnGanadorDiagonal_EsTrue()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha ficha2 = new Ficha(ColorFicha.Verde);
            int columna = 0;
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador(ficha1);
            Jugador jugador2 = new Jugador(ficha2);
            tablero.PonerFichaPosicion(jugador1.Ficha, 0, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 3, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 3, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 3, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 4, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 3, tablero);
            bool booleano = juego.HayGanador(tablero, ficha1, 4);

            Assert.IsTrue(booleano);
        }
        [TestMethod]
        public void iaFacil_PoneFicha_EsIgual()
        {
            Tablero tablero = new Tablero();
            Ficha ficha = new Ficha(ColorFicha.Morado);
            int columna = tablero.iaFacil();
            tablero.PonerFichaPosicion(ficha, columna, tablero);

            Assert.AreNotEqual(tablero.casilla[8, columna], null);

        }

        [TestMethod]
        public void iaDificil_GanaCuandoPuede_EsIgual()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha fichaIA = new Ficha(ColorFicha.Verde);
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador();
            Jugador jugadorIA = new Jugador();
            jugador1.Ficha = ficha1;
            jugadorIA.Ficha = fichaIA;
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 3, tablero);
            int columna = tablero.iaDificil(tablero, jugadorIA);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, columna, tablero);
            bool booleano = juego.HayGanador(tablero, fichaIA, 4);

            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void iaDificil_TaponaGanador_EsIgual()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha fichaIA = new Ficha(ColorFicha.Verde);
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador();
            Jugador jugadorIA = new Jugador();
            jugador1.Ficha = ficha1;
            jugadorIA.Ficha = fichaIA;
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 5, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 3, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 8, tablero);
            int columna = tablero.iaDificil(tablero, jugadorIA);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, columna, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 8, tablero);
            bool booleano = juego.HayGanador(tablero, fichaIA, 4);

            Assert.IsFalse(booleano);
        }

        [TestMethod]
        public void HayGanador_VerticalFichasEntrelazadas_EsFalse()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha ficha2 = new Ficha(ColorFicha.Verde);
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();
            jugador1.Ficha = ficha1;
            jugador2.Ficha = ficha2;
            tablero.PonerFichaPosicion(jugador2.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 8, tablero);
            bool booleano = juego.HayGanador(tablero, ficha2, 4);

            Assert.IsFalse(booleano);
        }

        [TestMethod]
        public void HayGanador_Verifica3Seguidas_EsTrue()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha ficha2 = new Ficha(ColorFicha.Verde);
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();
            jugador1.Ficha = ficha1;
            jugador2.Ficha = ficha2;
            tablero.PonerFichaPosicion(jugador2.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 4, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 8, tablero);

            bool booleano = juego.HayGanador(tablero, ficha2, 3);

            Assert.IsTrue(booleano);

        }

        [TestMethod]
        public void iaDificil_Conecta3CuandoPuede_EsTrue()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha fichaIA = new Ficha(ColorFicha.Verde);
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador();
            Jugador jugadorIA = new Jugador();
            jugador1.Ficha = ficha1;
            jugadorIA.Ficha = fichaIA;
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 2, tablero);
            int columna = tablero.iaDificil(tablero, jugadorIA);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, columna, tablero);
            bool booleano = juego.HayGanador(tablero, fichaIA, 3);

            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void iaDificil_NoConecta3CuandoNoPuede_EsTrue()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha fichaIA = new Ficha(ColorFicha.Verde);
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador();
            Jugador jugadorIA = new Jugador();
            jugador1.Ficha = ficha1;
            jugadorIA.Ficha = fichaIA;
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 8, tablero);
            int columna;
            do
            {
                columna = tablero.iaDificil(tablero, jugadorIA);

            } while (columna == 8 );

            tablero.PonerFichaPosicion(jugadorIA.Ficha, columna, tablero);
            bool booleano = tablero.casilla[4,8] == null;

            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void HayGanador_NoHayConecta3SiElDeArribaEsDistinto_EsFalso()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha fichaIA = new Ficha(ColorFicha.Verde);
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador();
            Jugador jugadorIA = new Jugador();
            jugador1.Ficha = ficha1;
            jugadorIA.Ficha = fichaIA;
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 8, tablero);
            bool booleano = juego.HayGanador(tablero, fichaIA, 3);

            Assert.IsFalse(booleano);
        }

        [TestMethod]
        public void iaDificil_GanaCuandoPuedeAunqueYoPuedaGanar_EsIgual()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha fichaIA = new Ficha(ColorFicha.Verde);
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador();
            Jugador jugadorIA = new Jugador();
            jugador1.Ficha = ficha1;
            jugadorIA.Ficha = fichaIA;
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugadorIA.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 3, tablero);

            
            bool booleano = juego.HayGanador(tablero, fichaIA, 3);

            Assert.IsTrue(booleano);
        }


        [TestMethod]
        public void HayGanador_DiagonalDerecha_EsTrue()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha ficha2 = new Ficha(ColorFicha.Verde);
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();
            jugador1.Ficha = ficha1;
            jugador2.Ficha = ficha2;
            tablero.PonerFichaPosicion(jugador2.Ficha, 0, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 1, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 3, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 2, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 3, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 3, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 4, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 3, tablero);
            bool booleano = juego.HayGanador(tablero, ficha2, 4);

            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void HayGanador_DiagonalIzquierda_EsTrue()
        {
            Juego juego = new Juego();
            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha ficha2 = new Ficha(ColorFicha.Verde);
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();
            jugador1.Ficha = ficha1;
            jugador2.Ficha = ficha2;
            tablero.PonerFichaPosicion(jugador2.Ficha, 8, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 7, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 7, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 6, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 6, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 5, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 6, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 5, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 5, tablero);
            tablero.PonerFichaPosicion(jugador1.Ficha, 4, tablero);
            tablero.PonerFichaPosicion(jugador2.Ficha, 5, tablero);
            bool booleano = juego.HayGanador(tablero, ficha2, 4);

            Assert.IsTrue(booleano);
        }
    }
}