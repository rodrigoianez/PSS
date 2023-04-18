 using PSS.rih419.Practica_03;
using System.Diagnostics.SymbolStore;

namespace PSS.rih419.Practica_03
{
    [TestClass]
    public class TestJuego
    {

        [TestMethod]
        public void Constructor_SinParametros_EsNoNulo()
        {
            Juego juego = new Juego();
            Assert.IsNotNull(juego);
        }

        [TestMethod]
        public void AnadirJugador_ParametrosNombreJugador_NumeroJugadoresEs1()
        {
            Juego juego = new Juego();
            Jugador jugador = new Jugador("Nobre jugador");
            juego.AnadirJugador(jugador);
            bool resultado = juego.NumeroJugadores == 1;
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ObtenerJugador_ParametrosNombreJugador_PosicionLista()
        {
            Juego juego = new Juego();
            Jugador jugador1 = new Jugador("Jugador1");
            juego.AnadirJugador(jugador1);
            Jugador jugador2 = new Jugador("Jugador2");
            juego.AnadirJugador(jugador2);
            Jugador jugadorDiccionario = juego.ObtenerJugador("Jugador2");
            bool resultado = jugadorDiccionario == jugador2;
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void EmpiezaJugadorAleatorio_SinParametros_JugadorEsJugador()
        {
            Juego juego = new Juego();
            Jugador jugador1 = new Jugador("Jugador1");
            juego.AnadirJugador(jugador1);
            Jugador jugador2 = new Jugador("Jugador2");
            Jugador jugadorDevuelto = juego.EmpiezaJugadorAleatorio();

            if (jugador1 == jugadorDevuelto)
            {
                Assert.AreEqual(jugadorDevuelto, jugador1);

            }
            if (jugador2 == jugadorDevuelto)
            {
                Assert.AreEqual(jugadorDevuelto, jugador2);

            }
        }
    }
}