namespace PSS.rih419.Practica_03
{
    public  class Jugador
    {

        public static int numJugadores = 0;

        public  string Nombre { get; }

        public  Jugador()
        {
            numJugadores++;
            Nombre = "Jugador" + numJugadores;
        }

        private static Ficha _ficha;
        public static Ficha Ficha { get { if (_ficha == null) throw new ArgumentException("El jugador tiene que tener ficha");
                else return _ficha;
                        }
            set { _ficha = value; } }    

        public  Jugador(string nombre)
        {
            numJugadores++;
            Nombre = nombre;
        }

        public String toString()
        {

            return this.Nombre.ToString();

        }
        

        
    }

}