using System.Drawing;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace PSS.rih419.Practica_03
{
    public class EjecutableConecta4
    {
        public static void Main(String[] args)
        {
            Juego juego = new Juego();
            juego.Encabezado();

            int dificultad;
            while (true)
            {
                String dificultadEntrada = Console.ReadLine();
                if (dificultadEntrada == "1" || dificultadEntrada == "2" || dificultadEntrada == "3" || dificultadEntrada == "4")
                {
                    dificultad = Int32.Parse(dificultadEntrada);
                    break;
                }
                else
                {
                    if (Juego.idioma == 1)
                    {
                        Console.WriteLine("Dificultad no valida, por favor vuelva a intentarlo:");
                    }
                    else
                    {
                        Console.WriteLine("Not valid difficulty, please try again:");
                    }

                }

            }


            int decision;

            do
            {
                bool booleano1 = false;
                bool booleano2 = false;
                Jugador jugadorGanador = new Jugador();

                if (dificultad == 1)
                {
                    juego.Dificultad1(juego, 1);
                }
                else if (dificultad == 2)
                {
                    juego.DificultadIA(juego, 2);
                }
                else if (dificultad == 3)
                {
                    juego.DificultadIA(juego, 3);
                }
                else if (dificultad == 4)
                {
                    juego.IAvsIA(juego, 4);
                }
                Console.Clear();
                Console.WriteLine("");
                if (Juego.idioma == 1)
                {
                    Console.WriteLine("¿Desea volver a jugar?");
                    Console.WriteLine("Pulse 1 si su respuesta es SI");
                    Console.WriteLine("Pulse 2 si su respuesta es NO");
                }
                else
                {
                    Console.WriteLine("Do you want to play again?");
                    Console.WriteLine("Write 1 id your answer is YES");
                    Console.WriteLine("Write 2 if your answer is NO");
                }
                Console.WriteLine("");
                
                while (true)
                {
                    String decisionEntrada = Console.ReadLine();
                    if (decisionEntrada == "1" || decisionEntrada == "2")
                    {
                        decision = Int32.Parse(decisionEntrada);
                        break;
                    }
                    else
                    {
                        if (Juego.idioma == 1)
                        {
                            Console.WriteLine("Respuesta no valida, por favor vueva a intentarlo");
                        }
                        else
                        {
                            Console.WriteLine("Not valid answer, please try again:");
                        }
                    }
                }

                if (decision == 2)
                {
                    if (Juego.idioma == 1)
                    {
                        Console.WriteLine("GRACIAS POR JUGAR");
                    }
                    else
                    {
                        Console.WriteLine("THANKS FOR PLAYING");
                    }

                }

            } while (decision == 1);


            
            

        }
    }
}

