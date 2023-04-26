using System;
using System.Reflection.Metadata.Ecma335;

namespace PSS.rih419.Practica_03
{
    public class Juego
    {
        public int NumeroJugadores;
        private Dictionary<string, Jugador> listaJugadores = new Dictionary<string, Jugador>();

        public Juego()
        {

        }

        public void AnadirJugador(Jugador jugador)
        {
            listaJugadores.Add(jugador.Nombre, jugador);
            NumeroJugadores++;
        }

        public Jugador ObtenerJugador(string nombre)
        {
            return listaJugadores[nombre];
        }

        public static bool IndiceAleatorio()
        {
            Random random = new Random();

            if (random.Next(0, 2) == 0)
            {
                return true;
            }
            else return false;
        }

        public Jugador EmpiezaJugadorAleatorio(Jugador j1, Jugador j2)
        {
            bool booleano = IndiceAleatorio();
            if (booleano == true)
            {
                return j1;
            }
            else return j2;
        }



        public bool HayGanador(Tablero tablero, Ficha ficha)
        {
            int contador = 0;
            int i, j;

            for (i = 0; i < 9; i++)          //Busqueda horizontal
            {
                contador = 0;
                for (j = 0; j < 9; j++)
                {
                    if (tablero.casilla[i, j] == ficha)
                    {
                        contador++;
                        if (contador == 4)
                            return true;
                    }
                    else
                        contador = 0;
                }
            }

            for (j = 0; j < 9; j++)         //Busqueda vertical
            {
                contador = 0;

                for (i = 0; i < 9; i++)
                {
                    if (tablero.casilla[i, j] == ficha)
                    {
                        contador++;
                        if (contador == 4)
                            return true;
                    }
                    else
                        contador = 0;
                }
                contador = 0;
            }

            //Busqueda diagonal
            i = 0;
            for (j = 0; j < 9; j++)
            {
                contador = 0;
                int v = i, m = j;

                while (v < 9 && m < 9)
                {
                    if (tablero[v, m] == ficha)
                    {
                        contador++;
                        if (contador == 4)
                            return true;
                    }
                    else
                        contador = 0;
                    v++;
                    m++;
                }
            }

            j = 0;
            for (i = 1; i < 9; i++)
            {
                int cont = 0;
                int v = i, m = j;
                while (v < 9 && m < 9)
                {
                    if (tablero[v, m] == ficha)
                    {
                        cont++;
                        if (cont == 4)
                            return true;
                    }
                    else
                        cont = 0;
                    v++;
                    m++;
                }
            }
            //Busqued diagonal
            i = 0;
            for (j = 9 - 1; j >= 0; j--)
            {
                contador = 0;
                int v = i, m = j;
                while (v < 9 && m >= 0)
                {
                    if (tablero[v, m] == ficha)
                    {
                        contador++;
                        if (contador == 4)
                            return true;
                    }
                    else
                        contador = 0;
                    v++;
                    m--;
                }
            }

            j = 9 - 1;
            for (i = 1; i < 9; i++)
            {
                contador = 0;
                int v = i, m = j;
                while (v < 9 && m >= 0)
                {
                    if (tablero[v, m] == ficha)
                    {
                        contador++;
                        if (contador == 4)
                            return true;
                    }
                    else
                        contador = 0;
                    v++;
                    m--;
                }
            }
            return false;
        }

        public void Encabezado()
        {
            while (true)
            {
                for (int i = 10; 0 <= i; i--)
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("\u001b[35m __________ \u001b[32m _____________ \u001b[35m ___       ___ \u001b[32m ___________ \u001b[35m __________ \u001b[32m ____________ \u001b[35m   ________   \u001b[32m     ___     ___ \u001b[0m");
                    Console.WriteLine("\u001b[35m|          |\u001b[32m|             |\u001b[35m|   |_    |   |\u001b[32m|           |\u001b[35m|          |\u001b[32m|            |\u001b[35m _|        |_ \u001b[32m    |   |   |   |\u001b[0m");
                    Console.WriteLine("\u001b[35m|     _____|\u001b[32m|    _____    |\u001b[35m|     |_  |   |\u001b[32m|    _______|\u001b[35m|     _____|\u001b[32m|___      ___|\u001b[35m|     __     |\u001b[32m    |   |___|   |\u001b[0m");
                    Console.WriteLine("\u001b[35m|    |      \u001b[32m|   |     |   |\u001b[35m|       |_|   |\u001b[32m|   |____    \u001b[35m|    |      \u001b[32m    |    |    \u001b[35m|    |__|    |\u001b[32m    |           |\u001b[0m");
                    Console.WriteLine("\u001b[35m|    |      \u001b[32m|   |     |   |\u001b[35m|    _        |\u001b[32m|    ____|   \u001b[35m|    |      \u001b[32m    |    |    \u001b[35m|            |\u001b[32m    |_______    |\u001b[0m");
                    Console.WriteLine("\u001b[35m|    |_____ \u001b[32m|   |_____|   |\u001b[35m|   | |_      |\u001b[32m|   |_______ \u001b[35m|    |_____ \u001b[32m    |    |    \u001b[35m|     __     |\u001b[32m            |   |\u001b[0m");
                    Console.WriteLine("\u001b[35m|          |\u001b[32m|             |\u001b[35m|   |   |_    |\u001b[32m|           |\u001b[35m|          |\u001b[32m    |    |    \u001b[35m|    |  |    |\u001b[32m            |   |\u001b[0m");
                    Console.WriteLine("\u001b[35m|__________|\u001b[32m|_____________|\u001b[35m|___|     |___|\u001b[32m|___________|\u001b[35m|__________|\u001b[32m    |____|    \u001b[35m|____|  |____|\u001b[32m            |___|\u001b[0m");
                    Thread.Sleep(200);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("\u001b[32m __________ \u001b[35m _____________ \u001b[32m ___       ___ \u001b[35m ___________ \u001b[32m __________ \u001b[35m ____________ \u001b[32m   ________   \u001b[35m     ___     ___ \u001b[0m");
                    Console.WriteLine("\u001b[32m|          |\u001b[35m|             |\u001b[32m|   |_    |   |\u001b[35m|           |\u001b[32m|          |\u001b[35m|            |\u001b[32m _|        |_ \u001b[35m    |   |   |   |\u001b[0m");
                    Console.WriteLine("\u001b[32m|     _____|\u001b[35m|    _____    |\u001b[32m|     |_  |   |\u001b[35m|    _______|\u001b[32m|     _____|\u001b[35m|___      ___|\u001b[32m|     __     |\u001b[35m    |   |___|   |\u001b[0m");
                    Console.WriteLine("\u001b[32m|    |      \u001b[35m|   |     |   |\u001b[32m|       |_|   |\u001b[35m|   |____    \u001b[32m|    |      \u001b[35m    |    |    \u001b[32m|    |__|    |\u001b[35m    |           |\u001b[0m");
                    Console.WriteLine("\u001b[32m|    |      \u001b[35m|   |     |   |\u001b[32m|    _        |\u001b[35m|    ____|   \u001b[32m|    |      \u001b[35m    |    |    \u001b[32m|            |\u001b[35m    |_______    |\u001b[0m");
                    Console.WriteLine("\u001b[32m|    |_____ \u001b[35m|   |_____|   |\u001b[32m|   | |_      |\u001b[35m|   |_______ \u001b[32m|    |_____ \u001b[35m    |    |    \u001b[32m|     __     |\u001b[35m            |   |\u001b[0m");
                    Console.WriteLine("\u001b[32m|          |\u001b[35m|             |\u001b[32m|   |   |_    |\u001b[35m|           |\u001b[32m|          |\u001b[35m    |    |    \u001b[32m|    |  |    |\u001b[35m            |   |\u001b[0m");
                    Console.WriteLine("\u001b[32m|__________|\u001b[35m|_____________|\u001b[32m|___|     |___|\u001b[35m|___________|\u001b[32m|__________|\u001b[35m    |____|    \u001b[32m|____|  |____|\u001b[35m            |___|\u001b[0m");
                    Thread.Sleep(200);
                    Console.WriteLine("");
                    if (i == 10)
                    {

                        Console.WriteLine("Cargando:                                                                                                        0%");
                    }
                    else if (i == 9)
                    {

                        Console.WriteLine("Cargando:---------                                                                                              10%");
                    }
                    else if (i == 8)
                    {

                        Console.WriteLine("Cargando:--------------------                                                                                   20%");
                    }

                    else if (i == 7)
                    {

                        Console.WriteLine("Cargando:------------------------------                                                                         30%");
                    }
                    else if (i == 6)
                    {

                        Console.WriteLine("Cargando:----------------------------------------                                                               40%");
                    }
                    else if (i == 5)
                    {

                        Console.WriteLine("Cargando:----------------------------------------------------                                                   50%");
                    }
                    else if (i == 4)
                    {

                        Console.WriteLine("Cargando:--------------------------------------------------------------                                         60%");
                    }
                    else if (i == 3)
                    {

                        Console.WriteLine("Cargando:------------------------------------------------------------------------                               70%");
                    }
                    else if (i == 2)
                    {

                        Console.WriteLine("Cargando:----------------------------------------------------------------------------------                     80%");
                    }
                    else if (i == 1)
                    {

                        Console.WriteLine("Cargando:--------------------------------------------------------------------------------------------           90%");
                    }
                    else if (i == 0)
                    {

                        Console.WriteLine("Cargando:------------------------------------------------------------------------------------------------------100%");
                        Thread.Sleep(200);
                        break;
                    }
                }
                break;
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("                                              Que comience la partida");
            Console.WriteLine("");
            Console.WriteLine("Las normas del conecta4 son:");
            Console.WriteLine("");
            Console.WriteLine("Para ganar debe tener 4 fichas del mismo color consecutivas en posicion vertical, horizontal o diagonal.");
            Console.WriteLine("Si al introducir un numero, introduce uno que no esté en el tablero, pierde turno.");
            Console.WriteLine("");
            Console.WriteLine("Elija la dificultad");
            Console.WriteLine("");
            Console.WriteLine("Pulse 1 para Jugador vs Jugador");
            Console.WriteLine("Pulse 2 para Jugador vs IA facil");
            Console.WriteLine("Pulse 3 para Jugador vs IA media");

        }

        public void DesarrolloTurno(Jugador j, Tablero tablero, int dificultad)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Turno de " + j.ToString());
            int columna = 0
                ;

            if (dificultad == 2)
            {
                if (j.Nombre.ToString() == "Jugador IA")
                {
                    columna = tablero.iaFacil();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Introduzca el numero de la columna donde quiera insertar la ficha");
                    while (true)
                    {
                        String c = Console.ReadLine();
                        if (c == "1" || c == "2" || c == "3" || c == "4" || c == "5" || c == "6" || c == "7" || c == "8" || c == "9")
                        {
                            columna = Int32.Parse(c) - 1;
                            break;
                        }

                        Console.WriteLine("Columna no valida, por favor vuelva a intentarlo:");
                    }
                }
            }
            else if (dificultad == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Introduzca el numero de la columna donde quiera insertar la ficha");
                while (true)
                {
                    String c = Console.ReadLine();
                    if ( c == "1" || c == "2" || c == "3" || c == "4" || c == "5" || c == "6" || c == "7" || c == "8"|| c == "9")
                    {
                        columna = Int32.Parse(c) - 1;
                        break;
                    }

                    Console.WriteLine("Columna no valida, por favor vuelva a intentarlo:");
                }

            } else if (dificultad == 3)
            {
                if (j.Nombre.ToString() == "Jugador IA")
                {
                    columna = tablero.iaMedia(tablero, j);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Introduzca el numero de la columna donde quiera insertar la ficha");
                    while (true)
                    {
                        String c = Console.ReadLine();
                        if (c == "1" || c == "2" || c == "3" || c == "4" || c == "5" || c == "6" || c == "7" || c == "8" || c == "9")
                        {
                            columna = Int32.Parse(c) - 1;
                            break;
                        }

                        Console.WriteLine("Columna no valida, por favor vuelva a intentarlo:");
                    }
                }
            }
            
            bool booleano = tablero.PonerFichaPosicion(j.Ficha, columna);

            if (booleano = true)
            {
                Console.WriteLine("La ficha se ha insertado correctamente");
            }
            Console.Clear();
            Console.WriteLine(tablero.ToString());
        }
        public void Dificultad1(Juego juego, int dificultad)
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

            Jugador jugadorTurno = juego.EmpiezaJugadorAleatorio(j1, j2);

            bool booleano1 = false;
            bool booleano2 = false;

            Jugador jugadorGanador = new Jugador();

            if (jugadorTurno == j1)
            {
                Console.WriteLine(tablero.ToString());

                for (int turno = 0; turno < 81; turno++)
                {
                    if (booleano2 == true || booleano1 == true)
                    {
                        if (booleano1 == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No ha ganado nadie");
                            Console.WriteLine("");
                            Console.WriteLine("FIN DEL JUEGO");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("El jugador " + jugadorGanador.Nombre.ToString() + " es el ganador.");
                            Console.WriteLine("");
                            Console.WriteLine("FIN DEL JUEGO");
                            break;
                        }
                    }
                    else if (turno % 2 == 0)
                    {
                        juego.DesarrolloTurno(j1, tablero, dificultad);
                        booleano1 = tablero.EsFinJuego();
                        booleano2 = juego.HayGanador(tablero, j1.Ficha);
                        jugadorGanador = j1;
                    }
                    else if (!(turno % 2 == 0))
                    {
                        juego.DesarrolloTurno(j2, tablero, dificultad);
                        booleano1 = tablero.EsFinJuego();
                        booleano2 = juego.HayGanador(tablero, j2.Ficha);
                        jugadorGanador = j2;
                    }
                }
            }
            else if (jugadorTurno == j2)
            {
                Console.WriteLine(tablero.ToString());

                for (int turno = 0; turno < 81; turno++)
                {
                    if (booleano2 == true || booleano1 == true)
                    {
                        if (booleano1 == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No ha ganado nadie");
                            Console.WriteLine("");
                            Console.WriteLine("FIN DEL JUEGO");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("El jugador " + jugadorGanador.Nombre.ToString() + " es el ganador.");
                            Console.WriteLine("");
                            Console.WriteLine("FIN DEL JUEGO");
                            break;
                        }
                    }
                    else if (turno % 2 == 0)
                    {
                        juego.DesarrolloTurno(j1, tablero, dificultad);
                        booleano1 = tablero.EsFinJuego();
                        booleano2 = juego.HayGanador(tablero, j1.Ficha);
                        jugadorGanador = j1;
                    }
                    else if (!(turno % 2 == 0))
                    {
                        juego.DesarrolloTurno(j2, tablero, dificultad);
                        booleano1 = tablero.EsFinJuego();
                        booleano2 = juego.HayGanador(tablero, j2.Ficha);
                        jugadorGanador = j2;
                    }
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("El jugador " + jugadorGanador.Nombre.ToString() + " es el ganador.");
                Console.WriteLine("");
                Console.WriteLine("FIN DEL JUEGO");
            }
        }

        public void DificultadIA(Juego juego, int dificultad)
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

            bool booleano1 = false;
            bool booleano2 = false;
            Jugador jugadorGanador = new Jugador();

            Jugador jugadorTurno = juego.EmpiezaJugadorAleatorio(j, jIA);

            if (jugadorTurno == j)
            {
                Console.WriteLine(tablero.ToString());

                for (int turno = 0; turno < 81; turno++)
                {
                    

                    if (booleano2 == true || booleano1 == true)
                    {
                        if (booleano1 == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No ha ganado nadie");
                            Console.WriteLine("");
                            Console.WriteLine("FIN DEL JUEGO");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("El jugador " + jugadorGanador.Nombre.ToString() + " es el ganador.");
                            Console.WriteLine("");
                            Console.WriteLine("FIN DEL JUEGO");
                            break;
                        }
                    }
                    else if (turno % 2 == 0)
                    {
                        juego.DesarrolloTurno(j, tablero, dificultad);
                        booleano1 = tablero.EsFinJuego();
                        booleano2 = juego.HayGanador(tablero, j.Ficha);
                        jugadorGanador = j;
                    }
                    else if (!(turno % 2 == 0))
                    {
                        juego.DesarrolloTurno(jIA, tablero, dificultad);
                        booleano1 = tablero.EsFinJuego();
                        booleano2 = juego.HayGanador(tablero, jIA.Ficha);
                        jugadorGanador = jIA;
                    }
                }
            }
            else if (jugadorTurno == jIA)
            {
                Console.WriteLine(tablero.ToString());

                for (int turno = 0; turno < 81; turno++)
                {
                    if (booleano2 == true || booleano1 == true)
                    {
                        if (booleano1 == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No ha ganado nadie");
                            Console.WriteLine("");
                            Console.WriteLine("FIN DEL JUEGO");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("El jugador " + jugadorGanador.Nombre.ToString() + " es el ganador.");
                            Console.WriteLine("");
                            Console.WriteLine("FIN DEL JUEGO");
                            break;
                        }
                    }
                    else if (turno % 2 == 0)
                    {
                        juego.DesarrolloTurno(jIA, tablero, dificultad);
                        booleano1 = tablero.EsFinJuego();
                        booleano2 = juego.HayGanador(tablero, jIA.Ficha);
                        jugadorGanador = jIA;

                    }
                    else if (!(turno % 2 == 0))
                    {

                        juego.DesarrolloTurno(j, tablero, dificultad);
                        booleano1 = tablero.EsFinJuego();
                        booleano2 = juego.HayGanador(tablero, j.Ficha);
                        jugadorGanador = j;
                    }
                }
            }
        }
    }
}
