using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PSS.rih419.Practica_03
{
    public class Tablero
    {
        public Ficha[ , ] casilla=new Ficha[9,9];

        int dimension = 9;
        public int numeroCasillasOcupadas = 0;

        public Tablero() {

            casilla = new Ficha[9, 9];
           
        }
        
        public int Dimension { get { return dimension; } }

        public bool EsFinJuego()
        { 
            if (numeroCasillasOcupadas == (9 * 9)){

                return true;
            }
            else return false;
        }

        public Ficha this [int fila, int columna]
        {

            get{  return casilla[fila, columna];  }
            set{ casilla[fila, columna] = value; }

        }

        public void AsignarFicha(Jugador j1, Jugador j2)
        {

            Ficha fichaJ1 = new Ficha(ColorFicha.Rojo);
            Ficha fichaJ2 = new Ficha(ColorFicha.Negro);

            j1.Ficha = fichaJ1;
            j2.Ficha = fichaJ2;

        }

        public bool PonerFichaPosicion(Ficha ficha, int columna)
        {
               
            if( columna >= 0 && columna < 9)
            {
                for(int i = 8; i >= 0 ; i--)
                {   
                    if (casilla[i, columna] == null)
                    {
                        casilla[i, columna] = ficha;
                        numeroCasillasOcupadas++;
                        return true;
                        break;
                        
                    }
                    else  continue;
                }
            }
            return false;
        }


        public bool HayGanador(Jugador jugador)
        {
            
            for (int fila = 0; fila < 9; fila++)
            {
                for (int columna = 0; columna < 6; columna++)
                {
                    if (casilla[fila, columna] != null &&
                        casilla[fila, columna] == casilla[fila, columna + 1] &&
                        casilla[fila, columna] == casilla[fila, columna + 2] &&
                        casilla[fila, columna] == casilla[fila, columna + 3])
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 9; i++)
            {

                sb.Append("-------------------------------------------------------\n");

                for (int j = 0; j < 9; j++)
                {
                    if (casilla[i, j] != null)
                    {

                        Ficha ficha1 = new Ficha(ColorFicha.Rojo);
                        Ficha ficha2 = new Ficha(ColorFicha.Negro);

                        if (casilla[i, j].Color.ToString() == ficha1.Color.ToString())
                        {
                            sb.Append("| ");
                            sb.Append(casilla[i, j].Color.ToString());
                        } 
                        else if (casilla[i, j].Color.ToString() == ficha2.Color.ToString())
                        {
                            sb.Append("|");
                            sb.Append(casilla[i, j].Color.ToString());
                        }


                    }
                    else if (casilla[i, j] == null)
                    {
                        sb.Append("|");
                        sb.Append("     ");
                    }
                }
                sb.Append("|\n");
            }
            sb.Append("-------------------------------------------------------\n");
            sb.Append("   0     1     2     3     4     5     6     7     8    ");
            return sb.ToString();
        }
    }
}