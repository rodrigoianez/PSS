using System.Security.Cryptography.X509Certificates;

namespace PSS.rih419.Practica_03
{
    public class Tablero
    {
        public static  Ficha[ , ] casilla;
        

        public Tablero() {

            casilla = new Ficha[9, 9];

        }
        public Tablero(int dimension)
        {
            dimension =  dimension;
            casilla = new Ficha[dimension, dimension];
        }

        int dimension = 9;
        public int numeroCasillasOcupadas = 0;

        public int Dimension { get { return dimension; } }

        public bool EsFinJuego()
        { 
            if (numeroCasillasOcupadas == (dimension * dimension)){

                return true;
            }
            else return false;
        }

        public Ficha this [int fila, int columna]
        {

            get{  return casilla[fila, columna];  }
            set{ casilla[fila, columna] = value; }

        }

        public static void AsignarFicha(Jugador j1, Jugador j2)
        {

            Ficha fichaJ1 = new Ficha(ColorFicha.Rojo);
            Ficha fichaJ2 = new Ficha(ColorFicha.Negro);

            j1.Ficha = fichaJ1;
            j2.Ficha = fichaJ2;

        }

        public static bool PonerFichaPosicion(Ficha ficha, int columna)
        {
            if( columna >= 0 && columna < 9)
            {
                for(int i = 8; i >= 0 ; i--)
                {
                    if (casilla[i, columna].Equals(null))
                    {
                        casilla[i, columna] = ficha;
                        return true;
                    }
                    else return false;     
                }
            } else return false;

            return false;
        }
    }
}