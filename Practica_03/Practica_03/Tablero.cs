namespace PSS.rih419.Practica_03
{
    public class Tablero
    {
        private Ficha[,] casilla;

        public Tablero() {

            casilla = new Ficha[9, 9];

        }

           
        public Tablero(int dimension)
        {
            Dimension = dimension;
            casilla = new Ficha[dimension, dimension];
        }

        public int Dimension { get; }

        public Ficha this[int fila, int columna]
        {

            get
            {
                if (columna < 0 || columna > 9 || fila < 0 || fila > 9) throw new ArgumentException("El jugador tiene que tener ficha");
                return casilla[fila, columna];  }
            set { casilla[fila, columna] = value; }

        }

    }
}