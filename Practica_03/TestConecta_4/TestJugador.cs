using PSS.rih419.Practica_03;

namespace PSS.rih419.Practica_03
{
    [TestClass]
    public class TestJugador
    {
        [TestMethod]
        public void CrearJugadorTest()
        {
            Jugador jugador = new Jugador();
            Assert.IsNotNull(jugador); 
        }

        

    }

    
}