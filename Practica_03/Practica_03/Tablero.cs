using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PSS.rih419.Practica_03
{
    public class Tablero
    {

        int dimension = 9;
        public Ficha[,] casilla = new Ficha[9, 9];
        public int numeroCasillasOcupadas = 0;

        public Tablero()
        {
           
            casilla = new Ficha[9, 9];
        }

        public Tablero(Tablero tablero)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    casilla[i, j] = tablero.casilla[i, j];
                }
            }


        }

        public int Dimension { get { return dimension; } }

        public bool EsFinJuego()
        {
            if (numeroCasillasOcupadas == (9 * 9))
            {

                return true;
            }
            else return false;
        }

        public Ficha this[int fila, int columna]
        {

            get { return casilla[fila, columna]; }
            set { casilla[fila, columna] = value; }

        }

        public void AsignarFicha(Jugador j1, Jugador j2)
        {

            Ficha fichaJ1 = new Ficha(ColorFicha.Morado);
            Ficha fichaJ2 = new Ficha(ColorFicha.Verde);

            j1.Ficha = fichaJ1;
            j2.Ficha = fichaJ2;

        }

        public bool PonerFichaPosicion(Ficha ficha, int columna, Tablero tablero)
        {
            if (columna >= 0 && columna < 9)
            {
                for (int i = 8; i >= 0; i--)
                {
                    if (tablero.casilla[i, columna] == null)
                    {
                        tablero.casilla[i, columna] = ficha;
                        numeroCasillasOcupadas++;
                        return true;
                        break;

                    }
                    else continue;
                }
            }
            else
            {
                return false;
            }
            return false;
        }

        public int iaFacil()
        {
            Random random = new Random();
            int randNum = random.Next(0, 9); 
            return randNum;
        }

        public static Tablero clonar(Tablero tablero)
        {
            Tablero tablerocopia = new Tablero();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    tablerocopia.casilla[i, j] = tablero.casilla[i, j];
                }
            }

            return tablerocopia;
        }

        public int iaMedia(Tablero tablero, Jugador jugadorIA)
        {
            Tablero tableroCopia = new Tablero(tablero);
            Juego juego = new Juego();

            Ficha ficha1 = new Ficha(ColorFicha.Morado);
            Ficha ficha2 = new Ficha(ColorFicha.Verde);

            Jugador jugador1 = new Jugador(ficha1);
            Jugador jugador2 = new Jugador(ficha2);

            bool booleano = false;
            int columna = -1;

            while (booleano == false)
            {
                for (int i = 8; -1 < i; i--)
                {

                    bool condicion = PonerFichaPosicion(ficha1, i, tableroCopia);
                    Tablero tableroCopia2 = new Tablero(tableroCopia);

                    if (condicion == true)
                    {
                        booleano = juego.HayGanador(tableroCopia, ficha1);
                        if (booleano)
                        {
                            tableroCopia = tablero;
                            columna = i;
                            break;
                        }
                    }

                    for (int j = 8; -1 < j; j--)
                    {
                        if (PonerFichaPosicion(ficha2, j, tableroCopia2) == true)
                        {
                            booleano = juego.HayGanador(tableroCopia2, ficha2);
                            if (booleano)
                            {
                                tableroCopia = tablero;
                                columna = j;
                                break;
                            }
                            tableroCopia2 = Tablero.clonar(tableroCopia);
                            
                        }
                    }
                    tableroCopia = Tablero.clonar(tablero);
                }
                break;
            }
            if (columna != -1)
            {
                return columna;
            }
            else 
            {
                Random random = new Random();
                columna = random.Next(0, 9);
                tableroCopia = tablero;
                return columna;
            }
          }

        public string ToString()

        {
            StringBuilder matriz = new StringBuilder();

            for (int i = 0; i < 9; i++)
            {
                matriz.Append("                    +------++------++------++------++------++------++------++------++------+\n");

                for (int j = 0; j < 9; j++)
                {
                    if (casilla[i, j] != null)
                    {
                        Ficha ficha1 = new Ficha(ColorFicha.Morado);
                        Ficha ficha2 = new Ficha(ColorFicha.Verde);

                        if (casilla[i, j].Color.ToString() == ficha1.Color.ToString())
                        {
                            if (j == 0)
                            {
                                matriz.Append("\u001b[35m                    |\u001b[0m");
                                matriz.Append("\u001b[35m" + casilla[i, j].Color.ToString() + "\u001b[0m");
                                matriz.Append("\u001b[35m|\u001b[0m");
                            }
                            else if (0 < j && j < 9)
                            {
                                matriz.Append("\u001b[35m|\u001b[0m");
                                matriz.Append("\u001b[35m" + casilla[i, j].Color.ToString() + "\u001b[0m");
                                matriz.Append("\u001b[35m|\u001b[0m");
                            }
                        }
                        else if (casilla[i, j].Color.ToString() == ficha2.Color.ToString())
                        {
                            if (j == 0)
                            {
                                matriz.Append("\u001b[32m                    | \u001b[0m");
                                matriz.Append("\u001b[32m" + casilla[i, j].Color.ToString() + "\u001b[0m");
                                matriz.Append("\u001b[32m|\u001b[0m");
                            }
                            else if (0 < j && j < 9)
                            {
                                matriz.Append("\u001b[32m| \u001b[0m");
                                matriz.Append("\u001b[32m" + casilla[i, j].Color.ToString() + "\u001b[0m");
                                matriz.Append("\u001b[32m|\u001b[0m");
                            }
                        }
                    }
                    else if (casilla[i, j] == null)
                    {
                        if (j == 0)
                        {
                            matriz.Append("                    |");
                            matriz.Append("      ");
                            matriz.Append("|");
                        }
                        else if (0 < j && j < 9)
                        {
                            matriz.Append("|");
                            matriz.Append("      ");
                            matriz.Append("|");
                        }
                    }
                }
                matriz.Append("\n");
            }
            matriz.Append("                    +------++------++------++------++------++------++------++------++------+\n");
            matriz.Append("                    |   1  ||   2  ||   3  ||   4  ||   5  ||   6  ||   7  ||   8  ||   9  |");

            return matriz.ToString();
        }
    }
}