namespace PSS.rih419.Practica_03
{
    public class Juego
    {
        public int NumeroJugadores;
        private Dictionary<string,Jugador> listaJugadores = new Dictionary<string,Jugador>();

        public Juego()
        {
        }

        public void AnadirJugador(Jugador jugador)
        {
           
            listaJugadores.Add(jugador.Nombre,jugador);
            NumeroJugadores++;


        }

        public Jugador ObtenerJugador(string nombre)
        {

            return listaJugadores[nombre];

        }
    }
}