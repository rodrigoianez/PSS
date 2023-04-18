namespace PSS.rih419.Practica_03
{
    public  class Juego
    {
        public static int NumeroJugadores;
        private static Dictionary<string,Jugador> listaJugadores = new Dictionary<string,Jugador>();
        

        public Juego()
        {

        }

        public static void AnadirJugador(Jugador jugador)
        {
            listaJugadores.Add(jugador.Nombre,jugador);
            NumeroJugadores++;
        }

        public static Jugador ObtenerJugador(string nombre)
        {
            return listaJugadores[nombre];
        }

        public static bool IndiceAleatorio()
        {
            Random random = new Random();
            
            if (random.Next(0,2) == 0)
            {
                return true;
            }
            else return false;
        }

        public static Jugador EmpiezaJugadorAleatorio(Jugador j1, Jugador j2)
        {

            bool booleano = IndiceAleatorio();
          

            if (booleano == true)
            {

                return j1;
            }

            else return j2;
        }
    }
}