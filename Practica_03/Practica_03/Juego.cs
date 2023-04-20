namespace PSS.rih419.Practica_03
{
    public  class Juego
    {
        public  int NumeroJugadores;
        private  Dictionary<string,Jugador> listaJugadores = new Dictionary<string,Jugador>();
        
        public Juego()
        {

        }

        public  void AnadirJugador(Jugador jugador)
        {
            listaJugadores.Add(jugador.Nombre,jugador);
            NumeroJugadores++;
        }

        public  Jugador ObtenerJugador(string nombre)
        {
            return listaJugadores[nombre];
        }

        public static  bool IndiceAleatorio()
        {
            Random random = new Random();
            
            if (random.Next(0,2) == 0)
            {
                return true;
            }
            else return false;
        }

        public  Jugador EmpiezaJugadorAleatorio(Jugador j1, Jugador j2)
        {

            bool booleano = IndiceAleatorio();
            if (booleano == true)
            {

                return j1;
            }

            else return j2;
        }

        public void DesarrolloTurno(Jugador j, Tablero tablero, int dificultad)
        {

            Console.WriteLine("Turno de " + j.toString());

            int columna;

            if (dificultad == 2)
            {   
                if(j.Nombre.ToString() == "Jugador IA")
                {

                    columna = tablero.iaFacil();

                } else
                {

                    String c = Console.ReadLine();
                    columna = Int32.Parse(c);

                }
                 

            } else
            {

                String c = Console.ReadLine();
                columna = Int32.Parse(c);
            }
            
            bool booleano = tablero.PonerFichaPosicion(j.Ficha, columna);

            if (booleano = true) Console.WriteLine("La ficha se ha insertado correctamente");
            else Console.WriteLine("Se ha producido un error");

            Console.WriteLine(tablero.ToString());
        }
    }
}