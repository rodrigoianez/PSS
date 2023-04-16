using PSS.rih419.Practica_03;
using System.Diagnostics.SymbolStore;

namespace PSS.rih419.Practica_03
{
    [TestClass]
    public class TestJugador
    {
        [TestMethod]
        public void Constructor_SinParametros_EsNoNulo()
        {
            Jugador jugador = new Jugador();
            Assert.IsNotNull(jugador);
        }

        [TestMethod]
        public void Constructor_ParametroNombre_EsIgual() 
        {
            Jugador jugador = new Jugador("Nombre jugador");
            bool booleano = jugador.Nombre == ("Nombre jugador"); 
            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void Constructor_SinParametros_NombreEsNombreInstancia()
        {
            Jugador.numJugadores = 0;
            Jugador jugador = new Jugador();
            bool booleano = (jugador.Nombre == ("Jugador1"));
            Assert.IsTrue(booleano);
        }

        [TestMethod]
        public void Ficha_ColorRojo_ColorFichaJugadorEsIgual()
        {
            Jugador jugador = new Jugador();
            jugador.Ficha = new Ficha(ColorFicha.Rojo);
            bool booleano = (jugador.Ficha.Color == ColorFicha.Rojo);
            Assert.IsTrue(booleano);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Ficha_No_Asignada_Excepcion()
        {

            Jugador jugador = new Jugador();
            bool boleano = (jugador.Ficha.Color == ColorFicha.Rojo);
            Assert.Fail("Se esperaba una ArgumentException");

        }


        [TestMethod]
        public void Ficha_ColorRojo_ColoorFichaJugadorEsIgual()
        {
            Jugador jugador = new Jugador();
            jugador.Ficha = new Ficha(ColorFicha.Rojo);
            bool booleano = (jugador.Ficha.Color == ColorFicha.Rojo);
            Assert.IsTrue(booleano);
        }




    }

}