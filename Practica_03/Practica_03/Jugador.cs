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

        public  Ficha _ficha;

        public  Ficha Ficha { 
            
            get { if (_ficha == null) throw new ArgumentException("El jugador tiene que tener ficha");
                else return _ficha;
            }

            set { _ficha = value;
            }

        }    

        public Jugador(Ficha fichaJugador)
        {

            Ficha = fichaJugador;

        }

        public Jugador(string nombre)
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