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

            Tablero.AsignarFicha(j1, j2);

            Console.WriteLine("La ficha de " + nombreJugador1 + " es " + j1.Ficha.Color);
            Console.WriteLine("La ficha de " + nombreJugador2 + " es " + j2.Ficha.Color);

            String jugador1 = Juego.EmpiezaJugadorAleatorio(j1, j2).toString();

            Console.WriteLine("Turno de " + jugador1);

            Console.WriteLine("¿En que columna quiere insertar la ficha?");

            String c = Console.ReadLine();
            int columna = Int32.Parse(c);

            Tablero.PonerFichaPosicion(j1.Ficha, columna);

            


        }



    }
}



