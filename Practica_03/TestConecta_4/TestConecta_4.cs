using Conecta_4;

namespace TestConecta_4
{
    [TestClass]
    public class TestConecta_4
    {
        [TestMethod]
        public void CrearJugadorTest()
        {
            Jugador jugador = new Jugador();
            Assert.IsNotNull(jugador);

        }

        

    }

    
}