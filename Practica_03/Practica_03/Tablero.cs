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

        public bool PonerFichaPosicion(Ficha ficha, int columna)
        {
            if (columna >= 0 && columna < 9)
            {
                for (int i = 8; i >= 0; i--)
                {
                    if (casilla[i, columna] == null)
                    {
                        casilla[i, columna] = ficha;
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

        public int iaDificil()
        {
            int mejor_mov = -1;
            double max, max_actual;
            max = double.NegativeInfinity;

            for (int j = 0; j < 9; j++)
            {


            }

            return 1; ;
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