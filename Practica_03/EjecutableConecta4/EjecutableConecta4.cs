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
                if (dificultadEntrada == "1" || dificultadEntrada == "2")
                {
                    dificultad = Int32.Parse(dificultadEntrada);
                    break;

                }

                Console.WriteLine("Dificultad no valida, por favor vuelva a intentarlo:");
            }
            

            bool booleano1 = false;
            bool booleano2 = false;
            Jugador jugadorGanador = new Jugador();

            if (dificultad == 1)
            {
                juego.Dificultad1(juego, 1);
            }
            else if (dificultad == 2)
            {
                juego.Ddificultad2(juego, 2);

            }
        }
    }
}

