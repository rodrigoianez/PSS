using System;
using System.Reflection.Metadata.Ecma335;

namespace PSS.rih419.Practica_03
{
    public class Juego
    {
        public int NumeroJugadores;
        private Dictionary<string, Jugador> listaJugadores = new Dictionary<string, Jugador>();
        private static int idioma;
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
                    if (tablero.casilla[i, j] == null)
                    {
                        contador = 0;

                    }
                    else if (tablero.casilla[i, j].Color.ToString() == ficha.Color.ToString())
                    {
                        contador++;
                        if (contador == 4)
                            return true;
                    }  
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
            Console.WriteLine("En que idioma quiere jugar / In which language do you want to play:");
            Console.WriteLine("- Pulsa 1 para jugar en Español:");
            Console.WriteLine("- Press 2 to play in English: ");
            String idiomaentrada = Console.ReadLine();
            
            while (true)
            {
                if (idiomaentrada == "1" || idiomaentrada == "2")
                {
                    idioma = Int32.Parse(idiomaentrada);
                    Console.WriteLine("Idioma no valido, por favor vuelva a intentarlo:");
                    break;
                }
                Console.WriteLine("Language not valid, please try again:");
                break;
            }
            if (idioma == 2)
            {
                Console.WriteLine(Strings_En.Encabezado);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                              "+Strings_En.Encabezado1);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(Strings_En.Encabezado2);
                Console.WriteLine(Strings_En.Encabezado3);
                Console.WriteLine(Strings_En.Encabezado4);
            }
            else
            {
                Console.WriteLine("Dificultad no valida, por favor vuelva a intentarlo:");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("                                              Que comience la partida");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Elija la dificultad");
                Console.WriteLine("");
                Console.WriteLine("Pulse 1 para Jugador vs Jugador");
                Console.WriteLine("Pulse 2 para Jugador vs IA facil");
                Console.WriteLine("Pulse 3 para Jugador vs IA media");
            }
            

        }

        public void DesarrolloTurno(Jugador j, Tablero tablero, int dificultad)
        {
            Console.WriteLine();
            Console.WriteLine();
            if (idioma == 2)
            {
                Console.WriteLine(j.ToString() + Strings_En.DesarrolloTurno1);

            }
            else
            {
                Console.WriteLine("Turno de " + j.ToString());
            }
                
            int columna = 0;
            
            if (dificultad == 2)
            {
                if (j.Nombre.ToString() == "Jugador IA")
                {
                    columna = tablero.iaFacil();
                }
                else
                {
                    Console.WriteLine();
                    if (idioma == 2)
                    {
                        Console.WriteLine(Strings_En.DesarrolloTurno2);

                    }
                    else
                    {
                        Console.WriteLine("Introduzca el numero de la columna donde quiera insertar la ficha");
                    }
                    while (true)
                    {
                        String c = Console.ReadLine();
                        if (c == "1" || c == "2" || c == "3" || c == "4" || c == "5" || c == "6" || c == "7" || c == "8" || c == "9")
                        {
                            columna = Int32.Parse(c) - 1;
                            break;
                        }
                        if (idioma == 2)
                        {
                            Console.WriteLine(Strings_En.DesarrolloTurno3);

                        }
                        else
                        {
                            Console.WriteLine("Columna no valida, por favor vuelva a intentarlo:");
                        }
                    }
                }
            }
            else if (dificultad == 1)
            {
                Console.WriteLine();
                if (idioma == 2)
                {
                    Console.WriteLine(Strings_En.DesarrolloTurno2);

                }
                else
                {
                    Console.WriteLine("Introduzca el numero de la columna donde quiera insertar la ficha");
                }
                while (true)
                {
                    String c = Console.ReadLine();
                    if ( c == "1" || c == "2" || c == "3" || c == "4" || c == "5" || c == "6" || c == "7" || c == "8"|| c == "9")
                    {
                        columna = Int32.Parse(c) - 1;
                        break;
                    }
                    if (idioma == 2)
                    {
                        Console.WriteLine(Strings_En.DesarrolloTurno3);
                    }
                    else
                    {
                        Console.WriteLine("Columna no valida, por favor vuelva a intentarlo:");
                    }
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
                    if (idioma == 2)
                    {
                        Console.WriteLine(Strings_En.DesarrolloTurno2);

                    }
                    else
                    {
                        Console.WriteLine("Introduzca el numero de la columna donde quiera insertar la ficha");
                    }
                    while (true)
                    {
                        String c = Console.ReadLine();
                        if (c == "1" || c == "2" || c == "3" || c == "4" || c == "5" || c == "6" || c == "7" || c == "8" || c == "9")
                        {
                            columna = Int32.Parse(c) - 1;
                            break;
                        }
                        if (idioma == 2)
                        {
                            Console.WriteLine(Strings_En.DesarrolloTurno3);
                        }
                        else
                        {
                            Console.WriteLine("Columna no valida, por favor vuelva a intentarlo:");
                        }
                    }
                }
            }
            
            bool booleano = tablero.PonerFichaPosicion(j.Ficha, columna, tablero);

            if (booleano = true)
            {
                if (idioma == 2)
                {
                    Console.WriteLine(Strings_En.DesarrolloTurno4);
                }
                else
                {
                    Console.WriteLine("La ficha se ha insertado correctamente");
                }
            }
            Console.Clear();
            Console.WriteLine(tablero.ToString());
        }
        public void Dificultad1(Juego juego, int dificultad)
        {

            if (idioma == 2)
            {
                Console.WriteLine(Strings_En.Dificultad1);
            }
            else
            {
                Console.WriteLine("Introduzca el nombre del primer jugador");
            }

            String nombreJugador1 = Console.ReadLine();
            if (idioma == 2)
            {
                Console.WriteLine(Strings_En.Dificultad2);
            }
            else
            {

                Console.WriteLine("Introduzca el nombre del segundo jugador");
            }

            String nombreJugador2 = Console.ReadLine();

            Jugador j1 = new Jugador(nombreJugador1);
            Jugador j2 = new Jugador(nombreJugador2);

            Tablero tablero = new Tablero();

            tablero.AsignarFicha(j1, j2);
            if (idioma == 2)
            {
                Console.WriteLine(Strings_En.Dificultad3 + " " + nombreJugador1 + " " + Strings_En.Dificultad4 + " " + j1.Ficha.Color);
                Console.WriteLine(Strings_En.Dificultad3 + " " + nombreJugador2 + " " + Strings_En.Dificultad4 + " " + j2.Ficha.Color);
            }
            else
            {
                Console.WriteLine("La ficha de " + nombreJugador1 + " es " + j1.Ficha.Color);
                Console.WriteLine("La ficha de " + nombreJugador2 + " es " + j2.Ficha.Color);
            }

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
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad5);
                            }
                            else
                            {
                                Console.WriteLine("No ha ganado nadie");
                            }
                                
                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad6);
                            }
                            else
                            {
                                Console.WriteLine("FIN DEL JUEGO");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad7 + " " + jugadorGanador.Nombre.ToString() + " " + Strings_En.Dificultad8);
                            }
                            else
                            {
                                Console.WriteLine("El jugador " + jugadorGanador.Nombre.ToString() + " es el ganador.");
                            }

                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad6);
                            }
                            else
                            {
                                Console.WriteLine("FIN DEL JUEGO");
                            }
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
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad5);
                            }
                            else
                            {
                                Console.WriteLine("No ha ganado nadie");
                            }

                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad6);
                            }
                            else
                            {
                                Console.WriteLine("FIN DEL JUEGO");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad7 + " " + jugadorGanador.Nombre.ToString() + " " + Strings_En.Dificultad8);
                            }
                            else
                            {
                                Console.WriteLine("El jugador " + jugadorGanador.Nombre.ToString() + " es el ganador.");
                            }

                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad6);
                            }
                            else
                            {
                                Console.WriteLine("FIN DEL JUEGO");
                            }
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
            

        }

        public void DificultadIA(Juego juego, int dificultad)
        {
            if (idioma == 2)
            {
                Console.WriteLine(Strings_En.Dificultad9);
            }
            else
            {
                Console.WriteLine("Introduzca su nombre");
            }
            String nombreJugador = Console.ReadLine();
            String nombreJugadorIA = "Jugador IA";

            Jugador j = new Jugador(nombreJugador);
            Jugador jIA = new Jugador(nombreJugadorIA);

            Tablero tablero = new Tablero();

            tablero.AsignarFicha(j, jIA);
            if (idioma == 2)
            {
                Console.WriteLine(Strings_En.Dificultad3 + " " + nombreJugador + " " + Strings_En.Dificultad4 + " " + j.Ficha.Color);
                Console.WriteLine(Strings_En.Dificultad3 + " " + nombreJugadorIA + " " + Strings_En.Dificultad4 + " " + jIA.Ficha.Color);
            }
            else
            {
                Console.WriteLine("La ficha de " + nombreJugador + " es " + j.Ficha.Color);
                Console.WriteLine("La ficha de " + nombreJugadorIA + " es " + jIA.Ficha.Color);
            }

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
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad5);
                            }
                            else
                            {
                                Console.WriteLine("No ha ganado nadie");
                            }

                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad6);
                            }
                            else
                            {
                                Console.WriteLine("FIN DEL JUEGO");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad7 + " " + jugadorGanador.Nombre.ToString() + " " + Strings_En.Dificultad8);
                            }
                            else
                            {
                                Console.WriteLine("El jugador " + jugadorGanador.Nombre.ToString() + " es el ganador.");
                            }

                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad6);
                            }
                            else
                            {
                                Console.WriteLine("FIN DEL JUEGO");
                            }
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
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad5);
                            }
                            else
                            {
                                Console.WriteLine("No ha ganado nadie");
                            }

                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad6);
                            }
                            else
                            {
                                Console.WriteLine("FIN DEL JUEGO");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad7 + " " + jugadorGanador.Nombre.ToString() + " " + Strings_En.Dificultad8);
                            }
                            else
                            {
                                Console.WriteLine("El jugador " + jugadorGanador.Nombre.ToString() + " es el ganador.");
                            }

                            Console.WriteLine("");
                            if (idioma == 2)
                            {
                                Console.WriteLine(Strings_En.Dificultad6);
                            }
                            else
                            {
                                Console.WriteLine("FIN DEL JUEGO");
                            }
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
