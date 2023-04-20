namespace PSS.rih419.Practica_03
{
    public  class EjecutableConecta4
    {

        public static void Main(String[] args)
        {

            Console.WriteLine("Que comience la partida");

            Console.WriteLine("Elija la dificultad");
            Console.WriteLine("Pulse 1 para Jugador vs Jugador");
            Console.WriteLine("Pulse 2 para Jugador vs IA");

            String dificultadEntrada = Console.ReadLine();
            int dificultad = Int32.Parse(dificultadEntrada);

            if (dificultad == 1)
            {
                Console.WriteLine("Introduzca el nombre del primer jugador");

                String nombreJugador1 = Console.ReadLine();

                Console.WriteLine("Introduzca el nombre del segundo jugador");

                String nombreJugador2 = Console.ReadLine();

                Jugador j1 = new Jugador(nombreJugador1);
                Jugador j2 = new Jugador(nombreJugador2);

                Tablero tablero = new Tablero();

                tablero.AsignarFicha(j1, j2);

                Console.WriteLine("La ficha de " + nombreJugador1 + " es " + j1.Ficha.Color);
                Console.WriteLine("La ficha de " + nombreJugador2 + " es " + j2.Ficha.Color);



                Jugador jugadorTurno = Juego.EmpiezaJugadorAleatorio(j1, j2);


                if (jugadorTurno == j1)
                {
                    for (int turno = 0; turno < 81; turno++)
                    {
                        bool condidion1 = false;
                        bool condicion2 = false;

                        if (condidion1 = false || condicion2 == false)
                        {
                            if (turno % 2 == 0)
                            {

                                Console.WriteLine("Turno de " + j1.toString());
                                Console.WriteLine("¿En que columna quiere insertar la ficha?");

                                String c = Console.ReadLine();
                                int columna = Int32.Parse(c);
                                bool booleano = tablero.PonerFichaPosicion(j1.Ficha, columna);

                                if (booleano = true) Console.WriteLine("La ficha se ha insertado correctamente");
                                else Console.WriteLine("Se ha producido un error");

                                Console.WriteLine(tablero.ToString());
                                bool condicion1 = tablero.EsFinJuego();
                                condicion2 = tablero.HayGanador(j1);


                            }
                            else if (!(turno % 2 == 0))
                            {

                                Console.WriteLine("Turno de " + j2.toString());
                                Console.WriteLine("¿En que columna quiere insertar la ficha?");

                                String c = Console.ReadLine();
                                int columna = Int32.Parse(c);
                                bool booleano = tablero.PonerFichaPosicion(j2.Ficha, columna);

                                if (booleano = true) Console.WriteLine("La ficha se ha insertado correctamente");
                                else Console.WriteLine("Se ha producido un error");

                                Console.WriteLine(tablero.ToString());
                                bool condicion1 = tablero.EsFinJuego();
                                condicion2 = tablero.HayGanador(j2);

                            }
                        }
                    }
                }
                else if (jugadorTurno == j2)
                {
                    for (int turno = 0; turno < 81; turno++)
                    {

                        bool condidion1 = false;
                        bool condicion2 = false;

                        if (condidion1 = false || condicion2 == false)
                        {
                            if (turno % 2 == 0)
                            {

                                Console.WriteLine("Turno de " + j2.toString());
                                Console.WriteLine("¿En que columna quiere insertar la ficha?");

                                String c = Console.ReadLine();
                                int columna = Int32.Parse(c);
                                bool booleano = tablero.PonerFichaPosicion(j2.Ficha, columna);

                                if (booleano = true) Console.WriteLine("La ficha se ha insertado correctamente");
                                else Console.WriteLine("Se ha producido un error");

                                Console.WriteLine(tablero.ToString());
                                bool condicion1 = tablero.EsFinJuego();
                                condicion2 = tablero.HayGanador(j2);


                            }
                            else if (!(turno % 2 == 0))
                            {

                                Console.WriteLine("Turno de " + j1.toString());
                                Console.WriteLine("¿En que columna quiere insertar la ficha?");

                                String c = Console.ReadLine();
                                int columna = Int32.Parse(c);
                                bool booleano = tablero.PonerFichaPosicion(j1.Ficha, columna);

                                if (booleano = true) Console.WriteLine("La ficha se ha insertado correctamente");
                                else Console.WriteLine("Se ha producido un error");

                                Console.WriteLine(tablero.ToString());
                                bool condicion1 = tablero.EsFinJuego();
                                condicion2 = tablero.HayGanador(j1);
                            }
                        }
                    }
                }


            }
            else 
            {


                Console.WriteLine("Introduzca su nombre");

                String nombreJugador = Console.ReadLine();
                String nombreJugadorIA = "Jugador IA";

                Jugador j = new Jugador(nombreJugador);
                Jugador jIA = new Jugador(nombreJugadorIA);

                Tablero tablero = new Tablero();

                tablero.AsignarFicha(j, jIA);

                Console.WriteLine("La ficha de " + nombreJugador + " es " + j.Ficha.Color);
                Console.WriteLine("La ficha de " + nombreJugadorIA + " es " + jIA.Ficha.Color);

                Jugador jugadorTurno = Juego.EmpiezaJugadorAleatorio(j, jIA);

                if (jugadorTurno == j)
                {
                    for (int turno = 0; turno < 81; turno++)
                    {
                        bool condidion1 = false;
                        bool condicion2 = false;

                        if (condidion1 = false || condicion2 == false)
                        {
                            if (turno % 2 == 0)
                            {

                                Console.WriteLine("Turno de " + j.toString());
                                Console.WriteLine("¿En que columna quiere insertar la ficha?");

                                String c = Console.ReadLine();
                                int columna = Int32.Parse(c);
                                bool booleano = tablero.PonerFichaPosicion(j.Ficha, columna);

                                if (booleano = true) Console.WriteLine("La ficha se ha insertado correctamente");
                                else Console.WriteLine("Se ha producido un error");

                                Console.WriteLine(tablero.ToString());
                                bool condicion1 = tablero.EsFinJuego();
                                condicion2 = tablero.HayGanador(j);


                            }
                            else if (!(turno % 2 == 0))
                            {

                                Console.WriteLine("Turno de " + jIA.toString());


                                int columna = tablero.iaFacil();

                                bool booleano = tablero.PonerFichaPosicion(jIA.Ficha, columna);

                                if (booleano = true) Console.WriteLine("La ficha se ha insertado correctamente");
                                else Console.WriteLine("Se ha producido un error");

                                Console.WriteLine(tablero.ToString());
                                bool condicion1 = tablero.EsFinJuego();
                                condicion2 = tablero.HayGanador(jIA);

                            }
                        }
                    }
                }
                else if (jugadorTurno == jIA)
                {
                    for (int turno = 0; turno < 81; turno++)
                    {

                        bool condidion1 = false;
                        bool condicion2 = false;

                        if (condidion1 = false || condicion2 == false)
                        {
                            if (turno % 2 == 0)
                            {

                                Console.WriteLine("Turno de " + jIA.toString());
                                

                                int columna = tablero.iaFacil();
                                bool booleano = tablero.PonerFichaPosicion(jIA.Ficha, columna);

                                if (booleano = true) Console.WriteLine("La ficha se ha insertado correctamente");
                                else Console.WriteLine("Se ha producido un error");

                                Console.WriteLine(tablero.ToString());
                                bool condicion1 = tablero.EsFinJuego();
                                condicion2 = tablero.HayGanador(jIA);


                            }
                            else if (!(turno % 2 == 0))
                            {

                                Console.WriteLine("Turno de " + j.toString());
                                Console.WriteLine("¿En que columna quiere insertar la ficha?");

                                String c = Console.ReadLine();
                                int columna = Int32.Parse(c);
                                bool booleano = tablero.PonerFichaPosicion(j.Ficha, columna);

                                if (booleano = true) Console.WriteLine("La ficha se ha insertado correctamente");
                                else Console.WriteLine("Se ha producido un error");

                                Console.WriteLine(tablero.ToString());
                                bool condicion1 = tablero.EsFinJuego();
                                condicion2 = tablero.HayGanador(j);
                            }
                        }
                    }
                }
            }            
        }
    }
}



