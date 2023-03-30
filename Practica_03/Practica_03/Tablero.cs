namespace PSS.rih419.Practica_03
{
    public class Tablero
    {
        private Ficha[ , ] _casilla;
        

        public Tablero() {

            _casilla = new Ficha[9, 9];

        }
        public Tablero(int dimension)
        {
            _dimension = dimension;
            _casilla = new Ficha[dimension, dimension];
        }

         int _dimension = 9;
        public int Dimension { get { return _dimension; } }

        public Ficha this [int fila, int columna]
        {

            get{
                
                return _casilla[fila, columna];  }

            set { _casilla[fila, columna] = value; }

        }

        public bool PonerFichaPosicion(Ficha ficha, Posicion posicion)
        {


            if (posicion.Fila < _dimension && posicion.Columna < _dimension ||
                posicion.Fila >= 0 && posicion.Columna >= 0)
            {
                if (_casilla[posicion.Fila, posicion.Columna] == null)
                {

                    _casilla[posicion.Fila, posicion.Columna] = ficha;
                    return true;

                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}