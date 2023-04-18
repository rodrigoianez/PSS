namespace PSS.rih419.Practica_03
{
    public static class EjecutableConecta4
    {

        public static void Main(String[] args)
        {

            Console.WriteLine("Que comience la partida");

            Console.WriteLine("Introduzca el nombre del primer jugador");

            String nombreJugador1 = Console.ReadLine();

            Console.WriteLine("Introduzca el nombre del segundo jugador");

            String nombreJugador2 = Console.ReadLine();

            Jugador j1 = new Jugador(nombreJugador1);
            Jugador j2 = new Jugador(nombreJugador2);


           

            Console.WriteLine("Turno de " + Juego.EmpiezaJugadorAleatorio(j1, j2).toString());

        }

    }

}



